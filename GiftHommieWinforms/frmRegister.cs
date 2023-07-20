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
    
    public partial class frmRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadDataToYob();
        }

        private void LoadDataToYob()
        {
            List<int> yob = new List<int>();
            int i = 2023;
            while (i > 1950) { 
                yob.Add(i);
                i--;
            }
            cbYob.DataSource = yob;
            cbYob.SelectedIndex = 0;
        }

        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            if (Regex.IsMatch(input, pattern))
                return true;
            else
                throw new Exception("Please type phone number from 9 to 12");
        }
        private bool CheckName(String input)
        {
            string pattern = @"\d"; // Ký tự chữ cái không phải là số

            if (!Regex.IsMatch(input, pattern))
                return true;
            else
                throw new Exception("Name cannot contain digit");
        }
        private bool CheckGender(bool male, bool female)
        {
            if (!male && !female)
                throw new Exception("Please check gender");

            return true;
        }
        private bool CheckCharacter(String input)
        {
            string pattern = "^[a-zA-Z ]+$"; // Ký tự chữ cái không phải là số
            if (Regex.IsMatch(input, pattern))
                return true;
            else
                throw new Exception("Please type phone number from 9 to 12");
        }
        private bool CheckUsername(string input)
        {
            if (userRepository.Exist(input))
                throw new Exception("Username was Exist");
            if (!char.IsLetter(input[0]))
                throw new Exception("Wrong format of username");
            if (input.Length < 5)
                throw new Exception("Username length equal or more than 5");
            return true;
        }
        private bool CheckEmail(string input)
        {
            if (userRepository.Exist(input))
                throw new Exception("Email was Exist");
            if (!char.IsLetter(input[0]) || !input.Contains("@") || !input.Contains("."))
                throw new Exception("Wrong format of email");

            return true;
        }
        private bool CheckPassword(string input)
        {
            if (input.Length < 5)
                throw new Exception("Password length equal or more than 5");

            return true;
        }
        private bool ValidateInputs()
        {
            try
            {
                if (
                                string.IsNullOrEmpty(txtUserName.Text.Trim()) ||
                                string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                                string.IsNullOrEmpty(txtName.Text.Trim()) ||
                                string.IsNullOrEmpty(txtPhone.Text.Trim()) ||
                                string.IsNullOrEmpty(txtPassword.Text.Trim()) ||
                                string.IsNullOrEmpty(txtPassword.Text.Trim())
                                )
                {
                    MessageBox.Show("Please enter all information field", "Lack of information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (!CheckUsername(txtUserName.Text))
                {
                    //MessageBox.Show("Username was Exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtUserName.Clear();
                }
                if (!CheckEmail(txtEmail.Text))
                {
                    //MessageBox.Show("Email was Exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtEmail.Clear();
                }
                if (!CheckName(txtName.Text))
                {
                    //MessageBox.Show("Name cannot contain digit", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtName.Clear();
                }
                if (!CheckGender(rbMale.Checked, rbFemale.Checked))
                {

                }
                if (!CheckCharacterOfPhone(txtPhone.Text) != true)
                {
                    //MessageBox.Show("Please type phone number from 9 to 12", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtPhone.Clear();
                }
                if (userRepository.GetAll().Where(u => u.Phone == txtPhone.Text).Count() > 0)
                {
                    //throw new Exception("Phone was Exist");
                    throw new Exception("Phone was Exist");
                    //txtPhone.Clear();
                }
                if (!CheckPassword(txtPassword.Text))
                {
                    return false;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    throw new Exception("Password and confirm password was not similar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            byte tmpGender;
            if(ValidateInputs() == true) {
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
                    Role = "CUSTOMER",
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
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtName.Text = string.Empty;
        }
    }
}
