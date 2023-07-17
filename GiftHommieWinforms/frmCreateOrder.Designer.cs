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
            dgvProducts = new System.Windows.Forms.DataGridView();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            txtProductNameSearch = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtAvailable = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            lbPrice = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            pbProductAvatar = new System.Windows.Forms.PictureBox();
            txtDesc = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            lbAvailable = new System.Windows.Forms.Label();
            groupBox9 = new System.Windows.Forms.GroupBox();
            txtCartDescription = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            btnCheckout = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBox2 = new System.Windows.Forms.TextBox();
            Address = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new System.Drawing.Point(16, 64);
            dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new System.Drawing.Size(556, 254);
            dgvProducts.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(Address);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtTotal);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(btnCheckout);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox9);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(lbAvailable);
            splitContainer1.Panel2.Controls.Add(txtAvailable);
            splitContainer1.Panel2.Controls.Add(txtPrice);
            splitContainer1.Panel2.Controls.Add(lbPrice);
            splitContainer1.Panel2.Controls.Add(lbProductName);
            splitContainer1.Panel2.Controls.Add(pbProductAvatar);
            splitContainer1.Panel2.Controls.Add(txtDesc);
            splitContainer1.Panel2.Controls.Add(txtProductNameSearch);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(dgvProducts);
            splitContainer1.Size = new System.Drawing.Size(1145, 586);
            splitContainer1.SplitterDistance = 557;
            splitContainer1.TabIndex = 2;
            // 
            // txtProductNameSearch
            // 
            txtProductNameSearch.BackColor = System.Drawing.Color.White;
            txtProductNameSearch.Location = new System.Drawing.Point(318, 24);
            txtProductNameSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductNameSearch.Name = "txtProductNameSearch";
            txtProductNameSearch.Size = new System.Drawing.Size(254, 23);
            txtProductNameSearch.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(270, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 15);
            label5.TabIndex = 50;
            label5.Text = "Search";
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new System.Drawing.Point(587, 407);
            txtAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtAvailable.Size = new System.Drawing.Size(97, 23);
            txtAvailable.TabIndex = 90;
            txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(217, 407);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPrice.Size = new System.Drawing.Size(97, 23);
            txtPrice.TabIndex = 89;
            txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(164, 407);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(47, 21);
            lbPrice.TabIndex = 92;
            lbPrice.Text = "Price:";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductName.Location = new System.Drawing.Point(164, 348);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(194, 37);
            lbProductName.TabIndex = 87;
            lbProductName.Text = "Product Name";
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new System.Drawing.Point(56, 348);
            pbProductAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new System.Drawing.Size(102, 96);
            pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 91;
            pbProductAvatar.TabStop = false;
            pbProductAvatar.Click += pbProductAvatar_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new System.Drawing.Point(16, 322);
            txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new System.Drawing.Size(556, 253);
            txtDesc.TabIndex = 88;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(430, 405);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            textBox1.Size = new System.Drawing.Size(97, 23);
            textBox1.TabIndex = 93;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAvailable.Location = new System.Drawing.Point(348, 407);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new System.Drawing.Size(76, 21);
            lbAvailable.TabIndex = 94;
            lbAvailable.Text = "Available:";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtCartDescription);
            groupBox9.Location = new System.Drawing.Point(56, 448);
            groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox9.Size = new System.Drawing.Size(489, 83);
            groupBox9.TabIndex = 95;
            groupBox9.TabStop = false;
            groupBox9.Text = "Description";
            // 
            // txtCartDescription
            // 
            txtCartDescription.Location = new System.Drawing.Point(8, 20);
            txtCartDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCartDescription.Multiline = true;
            txtCartDescription.Name = "txtCartDescription";
            txtCartDescription.ReadOnly = true;
            txtCartDescription.Size = new System.Drawing.Size(475, 59);
            txtCartDescription.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(94, 113);
            txtTotal.Margin = new System.Windows.Forms.Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(116, 23);
            txtTotal.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(29, 116);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 32;
            label4.Text = "TOTAL:";
            // 
            // button2
            // 
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.Location = new System.Drawing.Point(372, 410);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(84, 35);
            button2.TabIndex = 29;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnCheckout.Location = new System.Drawing.Point(263, 411);
            btnCheckout.Margin = new System.Windows.Forms.Padding(2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(83, 34);
            btnCheckout.TabIndex = 28;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(113, 27);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(305, 37);
            label1.TabIndex = 34;
            label1.Text = "ORDER INFORMATION";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 203);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(551, 182);
            dataGridView1.TabIndex = 96;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(94, 150);
            textBox2.Margin = new System.Windows.Forms.Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(397, 49);
            textBox2.TabIndex = 98;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Address.Location = new System.Drawing.Point(29, 153);
            Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(61, 15);
            Address.TabIndex = 97;
            Address.Text = "ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(294, 116);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 99;
            label2.Text = "ORDER BY";
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1145, 586);
            Controls.Add(splitContainer1);
            Name = "frmCreateOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create New Order";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
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
        private System.Windows.Forms.TextBox txtCartDescription;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}