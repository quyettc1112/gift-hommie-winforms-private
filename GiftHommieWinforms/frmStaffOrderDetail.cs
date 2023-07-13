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
    public partial class frmStaffOrderDetail : Form
    {
        public frmStaffOrderDetail()
        {
            InitializeComponent();
        }

        public List<OrderDetail> orderDetails { get; set; }
        public Order Order { get; set; }


        private IProductRepository productRepository = new ProductRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private BindingSource bindingSource = null;
        private BindingSource orderDetailBindingSource = null;

        private void frmStaffOrderDetail_Load(object sender, EventArgs e)
        {
            OrderDetailLoadDataToGridView(orderDetails);
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = Order;
            txtOrderStatus.DataBindings.Clear();
            dtpOrderTime.DataBindings.Clear();

            txtOrderReceiver.DataBindings.Clear();
            txtOrderPhone.DataBindings.Clear();
            txtOrderAddress.DataBindings.Clear();
            txtOrderMessage.DataBindings.Clear();

            txtOrderShippingFee.DataBindings.Clear();
            txtOrderTotal.DataBindings.Clear();


            txtOrderStatus.DataBindings.Add("Text", bindingSource, "Status");
            dtpOrderTime.DataBindings.Add("Text", bindingSource, "OrderTime");

            txtOrderReceiver.DataBindings.Add("Text", bindingSource, "Name");
            txtOrderPhone.DataBindings.Add("Text", bindingSource, "Phone");
            txtOrderAddress.DataBindings.Add("Text", bindingSource, "Address");
            txtOrderMessage.DataBindings.Add("Text", bindingSource, "Message");

            txtOrderShippingFee.DataBindings.Add("Text", bindingSource, "ShippingFee");

            double? total = 0;
            double? fee = Order.ShippingFee;
            for (int i = 0; i < orderDetails.Count; i++)
            {
                total = total + (orderDetails[i].Price * orderDetails[i].Quantity);

            }

            txtOrderTotal.Text = (total + fee).ToString();




        }


        private void OrderDetailLoadDataToGridView(IEnumerable<OrderDetail> orderDetails)
        {
            if (orderDetails == null)
                orderDetails = new List<OrderDetail>()
                {
                };

            foreach (OrderDetail detail in orderDetails)
            {
                Product product = productRepository.Get(detail.ProductId.Value);
                detail.Product = product;
            }

            try
            {
                orderDetailBindingSource = new BindingSource();
                orderDetailBindingSource.DataSource = orderDetails;

                OrderDetailReBinding();

                dgvStaffOrderDetail.DataSource = null;
                dgvStaffOrderDetail.DataSource = orderDetailBindingSource;
                dgvStaffOrderDetail.Columns["Id"].Visible = false;
                dgvStaffOrderDetail.Columns["OrderId"].Visible = false;
                dgvStaffOrderDetail.Columns["ProductId"].Visible = false;
                dgvStaffOrderDetail.Columns["Order"].Visible = false;
                dgvStaffOrderDetail.Columns["Product"].DisplayIndex = 1;
                dgvStaffOrderDetail.Columns["Product"].Width = 520;

                // Add the column to the DataGridView
                if (dgvStaffOrderDetail.Columns["Total"] == null)
                    dgvStaffOrderDetail.Columns.Add("Total", "Total");

                //Calculate and assign the total value for each row
                foreach (DataGridViewRow row in dgvStaffOrderDetail.Rows)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    decimal total = quantity * price;

                    row.Cells["Total"].Value = total;
                }
                dgvStaffOrderDetail.Columns["Total"].DisplayIndex = 4;
                dgvStaffOrderDetail.Columns["Total"].DataPropertyName = "Total";
                dgvStaffOrderDetail.CellClick += dgvStaffOrderDetail_CellClick;
                txtOrderDetailTotal.Text = GetSelectedRowOrderIdValue().ToString();

                //dgvOrders.Columns["Comment"].Visible = false;
                //dgvOrders.Columns["Status"].Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvStaffOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OrderDetailReBinding()
        {
            //gbOrderProduct.DataBindings.Clear();
            lbOrderProductName.DataBindings.Clear();
            txtOrderPrice.DataBindings.Clear();
            txtOrderQuantity.DataBindings.Clear();
            pbOrderProductAvatar.DataBindings.Clear();
            txtOrderDetailTotal.DataBindings.Clear();


            ////gbProduct.DataBindings.Add("Text", orderDetailBindingSource, "Name");
            lbOrderProductName.DataBindings.Add("Text", orderDetailBindingSource, "Product.Name");
            txtOrderPrice.DataBindings.Add("Text", orderDetailBindingSource, "Price");
            txtOrderQuantity.DataBindings.Add("Text", orderDetailBindingSource, "Quantity");
            pbOrderProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", orderDetailBindingSource, "Product.Avatar", true));
            //if(dgvOrderDetails.DataSource != null)
            //    txtOrderDetailTotal.DataBindings.Add("Text", dgvOrderDetails.DataSource, "Total");

        }


        private int GetSelectedRowOrderIdValue()
        {
            if (dgvStaffOrderDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStaffOrderDetail.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["Total"];

                if (dgvStaffOrderDetail.Columns["Total"].Visible != false && idCell != null && idCell.Value != null
                    && int.TryParse(idCell.Value.ToString(), out int result))
                {
                    return result;
                }
            }

            // Nếu không thể chuyển đổi thành công hoặc không có giá trị, trả về giá trị mặc định (vd: -1)
            return -1;
        }

        private void dgvStaffOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderDetailTotal.Text = GetSelectedRowOrderIdValue().ToString();
        }


    }
}
