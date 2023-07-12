using BusinessObjects;
using GiftHommieWinforms;
using Repositories;
using System;
using System.Windows.Forms;

namespace GiftHommieWinforms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private IUserRepository userRepository = new UserRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User user = null;
            try
            {
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

}
