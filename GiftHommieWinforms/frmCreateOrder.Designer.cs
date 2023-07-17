namespace GiftHommieWinforms
{
    partial class frmCreateOrder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupShipping = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.checkShipping = new System.Windows.Forms.CheckBox();
            this.txtOrderBy = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSelectedProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbProductAvatar = new System.Windows.Forms.PictureBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtProductNameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductAvatar)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupShipping);
            this.splitContainer1.Panel1.Controls.Add(this.checkShipping);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderBy);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dgvSelectedProducts);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTotal);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.dgvProducts);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.txtAvailable);
            this.splitContainer1.Panel2.Controls.Add(this.txtProductNameSearch);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(1309, 717);
            this.splitContainer1.SplitterDistance = 636;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupShipping
            // 
            this.groupShipping.Controls.Add(this.label6);
            this.groupShipping.Controls.Add(this.Address);
            this.groupShipping.Controls.Add(this.txtPhone);
            this.groupShipping.Controls.Add(this.txtAddress);
            this.groupShipping.Controls.Add(this.label3);
            this.groupShipping.Controls.Add(this.txtReceiver);
            this.groupShipping.Enabled = false;
            this.groupShipping.Location = new System.Drawing.Point(20, 162);
            this.groupShipping.Name = "groupShipping";
            this.groupShipping.Size = new System.Drawing.Size(600, 113);
            this.groupShipping.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "RECEIVER";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(9, 60);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(76, 20);
            this.Address.TabIndex = 97;
            this.Address.Text = "ADDRESS";
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(401, 15);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 27);
            this.txtPhone.TabIndex = 107;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 56);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(500, 47);
            this.txtAddress.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(254, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "RECEIVER\'s PHONE";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(89, 15);
            this.txtReceiver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(146, 27);
            this.txtReceiver.TabIndex = 104;
            // 
            // checkShipping
            // 
            this.checkShipping.AutoSize = true;
            this.checkShipping.Location = new System.Drawing.Point(480, 132);
            this.checkShipping.Name = "checkShipping";
            this.checkShipping.Size = new System.Drawing.Size(133, 24);
            this.checkShipping.TabIndex = 96;
            this.checkShipping.Text = "Shipping Mode";
            this.checkShipping.UseVisualStyleBackColor = true;
            this.checkShipping.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // txtOrderBy
            // 
            this.txtOrderBy.Location = new System.Drawing.Point(382, 94);
            this.txtOrderBy.Name = "txtOrderBy";
            this.txtOrderBy.Size = new System.Drawing.Size(159, 27);
            this.txtOrderBy.TabIndex = 102;
            this.txtOrderBy.TextChanged += new System.EventHandler(this.txtOrderBy_TextChanged);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewCustomer.Location = new System.Drawing.Point(546, 94);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(50, 28);
            this.btnNewCustomer.TabIndex = 101;
            this.btnNewCustomer.Text = "New";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "ORDER BY";
            // 
            // dgvSelectedProducts
            // 
            this.dgvSelectedProducts.AllowUserToAddRows = false;
            this.dgvSelectedProducts.AllowUserToDeleteRows = false;
            this.dgvSelectedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedProducts.Location = new System.Drawing.Point(3, 281);
            this.dgvSelectedProducts.Name = "dgvSelectedProducts";
            this.dgvSelectedProducts.RowHeadersWidth = 51;
            this.dgvSelectedProducts.RowTemplate.Height = 29;
            this.dgvSelectedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedProducts.Size = new System.Drawing.Size(630, 270);
            this.dgvSelectedProducts.TabIndex = 96;
            this.dgvSelectedProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedProducts_CellEndEdit);
            this.dgvSelectedProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSelectedProducts_EditingControlShowing);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "ORDER INFORMATION";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(110, 95);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(146, 27);
            this.txtTotal.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "TOTAL:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(517, 579);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheckout.Location = new System.Drawing.Point(398, 579);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(95, 45);
            this.btnCheckout.TabIndex = 28;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReset.Location = new System.Drawing.Point(593, 31);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 28);
            this.btnReset.TabIndex = 108;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvProducts.Location = new System.Drawing.Point(18, 65);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(638, 292);
            this.dgvProducts.TabIndex = 91;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // Check
            // 
            this.Check.FalseValue = "false";
            this.Check.HeaderText = "Choose";
            this.Check.MinimumWidth = 8;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.TrueValue = "true";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbProductAvatar);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lbAvailable);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(18, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 324);
            this.panel1.TabIndex = 89;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbProductAvatar
            // 
            this.pbProductAvatar.Location = new System.Drawing.Point(27, 26);
            this.pbProductAvatar.Name = "pbProductAvatar";
            this.pbProductAvatar.Size = new System.Drawing.Size(117, 128);
            this.pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductAvatar.TabIndex = 91;
            this.pbProductAvatar.TabStop = false;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(150, 26);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(236, 45);
            this.lbProductName.TabIndex = 87;
            this.lbProductName.Text = "Product Name";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(150, 75);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 28);
            this.lbPrice.TabIndex = 92;
            this.lbPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(249, 76);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(110, 27);
            this.txtPrice.TabIndex = 89;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAvailable
            // 
            this.lbAvailable.AutoSize = true;
            this.lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAvailable.Location = new System.Drawing.Point(151, 113);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(96, 28);
            this.lbAvailable.TabIndex = 94;
            this.lbAvailable.Text = "Available:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDesc);
            this.groupBox9.Location = new System.Drawing.Point(36, 185);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(570, 111);
            this.groupBox9.TabIndex = 95;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(6, 26);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(558, 79);
            this.txtDesc.TabIndex = 88;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(110, 27);
            this.textBox1.TabIndex = 93;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(671, 543);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAvailable.Size = new System.Drawing.Size(110, 27);
            this.txtAvailable.TabIndex = 90;
            this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.BackColor = System.Drawing.Color.White;
            this.txtProductNameSearch.Location = new System.Drawing.Point(298, 32);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(290, 27);
            this.txtProductNameSearch.TabIndex = 49;
            this.txtProductNameSearch.TextChanged += new System.EventHandler(this.txtProductNameSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Search";
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 717);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Order";
            this.Load += new System.EventHandler(this.frmCreateOrder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupShipping.ResumeLayout(false);
            this.groupShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductAvatar)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.PictureBox pbProductAvatar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.DataGridView dgvSelectedProducts;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.TextBox txtOrderBy;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel groupShipping;
        private System.Windows.Forms.CheckBox checkShipping;
    }
}