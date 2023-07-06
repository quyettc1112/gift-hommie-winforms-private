using BusinessObjects;
using BussinessObjects;
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
    public partial class frmCustomer : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private BindingSource bindingSource = null;
        public frmCustomer()
        {
            InitializeComponent();
            if (GlobalData.AuthenticatedUser == null)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.FormClosed += delegate
                {
                    this.Close();
                };
                this.Hide();
                frmLogin.ShowDialog();
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
    }

    // END OF TAB HOME AREA -------------------------------------------

    // TAB ORDER AREA -------------------------------------------------
    // END OF TAB ORDER AREA ------------------------------------------


}
