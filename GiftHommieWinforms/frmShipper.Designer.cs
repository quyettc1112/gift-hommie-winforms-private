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
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dgvTakeOrder = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            lbOrderProductName = new System.Windows.Forms.Label();
            dgvProductInfo = new System.Windows.Forms.DataGridView();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtOrderDetailTotal = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtOrderPrice = new System.Windows.Forms.TextBox();
            txtOrderQuantity = new System.Windows.Forms.TextBox();
            pbOrderProductAvatar = new System.Windows.Forms.PictureBox();
            tbCountItem = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbAllTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTakeOrder).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductInfo).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(6, 313);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 42);
            button1.TabIndex = 1;
            button1.Text = "Delivery";
            button1.UseVisualStyleBackColor = false;
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
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
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
            // dgvProductInfo
            // 
            dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductInfo.Location = new System.Drawing.Point(6, 62);
            dgvProductInfo.Name = "dgvProductInfo";
            dgvProductInfo.RowTemplate.Height = 25;
            dgvProductInfo.Size = new System.Drawing.Size(430, 245);
            dgvProductInfo.TabIndex = 114;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOrderDetailTotal);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label14);
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
            // txtOrderDetailTotal
            // 
            txtOrderDetailTotal.Location = new System.Drawing.Point(300, 140);
            txtOrderDetailTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderDetailTotal.Name = "txtOrderDetailTotal";
            txtOrderDetailTotal.ReadOnly = true;
            txtOrderDetailTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderDetailTotal.Size = new System.Drawing.Size(87, 23);
            txtOrderDetailTotal.TabIndex = 117;
            txtOrderDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(218, 46);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(47, 21);
            label11.TabIndex = 118;
            label11.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(221, 138);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(42, 21);
            label14.TabIndex = 120;
            label14.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(218, 93);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 21);
            label10.TabIndex = 119;
            label10.Text = "Quantity";
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new System.Drawing.Point(300, 47);
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
            txtOrderQuantity.Location = new System.Drawing.Point(300, 96);
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
            // frmShipper
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1330, 577);
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
            ((System.ComponentModel.ISupportInitialize)dgvProductInfo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtOrderDetailTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.PictureBox pbOrderProductAvatar;
        private System.Windows.Forms.TextBox tbCountItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAllTotal;
        private System.Windows.Forms.Label label3;
    }
}