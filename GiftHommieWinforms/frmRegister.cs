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
    public partial class frmRegister : Form
    {
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
            for (int i = 1950; i <= 2023; i++)
            {
                yob.Add(i);
            }
            cbYob.DataSource = yob;
            cbYob.SelectedIndex = 0;
        }
    }
}
