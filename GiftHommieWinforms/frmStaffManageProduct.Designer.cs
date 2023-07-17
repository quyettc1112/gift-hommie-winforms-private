namespace GiftHommieWinforms
{
    partial class frmStaffManageProduct
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
            lbProductName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtDesciption = new System.Windows.Forms.TextBox();
            pbProductAvatar = new System.Windows.Forms.PictureBox();
            btnSave = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtImgUrl = new System.Windows.Forms.TextBox();
            cbProductCategory = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            cbAvailable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            SuspendLayout();
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductName.Location = new System.Drawing.Point(270, 26);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(202, 37);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(33, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(33, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(33, 181);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(33, 238);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 21);
            label4.TabIndex = 4;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(33, 350);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 21);
            label5.TabIndex = 5;
            label5.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(153, 67);
            txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtName.Size = new System.Drawing.Size(171, 23);
            txtName.TabIndex = 6;
            txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(153, 121);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPrice.Size = new System.Drawing.Size(171, 23);
            txtPrice.TabIndex = 7;
            txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(153, 238);
            txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtQuantity.Size = new System.Drawing.Size(171, 23);
            txtQuantity.TabIndex = 9;
            txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDesciption
            // 
            txtDesciption.Location = new System.Drawing.Point(153, 353);
            txtDesciption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDesciption.Multiline = true;
            txtDesciption.Name = "txtDesciption";
            txtDesciption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtDesciption.Size = new System.Drawing.Size(545, 76);
            txtDesciption.TabIndex = 0;
            txtDesciption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new System.Drawing.Point(487, 67);
            pbProductAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new System.Drawing.Size(210, 203);
            pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 86;
            pbProductAvatar.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(246, 497);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 33);
            btnSave.TabIndex = 87;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(430, 497);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 33);
            button1.TabIndex = 88;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(37, 452);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 21);
            label6.TabIndex = 89;
            label6.Text = "Image Url";
            // 
            // txtImgUrl
            // 
            txtImgUrl.Location = new System.Drawing.Point(153, 454);
            txtImgUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtImgUrl.Name = "txtImgUrl";
            txtImgUrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtImgUrl.Size = new System.Drawing.Size(301, 23);
            txtImgUrl.TabIndex = 90;
            txtImgUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtImgUrl.TextChanged += txtImgUrl_TextChanged;
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = System.Drawing.Color.White;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "Select the category" });
            cbProductCategory.Location = new System.Drawing.Point(153, 296);
            cbProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new System.Drawing.Size(254, 23);
            cbProductCategory.TabIndex = 91;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(33, 296);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 21);
            label7.TabIndex = 92;
            label7.Text = "Category";
            // 
            // cbAvailable
            // 
            cbAvailable.FormattingEnabled = true;
            cbAvailable.Items.AddRange(new object[] { "True", "False" });
            cbAvailable.Location = new System.Drawing.Point(153, 179);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new System.Drawing.Size(171, 23);
            cbAvailable.TabIndex = 93;
            cbAvailable.Text = "True";
            // 
            // frmStaffManageProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(788, 581);
            Controls.Add(cbAvailable);
            Controls.Add(label7);
            Controls.Add(cbProductCategory);
            Controls.Add(txtImgUrl);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(pbProductAvatar);
            Controls.Add(txtDesciption);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbProductName);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmStaffManageProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaffManageProduct";
            Load += frmStaffManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDesciption;
        private System.Windows.Forms.PictureBox pbProductAvatar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImgUrl;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAvailable;
    }
}