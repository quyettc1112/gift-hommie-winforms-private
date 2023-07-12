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

namespace GiftHommieWinforms
{

    public partial class frmStaff : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private BindingSource bindingSource = null;
        private IOrderRepository orderRepository = new OrderRepository();
        private bool orderTimeDescMode = true;
        public frmStaff()
        {
            InitializeComponent();
            dgvProducts.CellDoubleClick += DgvProduct_CellDoubleClick;
        }


        // Hàm này để lấy ID của Product từ DataGrdView
        private int GetSelectedRowIdValue()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["Id"];

                if (dgvProducts.Columns["Id"].Visible == false && idCell != null && idCell.Value != null
                    && int.TryParse(idCell.Value.ToString(), out int result))
                {
                    return result;
                }
            }

            // Nếu không thể chuyển đổi thành công hoặc không có giá trị, trả về giá trị mặc định (vd: -1)
            return -1;
        }


        // Hàm này để hiển thị Product Detail và có thể Update Product
        private void DgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStaffManageProduct frm = new frmStaffManageProduct()
            {
                Product = productRepository.Get(GetSelectedRowIdValue()),
                CreateOrUpdate = true
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HomeLoadData();
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            frmStaffManageProduct frm = new frmStaffManageProduct()
            {
                CreateOrUpdate = false,
                Product = new Product() { }
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HomeLoadData();
            }

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            tabHome_Click(sender, e);
        }

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
            cbProductSort.SelectedIndex = 0;
        }

        private void HomeLoadData()
        {
            List<Product> products = productRepository.GetAllWithFilterWithoutStatus(
                "",
                txtProductNameSearch.Text,
                txtUnitPriceMinSearch.Text, txtUnitPriceMaxSearch.Text,
                txtUnitsInStockMinSearch.Text, txtUnitsInStockMaxSearch.Text,
                ToIntOrZero(cbProductCategory.SelectedValue.ToString())
                );
            if (cbProductSort.SelectedIndex == 1)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            else if (cbProductSort.SelectedIndex == 2)
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }
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

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
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

        private void cbProductSort_SelectedIndexChanged(object sender, EventArgs e)
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
            cbProductSort.SelectedIndex = 0;
        }
        private bool flagBtnNext_Click = false;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbProductName_Click(object sender, EventArgs e)
        {

        }

        private void lbProductName_TextChanged(object sender, EventArgs e)
        {
            txtCurrentIndex.Text = (bindingSource.Position + 1).ToString();
            btnBack.Enabled = (bindingSource.Position != 0);
            btnNext.Enabled = flagBtnNext_Click == true || bindingSource.Position + 1 < bindingSource.Count;
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
            flagBtnNext_Click = true;
            bindingSource.Position = index;
            flagBtnNext_Click = false;
            btnNext.Enabled = bindingSource.Position + 1 < bindingSource.Count;
        }

        private void frmStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to exit?",
                                   "Confirm to exit",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.No)
                e.Cancel = true;
            else
            {
                GlobalData.AuthenticatedUser = null;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult d;
            try
            {
                Product p = productRepository.Get(GetSelectedRowIdValue());
                if (p != null)
                {
                    d = MessageBox.Show("Bạn có thật sự muốn xóa hay không sản phẩm " + p.Name + "?", "Quản lý thông tin Product - Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        productRepository.Delete(p.Id);
                        HomeLoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //------------------------Order------------------------------------
        private void tabOrder_Click(object sender, EventArgs e)
        {
            OrderInitDataForSearchComponent();
            OrderLoadData();
        }

        private void OrderInitDataForSearchComponent()
        {
            OrderResetFilter();
        }

        private void OrderResetFilter()
        {
            orderTimeDescMode = true;
            if (orderTimeDescMode)
                btnSort.Text = "Sort In Ascending Date Order";
            else btnSort.Text = "Sort In Descending Date Order";

            txtOrderSearch.Text = string.Empty;
            dtpStartDate.Value = new DateTime(2015, 01, 31);
            dtpEndDate.Value = DateTime.Now;
            cbOrderStatus.SelectedIndex = 0;
        }

        private void OrderLoadData()
        {

            // Load orders
            List<Order> orders = orderRepository.GetAll()
                            .Where(o => (
                                o.OrderTime >= dtpStartDate.Value && o.OrderTime < dtpEndDate.Value)
                                && (o.Id.ToString().Contains(txtOrderSearch.Text) || o.Name.ToLower().Contains(txtOrderSearch.Text.ToLower()))
                                && (cbOrderStatus.SelectedIndex == 0 || o.Status.Equals(cbOrderStatus.SelectedItem?.ToString()))
                            )
                            .ToList();

            if (orderTimeDescMode)
                orders = orders.OrderByDescending(o => o.OrderTime).ToList();
            else
                orders = orders.OrderBy(o => o.OrderTime).ToList();
            cbStatus.Visible = false;
            OrderLoadDataToGridView(orders);


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

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = bindingSource;
                //dgvOrders.Columns["Id"].Visible = false;
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

        private void tabcontrolStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrolStaff.SelectedIndex == 0)
            {
                tabHome_Click(sender, e);
            }
            else if (tabcontrolStaff.SelectedIndex == 1)
            {
                tabOrder_Click(sender, e);
            }
        }

        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }

        private void cbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }

        private void btnCleanAllFilterOrder_Click(object sender, EventArgs e)
        {
            OrderResetFilter();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            orderTimeDescMode = !orderTimeDescMode;
            if (orderTimeDescMode)
                btnSort.Text = "Sort In Ascending Date Order";
            else btnSort.Text = "Sort In Descending Date Order";
            OrderLoadData();
        }

        private void dgvOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var frm = new frmStaffOrderDetail();
            frm.ShowDialog();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }
    }
}
