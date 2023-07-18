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
using BusinessObjects;
using Repositories;
namespace GiftHommieWinforms
{
    public partial class frmShipper : Form
    {
        public frmShipper()
        {
            InitializeComponent();
        }
        private IOrderRepository orderRepository = new OrderRepository();
        private BindingSource bindingSource = null;
        private BindingSource bindingSourceOrderShipper = null;

        private void frmShipper_Load(object sender, EventArgs e)
        {
            LoadOrderToDelivery();
        }


        public void LoadOrderToDelivery()
        {
            User user = GlobalData.AuthenticatedUser;
            List<Order> order = orderRepository.GetAll().Where(o => o.ShippingMode == true && o.Status == "ORDERED" && o.Shipper == user.Username).ToList();
            LoadDataToGridView(order);

        }


        private void LoadDataToGridView(IEnumerable<Order> orders)
        {
            if (orders == null)
                orders = new List<Order>()
                {
                };
            bindingSourceOrderShipper = new BindingSource();
            bindingSourceOrderShipper.DataSource = orders;
            dgvTakeOrder.DataSource = null;
            dgvTakeOrder.DataSource = bindingSourceOrderShipper;
            setRowNumber(dgvTakeOrder);


            dgvTakeOrder.Columns["Id"].Visible = false;
            dgvTakeOrder.Columns["Username"].Visible = false;
            dgvTakeOrder.Columns["ShippingMode"].Visible = false;
            dgvTakeOrder.Columns["Shipper"].Visible = false;
            dgvTakeOrder.Columns["LastUpdatedTime"].Visible = false;
            dgvTakeOrder.Columns["Status"].Visible = false;
            //dgvTakeOrder.Columns["ShippingFee"].Visible = false;
            dgvTakeOrder.Columns["ShippingStatus"].Visible = false;
            dgvTakeOrder.Columns["ShipperNavigation"].Visible = false;
            dgvTakeOrder.Columns["User"].Visible = false;
            dgvTakeOrder.Columns["OrderDetails"].Visible = false;
        }


        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }



        /// Lấy dữ liệu của product khi click vào cái order

        private int GetSelectedRowOrderIdValue()
        {

            if (dgvTakeOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTakeOrder.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["Id"];

                if (dgvTakeOrder.Columns["Id"].Visible == false && idCell != null && idCell.Value != null
                    && int.TryParse(idCell.Value.ToString(), out int result))
                {
                    return result;
                }
            }

            // Nếu không thể chuyển đổi thành công hoặc không có giá trị, trả về giá trị mặc định (vd: -1)
            return -1;
        }

        // Load Product In Order Đã chọn
        public void LoadOrderInfo(Order order)
        {

            bindingSourceOrderInfo = new BindingSource();
            bindingSourceOrderInfo.DataSource = order;
            txtOrderStatus.DataBindings.Clear();
            dtpOrderTime.DataBindings.Clear();

            txtOrderReceiver.DataBindings.Clear();
            txtOrderPhone.DataBindings.Clear();
            txtOrderAddress.DataBindings.Clear();
            txtOrderMessage.DataBindings.Clear();

            txtOrderShippingFee.DataBindings.Clear();
            txtOrderTotal.DataBindings.Clear();
            rComment.DataBindings.Clear();

            txtOrderStatus.DataBindings.Add("Text", bindingSourceOrderInfo, "Status");
            dtpOrderTime.DataBindings.Add("Text", bindingSourceOrderInfo, "OrderTime");

            txtOrderReceiver.DataBindings.Add("Text", bindingSourceOrderInfo, "Name");
            txtOrderPhone.DataBindings.Add("Text", bindingSourceOrderInfo, "Phone");
            txtOrderAddress.DataBindings.Add("Text", bindingSourceOrderInfo, "Address");
            txtOrderMessage.DataBindings.Add("Text", bindingSourceOrderInfo, "Message");
            rComment.DataBindings.Add("Text", bindingSourceOrderInfo, "Comment");

            txtOrderShippingFee.DataBindings.Add("Text", bindingSourceOrderInfo, "ShippingFee");

            double? total = 0;
            double? fee = order.ShippingFee;
            List<OrderDetail> orderDetails = orderRepository.GetOrderDetails(order.Id);
            for (int i = 0; i < orderDetails.Count; i++)
            {
                total = total + (orderDetails[i].Price * orderDetails[i].Quantity);

            }

            txtOrderTotal.Text = (total + fee).ToString();

        }

      
    }
}
