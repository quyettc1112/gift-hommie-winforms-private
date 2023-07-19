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
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using System.Windows.Forms.VisualStyles;

namespace GiftHommieWinforms
{
    public partial class frmAdmin : Form
    {
        BindingSource source;
        IOrderRepository orderRepository = new OrderRepository();
        IUserRepository userRepository = new UserRepository();
        private const string CUSTOMER_ROLE = "CUSTOMER";
        private const string STAFF_ROLE = "STAFF";
        private const string SHIPPER_ROLE = "SHIPPER";
        private const string DEFAULT_AVATAR = "https://thinksport.com.au/wp-content/uploads/2020/01/avatar-.jpg";

        internal class UserDTO : User
        {
            public string Sex => (Gender == 0) ? "Female" : "Male";
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void SetDataGridViewVisible(DataGridView dgvList)
        {
            string[] columnNameList = { "Avatar", "Password", "Role", "Enabled",
                            "OrderShipperNavigations", "OrderUsernameNavigations", "Carts", "Gender" };

            //SET INVISIBLE COLUMN
            foreach (string column in columnNameList)
            {
                dgvList.Columns[column].Visible = false;
            }
        }
        //================ CUSTOMER AREA =========================

        private List<User> LoadCustomerFilter(List<User> list)
        {
            list = list.Where(u => u.Name.ToLower().Contains(txtCustomerSearch.Text.ToLower())).ToList();
            if (cbCustomerStatus.SelectedIndex == 1)
            {
                list = list.Where(u => u.Enabled == true).ToList();
            }
            else if (cbCustomerStatus.SelectedIndex == 2)
            {
                list = list.Where(u => u.Enabled == false).ToList();
            }
            return list;
        }

        private void LoadCustomerButton()
        {
            User u = userRepository.Get(txtCustomerUsername.Text);
            btnCustomerStatus.Enabled = true;
            if (u == null)
            {
                btnCustomerStatus.Enabled = false;
            }
            else if (u.Enabled == true)
            {
                btnCustomerStatus.Text = "BAN";
                btnCustomerStatus.ForeColor = Color.Red;
            }
            else
            {
                btnCustomerStatus.Text = "ACTIVE";
                btnCustomerStatus.ForeColor = Color.Green;
            }
        }

        private void LoadCustomerData()
        {
            source = new BindingSource();
            List<User> list = userRepository.GetUsersByRole(CUSTOMER_ROLE);
            list = LoadCustomerFilter(list);

            source.DataSource = list;
            lblCustomerFullname.DataBindings.Clear();
            txtCustomerEmail.DataBindings.Clear();
            txtCustomerUsername.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerAddress.DataBindings.Clear();
            txtCustomerYob.DataBindings.Clear();
            txtCustomerGender.DataBindings.Clear();

            lblCustomerFullname.DataBindings.Add("Text", source, "Name");
            txtCustomerEmail.DataBindings.Add("Text", source, "Email");
            txtCustomerUsername.DataBindings.Add("Text", source, "Username");
            txtCustomerPhone.DataBindings.Add("Text", source, "Phone");
            txtCustomerAddress.DataBindings.Add("Text", source, "Address");
            txtCustomerYob.DataBindings.Add("Text", source, "Yob");
            txtCustomerGender.DataBindings.Add("Text", source, "Sex");
            pbCustomerAvatar.ImageLocation = DEFAULT_AVATAR;

            dgvCustomers.DataSource = source;
            btnCustomerStatus.Enabled = false;

            SetDataGridViewVisible(dgvCustomers);
        }

        private void cbCustomerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void tabcontrolCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
            cbCustomerStatus.SelectedIndex = 0;
        }

        //EVENT CLICK
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCustomerButton();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerSearch.Text = "";
            cbCustomerStatus.SelectedIndex = 0;
            LoadCustomerData();
        }
        private void btnCustomerStatus_Click(object sender, EventArgs e)
        {
            User u = userRepository.Get(txtCustomerUsername.Text);

            if (btnCustomerStatus.Text == "BAN")
            {
                if (MessageBox.Show($"DO YOU WANT TO BAN {u.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    u.Enabled = false;

                    userRepository.Update(u);
                    LoadCustomerData();
                }
            }
            else
            {
                if (MessageBox.Show($"DO YOU WANT TO ACTIVE {u.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    u.Enabled = true;

                    userRepository.Update(u);
                    LoadCustomerData();
                }
            }
        }
        //================ CUSTOMER AREA =========================
        //--------------------------------------------------------
        //================ STAFF AREA ============================
        private List<User> LoadStaffFilter(List<User> list)
        {
            list = list.Where(u => u.Name.ToLower().Contains(txtStaffSearch.Text.ToLower())).ToList();
            if (cbStaffStatus.SelectedIndex == 1)
            {
                list = list.Where(u => u.Enabled == true).ToList();
            }
            else if (cbStaffStatus.SelectedIndex == 2)
            {
                list = list.Where(u => u.Enabled == false).ToList();
            }
            return list;
        }
        private void LoadStaffData()
        {
            source = new BindingSource();
            List<User> list = userRepository.GetUsersByRole(STAFF_ROLE);
            list = LoadStaffFilter(list);

            source.DataSource = list;
            lblStaffFullname.DataBindings.Clear();
            txtStaffEmail.DataBindings.Clear();
            txtStaffUsername.DataBindings.Clear();
            txtStaffPhone.DataBindings.Clear();
            txtStaffAddress.DataBindings.Clear();
            txtStaffYob.DataBindings.Clear();
            txtStaffGender.DataBindings.Clear();

            lblStaffFullname.DataBindings.Add("Text", source, "Name");
            txtStaffEmail.DataBindings.Add("Text", source, "Email");
            txtStaffUsername.DataBindings.Add("Text", source, "Username");
            txtStaffPhone.DataBindings.Add("Text", source, "Phone");
            txtStaffAddress.DataBindings.Add("Text", source, "Address");
            txtStaffYob.DataBindings.Add("Text", source, "Yob");
            txtStaffGender.DataBindings.Add("Text", source, "Sex");
            pbStaffAvatar.ImageLocation = DEFAULT_AVATAR;

            dgvStaffs.DataSource = source;
            btnStaffStatus.Enabled = false;
            SetDataGridViewVisible(dgvStaffs);
        }

        private void LoadStaffButton()
        {
            User u = userRepository.Get(txtStaffUsername.Text);
            btnStaffStatus.Enabled = true;
            if (u == null)
            {
                btnStaffStatus.Enabled = false;
            }
            else if (u.Enabled == true)
            {
                btnStaffStatus.Text = "BAN";
                btnStaffStatus.ForeColor = Color.Red;
            }
            else
            {
                btnStaffStatus.Text = "ACTIVE";
                btnStaffStatus.ForeColor = Color.Green;
            }
        }
        //CLICK EVENT
        private void tabStaff_Click(object sender, EventArgs e)
        {
            LoadStaffData();
            cbStaffStatus.SelectedIndex = 0;
        }
        private void dgvStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadStaffButton();
        }

        private void btnStaffStatus_Click(object sender, EventArgs e)
        {
            User u = userRepository.Get(txtStaffUsername.Text);

            if (btnStaffStatus.Text == "BAN")
            {
                if (MessageBox.Show($"DO YOU WANT TO BAN {u.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    u.Enabled = false;

                    userRepository.Update(u);
                    LoadStaffData();
                }
            }
            else
            {
                if (MessageBox.Show($"DO YOU WANT TO ACTIVE {u.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    u.Enabled = true;

                    userRepository.Update(u);
                    LoadStaffData();
                }
            }
        }
        private void txtStaffAdd_Click(object sender, EventArgs e)
        {
            var form = new frmStaffRegister
            {
                RegisterRole = "STAFF"
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStaffData();
            }
        }
        //RESET CLICK
        private void button1_Click(object sender, EventArgs e)
        {
            txtStaffSearch.Text = "";
            cbStaffStatus.SelectedIndex = 0;
            LoadStaffData();
        }
        //TEXT CHANGED EVENT
        private void txtStaffSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStaffData();
        }
        private void cbStaffStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStaffData();
        }
        //================ STAFF AREA ============================

        //================ SHIPPER AREA ==========================
        private List<User> LoadShipperFilter(List<User> list)
        {
            list = list.Where(u => u.Name.ToLower().Contains(txtShipperSearch.Text.ToLower())).ToList();
            if (cbShipperStatus.SelectedIndex == 1)
            {
                list = list.Where(u => u.Enabled == true).ToList();
            }
            else if (cbShipperStatus.SelectedIndex == 2)
            {
                list = list.Where(u => u.Enabled == false).ToList();
            }
            return list;
        }
        private void LoadShipperData()
        {
            source = new BindingSource();
            List<User> list = userRepository.GetUsersByRole(SHIPPER_ROLE);
            list = LoadShipperFilter(list);

            source.DataSource = list;
            lblShipperFullname.DataBindings.Clear();
            txtShipperEmail.DataBindings.Clear();
            txtShipperUsername.DataBindings.Clear();
            txtShipperPhone.DataBindings.Clear();
            txtShipperAddress.DataBindings.Clear();
            txtShipperYob.DataBindings.Clear();
            txtShipperGender.DataBindings.Clear();

            lblShipperFullname.DataBindings.Add("Text", source, "Name");
            txtShipperEmail.DataBindings.Add("Text", source, "Email");
            txtShipperUsername.DataBindings.Add("Text", source, "Username");
            txtShipperPhone.DataBindings.Add("Text", source, "Phone");
            txtShipperAddress.DataBindings.Add("Text", source, "Address");
            txtShipperYob.DataBindings.Add("Text", source, "Yob");
            txtShipperGender.DataBindings.Add("Text", source, "Sex");
            pbShipperAvatar.ImageLocation = DEFAULT_AVATAR;

            dgvShippers.DataSource = source;
            btnShipperStatus.Enabled = false;
            SetDataGridViewVisible(dgvShippers);
        }

        private void LoadShipperButton()
        {
            User u = userRepository.Get(txtShipperUsername.Text);
            btnShipperStatus.Enabled = true;
            if (u == null)
            {
                btnShipperStatus.Enabled = false;
            }
            else if (u.Enabled == true)
            {
                btnShipperStatus.Text = "BAN";
                btnShipperStatus.ForeColor = Color.Red;
            }
            else
            {
                btnShipperStatus.Text = "ACTIVE";
                btnShipperStatus.ForeColor = Color.Green;
            }
        }
        //CLICK EVENT
        private void tabShipper_Click(object sender, EventArgs e)
        {
            LoadShipperData();
            cbShipperStatus.SelectedIndex = 0;
        }
        private void dgvShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadShipperButton();
        }

        private void btnShipperStatus_Click(object sender, EventArgs e)
        {
            User u = userRepository.Get(txtShipperUsername.Text);

            if (btnShipperStatus.Text == "BAN")
            {
                if (MessageBox.Show($"DO YOU WANT TO BAN {u.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    u.Enabled = false;

                    userRepository.Update(u);
                    LoadShipperData();
                }
            }
            else
            {
                if (MessageBox.Show($"DO YOU WANT TO ACTIVE {u.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    u.Enabled = true;

                    userRepository.Update(u);
                    LoadShipperData();
                }
            }
        }
        private void txtShipperAdd_Click(object sender, EventArgs e)
        {
            var form = new frmStaffRegister
            {
                RegisterRole = "SHIPPER"
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadShipperData();
            }
        }
        //RESET CLICK
        private void btnShipperReset_Click(object sender, EventArgs e)
        {
            txtShipperSearch.Text = "";
            cbShipperStatus.SelectedIndex = 0;
            LoadShipperData();
        }
        //TEXT CHANGED EVENT
        private void txtShipperSearch_TextChanged(object sender, EventArgs e)
        {
            LoadShipperData();
        }
        private void cbShipperStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShipperData();
        }

        //================ SHIPPER AREA ==========================

        private void groupBoxSearch_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            tabcontrolCustomer_SelectedIndexChanged(sender, e);
        }

        private void tabcontrolCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedIndex == 0)
            {
                tabcontrolCustomer_Click(sender, e);
            }
            else if (tabControlAdmin.SelectedIndex == 1)
            {
                tabStaff_Click(sender, e);
            }
            else if (tabControlAdmin.SelectedIndex == 2)
            {
                tabShipper_Click(sender, e);
            }
            else if (tabControlAdmin.SelectedIndex == 3)
            {
                tabStatisticOveral_Click(sender, e);
            }
            else if (tabControlAdmin.SelectedIndex == 4)
            {
                tabRevenue_Click(sender, e);
            }
            else if (tabControlAdmin.SelectedIndex == 5)
            {
                tabOrder_Click(sender, e);
            }
        }
        //====================statistic=====================
        private DateTime GetDate(DateTime date)
        {
            date = DateTime.Now.Date;

            while (date.AddHours(-1).Day == date.Day)
                date = date.AddHours(-1);

            return date;
        }
        private List<double> GetRevenueListOfYear(DateTime date)
        {
            DateTime start = date;
            DateTime end = date;

            List<double> revenueList = new List<double>();

            //GET FIRST DAY OF FIRST MONTH
            while (start.AddMonths(-1).Year == date.Year)
                start = start.AddMonths(-1);
            while (start.AddDays(-1).Month == start.Month)
            {
                start = start.AddDays(-1);
            }

            while (start.AddMonths(1).Year == start.Year)
            {
                revenueList.Add(orderRepository.GetRevenueByMonth(start));
                start = start.AddMonths(1);
            }
            revenueList.Add(orderRepository.GetRevenueByMonth(start));

            return revenueList;
        }
        private List<int> GetTotalOrderListOfYear(DateTime date)
        {
            DateTime start = date;
            DateTime end = date;

            List<int> totalOrderList = new List<int>();

            //GET FIRST DAY OF FIRST MONTH
            while (start.AddMonths(-1).Year == date.Year)
                start = start.AddMonths(-1);
            while (start.AddDays(-1).Month == start.Month)
            {
                start = start.AddDays(-1);
            }

            while (start.AddMonths(1).Year == start.Year)
            {
                totalOrderList.Add(orderRepository.GetTotalOrderByMonth(start));
                start = start.AddMonths(1);
            }
            totalOrderList.Add(orderRepository.GetTotalOrderByMonth(start));

            return totalOrderList;
        }
        private void tabStatisticOveral_Click(object sender, EventArgs e)
        {
            //LAY DATE THONG QUA GetDate()
            DateTime date = GetDate(DateTime.Now);

            txtRevenueDay.Text = orderRepository.GetRevenueByDay(date).ToString() + " VND";
            txtRevenueWeek.Text = orderRepository.GetRevenueByWeek(date).ToString() + " VND";
            txtRevenueMonth.Text = orderRepository.GetRevenueByMonth(date).ToString() + " VND";

            txtOrderDay.Text = orderRepository.GetTotalOrderByDay(date).ToString();
            txtOrderWeek.Text = orderRepository.GetTotalOrderByWeek(date).ToString();
            txtOrderMonth.Text = orderRepository.GetTotalOrderByMonth(date).ToString();

            txtCustomer.Text = userRepository.GetUsersQuantityByRole(CUSTOMER_ROLE).ToString();
            txtStaff.Text = userRepository.GetUsersQuantityByRole(STAFF_ROLE).ToString();
            txtShipper.Text = userRepository.GetUsersQuantityByRole(SHIPPER_ROLE).ToString();

            List<double> revenueList = GetRevenueListOfYear(date);
            List<int> totalOrderList = GetTotalOrderListOfYear(date);

            //draw pie chart 
            int quantityCustomer = userRepository.GetUsersQuantityByRole(CUSTOMER_ROLE);
            int quantityStaff = userRepository.GetUsersQuantityByRole(STAFF_ROLE);
            int quantityShipper = userRepository.GetUsersQuantityByRole(SHIPPER_ROLE);
            var model = new PlotModel { Title = "Percentage of User" };

            var series = new PieSeries();
            if (quantityCustomer != 0)
            {
                series.Slices.Add(new PieSlice("Cutomer", quantityCustomer) { Fill = OxyColors.Blue });
            }
            if (quantityStaff != 0)
            {
                series.Slices.Add(new PieSlice("Staff", quantityStaff) { Fill = OxyColors.Red });
            }
            if (quantityShipper != 0)
            {
                series.Slices.Add(new PieSlice("Shipper", quantityShipper) { Fill = OxyColors.Orange });
            }
            model.Series.Add(series);

            pvUser.Model = model;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabRevenue_Click(object sender, EventArgs e)
        {
            DateTime date = GetDate(DateTime.Now);

            txtRevenueByDay.Text = orderRepository.GetRevenueByDay(date).ToString() + " VND";
            txtRevenueByWeek.Text = orderRepository.GetRevenueByWeek(date).ToString() + " VND";
            txtRevenueByMonth.Text = orderRepository.GetRevenueByMonth(date).ToString() + " VND";

            List<double> revenueList = GetRevenueListOfYear(date);
            var model = new PlotModel { Title = "Revenue of each month" };

            var xAxis = new CategoryAxis { Position = AxisPosition.Bottom, Title = "Month" };
            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Revenue" };

            //add data
            var series = new LineSeries();
            for (int i = 0; i < revenueList.Count; i++)
            {
                series.Points.Add(new DataPoint(i, revenueList[i]));
                xAxis.Labels.Add((i + 1).ToString());
            }

            model.Series.Add(series);
            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);
            pvRevenue.Model = model;

        }

        private void tabOrder_Click(object sender, EventArgs e)
        {
            DateTime date = GetDate(DateTime.Now);

            txtOrderByDay.Text = orderRepository.GetTotalOrderByDay(date).ToString();
            txtOrderByWeek.Text = orderRepository.GetTotalOrderByWeek(date).ToString();
            txtOrderByMonth.Text = orderRepository.GetTotalOrderByMonth(date).ToString();

            txtTotalOrder.Text = orderRepository.GetAll().Count().ToString();

            //Chinh lai status o day nha
            txtSuccessflOrder.Text = orderRepository.GetOrdersWithStatus(new List<string> { "SUCCESSFUL" }).Count().ToString();
            txtFailOrder.Text = orderRepository.GetOrdersWithStatus(new List<string> { "FAIL", "CANCELLED" }).Count().ToString();
            txtConfirmOrder.Text = orderRepository.GetOrdersWithStatus(new List<string> { "ORDERED" }).Count().ToString();


            List<int> totalOrderList = GetTotalOrderListOfYear(date);
            var model = new PlotModel { Title = "Percentage of Order Status by Year" };

            var series = new PieSeries();
            int quantitySuccess = orderRepository.GetOrdersWithStatus(new List<string> { "SUCCESSFUL" }).Count();
            if (quantitySuccess != 0)
            {
                series.Slices.Add(new PieSlice("Success", quantitySuccess) { Fill = OxyColors.Blue });
            }
            int quantityConfirm = orderRepository.GetOrdersWithStatus(new List<string> { "ORDERED" }).Count();
            if (quantityConfirm != 0)
            {
                series.Slices.Add(new PieSlice("Ordered", quantityConfirm) { Fill = OxyColors.Orange });
            }
            int quantityFail = orderRepository.GetOrdersWithStatus(new List<string> { "FAIL", "CANCELLED" }).Count();
            if (quantityFail != 0)
            {
                series.Slices.Add(new PieSlice("Fail", quantityFail) { Fill = OxyColors.Red });
            }
            model.Series.Add(series);
            pvOrder.Model = model;
            //draw pie chart 
            //int quantitySuccess = orderRepository.GetOrdersWithStatus(new List<string> { "SUCCESSFUL" }).Count();
            //int quantityFail = orderRepository.GetOrdersWithStatus(new List<string> { "FAIL", "CANCELLED" }).Count();
            //int quantityConfirm = orderRepository.GetOrdersWithStatus(new List<string> { "CONFIRMED" }).Count();

            //var model = new PlotModel { Title = "Percentage of Order Status by Year" };

            //var series = new PieSeries();
            //if (quantitySuccess != 0)
            //{
            //    series.Slices.Add(new PieSlice("Success", quantitySuccess) { Fill = OxyColors.Blue });
            //}
            //if (quantityFail != 0)
            //{
            //    series.Slices.Add(new PieSlice("Fail", quantityFail) { Fill = OxyColors.Red });
            //}
            //if (quantityConfirm != 0)
            //{
            //    series.Slices.Add(new PieSlice("Confirm", quantityConfirm) { Fill = OxyColors.Orange });
            //}

            //model.Series.Add(series);

            //pvOrder.Model = model;
        }
    }
}
