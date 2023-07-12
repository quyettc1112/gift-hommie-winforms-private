namespace GiftHommieWinforms
{
    partial class frmStaffOrderDetail
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label16 = new System.Windows.Forms.Label();
            txtOrderMessage = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            txtOrderShippingFee = new System.Windows.Forms.TextBox();
            txtOrderReceiver = new System.Windows.Forms.TextBox();
            lbOrderShippingFee = new System.Windows.Forms.Label();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            txtOrderAddress = new System.Windows.Forms.TextBox();
            lbOrderDate = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lbTotal = new System.Windows.Forms.Label();
            txtOrderPhone = new System.Windows.Forms.TextBox();
            dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            lbReceiver = new System.Windows.Forms.Label();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label12 = new System.Windows.Forms.Label();
            lbOrderProductName = new System.Windows.Forms.Label();
            pbOrderProductAvatar = new System.Windows.Forms.PictureBox();
            txtOrderDetailTotal = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtOrderPrice = new System.Windows.Forms.TextBox();
            txtOrderQuantity = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtOrderMessage);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtOrderShippingFee);
            groupBox1.Controls.Add(txtOrderReceiver);
            groupBox1.Controls.Add(lbOrderShippingFee);
            groupBox1.Controls.Add(txtOrderTotal);
            groupBox1.Controls.Add(txtOrderAddress);
            groupBox1.Controls.Add(lbOrderDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lbTotal);
            groupBox1.Controls.Add(txtOrderPhone);
            groupBox1.Controls.Add(dtpOrderTime);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbReceiver);
            groupBox1.Controls.Add(txtOrderStatus);
            groupBox1.Location = new System.Drawing.Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(857, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "OrderDetail";
            // 
            // groupBox2
            // 
            groupBox2.Location = new System.Drawing.Point(863, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(453, 399);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(458, 228);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(49, 20);
            label16.TabIndex = 166;
            label16.Text = "Status";
            // 
            // txtOrderMessage
            // 
            txtOrderMessage.Location = new System.Drawing.Point(154, 169);
            txtOrderMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderMessage.Name = "txtOrderMessage";
            txtOrderMessage.ReadOnly = true;
            txtOrderMessage.Size = new System.Drawing.Size(276, 27);
            txtOrderMessage.TabIndex = 163;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(25, 172);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(67, 20);
            label13.TabIndex = 174;
            label13.Text = "Message";
            // 
            // txtOrderShippingFee
            // 
            txtOrderShippingFee.Location = new System.Drawing.Point(580, 172);
            txtOrderShippingFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderShippingFee.Name = "txtOrderShippingFee";
            txtOrderShippingFee.ReadOnly = true;
            txtOrderShippingFee.Size = new System.Drawing.Size(215, 27);
            txtOrderShippingFee.TabIndex = 164;
            txtOrderShippingFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiver
            // 
            txtOrderReceiver.Location = new System.Drawing.Point(154, 64);
            txtOrderReceiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderReceiver.Name = "txtOrderReceiver";
            txtOrderReceiver.ReadOnly = true;
            txtOrderReceiver.Size = new System.Drawing.Size(273, 27);
            txtOrderReceiver.TabIndex = 159;
            // 
            // lbOrderShippingFee
            // 
            lbOrderShippingFee.AutoSize = true;
            lbOrderShippingFee.Location = new System.Drawing.Point(455, 175);
            lbOrderShippingFee.Name = "lbOrderShippingFee";
            lbOrderShippingFee.Size = new System.Drawing.Size(95, 20);
            lbOrderShippingFee.TabIndex = 173;
            lbOrderShippingFee.Text = "Shipping Fee";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(154, 226);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(176, 27);
            txtOrderTotal.TabIndex = 165;
            txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderAddress
            // 
            txtOrderAddress.Location = new System.Drawing.Point(154, 117);
            txtOrderAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderAddress.Name = "txtOrderAddress";
            txtOrderAddress.ReadOnly = true;
            txtOrderAddress.Size = new System.Drawing.Size(276, 27);
            txtOrderAddress.TabIndex = 161;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(455, 65);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(84, 20);
            lbOrderDate.TabIndex = 169;
            lbOrderDate.Text = "Order Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(25, 120);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 20);
            label9.TabIndex = 172;
            label9.Text = "Address";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new System.Drawing.Point(29, 229);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(42, 20);
            lbTotal.TabIndex = 168;
            lbTotal.Text = "Total";
            // 
            // txtOrderPhone
            // 
            txtOrderPhone.Location = new System.Drawing.Point(579, 120);
            txtOrderPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderPhone.Name = "txtOrderPhone";
            txtOrderPhone.ReadOnly = true;
            txtOrderPhone.Size = new System.Drawing.Size(216, 27);
            txtOrderPhone.TabIndex = 162;
            txtOrderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpOrderTime
            // 
            dtpOrderTime.CustomFormat = "MMM dd, yyyy hh:ss";
            dtpOrderTime.Enabled = false;
            dtpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpOrderTime.Location = new System.Drawing.Point(580, 60);
            dtpOrderTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dtpOrderTime.Name = "dtpOrderTime";
            dtpOrderTime.Size = new System.Drawing.Size(215, 27);
            dtpOrderTime.TabIndex = 160;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(455, 123);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 20);
            label8.TabIndex = 171;
            label8.Text = "Phone";
            // 
            // lbReceiver
            // 
            lbReceiver.AutoSize = true;
            lbReceiver.Location = new System.Drawing.Point(22, 64);
            lbReceiver.Name = "lbReceiver";
            lbReceiver.Size = new System.Drawing.Size(65, 20);
            lbReceiver.TabIndex = 167;
            lbReceiver.Text = "Receiver";
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(580, 222);
            txtOrderStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.ReadOnly = true;
            txtOrderStatus.Size = new System.Drawing.Size(121, 27);
            txtOrderStatus.TabIndex = 170;
            txtOrderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(1, 398);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1316, 313);
            dataGridView1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(904, 25);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(349, 41);
            label12.TabIndex = 93;
            label12.Text = "Order Detail Information";
            // 
            // lbOrderProductName
            // 
            lbOrderProductName.AutoSize = true;
            lbOrderProductName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderProductName.Location = new System.Drawing.Point(971, 83);
            lbOrderProductName.Name = "lbOrderProductName";
            lbOrderProductName.Size = new System.Drawing.Size(199, 41);
            lbOrderProductName.TabIndex = 97;
            lbOrderProductName.Text = "Product Name";
            // 
            // pbOrderProductAvatar
            // 
            pbOrderProductAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbOrderProductAvatar.Location = new System.Drawing.Point(876, 138);
            pbOrderProductAvatar.Name = "pbOrderProductAvatar";
            pbOrderProductAvatar.Size = new System.Drawing.Size(200, 241);
            pbOrderProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbOrderProductAvatar.TabIndex = 98;
            pbOrderProductAvatar.TabStop = false;
            // 
            // txtOrderDetailTotal
            // 
            txtOrderDetailTotal.Location = new System.Drawing.Point(1176, 310);
            txtOrderDetailTotal.Name = "txtOrderDetailTotal";
            txtOrderDetailTotal.ReadOnly = true;
            txtOrderDetailTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderDetailTotal.Size = new System.Drawing.Size(99, 27);
            txtOrderDetailTotal.TabIndex = 101;
            txtOrderDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(1082, 184);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 28);
            label11.TabIndex = 102;
            label11.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(1086, 306);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(54, 28);
            label14.TabIndex = 104;
            label14.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(1082, 247);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(88, 28);
            label10.TabIndex = 103;
            label10.Text = "Quantity";
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new System.Drawing.Point(1176, 185);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.ReadOnly = true;
            txtOrderPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderPrice.Size = new System.Drawing.Size(99, 27);
            txtOrderPrice.TabIndex = 99;
            txtOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new System.Drawing.Point(1176, 251);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.ReadOnly = true;
            txtOrderQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderQuantity.Size = new System.Drawing.Size(99, 27);
            txtOrderQuantity.TabIndex = 100;
            txtOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmStaffOrderDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1313, 738);
            Controls.Add(txtOrderDetailTotal);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(txtOrderPrice);
            Controls.Add(txtOrderQuantity);
            Controls.Add(pbOrderProductAvatar);
            Controls.Add(lbOrderProductName);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmStaffOrderDetail";
            Text = "frmStaffOrderDetail";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOrderMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOrderShippingFee;
        private System.Windows.Forms.TextBox txtOrderReceiver;
        private System.Windows.Forms.Label lbOrderShippingFee;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtOrderPhone;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbReceiver;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbOrderProductName;
        private System.Windows.Forms.PictureBox pbOrderProductAvatar;
        private System.Windows.Forms.TextBox txtOrderDetailTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderQuantity;
    }
}