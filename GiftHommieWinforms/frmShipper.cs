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
        private IProductRepository productRepository = new ProductRepository();
        private BindingSource bindingSource = null;
        private BindingSource bindingSourceProduct = null;
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
        public void LoadProductOrderInfo(Order order)
        {

            bindingSource = new BindingSource();
            bindingSource.DataSource = order.OrderDetails;

            foreach (OrderDetail o in order.OrderDetails)
            {
                o.Product = productRepository.Get((int)o.ProductId);
            }

            dgvProductInfo.DataSource = bindingSource;

            dgvProductInfo.Columns["Id"].Visible = false;
            dgvProductInfo.Columns["OrderId"].Visible = false;
            dgvProductInfo.Columns["ProductId"].Visible = false;
            dgvProductInfo.Columns["Order"].Visible = false;
            // dgvProductInfo.Columns["Product"].Visible = false;


            txtOrderPrice.DataBindings.Clear();
            txtOrderQuantity.DataBindings.Clear();
            lbOrderProductName.DataBindings.Clear();
            pbOrderProductAvatar.DataBindings.Clear();
            int tmp = (int)((OrderDetail)bindingSource.Current).ProductId;

            Product p = productRepository.Get(tmp);
            bindingSourceProduct = new BindingSource();
            bindingSourceProduct.DataSource = p;

            lbOrderProductName.Text = p.Name;
            txtOrderQuantity.DataBindings.Add("Text", bindingSource, "Quantity");
            txtOrderPrice.DataBindings.Add("Text", bindingSource, "Price");
            pbOrderProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", bindingSourceProduct, "Avatar", true));

            // tbCountItem.Text = 
            int count = 0;
            double? Alltotal = 0;
            foreach (OrderDetail o in order.OrderDetails)
            {
                count = (int)(count + o.Quantity);
                Alltotal = Alltotal + (o.Price * o.Quantity);
            }

            tbCountItem.Text = count.ToString();
            tbAllTotal.Text = Alltotal.ToString();
            User user = GlobalData.AuthenticatedUser;

            txtname.Text = order.Name;
            txtPhone.Text = order.Phone;
            txtxAddress.Text = order.Address;
            txtTotal.Text = Alltotal.ToString();


        }

        private void dgvTakeOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Order order = orderRepository.Get(GetSelectedRowOrderIdValue());
            if (order != null)
            {
                LoadProductOrderInfo(order);
            }

        }


        private void dgvProductInfo_SelectionChanged(object sender, EventArgs e)
        {



        }

        private void dgvProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderPrice.DataBindings.Clear();
            txtOrderQuantity.DataBindings.Clear();
            lbOrderProductName.DataBindings.Clear();
            pbOrderProductAvatar.DataBindings.Clear();
            Product p = productRepository.Get(GetSelectedRowProductIdValue());


            bindingSourceProduct = new BindingSource();
            bindingSourceProduct.DataSource = p;

            lbOrderProductName.Text = p.Name;
            txtOrderQuantity.DataBindings.Add("Text", bindingSource, "Quantity");
            txtOrderPrice.DataBindings.Add("Text", bindingSource, "Price");
            pbOrderProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", bindingSourceProduct, "Avatar", true));


        }
        private int GetSelectedRowProductIdValue()
        {

            if (dgvTakeOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProductInfo.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["ProductId"];

                if (dgvProductInfo.Columns["ProductId"].Visible == false && idCell != null && idCell.Value != null
                    && int.TryParse(idCell.Value.ToString(), out int result))
                {
                    return result;
                }
            }

            // Nếu không thể chuyển đổi thành công hoặc không có giá trị, trả về giá trị mặc định (vd: -1)
            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
