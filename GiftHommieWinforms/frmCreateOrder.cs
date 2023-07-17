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
    public partial class frmCreateOrder : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private BindingSource bindingSource = null;
        private Dictionary<int, bool> selectedItems = new Dictionary<int, bool>();
        public frmCreateOrder()
        {
            InitializeComponent();
        }
        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            HomeLoadData();
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
                row.Cells["Check"].Value = (selectedItems.ContainsKey(id)) ? selectedItems[id] : false;
            }
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

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int c, r;

            if (e.ColumnIndex == 0 && dgvProducts.RowCount > 0)
            {
                c = e.ColumnIndex;
                r = e.RowIndex;

                dgvProducts.Rows[r].Cells[c].Value = !((bool)dgvProducts.Rows[r].Cells[c].Value);

                bool check = (bool)dgvProducts.Rows[r].Cells[c].Value;
                int cartId = (int)dgvProducts.Rows[r].Cells["Id"].Value;

                selectedItems[cartId] = check;                
            }
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
                int cartId = (int)dgvProducts.Rows[r].Cells["Id"].Value;

                selectedItems[cartId] = check;
            }
        }
    }
}
