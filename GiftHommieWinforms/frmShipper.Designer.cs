namespace GiftHommieWinforms
{
    partial class frmShipper
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnF = new System.Windows.Forms.Button();
            btnSuc = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dgvTakeOrder = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tbAllTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tbCountItem = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtOrderPrice = new System.Windows.Forms.TextBox();
            txtOrderQuantity = new System.Windows.Forms.TextBox();
            pbOrderProductAvatar = new System.Windows.Forms.PictureBox();
            dgvProductInfo = new System.Windows.Forms.DataGridView();
            lbOrderProductName = new System.Windows.Forms.Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtname = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtxAddress = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTakeOrder).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductInfo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnF);
            groupBox1.Controls.Add(btnSuc);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvTakeOrder);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(858, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordered";
            // 
            // btnF
            // 
            btnF.BackColor = System.Drawing.SystemColors.ControlDark;
            btnF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnF.Location = new System.Drawing.Point(434, 315);
            btnF.Name = "btnF";
            btnF.Size = new System.Drawing.Size(120, 42);
            btnF.TabIndex = 6;
            btnF.Text = "Fail";
            btnF.UseVisualStyleBackColor = false;
            btnF.Visible = false;
            btnF.Click += btnF_Click;
            // 
            // btnSuc
            // 
            btnSuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnSuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuc.Location = new System.Drawing.Point(308, 315);
            btnSuc.Name = "btnSuc";
            btnSuc.Size = new System.Drawing.Size(120, 42);
            btnSuc.TabIndex = 5;
            btnSuc.Text = "Sucessful";
            btnSuc.UseVisualStyleBackColor = false;
            btnSuc.Visible = false;
            btnSuc.Click += btnSuc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Lime;
            label8.Location = new System.Drawing.Point(132, 330);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 15);
            label8.TabIndex = 4;
            label8.Text = "Order is in transit";
            label8.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Chartreuse;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(282, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(257, 37);
            label1.TabIndex = 3;
            label1.Text = "SHIPPING ORDERS";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.IndianRed;
            button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(732, 313);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(120, 42);
            button2.TabIndex = 2;
            button2.Text = "Refuse";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(6, 313);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 42);
            button1.TabIndex = 1;
            button1.Text = "Delivery";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // dgvTakeOrder
            // 
            dgvTakeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTakeOrder.Location = new System.Drawing.Point(6, 62);
            dgvTakeOrder.Name = "dgvTakeOrder";
            dgvTakeOrder.RowTemplate.Height = 25;
            dgvTakeOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTakeOrder.Size = new System.Drawing.Size(846, 245);
            dgvTakeOrder.TabIndex = 0;
            dgvTakeOrder.CellClick += dgvTakeOrder_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbAllTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbCountItem);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvProductInfo);
            groupBox2.Controls.Add(lbOrderProductName);
            groupBox2.Location = new System.Drawing.Point(876, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(442, 561);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product";
            // 
            // tbAllTotal
            // 
            tbAllTotal.Location = new System.Drawing.Point(349, 311);
            tbAllTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAllTotal.Name = "tbAllTotal";
            tbAllTotal.ReadOnly = true;
            tbAllTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tbAllTotal.Size = new System.Drawing.Size(87, 23);
            tbAllTotal.TabIndex = 126;
            tbAllTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(268, 312);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 21);
            label3.TabIndex = 125;
            label3.Text = "All Total";
            // 
            // tbCountItem
            // 
            tbCountItem.Location = new System.Drawing.Point(101, 312);
            tbCountItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbCountItem.Name = "tbCountItem";
            tbCountItem.ReadOnly = true;
            tbCountItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tbCountItem.Size = new System.Drawing.Size(87, 23);
            tbCountItem.TabIndex = 124;
            tbCountItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(9, 313);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 21);
            label2.TabIndex = 123;
            label2.Text = "Count Item";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtOrderPrice);
            groupBox3.Controls.Add(txtOrderQuantity);
            groupBox3.Controls.Add(pbOrderProductAvatar);
            groupBox3.Location = new System.Drawing.Point(6, 352);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(430, 189);
            groupBox3.TabIndex = 116;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Info";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(206, 64);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(47, 21);
            label11.TabIndex = 118;
            label11.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(206, 111);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 21);
            label10.TabIndex = 119;
            label10.Text = "Quantity";
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new System.Drawing.Point(288, 65);
            txtOrderPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.ReadOnly = true;
            txtOrderPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderPrice.Size = new System.Drawing.Size(87, 23);
            txtOrderPrice.TabIndex = 115;
            txtOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new System.Drawing.Point(288, 114);
            txtOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.ReadOnly = true;
            txtOrderQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderQuantity.Size = new System.Drawing.Size(87, 23);
            txtOrderQuantity.TabIndex = 116;
            txtOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbOrderProductAvatar
            // 
            pbOrderProductAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbOrderProductAvatar.Location = new System.Drawing.Point(26, 24);
            pbOrderProductAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pbOrderProductAvatar.Name = "pbOrderProductAvatar";
            pbOrderProductAvatar.Size = new System.Drawing.Size(139, 156);
            pbOrderProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbOrderProductAvatar.TabIndex = 114;
            pbOrderProductAvatar.TabStop = false;
            // 
            // dgvProductInfo
            // 
            dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductInfo.Location = new System.Drawing.Point(6, 62);
            dgvProductInfo.Name = "dgvProductInfo";
            dgvProductInfo.RowTemplate.Height = 25;
            dgvProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductInfo.Size = new System.Drawing.Size(430, 245);
            dgvProductInfo.TabIndex = 114;
            dgvProductInfo.CellClick += dgvProductInfo_CellClick;
            dgvProductInfo.SelectionChanged += dgvProductInfo_SelectionChanged;
            // 
            // lbOrderProductName
            // 
            lbOrderProductName.AutoSize = true;
            lbOrderProductName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderProductName.Location = new System.Drawing.Point(156, 19);
            lbOrderProductName.Name = "lbOrderProductName";
            lbOrderProductName.Size = new System.Drawing.Size(160, 32);
            lbOrderProductName.TabIndex = 106;
            lbOrderProductName.Text = "Product Name";
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(38, 410);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 20);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(364, 410);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(36, 524);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 20);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(364, 524);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(44, 20);
            label7.TabIndex = 5;
            label7.Text = "Total";
            // 
            // txtname
            // 
            txtname.Location = new System.Drawing.Point(107, 410);
            txtname.Name = "txtname";
            txtname.Size = new System.Drawing.Size(211, 23);
            txtname.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.Color.Yellow;
            txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            txtTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotal.Location = new System.Drawing.Point(445, 516);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(211, 49);
            txtTotal.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(107, 524);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(211, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtxAddress
            // 
            txtxAddress.Location = new System.Drawing.Point(445, 400);
            txtxAddress.Multiline = true;
            txtxAddress.Name = "txtxAddress";
            txtxAddress.Size = new System.Drawing.Size(419, 49);
            txtxAddress.TabIndex = 10;
            // 
            // frmShipper
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1330, 577);
            Controls.Add(txtxAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtTotal);
            Controls.Add(txtname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmShipper";
            Text = "frmShipper";
            Load += frmShipper_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTakeOrder).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTakeOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderProductName;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.PictureBox pbOrderProductAvatar;
        private System.Windows.Forms.TextBox tbCountItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAllTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnSuc;
    }
}