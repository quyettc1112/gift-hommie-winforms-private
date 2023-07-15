namespace GiftHommieWinforms
{
    partial class frmAdmin
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
            tabControlAdmin = new System.Windows.Forms.TabControl();
            tabCustomer = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBoxSearch = new System.Windows.Forms.GroupBox();
            cbCustomerStatus = new System.Windows.Forms.ComboBox();
            label15 = new System.Windows.Forms.Label();
            txtCustomerSearch = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            gbProduct = new System.Windows.Forms.GroupBox();
            txtCustomerGender = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtCustomerAddress = new System.Windows.Forms.TextBox();
            txtCustomerYob = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtCustomerPhone = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            lbAvailable = new System.Windows.Forms.Label();
            gbSelect = new System.Windows.Forms.GroupBox();
            btnCustomerStatus = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtCurrentIndex = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            txtCustomerEmail = new System.Windows.Forms.TextBox();
            txtCustomerUsername = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lblCustomerFullname = new System.Windows.Forms.Label();
            pbProductAvatar = new System.Windows.Forms.PictureBox();
            dgvCustomers = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            tabStaff = new System.Windows.Forms.TabPage();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cbStaffStatus = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtStaffSearch = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            splitContainer4 = new System.Windows.Forms.SplitContainer();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtStaffAdd = new System.Windows.Forms.Button();
            txtStaffGender = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtStaffAddress = new System.Windows.Forms.TextBox();
            txtStaffYob = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            txtStaffPhone = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnStaffStatus = new System.Windows.Forms.Button();
            label18 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            txtStaffEmail = new System.Windows.Forms.TextBox();
            txtStaffUsername = new System.Windows.Forms.TextBox();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            lblStaffFullname = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dgvStaffs = new System.Windows.Forms.DataGridView();
            button6 = new System.Windows.Forms.Button();
            tabControlAdmin.SuspendLayout();
            tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbProduct.SuspendLayout();
            gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).BeginInit();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabCustomer);
            tabControlAdmin.Controls.Add(tabStaff);
            tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            tabControlAdmin.Margin = new System.Windows.Forms.Padding(4);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new System.Drawing.Size(1742, 956);
            tabControlAdmin.TabIndex = 1;
            tabControlAdmin.TabStop = false;
            tabControlAdmin.SelectedIndexChanged += tabcontrolCustomer_SelectedIndexChanged;
            tabControlAdmin.Click += tabcontrolCustomer_Click;
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(splitContainer1);
            tabCustomer.Location = new System.Drawing.Point(4, 34);
            tabCustomer.Margin = new System.Windows.Forms.Padding(4);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new System.Windows.Forms.Padding(4);
            tabCustomer.Size = new System.Drawing.Size(1734, 918);
            tabCustomer.TabIndex = 0;
            tabCustomer.Text = "Customer";
            tabCustomer.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(4, 4);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(1726, 910);
            splitContainer1.SplitterDistance = 415;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 87;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBoxSearch.Controls.Add(cbCustomerStatus);
            groupBoxSearch.Controls.Add(label15);
            groupBoxSearch.Controls.Add(txtCustomerSearch);
            groupBoxSearch.Controls.Add(label5);
            groupBoxSearch.Controls.Add(btnReset);
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            groupBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxSearch.Size = new System.Drawing.Size(415, 910);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            groupBoxSearch.Enter += groupBoxSearch_Enter;
            // 
            // cbCustomerStatus
            // 
            cbCustomerStatus.BackColor = System.Drawing.Color.White;
            cbCustomerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCustomerStatus.FormattingEnabled = true;
            cbCustomerStatus.Items.AddRange(new object[] { "ALL", "ACTIVE", "BANNED" });
            cbCustomerStatus.Location = new System.Drawing.Point(11, 244);
            cbCustomerStatus.Margin = new System.Windows.Forms.Padding(4);
            cbCustomerStatus.Name = "cbCustomerStatus";
            cbCustomerStatus.Size = new System.Drawing.Size(362, 33);
            cbCustomerStatus.TabIndex = 51;
            cbCustomerStatus.SelectedIndexChanged += cbCustomerStatus_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(11, 215);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(60, 25);
            label15.TabIndex = 52;
            label15.Text = "Status";
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.BackColor = System.Drawing.Color.White;
            txtCustomerSearch.Location = new System.Drawing.Point(11, 151);
            txtCustomerSearch.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new System.Drawing.Size(362, 31);
            txtCustomerSearch.TabIndex = 0;
            txtCustomerSearch.TextChanged += txtCustomerSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 124);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(141, 25);
            label5.TabIndex = 48;
            label5.Text = "Customer Name";
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(231, 49);
            btnReset.Margin = new System.Windows.Forms.Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(142, 39);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.Enabled = false;
            btnSearch.Location = new System.Drawing.Point(31, 49);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(178, 39);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Auto Filting";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(gbProduct);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvCustomers);
            splitContainer2.Panel2.Controls.Add(btnClose);
            splitContainer2.Size = new System.Drawing.Size(1306, 910);
            splitContainer2.SplitterDistance = 475;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 87;
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(txtCustomerGender);
            gbProduct.Controls.Add(label2);
            gbProduct.Controls.Add(txtCustomerAddress);
            gbProduct.Controls.Add(txtCustomerYob);
            gbProduct.Controls.Add(label11);
            gbProduct.Controls.Add(label10);
            gbProduct.Controls.Add(txtCustomerPhone);
            gbProduct.Controls.Add(label8);
            gbProduct.Controls.Add(lbAvailable);
            gbProduct.Controls.Add(gbSelect);
            gbProduct.Controls.Add(txtCustomerEmail);
            gbProduct.Controls.Add(txtCustomerUsername);
            gbProduct.Controls.Add(label1);
            gbProduct.Controls.Add(lbPrice);
            gbProduct.Controls.Add(lblCustomerFullname);
            gbProduct.Controls.Add(pbProductAvatar);
            gbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            gbProduct.Location = new System.Drawing.Point(0, 0);
            gbProduct.Margin = new System.Windows.Forms.Padding(4);
            gbProduct.Name = "gbProduct";
            gbProduct.Padding = new System.Windows.Forms.Padding(4);
            gbProduct.Size = new System.Drawing.Size(1306, 475);
            gbProduct.TabIndex = 86;
            gbProduct.TabStop = false;
            // 
            // txtCustomerGender
            // 
            txtCustomerGender.Location = new System.Drawing.Point(520, 372);
            txtCustomerGender.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerGender.Name = "txtCustomerGender";
            txtCustomerGender.ReadOnly = true;
            txtCustomerGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCustomerGender.Size = new System.Drawing.Size(155, 31);
            txtCustomerGender.TabIndex = 101;
            txtCustomerGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(363, 369);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 32);
            label2.TabIndex = 100;
            label2.Text = "Gender";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new System.Drawing.Point(937, 184);
            txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.ReadOnly = true;
            txtCustomerAddress.Size = new System.Drawing.Size(346, 137);
            txtCustomerAddress.TabIndex = 99;
            // 
            // txtCustomerYob
            // 
            txtCustomerYob.Location = new System.Drawing.Point(519, 314);
            txtCustomerYob.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerYob.Name = "txtCustomerYob";
            txtCustomerYob.ReadOnly = true;
            txtCustomerYob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCustomerYob.Size = new System.Drawing.Size(155, 31);
            txtCustomerYob.TabIndex = 98;
            txtCustomerYob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(363, 314);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(148, 32);
            label11.TabIndex = 97;
            label11.Text = "Year Of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(1055, 148);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(98, 32);
            label10.TabIndex = 96;
            label10.Text = "Address";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new System.Drawing.Point(520, 261);
            txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.ReadOnly = true;
            txtCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCustomerPhone.Size = new System.Drawing.Size(332, 31);
            txtCustomerPhone.TabIndex = 94;
            txtCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(363, 258);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(82, 32);
            label8.TabIndex = 93;
            label8.Text = "Phone";
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAvailable.Location = new System.Drawing.Point(363, 200);
            lbAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new System.Drawing.Size(71, 32);
            lbAvailable.TabIndex = 87;
            lbAvailable.Text = "Email";
            // 
            // gbSelect
            // 
            gbSelect.Controls.Add(btnCustomerStatus);
            gbSelect.Controls.Add(label4);
            gbSelect.Controls.Add(txtCurrentIndex);
            gbSelect.Controls.Add(btnBack);
            gbSelect.Controls.Add(btnNext);
            gbSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbSelect.Location = new System.Drawing.Point(4, 405);
            gbSelect.Margin = new System.Windows.Forms.Padding(4);
            gbSelect.Name = "gbSelect";
            gbSelect.Padding = new System.Windows.Forms.Padding(4);
            gbSelect.Size = new System.Drawing.Size(1298, 66);
            gbSelect.TabIndex = 92;
            gbSelect.TabStop = false;
            // 
            // btnCustomerStatus
            // 
            btnCustomerStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCustomerStatus.ForeColor = System.Drawing.Color.Red;
            btnCustomerStatus.Location = new System.Drawing.Point(1099, 20);
            btnCustomerStatus.Margin = new System.Windows.Forms.Padding(4);
            btnCustomerStatus.Name = "btnCustomerStatus";
            btnCustomerStatus.Size = new System.Drawing.Size(180, 39);
            btnCustomerStatus.TabIndex = 105;
            btnCustomerStatus.Text = "BAN";
            btnCustomerStatus.UseVisualStyleBackColor = true;
            btnCustomerStatus.Click += btnCustomerStatus_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(905, -33);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(184, 32);
            label4.TabIndex = 104;
            label4.Text = "Orders Quantity";
            // 
            // txtCurrentIndex
            // 
            txtCurrentIndex.Location = new System.Drawing.Point(591, 22);
            txtCurrentIndex.Margin = new System.Windows.Forms.Padding(4);
            txtCurrentIndex.Name = "txtCurrentIndex";
            txtCurrentIndex.ReadOnly = true;
            txtCurrentIndex.Size = new System.Drawing.Size(156, 31);
            txtCurrentIndex.TabIndex = 1;
            txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(404, 20);
            btnBack.Margin = new System.Windows.Forms.Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(180, 39);
            btnBack.TabIndex = 0;
            btnBack.Text = "<< Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(756, 20);
            btnNext.Margin = new System.Windows.Forms.Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(180, 39);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next >>";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new System.Drawing.Point(520, 203);
            txtCustomerEmail.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.ReadOnly = true;
            txtCustomerEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCustomerEmail.Size = new System.Drawing.Size(359, 31);
            txtCustomerEmail.TabIndex = 2;
            txtCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerUsername
            // 
            txtCustomerUsername.Location = new System.Drawing.Point(520, 153);
            txtCustomerUsername.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerUsername.Name = "txtCustomerUsername";
            txtCustomerUsername.ReadOnly = true;
            txtCustomerUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCustomerUsername.Size = new System.Drawing.Size(359, 31);
            txtCustomerUsername.TabIndex = 1;
            txtCustomerUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(375, 245);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 32);
            label1.TabIndex = 88;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(363, 152);
            lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(121, 32);
            lbPrice.TabIndex = 86;
            lbPrice.Text = "Username";
            // 
            // lblCustomerFullname
            // 
            lblCustomerFullname.AutoSize = true;
            lblCustomerFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCustomerFullname.Location = new System.Drawing.Point(363, 62);
            lblCustomerFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCustomerFullname.Name = "lblCustomerFullname";
            lblCustomerFullname.Size = new System.Drawing.Size(371, 54);
            lblCustomerFullname.TabIndex = 0;
            lblCustomerFullname.Text = "Customer Fullname";
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new System.Drawing.Point(21, 49);
            pbProductAvatar.Margin = new System.Windows.Forms.Padding(4);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new System.Drawing.Size(300, 348);
            pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 85;
            pbProductAvatar.TabStop = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            dgvCustomers.Location = new System.Drawing.Point(0, 0);
            dgvCustomers.Margin = new System.Windows.Forms.Padding(4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new System.Drawing.Size(1306, 371);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(2359, 706);
            btnClose.Margin = new System.Windows.Forms.Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(106, 36);
            btnClose.TabIndex = 83;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tabStaff
            // 
            tabStaff.Controls.Add(splitContainer3);
            tabStaff.Location = new System.Drawing.Point(4, 34);
            tabStaff.Margin = new System.Windows.Forms.Padding(4);
            tabStaff.Name = "tabStaff";
            tabStaff.Padding = new System.Windows.Forms.Padding(4);
            tabStaff.Size = new System.Drawing.Size(1734, 918);
            tabStaff.TabIndex = 1;
            tabStaff.Text = "Staff";
            tabStaff.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(4, 4);
            splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new System.Drawing.Size(1726, 910);
            splitContainer3.SplitterDistance = 415;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 88;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBox1.Controls.Add(cbStaffStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtStaffSearch);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(415, 910);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // cbStaffStatus
            // 
            cbStaffStatus.BackColor = System.Drawing.Color.White;
            cbStaffStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbStaffStatus.FormattingEnabled = true;
            cbStaffStatus.Items.AddRange(new object[] { "ALL", "ACTIVE", "BANNED" });
            cbStaffStatus.Location = new System.Drawing.Point(11, 244);
            cbStaffStatus.Margin = new System.Windows.Forms.Padding(4);
            cbStaffStatus.Name = "cbStaffStatus";
            cbStaffStatus.Size = new System.Drawing.Size(362, 33);
            cbStaffStatus.TabIndex = 51;
            cbStaffStatus.SelectedIndexChanged += cbStaffStatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 217);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 25);
            label3.TabIndex = 52;
            label3.Text = "Status";
            // 
            // txtStaffSearch
            // 
            txtStaffSearch.BackColor = System.Drawing.Color.White;
            txtStaffSearch.Location = new System.Drawing.Point(11, 151);
            txtStaffSearch.Margin = new System.Windows.Forms.Padding(4);
            txtStaffSearch.Name = "txtStaffSearch";
            txtStaffSearch.Size = new System.Drawing.Size(362, 31);
            txtStaffSearch.TabIndex = 0;
            txtStaffSearch.TextChanged += txtStaffSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 126);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(141, 25);
            label7.TabIndex = 48;
            label7.Text = "Customer Name";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(231, 49);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(142, 39);
            button1.TabIndex = 7;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(31, 49);
            button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(178, 39);
            button2.TabIndex = 0;
            button2.Text = "Auto Filting";
            button2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer4.Location = new System.Drawing.Point(0, 0);
            splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(dgvStaffs);
            splitContainer4.Panel2.Controls.Add(button6);
            splitContainer4.Size = new System.Drawing.Size(1306, 910);
            splitContainer4.SplitterDistance = 475;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 87;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStaffAdd);
            groupBox2.Controls.Add(txtStaffGender);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtStaffAddress);
            groupBox2.Controls.Add(txtStaffYob);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtStaffPhone);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txtStaffEmail);
            groupBox2.Controls.Add(txtStaffUsername);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(lblStaffFullname);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(0, 0);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4);
            groupBox2.Size = new System.Drawing.Size(1306, 475);
            groupBox2.TabIndex = 86;
            groupBox2.TabStop = false;
            // 
            // txtStaffAdd
            // 
            txtStaffAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtStaffAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtStaffAdd.Location = new System.Drawing.Point(1103, 32);
            txtStaffAdd.Margin = new System.Windows.Forms.Padding(4);
            txtStaffAdd.Name = "txtStaffAdd";
            txtStaffAdd.Size = new System.Drawing.Size(180, 39);
            txtStaffAdd.TabIndex = 106;
            txtStaffAdd.Text = "ADD NEW STAFF";
            txtStaffAdd.UseVisualStyleBackColor = true;
            txtStaffAdd.Click += txtStaffAdd_Click;
            // 
            // txtStaffGender
            // 
            txtStaffGender.Location = new System.Drawing.Point(520, 372);
            txtStaffGender.Margin = new System.Windows.Forms.Padding(4);
            txtStaffGender.Name = "txtStaffGender";
            txtStaffGender.ReadOnly = true;
            txtStaffGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtStaffGender.Size = new System.Drawing.Size(155, 31);
            txtStaffGender.TabIndex = 101;
            txtStaffGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(364, 370);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(92, 32);
            label12.TabIndex = 100;
            label12.Text = "Gender";
            // 
            // txtStaffAddress
            // 
            txtStaffAddress.Location = new System.Drawing.Point(937, 184);
            txtStaffAddress.Margin = new System.Windows.Forms.Padding(4);
            txtStaffAddress.Multiline = true;
            txtStaffAddress.Name = "txtStaffAddress";
            txtStaffAddress.ReadOnly = true;
            txtStaffAddress.Size = new System.Drawing.Size(346, 137);
            txtStaffAddress.TabIndex = 99;
            // 
            // txtStaffYob
            // 
            txtStaffYob.Location = new System.Drawing.Point(519, 314);
            txtStaffYob.Margin = new System.Windows.Forms.Padding(4);
            txtStaffYob.Name = "txtStaffYob";
            txtStaffYob.ReadOnly = true;
            txtStaffYob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtStaffYob.Size = new System.Drawing.Size(155, 31);
            txtStaffYob.TabIndex = 98;
            txtStaffYob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(364, 315);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(148, 32);
            label13.TabIndex = 97;
            label13.Text = "Year Of Birth";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(1056, 149);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(98, 32);
            label14.TabIndex = 96;
            label14.Text = "Address";
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Location = new System.Drawing.Point(520, 261);
            txtStaffPhone.Margin = new System.Windows.Forms.Padding(4);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.ReadOnly = true;
            txtStaffPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtStaffPhone.Size = new System.Drawing.Size(332, 31);
            txtStaffPhone.TabIndex = 94;
            txtStaffPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(364, 259);
            label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(82, 32);
            label16.TabIndex = 93;
            label16.Text = "Phone";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(364, 201);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(71, 32);
            label17.TabIndex = 87;
            label17.Text = "Email";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnStaffStatus);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox3.Location = new System.Drawing.Point(4, 405);
            groupBox3.Margin = new System.Windows.Forms.Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4);
            groupBox3.Size = new System.Drawing.Size(1298, 66);
            groupBox3.TabIndex = 92;
            groupBox3.TabStop = false;
            // 
            // btnStaffStatus
            // 
            btnStaffStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStaffStatus.ForeColor = System.Drawing.Color.Red;
            btnStaffStatus.Location = new System.Drawing.Point(1099, 20);
            btnStaffStatus.Margin = new System.Windows.Forms.Padding(4);
            btnStaffStatus.Name = "btnStaffStatus";
            btnStaffStatus.Size = new System.Drawing.Size(180, 39);
            btnStaffStatus.TabIndex = 105;
            btnStaffStatus.Text = "BAN";
            btnStaffStatus.UseVisualStyleBackColor = true;
            btnStaffStatus.Click += btnStaffStatus_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.Location = new System.Drawing.Point(906, -32);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(184, 32);
            label18.TabIndex = 104;
            label18.Text = "Orders Quantity";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(591, 22);
            textBox7.Margin = new System.Windows.Forms.Padding(4);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new System.Drawing.Size(156, 31);
            textBox7.TabIndex = 1;
            textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(404, 20);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(180, 39);
            button4.TabIndex = 0;
            button4.Text = "<< Back";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(756, 20);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(180, 39);
            button5.TabIndex = 2;
            button5.Text = "Next >>";
            button5.UseVisualStyleBackColor = true;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(520, 203);
            txtStaffEmail.Margin = new System.Windows.Forms.Padding(4);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.ReadOnly = true;
            txtStaffEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtStaffEmail.Size = new System.Drawing.Size(359, 31);
            txtStaffEmail.TabIndex = 2;
            txtStaffEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStaffUsername
            // 
            txtStaffUsername.Location = new System.Drawing.Point(520, 153);
            txtStaffUsername.Margin = new System.Windows.Forms.Padding(4);
            txtStaffUsername.Name = "txtStaffUsername";
            txtStaffUsername.ReadOnly = true;
            txtStaffUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtStaffUsername.Size = new System.Drawing.Size(359, 31);
            txtStaffUsername.TabIndex = 1;
            txtStaffUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.Location = new System.Drawing.Point(376, 246);
            label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(0, 32);
            label19.TabIndex = 88;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.Location = new System.Drawing.Point(364, 153);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(121, 32);
            label20.TabIndex = 86;
            label20.Text = "Username";
            // 
            // lblStaffFullname
            // 
            lblStaffFullname.AutoSize = true;
            lblStaffFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStaffFullname.Location = new System.Drawing.Point(364, 63);
            lblStaffFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStaffFullname.Name = "lblStaffFullname";
            lblStaffFullname.Size = new System.Drawing.Size(281, 54);
            lblStaffFullname.TabIndex = 0;
            lblStaffFullname.Text = "Staff Fullname";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(21, 49);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(300, 348);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // dgvStaffs
            // 
            dgvStaffs.AllowUserToAddRows = false;
            dgvStaffs.AllowUserToDeleteRows = false;
            dgvStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffs.Dock = System.Windows.Forms.DockStyle.Top;
            dgvStaffs.Location = new System.Drawing.Point(0, 0);
            dgvStaffs.Margin = new System.Windows.Forms.Padding(4);
            dgvStaffs.Name = "dgvStaffs";
            dgvStaffs.ReadOnly = true;
            dgvStaffs.RowHeadersWidth = 51;
            dgvStaffs.RowTemplate.Height = 29;
            dgvStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaffs.Size = new System.Drawing.Size(1306, 371);
            dgvStaffs.TabIndex = 0;
            dgvStaffs.CellClick += dgvStaffs_CellClick;
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button6.Location = new System.Drawing.Point(3515, 1090);
            button6.Margin = new System.Windows.Forms.Padding(4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(106, 36);
            button6.TabIndex = 83;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1742, 956);
            Controls.Add(tabControlAdmin);
            Name = "frmAdmin";
            Text = "ADMIN PAGE";
            Load += frmAdmin_Load;
            tabControlAdmin.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            gbSelect.ResumeLayout(false);
            gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tabStaff.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox cbCustomerStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lblCustomerFullname;
        private System.Windows.Forms.PictureBox pbProductAvatar;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerYob;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCustomerStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStaffStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStaffGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffYob;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStaffStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblStaffFullname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button txtStaffAdd;
    }
}