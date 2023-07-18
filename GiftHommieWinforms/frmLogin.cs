using BusinessObjects;
using Repositories;
using GiftHommieWinforms;
using System;
using System.Windows.Forms;

namespace GiftHommieWinforms
{
    public partial class frmLogin : Form
    {
        private string ADMIN_ROLE = "ADMIN";
        public frmLogin()
        {
            InitializeComponent();
        }

        private IUserRepository userRepository = new UserRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "hoangthien";
            txtPassword.Text = "1";
            User user = null;           
            try
            {
                if (txtEmail.Text.Length == 0)
                    throw new Exception("Please enter the email/username/phone!");
                if (txtPassword.Text.Length == 0)
                    throw new Exception("Please enter the password!");

                user = userRepository.Authenticate(txtEmail.Text, txtPassword.Text);
                if (user != null)
                {
                    GlobalData.AuthenticatedUser = user;
                    if (user.Role.Equals("CUSTOMER")) // CUSTOMER
                    {
                        frmCustomer frmCustomer = new frmCustomer();

                        frmCustomer.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "!";

                        frmCustomer.FormClosed += delegate
                        {
                            this.Close();
                        };
                        this.Hide();
                        frmCustomer.Show();

                    }
                    else if (user.Role.Equals("STAFF")) // STAFF
                    {
                        frmStaff frmStaff = new frmStaff();
                        frmStaff.FormClosed += delegate
                        {
                            this.Close();
                        };
                        frmStaff.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [Staff Mode]";
                        this.Hide();
                        frmStaff.Show();
                    }
                    else if (user.Role.Equals(ADMIN_ROLE)) //ADMIN
                    {
                        var form = new frmAdmin();
                        form.FormClosed += delegate
                        {
                            this.Close();
                        };
                        form.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [ADMIN Mode]";
                        this.Hide();
                        form.Show();
                    }
                    else if (user.Role.Equals("SHIPPER")) {
                        var form = new frmShipper();
                        form.FormClosed += delegate
                        {
                            this.Close();
                        };
                        form.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [SHIPPER Mode]";
                        this.Hide();
                        form.Show();


                    }
                }
                else
                {
                    MessageBox.Show("Wrong email or password!!!", "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Fail");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmRegister();
            frm.ShowDialog();
        }
    }

}
