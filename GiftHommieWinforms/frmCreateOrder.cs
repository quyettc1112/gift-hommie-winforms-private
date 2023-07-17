using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GiftHommieWinforms
{
    public partial class frmCreateOrder : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private IUserRepository userRepository = new UserRepository();
        private BindingSource bindingSource = null;
        private List<Product> selectedProducts = new List<Product>();
        private User selectedUser = null;
        public frmCreateOrder()
        {
            InitializeComponent();
        }
        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            HomeLoadData();
            LoadSelectedProducts();
        }
        private void HomeLoadData()
        {
            // Load products
            List<Product> products = productRepository.GetAllWithFilter(
                "",
                txtProductNameSearch.Text,
                "", "",
                "", "", 0,
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
                dgvProducts.Columns["isDelete"].Visible = false;
                setRowNumber(dgvProducts);
                LoadChoosenItems();



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
        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        private void HomeReBinding()
        {
            lbProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtAvailable.DataBindings.Clear();
            txtDesc.DataBindings.Clear();
            pbProductAvatar.DataBindings.Clear();


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

        private void LoadChoosenItems()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                int id = (int)row.Cells["Id"].Value;
               
                if (row.Cells["Quantity"].Value.Equals("0"))
                {
                    row.Cells["Check"].ReadOnly = true;
                    selectedProducts = selectedProducts.Where(p => p.Id != id).ToList();
                    row.Cells["Check"].Value = false;
                }
                else 
                    row.Cells["Check"].Value = selectedProducts.SingleOrDefault(x => x.Id == id) != null;

            }
        }

        private bool flagLoadSelected = false;
        private void AdditionalSelectedProducts()
        {
            // Add the column to the DataGridView
            if (dgvSelectedProducts.Columns["Total"] == null)
                dgvSelectedProducts.Columns.Add("Total", "Total");

            //Calculate and assign the total value for each row
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvSelectedProducts.Rows)
            {
                dgvSelectedProducts.Columns["Total"].ReadOnly = true;
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                decimal total = quantity * price;

                row.Cells["Total"].Value = total;
                sum += total;
            }

            dgvSelectedProducts.Columns["Total"].DisplayIndex = 4;
            dgvSelectedProducts.Columns["Total"].DataPropertyName = "Total";
            txtTotal.Text = sum.ToString();
        }
        private void LoadSelectedProducts()
        {
            if (selectedProducts == null)
                selectedProducts = new List<Product>();
            BindingSource bding = new BindingSource();
            bding.DataSource = selectedProducts;
            flagLoadSelected = true;
            dgvSelectedProducts.DataSource = null;
            dgvSelectedProducts.DataSource = bding;           
            dgvSelectedProducts.Columns["Id"].Visible = false;
            dgvSelectedProducts.Columns["Avatar"].Visible = false;
            dgvSelectedProducts.Columns["Status"].Visible = false;
            dgvSelectedProducts.Columns["Carts"].Visible = false;
            dgvSelectedProducts.Columns["Category"].Visible = false;
            dgvSelectedProducts.Columns["CategoryId"].Visible = false;
            dgvSelectedProducts.Columns["OrderDetails"].Visible = false;
            dgvSelectedProducts.Columns["isDelete"].Visible = false;
            dgvSelectedProducts.Columns["Quantity"].ReadOnly = false;
            dgvSelectedProducts.Columns["Description"].Visible = false;
            dgvSelectedProducts.Columns["Price"].ReadOnly = true;
            dgvSelectedProducts.Columns["Name"].ReadOnly = true;
            btnCheckout.Enabled = selectedProducts.Count > 0;

            AdditionalSelectedProducts();

            flagLoadSelected = false;
        }
        private void pbProductAvatar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int c, r;

            if (e.ColumnIndex == 0 && dgvProducts.RowCount > 0)
            {
                c = e.ColumnIndex;
                r = e.RowIndex;

                dgvProducts.Rows[r].Cells[c].Value = !((bool)dgvProducts.Rows[r].Cells[c].Value);

                bool check = (bool)dgvProducts.Rows[r].Cells[c].Value;
                int id = (int)dgvProducts.Rows[r].Cells["Id"].Value;

                if (check == false)
                {
                    selectedProducts = selectedProducts.Where(p => p.Id != id).ToList();
                }
                else if (selectedProducts.SingleOrDefault(p => p.Id == id) == null)
                {
                    Product product = productRepository.Get(id);
                    product.Quantity = 1;
                    selectedProducts.Add(product);
                }
            }

            LoadSelectedProducts();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSelectedProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSelectedProducts.Rows)
            {
                dgvSelectedProducts.Columns["Total"].ReadOnly = true;
                int id = (int)row.Cells["Id"].Value;
                var product = productRepository.Get(id);
                int quantity =  Convert.ToInt32(row.Cells["Quantity"].Value);
                if (quantity == 0)
                {
                    MessageBox.Show("Please enter a positive number.");
                    row.Cells["Quantity"].Value = 1;
                    quantity = 1;
                }

                if (quantity > product.Quantity)
                    quantity = product.Quantity;
                if (quantity == 0)
                {
                    MessageBox.Show($"Sold out '{product.Name}', can not select to checkout.");
                    selectedProducts = selectedProducts.Where(p => p.Id != id).ToList();
                    HomeLoadData();
                    LoadSelectedProducts();
                    return;
                }

                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                decimal total = quantity * price;

                row.Cells["Total"].Value = total;
            }
        }

        private void txtProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductNameSearch.Text = "";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Complete the order?",
                                   "Confirm to checkout",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.Yes)
                try
                {
                    Order order = null;
                    if (checkShipping.Checked)
                        order = new Order()
                        {
                            Name = txtReceiver.Text,
                            Phone = txtPhone.Text,
                            Address = txtAddress.Text,
                            OrderTime = DateTime.Now,
                            Status = "ORDERED",
                            Username = selectedUser?.Username,
                            ShippingMode = checkShipping.Checked
                        };
                    else
                        order = new Order()
                        {
                            Name = "",
                            Phone = "",
                            Address = "",
                            Comment = "Buy at showroom.",
                            OrderTime = DateTime.Now,
                            Status = "ORDERED",
                            Username = selectedUser?.Username,
                            ShippingMode = checkShipping.Checked
                        };

                    List<OrderDetail> orderDetails = new List<OrderDetail>();

                    foreach (Product product in selectedProducts)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.ProductId = product.Id;
                        orderDetail.Quantity = product.Quantity;
                        orderDetail.Price = product.Price;
                        orderDetails.Add(orderDetail);
                    }
                    order.OrderDetails = orderDetails;
                    orderRepository.Add(order);

                    MessageBox.Show("Checkout Successfully!", "Completed");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Checkout Fail!");
                }
            
        }

        private void txtOrderBy_TextChanged(object sender, EventArgs e)
        {
            selectedUser = userRepository.Get(txtOrderBy.Text.Trim());
            if (selectedUser != null && txtReceiver.Text.Trim().Length == 0 
                && txtReceiver.Text.Trim().Length == 0
                && txtPhone.Text.Trim().Length == 0)
            {
                txtReceiver.Text = selectedUser.Name;
                txtPhone.Text = selectedUser.Phone;
                txtAddress.Text = selectedUser.Address;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            groupShipping.Enabled = checkShipping.Checked;
        }

        private void dgvSelectedProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvSelectedProducts.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
