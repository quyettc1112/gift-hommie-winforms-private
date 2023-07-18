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

        private void frmDetail_Load(object sender, EventArgs e)
        {
            //cb.DataSource = lists;
            //cb.ValueMember = "ID";
            //cb.DisplayMember = "Name";

            txtID.Enabled = InsertOrUpdate;
            if (InsertOrUpdate == false)
            {
                txtID.Text = TargetObject.PetId.ToString();
                dtpDate.Value = TargetObject.ImportDate.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDATION
                validForm = true;
                if (txtID.Text.Length == 0)
                    throw new Exception("ID is required!");


                // C/U Action
                var target = new Pet
                {
                    PetId = int.Parse(txtID.Text),
                    ImportDate = dtpDate.Value,
                };
                if (InsertOrUpdate)
                {
                    Repository.Create(target);
                }
                else
                {
                    Repository.Update(target);
                }
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
