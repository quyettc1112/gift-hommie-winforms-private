using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftHommieWinforms
{

    public partial class frmStaffRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        public string RegisterRole;
        public frmStaffRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            label1.Text += " " + RegisterRole;
            LoadDataToYob();
        }

        private void LoadDataToYob()
        {
            List<int> yob = new List<int>();
            int i = 2023;
            while (i > 1950)
            {
                yob.Add(i);
                i--;
            }
            cbYob.DataSource = yob;
            cbYob.SelectedIndex = 0;
        }

        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool CheckName(String input)
        {
            string pattern = @"\d"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckCharacter(String input)
        {
            string pattern = "^[a-zA-Z ]+$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool ValidateInputs()
        {
            if (
                string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtPassword.Text)
                )

            {
                MessageBox.Show("Enter information", "Lack of information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CheckCharacterOfPhone(txtPhone.Text) != true)
            {
                MessageBox.Show("Enter from 9 to 12 digit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
                return false;
            }

            if (CheckName(txtName.Text) == true)
            {
                MessageBox.Show("Name cannot contain number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                return false;
            }
            if (userRepository.Exist(txtUserName.Text))
            {
                MessageBox.Show("Username was Exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                return false;
            }
            if (userRepository.Exist(txtEmail.Text))
            {
                MessageBox.Show("Email was Exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                return false;
            }

            return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            byte tmpGender;
            if (ValidateInputs() == true)
            {
                if (rbMale.Checked == true)
                {
                    tmpGender = 1;
                }
                else
                {
                    tmpGender = 0;
                }
                User user = new User()
                {
                    Username = txtUserName.Text,
                    Email = txtEmail.Text,
                    Role = RegisterRole,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Gender = tmpGender,
                    Yob = int.Parse(cbYob.Text),
                    Address = txtAddress.Text,
                    Avatar = null,
                    Enabled = true
                };
                DialogResult d;
                d = MessageBox.Show($"Confirm register ", "Profile", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    userRepository.Create(user);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetInformation();
        }

        private void ResetInformation()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtName.Text = string.Empty;
        }
    }
}
