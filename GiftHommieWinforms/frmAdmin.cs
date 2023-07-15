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
    public partial class frmAdmin : Form
    {
        BindingSource source;
        IUserRepository userRepository = new UserRepository();
        private const string CUSTOMER_ROLE = "CUSTOMER";
        private const string STAFF_ROLE = "STAFF";
        private const string DEFAULT_AVATAR = "https://thinksport.com.au/wp-content/uploads/2020/01/avatar-.jpg";

        public frmAdmin()
        {
            InitializeComponent();
        }
        //================ CUSTOMER AREA =========================
        private void SetCustomersVisible()
        {
            string[] columnNameList = { "Avatar", "Password", "Role", "Enabled", "Carts", "Orders" };

            //SET INVISIBLE COLUMN
            foreach (string column in columnNameList)
            {
                dgvCustomers.Columns[column].Visible = false;
            }
        }

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
            txtCustomerGender.DataBindings.Add("Text", source, "Gender");
            pbCustomerAvatar.ImageLocation = DEFAULT_AVATAR;

            dgvCustomers.DataSource = source;
            btnCustomerStatus.Enabled = false;
            SetCustomersVisible();
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
        private void SetStaffVisible()
        {
            string[] columnNameList = { "Avatar", "Password", "Role", "Enabled", "Carts", "Orders" };

            //SET INVISIBLE COLUMN
            foreach (string column in columnNameList)
            {
                dgvStaffs.Columns[column].Visible = false;
            }
        }
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
            txtStaffGender.DataBindings.Add("Text", source, "Gender");
            pbStaffAvatar.ImageLocation = DEFAULT_AVATAR;

            dgvStaffs.DataSource = source;
            btnStaffStatus.Enabled = false;
            SetStaffVisible();
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
            var form = new frmStaffRegister();
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
        }
    }
}
