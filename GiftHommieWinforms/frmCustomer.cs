using BusinessObjects;
using BussinessObjects;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SaleManagementWinApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GiftHommieWinforms
{
    public partial class frmCustomer : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private BindingSource bindingSource = null;
        private BindingSource orderDetailBindingSource = null;
        public frmCustomer()
        {
            InitializeComponent();
            if (GlobalData.AuthenticatedUser == null)
            {
                MessageBox.Show("Let's start with Login form!");
                this.Close();
                //frmLogin frmLogin = new frmLogin();
                //frmLogin.FormClosed += delegate
                //{
                //    this.Close();
                //};
                //frmLogin.VisibleChanged += delegate
                //{
                //    if (frmLogin.Visible == false)
                //        this.Close();
                //};
                //this.Hide();
                //frmLogin.ShowDialog();
            }                
        }

        private void tabcontrolCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            tabHome_Click(sender, e);
        }

        // TAB HOME AREA ------------------------------------------------------------
        private void tabHome_Click(object sender, EventArgs e)
        {
            HomeInitDataForSearchComponent();
            HomeLoadData();
        }

        private void HomeInitDataForSearchComponent()
        {
            // Load for search
            List<Category> categories = productRepository.GetAllCategories();
            categories.Insert(0, new Category()
            {
                Id = 0,
                Name = "Select the category",
            });
            cbProductCategory.DataSource = categories;
            cbProductCategory.ValueMember = "Id";
            cbProductCategory.DisplayMember = "Name";
            cbProductCategory.SelectedValue = 0;
        }

        private void HomeLoadData()
        {
            //// Load for search
            //List<Category> categories = productRepository.GetAllCategories();
            //categories.Insert(0, new Category()
            //{
            //    Id = 0,
            //    Name = "Select the category",
            //});
            //cbProductCategory.DataSource = categories;
            //cbProductCategory.ValueMember = "Id";
            //cbProductCategory.DisplayMember = "Name";
            //cbProductCategory.SelectedValue = 0;

            // Load products
            //List<Product> products = productRepository.GetAllWithStatus(true);

            List<Product> products = productRepository.GetAllWithFilter(
                "",
                txtProductNameSearch.Text,
                txtUnitPriceMinSearch.Text, txtUnitPriceMaxSearch.Text,
                txtUnitsInStockMinSearch.Text, txtUnitsInStockMaxSearch.Text,
                ToIntOrZero(cbProductCategory.SelectedValue.ToString()),
                true
                );
            HomeLoadDataToGridView(products);

            
        }

        private void HomeLoadDataToGridView(IEnumerable<Product> products)
        {
            if (products == null)
                products = new List<Product>()
                {
                };

            try
            {
                

                bindingSource = new BindingSource();
                bindingSource.DataSource = products;

                HomeReBinding();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = bindingSource;
                dgvProducts.Columns["Id"].Visible = false;
                dgvProducts.Columns["Avatar"].Visible = false;
                dgvProducts.Columns["Status"].Visible = false;
                dgvProducts.Columns["Carts"].Visible = false;
                dgvProducts.Columns["Category"].Visible = false;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["OrderDetails"].Visible = false;
                setRowNumber(dgvProducts);



                //if (products.Count() == 0)
                //{
                //    ClearText();
                //    //btnNext.Enabled = false;
                //    //btnBack.Enabled = false;
                //}
                //else
                //{
                //    //btnNext.Enabled = true;
                //    //btnBack.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomeReBinding()
        {
            gbProduct.DataBindings.Clear();
            lbProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtAvailable.DataBindings.Clear();
            txtDesc.DataBindings.Clear();
            pbProductAvatar.DataBindings.Clear();


            gbProduct.DataBindings.Add("Text", bindingSource, "Name");
            lbProductName.DataBindings.Add("Text", bindingSource, "Name");
            txtPrice.DataBindings.Add("Text", bindingSource, "Price");
            txtAvailable.DataBindings.Add("Text", bindingSource, "Quantity");
            txtDesc.DataBindings.Add("Text", bindingSource, "Description");
            pbProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", bindingSource, "Avatar", true));

        }

        private void HomeClearText()
        {
            lbProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtAvailable.Text = string.Empty;
            txtDesc.Text = string.Empty;
        }

        private void txtProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();            
        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitPriceMinSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitPriceMaxSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitsInStockMinSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitsInStockMaxSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductNameSearch.Text = string.Empty;

            txtUnitPriceMinSearch.Text = string.Empty;
            txtUnitPriceMaxSearch.Text = string.Empty;
            txtUnitsInStockMinSearch.Text = string.Empty;
            txtUnitsInStockMaxSearch.Text = string.Empty;
            cbProductCategory.SelectedValue = 0;
        }

        private int ToIntOrZero(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                return 0;
            }
        }

        private void lbProductName_TextChanged(object sender, EventArgs e)
        {
            txtCurrentIndex.Text = (bindingSource.Position + 1).ToString();
            btnBack.Enabled = (bindingSource.Position != 0);
            btnNext.Enabled = bindingSource.Position + 1 < bindingSource.Count;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int index = bindingSource.Position - 1 < 0 ? 0 : bindingSource.Position - 1;
            bindingSource.Position = index;                
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = bindingSource.Position;
            if (index + 1 < bindingSource.Count)
                index += 1;
            bindingSource.Position = index;
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you want to exit?",
                                    "Confirm to exit",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.No)
                e.Cancel = true;
            else
            {
                GlobalData.AuthenticatedUser = null;
            }
        }

        // TAB ORDER AREA -------------------------------------------------
        private void tabMyOrder_Click(object sender, EventArgs e)
        {
            OrderLoadData();
            
        }

        private void OrderInitDataForSearchComponent()
        {
            // Load for search
            //List<Category> categories = productRepository.GetAllCategories();
            //categories.Insert(0, new Category()
            //{
            //    Id = 0,
            //    Name = "Select the category",
            //});
            //cbProductCategory.DataSource = categories;
            //cbProductCategory.ValueMember = "Id";
            //cbProductCategory.DisplayMember = "Name";
            //cbProductCategory.SelectedValue = 0;
        }

        private void OrderLoadData()
        {

            // Load orders
            List<Order> orders = orderRepository.GetAllOrdersOfCustomer(GlobalData.AuthenticatedUser.Username);

            //List<Product> products = productRepository.GetAllWithFilter(
            //    "",
            //    txtProductNameSearch.Text,
            //    txtUnitPriceMinSearch.Text, txtUnitPriceMaxSearch.Text,
            //    txtUnitsInStockMinSearch.Text, txtUnitsInStockMaxSearch.Text,
            //    ToIntOrZero(cbProductCategory.SelectedValue.ToString()),
            //    true
            //    );
            OrderLoadDataToGridView(orders);


        }

        private void OrderDetailLoadData()
        {
            IEnumerable<OrderDetail> orderDetails = new List<OrderDetail>();
            if (dgvOrders.DataSource != null && bindingSource.Count > 0)
            {

                Order order = bindingSource.Current as Order;
                orderDetails = order.OrderDetails;
            }
           
            OrderDetailLoadDataToGridView(orderDetails);


        }
        private void OrderLoadDataToGridView(IEnumerable<Order> orders)
        {
            if (orders == null)
                orders = new List<Order>()
                {
                };

            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = orders;

                OrderReBinding();

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = bindingSource;
                dgvOrders.Columns["Id"].Visible = false;
                dgvOrders.Columns["Username"].Visible = false;
                
                dgvOrders.Columns["LastUpdatedTime"].Visible = false;
                dgvOrders.Columns["User"].Visible = false;
                dgvOrders.Columns["OrderDetails"].Visible = false;
                //dgvOrders.Columns["Comment"].Visible = false;
                //dgvOrders.Columns["Status"].Visible = false;

                setRowNumber(dgvOrders);



                if (orders.Count() == 0)
                {
                    // gbProduct => hide
                }
                else
                {
                    // gbProduct=> not hide

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderDetailLoadDataToGridView(IEnumerable<OrderDetail> orderDetails)
        {
            if (orderDetails == null)
                orderDetails = new List<OrderDetail>()
                {
                };

            foreach(OrderDetail detail in orderDetails)
            {
                Product product = productRepository.Get(detail.ProductId.Value);
                detail.Product = product;
            }

            try
            {
                orderDetailBindingSource = new BindingSource();
                orderDetailBindingSource.DataSource = orderDetails;

                OrderDetailReBinding();

                dgvOrderDetails.DataSource = null;
                dgvOrderDetails.DataSource = orderDetailBindingSource;
                dgvOrderDetails.Columns["Id"].Visible = false;
                dgvOrderDetails.Columns["OrderId"].Visible = false;
                dgvOrderDetails.Columns["ProductId"].Visible = false;
                dgvOrderDetails.Columns["Order"].Visible = false;
                dgvOrderDetails.Columns["Product"].DisplayIndex = 1;
                dgvOrderDetails.Columns["Product"].Width = 400;
                //dgvOrders.Columns["Comment"].Visible = false;
                //dgvOrders.Columns["Status"].Visible = false;

                setRowNumber(dgvOrderDetails);



                if (orderDetails.Count() == 0)
                {
                    // gbProduct => hide
                }
                else
                {
                    // gbProduct=> not hide

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OrderReBinding()
        {
            //gbOrderTarget.DataBindings.Clear();
            txtOrderStatus.DataBindings.Clear();
            dtpOrderTime.DataBindings.Clear();

            txtOrderReceiver.DataBindings.Clear();
            txtOrderPhone.DataBindings.Clear();
            txtOrderAddress.DataBindings.Clear();
            txtOrderMessage.DataBindings.Clear();

            txtOrderShippingFee.DataBindings.Clear();
            //txtOrderTotal.DataBindings.Clear();


            //gbProduct.DataBindings.Add("Text", bindingSource, "Name");
            txtOrderStatus.DataBindings.Add("Text", bindingSource, "Status");
            dtpOrderTime.DataBindings.Add("Text", bindingSource, "OrderTime");

            txtOrderReceiver.DataBindings.Add("Text", bindingSource, "Name");
            txtOrderPhone.DataBindings.Add("Text", bindingSource, "Phone");
            txtOrderAddress.DataBindings.Add("Text", bindingSource, "Address");
            txtOrderMessage.DataBindings.Add("Text", bindingSource, "Message");

            txtOrderShippingFee.DataBindings.Add("Text", bindingSource, "ShippingFee");
            //txtOrderTotal.DataBindings.Add("Text", bindingSource, "");

        }

        private void OrderDetailReBinding()
        {
            //gbOrderProduct.DataBindings.Clear();
            lbOrderProductName.DataBindings.Clear();
            txtOrderPrice.DataBindings.Clear();
            txtOrderQuantity.DataBindings.Clear();
            pbOrderProductAvatar.DataBindings.Clear();


            ////gbProduct.DataBindings.Add("Text", bindingSource, "Name");
            //lbOrderProductName.DataBindings.Add("Text", bindingSource, "Product.Name");
            //txtOrderPrice.DataBindings.Add("Text", bindingSource, "Product.Price");
            //txtOrderQuantity.DataBindings.Add("Text", bindingSource, "Product.Quantity");       
            //pbOrderProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
            //                    "ImageLocation", bindingSource, "Product.Avatar", true));

        }

        private void OrderDetailClearText()
        {
            lbOrderProductName.Text = string.Empty;
            txtOrderPrice.Text = string.Empty;
            txtOrderQuantity.Text = string.Empty;
        }

        private void tabcontrolCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabcontrolCustomer.SelectedIndex == 0)
            {
                tabHome_Click(sender, e);
            }
            else if (tabcontrolCustomer.SelectedIndex == 2)
            {
                tabMyOrder_Click(sender, e);
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            whenSelectTheOrder();
        }

        private void whenSelectTheOrder()
        {
            if (dgvOrders.DataSource != null && bindingSource.Count > 0)
            {
                Order order = bindingSource.Current as Order;
                gbOrderTarget.Text = "Order >> " + order.Id;
                txtOrderTotal.Text = orderRepository.GetTotalOfOrder(order.Id).ToString();
                OrderDetailLoadData();
            }
        }
        private void dgvOrders_DataSourceChanged(object sender, EventArgs e)
        {
            whenSelectTheOrder();
        }

        private void gbOrderTarget_Enter(object sender, EventArgs e)
        {

        }

        // END OF TAB HOME AREA -------------------------------------------




    }




}
