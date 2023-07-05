namespace GiftHommieWinforms
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabcontrolCustomer = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.tabcontrolCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolCustomer
            // 
            this.tabcontrolCustomer.Controls.Add(this.tabHome);
            this.tabcontrolCustomer.Controls.Add(this.tabCart);
            this.tabcontrolCustomer.Controls.Add(this.tabProfile);
            this.tabcontrolCustomer.Controls.Add(this.tabOrder);
            this.tabcontrolCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabcontrolCustomer.Name = "tabcontrolCustomer";
            this.tabcontrolCustomer.SelectedIndex = 0;
            this.tabcontrolCustomer.Size = new System.Drawing.Size(1417, 664);
            this.tabcontrolCustomer.TabIndex = 0;
            this.tabcontrolCustomer.TabStop = false;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1409, 631);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabCart
            // 
            this.tabCart.Location = new System.Drawing.Point(4, 29);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(1409, 631);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "My Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            this.tabCart.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 29);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1409, 631);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabOrder
            // 
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(1409, 631);
            this.tabOrder.TabIndex = 3;
            this.tabOrder.Text = "My Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 664);
            this.Controls.Add(this.tabcontrolCustomer);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.tabcontrolCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolCustomer;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabOrder;
    }
}