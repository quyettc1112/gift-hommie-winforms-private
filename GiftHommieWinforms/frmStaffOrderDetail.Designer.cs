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
            groupBox1 = new System.Windows.Forms.GroupBox();
            rComment = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            cbOrderStatus = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
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
            btnEditStatus = new System.Windows.Forms.Button();
            dgvStaffOrderDetail = new System.Windows.Forms.DataGridView();
            label12 = new System.Windows.Forms.Label();
            lbOrderProductName = new System.Windows.Forms.Label();
            pbOrderProductAvatar = new System.Windows.Forms.PictureBox();
            txtOrderDetailTotal = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtOrderPrice = new System.Windows.Forms.TextBox();
            txtOrderQuantity = new System.Windows.Forms.TextBox();
            btnRefuse = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            groupBox1.Controls.Add(rComment);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbOrderStatus);
            groupBox1.Controls.Add(label1);
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
            groupBox1.Location = new System.Drawing.Point(1, 2);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(750, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "OrderDetail";
            // 
            // rComment
            // 
            rComment.Location = new System.Drawing.Point(135, 233);
            rComment.Name = "rComment";
            rComment.Size = new System.Drawing.Size(562, 50);
            rComment.TabIndex = 179;
            rComment.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 243);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 15);
            label2.TabIndex = 178;
            label2.Text = "Comment";
            // 
            // cbOrderStatus
            // 
            cbOrderStatus.FormattingEnabled = true;
            cbOrderStatus.Items.AddRange(new object[] { "PENDING", "CONFIRMED", "DELIVERYING", "SUCCESSFUL", "CANCALLED", "REFUSED", "FAIL" });
            cbOrderStatus.Location = new System.Drawing.Point(508, 172);
            cbOrderStatus.Name = "cbOrderStatus";
            cbOrderStatus.Size = new System.Drawing.Size(121, 23);
            cbOrderStatus.TabIndex = 176;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(135, 196);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 13);
            label1.TabIndex = 175;
            label1.Text = "Added Shipping Fee";
            // 
            // groupBox2
            // 
            groupBox2.Location = new System.Drawing.Point(755, 0);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(396, 299);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(401, 171);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(39, 15);
            label16.TabIndex = 166;
            label16.Text = "Status";
            // 
            // txtOrderMessage
            // 
            txtOrderMessage.Location = new System.Drawing.Point(135, 127);
            txtOrderMessage.Name = "txtOrderMessage";
            txtOrderMessage.ReadOnly = true;
            txtOrderMessage.Size = new System.Drawing.Size(242, 23);
            txtOrderMessage.TabIndex = 163;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(22, 129);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(53, 15);
            label13.TabIndex = 174;
            label13.Text = "Message";
            // 
            // txtOrderShippingFee
            // 
            txtOrderShippingFee.Location = new System.Drawing.Point(508, 129);
            txtOrderShippingFee.Name = "txtOrderShippingFee";
            txtOrderShippingFee.ReadOnly = true;
            txtOrderShippingFee.Size = new System.Drawing.Size(189, 23);
            txtOrderShippingFee.TabIndex = 164;
            txtOrderShippingFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiver
            // 
            txtOrderReceiver.Location = new System.Drawing.Point(135, 48);
            txtOrderReceiver.Name = "txtOrderReceiver";
            txtOrderReceiver.ReadOnly = true;
            txtOrderReceiver.Size = new System.Drawing.Size(239, 23);
            txtOrderReceiver.TabIndex = 159;
            // 
            // lbOrderShippingFee
            // 
            lbOrderShippingFee.AutoSize = true;
            lbOrderShippingFee.Location = new System.Drawing.Point(398, 131);
            lbOrderShippingFee.Name = "lbOrderShippingFee";
            lbOrderShippingFee.Size = new System.Drawing.Size(75, 15);
            lbOrderShippingFee.TabIndex = 173;
            lbOrderShippingFee.Text = "Shipping Fee";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(135, 170);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(154, 23);
            txtOrderTotal.TabIndex = 165;
            txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderAddress
            // 
            txtOrderAddress.Location = new System.Drawing.Point(135, 88);
            txtOrderAddress.Name = "txtOrderAddress";
            txtOrderAddress.ReadOnly = true;
            txtOrderAddress.Size = new System.Drawing.Size(242, 23);
            txtOrderAddress.TabIndex = 161;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(398, 49);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(66, 15);
            lbOrderDate.TabIndex = 169;
            lbOrderDate.Text = "Order Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(22, 90);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(49, 15);
            label9.TabIndex = 172;
            label9.Text = "Address";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new System.Drawing.Point(25, 172);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(32, 15);
            lbTotal.TabIndex = 168;
            lbTotal.Text = "Total";
            // 
            // txtOrderPhone
            // 
            txtOrderPhone.Location = new System.Drawing.Point(507, 90);
            txtOrderPhone.Name = "txtOrderPhone";
            txtOrderPhone.ReadOnly = true;
            txtOrderPhone.Size = new System.Drawing.Size(190, 23);
            txtOrderPhone.TabIndex = 162;
            txtOrderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpOrderTime
            // 
            dtpOrderTime.CustomFormat = "MMM dd, yyyy hh:ss";
            dtpOrderTime.Enabled = false;
            dtpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpOrderTime.Location = new System.Drawing.Point(508, 45);
            dtpOrderTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpOrderTime.Name = "dtpOrderTime";
            dtpOrderTime.Size = new System.Drawing.Size(189, 23);
            dtpOrderTime.TabIndex = 160;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(398, 92);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(41, 15);
            label8.TabIndex = 171;
            label8.Text = "Phone";
            // 
            // lbReceiver
            // 
            lbReceiver.AutoSize = true;
            lbReceiver.Location = new System.Drawing.Point(19, 48);
            lbReceiver.Name = "lbReceiver";
            lbReceiver.Size = new System.Drawing.Size(51, 15);
            lbReceiver.TabIndex = 167;
            lbReceiver.Text = "Receiver";
            // 
            // btnEditStatus
            // 
            btnEditStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnEditStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            btnEditStatus.Location = new System.Drawing.Point(1027, 420);
            btnEditStatus.Name = "btnEditStatus";
            btnEditStatus.Size = new System.Drawing.Size(75, 44);
            btnEditStatus.TabIndex = 177;
            btnEditStatus.Text = "Save";
            btnEditStatus.UseVisualStyleBackColor = false;
            btnEditStatus.Click += btnEditStatus_Click;
            // 
            // dgvStaffOrderDetail
            // 
            dgvStaffOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffOrderDetail.Location = new System.Drawing.Point(1, 298);
            dgvStaffOrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvStaffOrderDetail.Name = "dgvStaffOrderDetail";
            dgvStaffOrderDetail.RowHeadersWidth = 51;
            dgvStaffOrderDetail.RowTemplate.Height = 29;
            dgvStaffOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaffOrderDetail.Size = new System.Drawing.Size(940, 235);
            dgvStaffOrderDetail.TabIndex = 1;
            dgvStaffOrderDetail.CellClick += dgvStaffOrderDetail_CellClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(791, 19);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(284, 32);
            label12.TabIndex = 93;
            label12.Text = "Order Detail Information";
            // 
            // lbOrderProductName
            // 
            lbOrderProductName.AutoSize = true;
            lbOrderProductName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderProductName.Location = new System.Drawing.Point(850, 62);
            lbOrderProductName.Name = "lbOrderProductName";
            lbOrderProductName.Size = new System.Drawing.Size(160, 32);
            lbOrderProductName.TabIndex = 97;
            lbOrderProductName.Text = "Product Name";
            // 
            // pbOrderProductAvatar
            // 
            pbOrderProductAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbOrderProductAvatar.Location = new System.Drawing.Point(766, 104);
            pbOrderProductAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pbOrderProductAvatar.Name = "pbOrderProductAvatar";
            pbOrderProductAvatar.Size = new System.Drawing.Size(175, 181);
            pbOrderProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbOrderProductAvatar.TabIndex = 98;
            pbOrderProductAvatar.TabStop = false;
            // 
            // txtOrderDetailTotal
            // 
            txtOrderDetailTotal.Location = new System.Drawing.Point(1029, 232);
            txtOrderDetailTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderDetailTotal.Name = "txtOrderDetailTotal";
            txtOrderDetailTotal.ReadOnly = true;
            txtOrderDetailTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderDetailTotal.Size = new System.Drawing.Size(87, 23);
            txtOrderDetailTotal.TabIndex = 101;
            txtOrderDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(947, 138);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(47, 21);
            label11.TabIndex = 102;
            label11.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(950, 230);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(42, 21);
            label14.TabIndex = 104;
            label14.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(947, 185);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 21);
            label10.TabIndex = 103;
            label10.Text = "Quantity";
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new System.Drawing.Point(1029, 139);
            txtOrderPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.ReadOnly = true;
            txtOrderPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderPrice.Size = new System.Drawing.Size(87, 23);
            txtOrderPrice.TabIndex = 99;
            txtOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new System.Drawing.Point(1029, 188);
            txtOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.ReadOnly = true;
            txtOrderQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderQuantity.Size = new System.Drawing.Size(87, 23);
            txtOrderQuantity.TabIndex = 100;
            txtOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefuse
            // 
            btnRefuse.BackColor = System.Drawing.Color.Red;
            btnRefuse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRefuse.Location = new System.Drawing.Point(1008, 364);
            btnRefuse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRefuse.Name = "btnRefuse";
            btnRefuse.Size = new System.Drawing.Size(108, 33);
            btnRefuse.TabIndex = 106;
            btnRefuse.Text = "Refuse";
            btnRefuse.UseVisualStyleBackColor = false;
            btnRefuse.Visible = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.Cyan;
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Location = new System.Drawing.Point(1008, 305);
            btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(108, 33);
            btnConfirm.TabIndex = 105;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Visible = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1029, 510);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 178;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmStaffOrderDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1149, 554);
            Controls.Add(button1);
            Controls.Add(btnRefuse);
            Controls.Add(btnConfirm);
            Controls.Add(btnEditStatus);
            Controls.Add(txtOrderDetailTotal);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(txtOrderPrice);
            Controls.Add(txtOrderQuantity);
            Controls.Add(pbOrderProductAvatar);
            Controls.Add(lbOrderProductName);
            Controls.Add(label12);
            Controls.Add(dgvStaffOrderDetail);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmStaffOrderDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order Detail";
            FormClosed += frmStaffOrderDetail_FormClosed;
            Load += frmStaffOrderDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffOrderDetail).EndInit();
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
        private System.Windows.Forms.TextBox comboBox1;
        private System.Windows.Forms.DataGridView dgvStaffOrderDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbOrderProductName;
        private System.Windows.Forms.PictureBox pbOrderProductAvatar;
        private System.Windows.Forms.TextBox txtOrderDetailTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Button btnRefuse;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.Button btnEditStatus;
        private System.Windows.Forms.RichTextBox rComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}