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
    public partial class frmCreateCustomerInCreateOrder : Form
    {
        public bool InsertOrUpdate { get; set; }
        public User TargetObject { get; set; }
        public IUserRepository Repository { get; set; }
        public bool validForm = true;

        public frmCreateCustomerInCreateOrder()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == false)
            {
                txtName.Text = TargetObject.Name;
                txtUsername.Text = TargetObject.Username;
                txtPhone.Text = TargetObject.Phone;
                txtEmail.Text = TargetObject.Email;
                txtAddress.Text = TargetObject.Address;
            }
        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^((\+84)|0)(3[2-9]|5[2689]|7[06789]|8[1-9]|9[0-9])(\d{7})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static bool ValidateEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Check if the email matches the pattern
            Match match = Regex.Match(email, pattern);

            // Return true if the email is valid, false otherwise
            return match.Success;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDATION
                validForm = true;
                if (txtPhone.Text.Length == 0)
                    throw new Exception("Phone is required!");
                if (txtEmail.Text.Length == 0)
                    throw new Exception("Email is required!");
                if (txtName.Text.Length == 0)
                    throw new Exception("Name is required!");
                if (txtUsername.Text.Length == 0)
                    throw new Exception("Username is required!");
                if (ValidatePhoneNumber(txtPhone.Text) == false)
                    throw new Exception("Phone is not valid!");
                if (ValidateEmail(txtEmail.Text) == false)
                    throw new Exception("Email is not valid!");


                // C/U Action
                var target = new User
                {
                    Name = txtName.Text,
                    Username = txtUsername.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Role = "CUSTOMER",
                    Password = "123456"
                };
                if (Repository.Exist(target.Username) == false)
                {
                    Repository.Create(target);
                }
                else
                {
                    Repository.Update(target);
                }
                TargetObject = Repository.Get(target.Username);
                MessageBox.Show("Save successfully.", this.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                validForm = false;
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to exit?",
                                    "Confirm to exit",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.Yes)
                this.Close();

        }

        private void frmDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validForm == false)
            {
                validForm = true;
                e.Cancel = true;
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
