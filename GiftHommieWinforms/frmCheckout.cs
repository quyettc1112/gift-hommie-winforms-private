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
using System.Xml.Schema;

namespace GiftHommieWinforms
{
    public partial class frmCheckout : Form
    {
        private IOrderRepository orderRepository = new OrderRepository();
        private IProductRepository productRepository = new ProductRepository();
        public List<Cart> CartList;
        private double DEFAULT_SHIPPING_FEE = 20000;
        public double Total;
        private string DEFAULT_STATUS = "PENDING";
        public frmCheckout()
        {
            InitializeComponent();
        }
        private void SetValidation()
        {
            if (txtPhone.Text.Trim().Length < 8)
                btnCheckout.Enabled = false;
            else if (txtName.Text.Trim().Length < 2)
                btnCheckout.Enabled = false;
            else if (txtAddress.Text.Trim().Length < 5)
                btnCheckout.Enabled = false;
            else
                btnCheckout.Enabled = true;
        }

        private Order GetCurrentOrder()
        {
            return new Order
            {
                Username = GlobalData.AuthenticatedUser.Username,
                LastUpdatedTime = DateTime.Now,
                Name = txtName.Text,
                Address = txtAddress.Text,
                ShippingFee = DEFAULT_SHIPPING_FEE,
                OrderTime = DateTime.Now,
                Message = txtMessage.Text,
                Status = DEFAULT_STATUS,
                //Comment = txtComment.Text,
                Phone = txtPhone.Text,
            };
        }

        private List<OrderDetail> GetCurrentOrderDetail()
        {
            List<OrderDetail> details = new List<OrderDetail>();

            foreach (Cart cart in CartList)
            {
                details.Add(new OrderDetail
                {
                    ProductId = cart.ProductId,
                    Price = cart.Product.Price,
                    Quantity = cart.Quantity,
                });
            }

            return details;
        }

        private void LoadData()
        {
            txtName.Text = GlobalData.AuthenticatedUser.Name;
            txtAddress.Text = GlobalData.AuthenticatedUser.Address;
            txtPhone.Text = GlobalData.AuthenticatedUser.Phone;
            txtTotal.Text = Total.ToString();

            List<string> columns = new List<string>
            {
                "ID", "OrderId", "ProductId", "Order"
            };
            List<OrderDetail> details = GetCurrentOrderDetail();

            foreach (OrderDetail orderDetail in details)
            {
                orderDetail.Product = productRepository.Get((int)orderDetail.ProductId);
            }

            dgvCheckout.DataSource = details;

            foreach (string c in columns)
            {
                dgvCheckout.Columns[c].Visible = false;
            }

            SetValidation();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<OrderDetail> detals = new List<OrderDetail>();
            try
            {
                Order order = GetCurrentOrder();
                List<OrderDetail> details = GetCurrentOrderDetail();
                

                order.OrderDetails = details;
                orderRepository.Add(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            SetValidation();
            foreach (char c in txtAddress.Text)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != ',')
                {
                    int len = txtAddress.Text.Length;
                    txtAddress.Text = txtAddress.Text.Remove(txtAddress.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SetValidation();
            foreach (char c in txtName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            SetValidation();
            foreach (char c in txtPhone.Text)
            {
                if (!char.IsDigit(c))
                {
                    txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }
    }
}
