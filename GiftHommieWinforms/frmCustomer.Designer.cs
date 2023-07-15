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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tabMyProfile = new System.Windows.Forms.TabPage();
            btnSave = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            txtAddress = new System.Windows.Forms.TextBox();
            txtYob = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtGender = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtRole = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            label31 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            lbUserName = new System.Windows.Forms.Label();
            tabMyOrder = new System.Windows.Forms.TabPage();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            splitContainer4 = new System.Windows.Forms.SplitContainer();
            btnSort = new System.Windows.Forms.Button();
            gbFilter = new System.Windows.Forms.GroupBox();
            btnFilter = new System.Windows.Forms.Button();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            lbStartDate = new System.Windows.Forms.Label();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            lbEndDate = new System.Windows.Forms.Label();
            cbOrderStatus = new System.Windows.Forms.ComboBox();
            btnCleanAllFilterOrder = new System.Windows.Forms.Button();
            btnSearchOrder = new System.Windows.Forms.Button();
            txtOrderSearch = new System.Windows.Forms.TextBox();
            dgvOrders = new System.Windows.Forms.DataGridView();
            splitContainer5 = new System.Windows.Forms.SplitContainer();
            gbOrderProduct = new System.Windows.Forms.GroupBox();
            pbOrderProductAvatar = new System.Windows.Forms.PictureBox();
            txtOrderDetailTotal = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lbOrderProductName = new System.Windows.Forms.Label();
            txtOrderPrice = new System.Windows.Forms.TextBox();
            txtOrderQuantity = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            splitContainer6 = new System.Windows.Forms.SplitContainer();
            gbOrderTarget = new System.Windows.Forms.GroupBox();
            btnCancelOrder = new System.Windows.Forms.Button();
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
            dgvOrderDetails = new System.Windows.Forms.DataGridView();
            tabHome = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBoxSearch = new System.Windows.Forms.GroupBox();
            cbProductSort = new System.Windows.Forms.ComboBox();
            label15 = new System.Windows.Forms.Label();
            cbProductCategory = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtProductNameSearch = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtUnitsInStockMaxSearch = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtUnitsInStockMinSearch = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            txtUnitPriceMaxSearch = new System.Windows.Forms.TextBox();
            txtUnitPriceMinSearch = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnSearch = new System.Windows.Forms.Button();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            gbProduct = new System.Windows.Forms.GroupBox();
            btnAddToCart = new System.Windows.Forms.Button();
            gbSelect = new System.Windows.Forms.GroupBox();
            txtCurrentIndex = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            txtAvailable = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtDesc = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbAvailable = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            pbProductAvatar = new System.Windows.Forms.PictureBox();
            dgvProducts = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            tabcontrolCustomer = new System.Windows.Forms.TabControl();
            tabCart = new System.Windows.Forms.TabPage();
            splitContainer7 = new System.Windows.Forms.SplitContainer();
            groupBox4 = new System.Windows.Forms.GroupBox();
            txtCartTotal = new System.Windows.Forms.TextBox();
            lbCartTotal = new System.Windows.Forms.Label();
            cbCartSorting = new System.Windows.Forms.ComboBox();
            label17 = new System.Windows.Forms.Label();
            cbCartFilterCategory = new System.Windows.Forms.ComboBox();
            label18 = new System.Windows.Forms.Label();
            txtCartFilterName = new System.Windows.Forms.TextBox();
            label19 = new System.Windows.Forms.Label();
            btnCartReset = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            splitContainer8 = new System.Windows.Forms.SplitContainer();
            groupBox7 = new System.Windows.Forms.GroupBox();
            btnCartDelete = new System.Windows.Forms.Button();
            btnDecrease = new System.Windows.Forms.Button();
            btnIncrease = new System.Windows.Forms.Button();
            txtCartQuantity = new System.Windows.Forms.TextBox();
            label28 = new System.Windows.Forms.Label();
            btnCheckout = new System.Windows.Forms.Button();
            groupBox8 = new System.Windows.Forms.GroupBox();
            lblCartIndex = new System.Windows.Forms.TextBox();
            btnCartBack = new System.Windows.Forms.Button();
            btnCartNext = new System.Windows.Forms.Button();
            txtCartAvailable = new System.Windows.Forms.TextBox();
            txtCartPrice = new System.Windows.Forms.TextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            txtCartDescription = new System.Windows.Forms.TextBox();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            lbCartName = new System.Windows.Forms.Label();
            pbCartAvatar = new System.Windows.Forms.PictureBox();
            dgvCarts = new System.Windows.Forms.DataGridView();
            Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            button6 = new System.Windows.Forms.Button();
            pbCustomerAvatar = new System.Windows.Forms.PictureBox();
            tabMyProfile.SuspendLayout();
            tabMyOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            gbOrderProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            gbOrderTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbProduct.SuspendLayout();
            gbSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabcontrolCustomer.SuspendLayout();
            tabCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.Panel2.SuspendLayout();
            splitContainer8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCartAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCustomerAvatar).BeginInit();
            SuspendLayout();
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // tabMyProfile
            // 
            tabMyProfile.BackColor = System.Drawing.Color.Azure;
            tabMyProfile.Controls.Add(pbCustomerAvatar);
            tabMyProfile.Controls.Add(btnSave);
            tabMyProfile.Controls.Add(btnEdit);
            tabMyProfile.Controls.Add(txtAddress);
            tabMyProfile.Controls.Add(txtYob);
            tabMyProfile.Controls.Add(txtPhone);
            tabMyProfile.Controls.Add(txtGender);
            tabMyProfile.Controls.Add(txtName);
            tabMyProfile.Controls.Add(txtRole);
            tabMyProfile.Controls.Add(txtEmail);
            tabMyProfile.Controls.Add(txtUserName);
            tabMyProfile.Controls.Add(label31);
            tabMyProfile.Controls.Add(label30);
            tabMyProfile.Controls.Add(label29);
            tabMyProfile.Controls.Add(label27);
            tabMyProfile.Controls.Add(label23);
            tabMyProfile.Controls.Add(label22);
            tabMyProfile.Controls.Add(label21);
            tabMyProfile.Controls.Add(label20);
            tabMyProfile.Controls.Add(lbUserName);
            tabMyProfile.Location = new System.Drawing.Point(4, 29);
            tabMyProfile.Name = "tabMyProfile";
            tabMyProfile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tabMyProfile.Size = new System.Drawing.Size(1409, 723);
            tabMyProfile.TabIndex = 3;
            tabMyProfile.Text = "My Profile";
            tabMyProfile.Click += tabMyProfile_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(729, 535);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(92, 50);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(520, 535);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(130, 50);
            btnEdit.TabIndex = 35;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAddress.Location = new System.Drawing.Point(652, 313);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new System.Drawing.Size(350, 84);
            txtAddress.TabIndex = 34;
            // 
            // txtYob
            // 
            txtYob.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtYob.Location = new System.Drawing.Point(652, 225);
            txtYob.Name = "txtYob";
            txtYob.ReadOnly = true;
            txtYob.Size = new System.Drawing.Size(199, 38);
            txtYob.TabIndex = 33;
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Location = new System.Drawing.Point(652, 147);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new System.Drawing.Size(199, 38);
            txtPhone.TabIndex = 32;
            // 
            // txtGender
            // 
            txtGender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtGender.Location = new System.Drawing.Point(188, 453);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new System.Drawing.Size(199, 38);
            txtGender.TabIndex = 31;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(188, 372);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(199, 38);
            txtName.TabIndex = 30;
            // 
            // txtRole
            // 
            txtRole.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRole.Location = new System.Drawing.Point(188, 306);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new System.Drawing.Size(199, 38);
            txtRole.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(188, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new System.Drawing.Size(199, 38);
            txtEmail.TabIndex = 28;
            // 
            // txtUserName
            // 
            txtUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserName.Location = new System.Drawing.Point(188, 147);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new System.Drawing.Size(199, 38);
            txtUserName.TabIndex = 27;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label31.Location = new System.Drawing.Point(481, 313);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(97, 31);
            label31.TabIndex = 26;
            label31.Text = "Address";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label30.Location = new System.Drawing.Point(481, 232);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(137, 31);
            label30.TabIndex = 25;
            label30.Text = "Year of Birth";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label29.Location = new System.Drawing.Point(481, 154);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(78, 31);
            label29.TabIndex = 24;
            label29.Text = "Phone";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label27.Location = new System.Drawing.Point(39, 460);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(89, 31);
            label27.TabIndex = 23;
            label27.Text = "Gender";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.Location = new System.Drawing.Point(39, 379);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(75, 31);
            label23.TabIndex = 22;
            label23.Text = "Name";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label22.Location = new System.Drawing.Point(39, 313);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(58, 31);
            label22.TabIndex = 21;
            label22.Text = "Role";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.Location = new System.Drawing.Point(39, 235);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(70, 31);
            label21.TabIndex = 20;
            label21.Text = "Email";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.Location = new System.Drawing.Point(39, 154);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(127, 31);
            label20.TabIndex = 19;
            label20.Text = "User Name";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbUserName.Location = new System.Drawing.Point(485, 65);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new System.Drawing.Size(259, 41);
            lbUserName.TabIndex = 18;
            lbUserName.Text = "User Information";
            // 
            // tabMyOrder
            // 
            tabMyOrder.Controls.Add(splitContainer3);
            tabMyOrder.Location = new System.Drawing.Point(4, 29);
            tabMyOrder.Name = "tabMyOrder";
            tabMyOrder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tabMyOrder.Size = new System.Drawing.Size(1409, 723);
            tabMyOrder.TabIndex = 2;
            tabMyOrder.Text = "My Order";
            tabMyOrder.UseVisualStyleBackColor = true;
            tabMyOrder.Click += tabMyOrder_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer5);
            splitContainer3.Size = new System.Drawing.Size(1403, 717);
            splitContainer3.SplitterDistance = 277;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer4.Location = new System.Drawing.Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            splitContainer4.Panel1.Controls.Add(btnSort);
            splitContainer4.Panel1.Controls.Add(gbFilter);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.BackColor = System.Drawing.Color.White;
            splitContainer4.Panel2.Controls.Add(cbOrderStatus);
            splitContainer4.Panel2.Controls.Add(btnCleanAllFilterOrder);
            splitContainer4.Panel2.Controls.Add(btnSearchOrder);
            splitContainer4.Panel2.Controls.Add(txtOrderSearch);
            splitContainer4.Panel2.Controls.Add(dgvOrders);
            splitContainer4.Size = new System.Drawing.Size(1403, 277);
            splitContainer4.SplitterDistance = 465;
            splitContainer4.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.Location = new System.Drawing.Point(98, 34);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(278, 53);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort In Ascending Date Order";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnFilter);
            gbFilter.Controls.Add(dtpEndDate);
            gbFilter.Controls.Add(lbStartDate);
            gbFilter.Controls.Add(dtpStartDate);
            gbFilter.Controls.Add(lbEndDate);
            gbFilter.Location = new System.Drawing.Point(5, 100);
            gbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbFilter.Size = new System.Drawing.Size(459, 171);
            gbFilter.TabIndex = 110;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filt by Date";
            // 
            // btnFilter
            // 
            btnFilter.Enabled = false;
            btnFilter.Location = new System.Drawing.Point(156, 132);
            btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(135, 31);
            btnFilter.TabIndex = 44;
            btnFilter.Text = "Auto Filting";
            btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(126, 88);
            dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(262, 27);
            dtpEndDate.TabIndex = 1;
            dtpEndDate.ValueChanged += dtpRangeDate_ValueChanged;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new System.Drawing.Point(27, 46);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new System.Drawing.Size(76, 20);
            lbStartDate.TabIndex = 108;
            lbStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(126, 41);
            dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(262, 27);
            dtpStartDate.TabIndex = 0;
            dtpStartDate.ValueChanged += dtpRangeDate_ValueChanged;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new System.Drawing.Point(27, 93);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new System.Drawing.Size(70, 20);
            lbEndDate.TabIndex = 109;
            lbEndDate.Text = "End Date";
            // 
            // cbOrderStatus
            // 
            cbOrderStatus.FormattingEnabled = true;
            cbOrderStatus.Items.AddRange(new object[] { "All status", "PENDING", "CONFIRMED", "DELIVERYING", "SUCCESSFUL", "CANCALLED", "REFUSED", "FAIL" });
            cbOrderStatus.Location = new System.Drawing.Point(442, 12);
            cbOrderStatus.Name = "cbOrderStatus";
            cbOrderStatus.Size = new System.Drawing.Size(151, 28);
            cbOrderStatus.TabIndex = 2;
            cbOrderStatus.SelectedIndexChanged += cbOrderStatus_SelectedIndexChanged;
            // 
            // btnCleanAllFilterOrder
            // 
            btnCleanAllFilterOrder.Location = new System.Drawing.Point(806, 6);
            btnCleanAllFilterOrder.Name = "btnCleanAllFilterOrder";
            btnCleanAllFilterOrder.Size = new System.Drawing.Size(120, 35);
            btnCleanAllFilterOrder.TabIndex = 3;
            btnCleanAllFilterOrder.Text = "Clean all filters";
            btnCleanAllFilterOrder.UseVisualStyleBackColor = false;
            btnCleanAllFilterOrder.Click += btnCleanAllFilterOrder_Click;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Location = new System.Drawing.Point(6, 12);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new System.Drawing.Size(77, 29);
            btnSearchOrder.TabIndex = 0;
            btnSearchOrder.Text = "Search";
            btnSearchOrder.UseVisualStyleBackColor = false;
            // 
            // txtOrderSearch
            // 
            txtOrderSearch.Location = new System.Drawing.Point(89, 13);
            txtOrderSearch.Name = "txtOrderSearch";
            txtOrderSearch.Size = new System.Drawing.Size(330, 27);
            txtOrderSearch.TabIndex = 1;
            txtOrderSearch.TextChanged += txtOrderSearch_TextChanged;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvOrders.Location = new System.Drawing.Point(0, 45);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new System.Drawing.Size(932, 230);
            dgvOrders.TabIndex = 1;
            dgvOrders.DataSourceChanged += dgvOrders_DataSourceChanged;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // splitContainer5
            // 
            splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer5.Location = new System.Drawing.Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.BackColor = System.Drawing.Color.Azure;
            splitContainer5.Panel1.Controls.Add(gbOrderProduct);
            splitContainer5.Panel1.Controls.Add(label12);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer6);
            splitContainer5.Size = new System.Drawing.Size(1403, 436);
            splitContainer5.SplitterDistance = 465;
            splitContainer5.TabIndex = 0;
            // 
            // gbOrderProduct
            // 
            gbOrderProduct.Controls.Add(pbOrderProductAvatar);
            gbOrderProduct.Controls.Add(txtOrderDetailTotal);
            gbOrderProduct.Controls.Add(label11);
            gbOrderProduct.Controls.Add(label14);
            gbOrderProduct.Controls.Add(label10);
            gbOrderProduct.Controls.Add(lbOrderProductName);
            gbOrderProduct.Controls.Add(txtOrderPrice);
            gbOrderProduct.Controls.Add(txtOrderQuantity);
            gbOrderProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbOrderProduct.Location = new System.Drawing.Point(0, 60);
            gbOrderProduct.Name = "gbOrderProduct";
            gbOrderProduct.Size = new System.Drawing.Size(463, 374);
            gbOrderProduct.TabIndex = 99;
            gbOrderProduct.TabStop = false;
            gbOrderProduct.Text = "Product";
            // 
            // pbOrderProductAvatar
            // 
            pbOrderProductAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbOrderProductAvatar.Location = new System.Drawing.Point(16, 113);
            pbOrderProductAvatar.Name = "pbOrderProductAvatar";
            pbOrderProductAvatar.Size = new System.Drawing.Size(163, 192);
            pbOrderProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbOrderProductAvatar.TabIndex = 86;
            pbOrderProductAvatar.TabStop = false;
            // 
            // txtOrderDetailTotal
            // 
            txtOrderDetailTotal.Location = new System.Drawing.Point(297, 257);
            txtOrderDetailTotal.Name = "txtOrderDetailTotal";
            txtOrderDetailTotal.ReadOnly = true;
            txtOrderDetailTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderDetailTotal.Size = new System.Drawing.Size(99, 27);
            txtOrderDetailTotal.TabIndex = 2;
            txtOrderDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(203, 131);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 28);
            label11.TabIndex = 93;
            label11.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(207, 253);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(54, 28);
            label14.TabIndex = 97;
            label14.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(203, 194);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(88, 28);
            label10.TabIndex = 94;
            label10.Text = "Quantity";
            // 
            // lbOrderProductName
            // 
            lbOrderProductName.AutoSize = true;
            lbOrderProductName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbOrderProductName.Location = new System.Drawing.Point(16, 40);
            lbOrderProductName.Name = "lbOrderProductName";
            lbOrderProductName.Size = new System.Drawing.Size(199, 41);
            lbOrderProductName.TabIndex = 96;
            lbOrderProductName.Text = "Product Name";
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new System.Drawing.Point(297, 132);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.ReadOnly = true;
            txtOrderPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderPrice.Size = new System.Drawing.Size(99, 27);
            txtOrderPrice.TabIndex = 0;
            txtOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new System.Drawing.Point(297, 198);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.ReadOnly = true;
            txtOrderQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtOrderQuantity.Size = new System.Drawing.Size(99, 27);
            txtOrderQuantity.TabIndex = 1;
            txtOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(60, 14);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(349, 41);
            label12.TabIndex = 92;
            label12.Text = "Order Detail Information";
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer6.Location = new System.Drawing.Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(gbOrderTarget);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(dgvOrderDetails);
            splitContainer6.Size = new System.Drawing.Size(932, 434);
            splitContainer6.SplitterDistance = 254;
            splitContainer6.TabIndex = 0;
            // 
            // gbOrderTarget
            // 
            gbOrderTarget.BackColor = System.Drawing.Color.Azure;
            gbOrderTarget.Controls.Add(btnCancelOrder);
            gbOrderTarget.Controls.Add(label16);
            gbOrderTarget.Controls.Add(txtOrderMessage);
            gbOrderTarget.Controls.Add(label13);
            gbOrderTarget.Controls.Add(txtOrderShippingFee);
            gbOrderTarget.Controls.Add(txtOrderReceiver);
            gbOrderTarget.Controls.Add(lbOrderShippingFee);
            gbOrderTarget.Controls.Add(txtOrderTotal);
            gbOrderTarget.Controls.Add(txtOrderAddress);
            gbOrderTarget.Controls.Add(lbOrderDate);
            gbOrderTarget.Controls.Add(label9);
            gbOrderTarget.Controls.Add(lbTotal);
            gbOrderTarget.Controls.Add(txtOrderPhone);
            gbOrderTarget.Controls.Add(dtpOrderTime);
            gbOrderTarget.Controls.Add(label8);
            gbOrderTarget.Controls.Add(lbReceiver);
            gbOrderTarget.Controls.Add(txtOrderStatus);
            gbOrderTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            gbOrderTarget.Location = new System.Drawing.Point(0, 0);
            gbOrderTarget.Name = "gbOrderTarget";
            gbOrderTarget.Size = new System.Drawing.Size(932, 254);
            gbOrderTarget.TabIndex = 107;
            gbOrderTarget.TabStop = false;
            gbOrderTarget.Text = "Order >> ID";
            gbOrderTarget.Enter += gbOrderTarget_Enter;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = System.Drawing.Color.Khaki;
            btnCancelOrder.Location = new System.Drawing.Point(788, 213);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new System.Drawing.Size(136, 29);
            btnCancelOrder.TabIndex = 8;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(506, 213);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(49, 20);
            label16.TabIndex = 7;
            label16.Text = "Status";
            // 
            // txtOrderMessage
            // 
            txtOrderMessage.Location = new System.Drawing.Point(167, 156);
            txtOrderMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderMessage.Name = "txtOrderMessage";
            txtOrderMessage.ReadOnly = true;
            txtOrderMessage.Size = new System.Drawing.Size(276, 27);
            txtOrderMessage.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(38, 159);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(67, 20);
            label13.TabIndex = 158;
            label13.Text = "Message";
            // 
            // txtOrderShippingFee
            // 
            txtOrderShippingFee.Location = new System.Drawing.Point(686, 156);
            txtOrderShippingFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderShippingFee.Name = "txtOrderShippingFee";
            txtOrderShippingFee.ReadOnly = true;
            txtOrderShippingFee.Size = new System.Drawing.Size(215, 27);
            txtOrderShippingFee.TabIndex = 5;
            txtOrderShippingFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiver
            // 
            txtOrderReceiver.Location = new System.Drawing.Point(167, 51);
            txtOrderReceiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderReceiver.Name = "txtOrderReceiver";
            txtOrderReceiver.ReadOnly = true;
            txtOrderReceiver.Size = new System.Drawing.Size(273, 27);
            txtOrderReceiver.TabIndex = 0;
            // 
            // lbOrderShippingFee
            // 
            lbOrderShippingFee.AutoSize = true;
            lbOrderShippingFee.Location = new System.Drawing.Point(561, 159);
            lbOrderShippingFee.Name = "lbOrderShippingFee";
            lbOrderShippingFee.Size = new System.Drawing.Size(95, 20);
            lbOrderShippingFee.TabIndex = 156;
            lbOrderShippingFee.Text = "Shipping Fee";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(301, 210);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(176, 27);
            txtOrderTotal.TabIndex = 6;
            txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderAddress
            // 
            txtOrderAddress.Location = new System.Drawing.Point(167, 104);
            txtOrderAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderAddress.Name = "txtOrderAddress";
            txtOrderAddress.ReadOnly = true;
            txtOrderAddress.Size = new System.Drawing.Size(276, 27);
            txtOrderAddress.TabIndex = 2;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(561, 49);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(84, 20);
            lbOrderDate.TabIndex = 148;
            lbOrderDate.Text = "Order Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(38, 107);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 20);
            label9.TabIndex = 154;
            label9.Text = "Address";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new System.Drawing.Point(228, 213);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(42, 20);
            lbTotal.TabIndex = 143;
            lbTotal.Text = "Total";
            // 
            // txtOrderPhone
            // 
            txtOrderPhone.Location = new System.Drawing.Point(685, 104);
            txtOrderPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderPhone.Name = "txtOrderPhone";
            txtOrderPhone.ReadOnly = true;
            txtOrderPhone.Size = new System.Drawing.Size(216, 27);
            txtOrderPhone.TabIndex = 3;
            txtOrderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpOrderTime
            // 
            dtpOrderTime.CustomFormat = "MMM dd, yyyy hh:ss";
            dtpOrderTime.Enabled = false;
            dtpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpOrderTime.Location = new System.Drawing.Point(686, 44);
            dtpOrderTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dtpOrderTime.Name = "dtpOrderTime";
            dtpOrderTime.Size = new System.Drawing.Size(215, 27);
            dtpOrderTime.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(561, 107);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 20);
            label8.TabIndex = 152;
            label8.Text = "Phone";
            // 
            // lbReceiver
            // 
            lbReceiver.AutoSize = true;
            lbReceiver.Location = new System.Drawing.Point(35, 51);
            lbReceiver.Name = "lbReceiver";
            lbReceiver.Size = new System.Drawing.Size(65, 20);
            lbReceiver.TabIndex = 142;
            lbReceiver.Text = "Receiver";
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(561, 210);
            txtOrderStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.ReadOnly = true;
            txtOrderStatus.Size = new System.Drawing.Size(121, 27);
            txtOrderStatus.TabIndex = 151;
            txtOrderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new System.Drawing.Size(932, 176);
            dgvOrderDetails.TabIndex = 0;
            dgvOrderDetails.DataSourceChanged += dgvOrderDetails_DataSourceChanged;
            dgvOrderDetails.SelectionChanged += dgvOrderDetails_SelectionChanged;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(splitContainer1);
            tabHome.Location = new System.Drawing.Point(4, 29);
            tabHome.Name = "tabHome";
            tabHome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tabHome.Size = new System.Drawing.Size(1409, 723);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Click += tabHome_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(1403, 717);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.TabIndex = 87;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBoxSearch.Controls.Add(cbProductSort);
            groupBoxSearch.Controls.Add(label15);
            groupBoxSearch.Controls.Add(cbProductCategory);
            groupBoxSearch.Controls.Add(label4);
            groupBoxSearch.Controls.Add(txtProductNameSearch);
            groupBoxSearch.Controls.Add(label5);
            groupBoxSearch.Controls.Add(btnReset);
            groupBoxSearch.Controls.Add(groupBox2);
            groupBoxSearch.Controls.Add(groupBox1);
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBoxSearch.Size = new System.Drawing.Size(337, 717);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // cbProductSort
            // 
            cbProductSort.BackColor = System.Drawing.Color.White;
            cbProductSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProductSort.FormattingEnabled = true;
            cbProductSort.Items.AddRange(new object[] { "Sort by", "Price asc", "Price desc" });
            cbProductSort.Location = new System.Drawing.Point(9, 262);
            cbProductSort.Name = "cbProductSort";
            cbProductSort.Size = new System.Drawing.Size(290, 28);
            cbProductSort.TabIndex = 51;
            cbProductSort.SelectedIndexChanged += cbProductSort_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 239);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(57, 20);
            label15.TabIndex = 52;
            label15.Text = "Sorting";
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = System.Drawing.Color.White;
            cbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "Select the category" });
            cbProductCategory.Location = new System.Drawing.Point(9, 190);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new System.Drawing.Size(290, 28);
            cbProductCategory.TabIndex = 3;
            cbProductCategory.SelectedIndexChanged += cbProductCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 167);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 50;
            label4.Text = "Category";
            // 
            // txtProductNameSearch
            // 
            txtProductNameSearch.BackColor = System.Drawing.Color.White;
            txtProductNameSearch.Location = new System.Drawing.Point(9, 121);
            txtProductNameSearch.Name = "txtProductNameSearch";
            txtProductNameSearch.Size = new System.Drawing.Size(290, 27);
            txtProductNameSearch.TabIndex = 0;
            txtProductNameSearch.TextChanged += txtProductNameSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 98);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 20);
            label5.TabIndex = 48;
            label5.Text = "Product Name";
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(185, 39);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(114, 31);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUnitsInStockMaxSearch);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtUnitsInStockMinSearch);
            groupBox2.Location = new System.Drawing.Point(9, 469);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(311, 125);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Units In Stock";
            // 
            // txtUnitsInStockMaxSearch
            // 
            txtUnitsInStockMaxSearch.Location = new System.Drawing.Point(152, 84);
            txtUnitsInStockMaxSearch.Name = "txtUnitsInStockMaxSearch";
            txtUnitsInStockMaxSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitsInStockMaxSearch.TabIndex = 1;
            txtUnitsInStockMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitsInStockMaxSearch.TextChanged += txtUnitsInStockMaxSearch_TextChanged;
            txtUnitsInStockMaxSearch.KeyPress += txtUnitPriceMinSearch_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 20);
            label3.TabIndex = 2;
            label3.Text = "Units In Stock Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(16, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 20);
            label7.TabIndex = 0;
            label7.Text = "Units In Stock Min";
            // 
            // txtUnitsInStockMinSearch
            // 
            txtUnitsInStockMinSearch.Location = new System.Drawing.Point(152, 45);
            txtUnitsInStockMinSearch.Name = "txtUnitsInStockMinSearch";
            txtUnitsInStockMinSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitsInStockMinSearch.TabIndex = 0;
            txtUnitsInStockMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitsInStockMinSearch.TextChanged += txtUnitsInStockMinSearch_TextChanged;
            txtUnitsInStockMinSearch.KeyPress += txtUnitPriceMinSearch_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUnitPriceMaxSearch);
            groupBox1.Controls.Add(txtUnitPriceMinSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(9, 316);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(311, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 45);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(101, 20);
            label6.TabIndex = 0;
            label6.Text = "Unit Price Min";
            // 
            // txtUnitPriceMaxSearch
            // 
            txtUnitPriceMaxSearch.Location = new System.Drawing.Point(152, 87);
            txtUnitPriceMaxSearch.Name = "txtUnitPriceMaxSearch";
            txtUnitPriceMaxSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitPriceMaxSearch.TabIndex = 1;
            txtUnitPriceMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitPriceMaxSearch.TextChanged += txtUnitPriceMaxSearch_TextChanged;
            txtUnitPriceMaxSearch.KeyPress += txtUnitPriceMinSearch_KeyPress;
            // 
            // txtUnitPriceMinSearch
            // 
            txtUnitPriceMinSearch.Location = new System.Drawing.Point(152, 45);
            txtUnitPriceMinSearch.Name = "txtUnitPriceMinSearch";
            txtUnitPriceMinSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitPriceMinSearch.TabIndex = 0;
            txtUnitPriceMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitPriceMinSearch.TextChanged += txtUnitPriceMinSearch_TextChanged;
            txtUnitPriceMinSearch.KeyPress += txtUnitPriceMinSearch_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Unit Price Max";
            // 
            // btnSearch
            // 
            btnSearch.Enabled = false;
            btnSearch.Location = new System.Drawing.Point(25, 39);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(142, 31);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Auto Filting";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(gbProduct);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvProducts);
            splitContainer2.Panel2.Controls.Add(btnClose);
            splitContainer2.Size = new System.Drawing.Size(1062, 717);
            splitContainer2.SplitterDistance = 374;
            splitContainer2.TabIndex = 87;
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(btnAddToCart);
            gbProduct.Controls.Add(gbSelect);
            gbProduct.Controls.Add(txtAvailable);
            gbProduct.Controls.Add(txtPrice);
            gbProduct.Controls.Add(groupBox3);
            gbProduct.Controls.Add(label1);
            gbProduct.Controls.Add(lbAvailable);
            gbProduct.Controls.Add(lbPrice);
            gbProduct.Controls.Add(lbProductName);
            gbProduct.Controls.Add(pbProductAvatar);
            gbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            gbProduct.Location = new System.Drawing.Point(0, 0);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new System.Drawing.Size(1062, 374);
            gbProduct.TabIndex = 86;
            gbProduct.TabStop = false;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = System.Drawing.Color.LemonChiffon;
            btnAddToCart.Location = new System.Drawing.Point(858, 160);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(144, 38);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // gbSelect
            // 
            gbSelect.Controls.Add(txtCurrentIndex);
            gbSelect.Controls.Add(btnBack);
            gbSelect.Controls.Add(btnNext);
            gbSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbSelect.Location = new System.Drawing.Point(3, 318);
            gbSelect.Name = "gbSelect";
            gbSelect.Size = new System.Drawing.Size(1056, 53);
            gbSelect.TabIndex = 92;
            gbSelect.TabStop = false;
            // 
            // txtCurrentIndex
            // 
            txtCurrentIndex.Location = new System.Drawing.Point(473, 18);
            txtCurrentIndex.Name = "txtCurrentIndex";
            txtCurrentIndex.ReadOnly = true;
            txtCurrentIndex.Size = new System.Drawing.Size(126, 27);
            txtCurrentIndex.TabIndex = 1;
            txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(323, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(144, 31);
            btnBack.TabIndex = 0;
            btnBack.Text = "<< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(605, 16);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(144, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next >>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new System.Drawing.Point(637, 122);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtAvailable.Size = new System.Drawing.Size(110, 27);
            txtAvailable.TabIndex = 2;
            txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(363, 122);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPrice.Size = new System.Drawing.Size(110, 27);
            txtPrice.TabIndex = 1;
            txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDesc);
            groupBox3.Location = new System.Drawing.Point(290, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(733, 115);
            groupBox3.TabIndex = 89;
            groupBox3.TabStop = false;
            groupBox3.Text = "Description";
            // 
            // txtDesc
            // 
            txtDesc.Location = new System.Drawing.Point(9, 26);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new System.Drawing.Size(715, 83);
            txtDesc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(299, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 28);
            label1.TabIndex = 88;
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAvailable.Location = new System.Drawing.Point(535, 121);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new System.Drawing.Size(96, 28);
            lbAvailable.TabIndex = 87;
            lbAvailable.Text = "Available:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(299, 121);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(58, 28);
            lbPrice.TabIndex = 86;
            lbPrice.Text = "Price:";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductName.Location = new System.Drawing.Point(290, 49);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(236, 45);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            lbProductName.TextChanged += lbProductName_TextChanged;
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new System.Drawing.Point(17, 39);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new System.Drawing.Size(240, 271);
            pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 85;
            pbProductAvatar.TabStop = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            dgvProducts.Location = new System.Drawing.Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new System.Drawing.Size(1062, 297);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(962, 276);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(85, 29);
            btnClose.TabIndex = 83;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tabcontrolCustomer
            // 
            tabcontrolCustomer.Controls.Add(tabHome);
            tabcontrolCustomer.Controls.Add(tabCart);
            tabcontrolCustomer.Controls.Add(tabMyOrder);
            tabcontrolCustomer.Controls.Add(tabMyProfile);
            tabcontrolCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            tabcontrolCustomer.Location = new System.Drawing.Point(0, 0);
            tabcontrolCustomer.Name = "tabcontrolCustomer";
            tabcontrolCustomer.SelectedIndex = 0;
            tabcontrolCustomer.Size = new System.Drawing.Size(1417, 756);
            tabcontrolCustomer.TabIndex = 0;
            tabcontrolCustomer.TabStop = false;
            tabcontrolCustomer.SelectedIndexChanged += tabcontrolCustomer_SelectedIndexChanged;
            tabcontrolCustomer.Click += tabcontrolCustomer_Click;
            // 
            // tabCart
            // 
            tabCart.Controls.Add(splitContainer7);
            tabCart.Location = new System.Drawing.Point(4, 29);
            tabCart.Name = "tabCart";
            tabCart.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tabCart.Size = new System.Drawing.Size(1409, 723);
            tabCart.TabIndex = 1;
            tabCart.Text = "My Cart";
            tabCart.UseVisualStyleBackColor = true;
            tabCart.Click += tabCart_Click;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer7.Location = new System.Drawing.Point(3, 3);
            splitContainer7.Margin = new System.Windows.Forms.Padding(2);
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(groupBox4);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(splitContainer8);
            splitContainer7.Size = new System.Drawing.Size(1403, 717);
            splitContainer7.SplitterDistance = 328;
            splitContainer7.SplitterWidth = 3;
            splitContainer7.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBox4.Controls.Add(txtCartTotal);
            groupBox4.Controls.Add(lbCartTotal);
            groupBox4.Controls.Add(cbCartSorting);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(cbCartFilterCategory);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(txtCartFilterName);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(btnCartReset);
            groupBox4.Controls.Add(button2);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox4.Location = new System.Drawing.Point(0, 0);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(328, 717);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search";
            // 
            // txtCartTotal
            // 
            txtCartTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCartTotal.Location = new System.Drawing.Point(93, 331);
            txtCartTotal.Margin = new System.Windows.Forms.Padding(2);
            txtCartTotal.Name = "txtCartTotal";
            txtCartTotal.ReadOnly = true;
            txtCartTotal.Size = new System.Drawing.Size(206, 39);
            txtCartTotal.TabIndex = 54;
            txtCartTotal.TextChanged += txtCartTotal_TextChanged;
            // 
            // lbCartTotal
            // 
            lbCartTotal.AutoSize = true;
            lbCartTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbCartTotal.Location = new System.Drawing.Point(7, 332);
            lbCartTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbCartTotal.Name = "lbCartTotal";
            lbCartTotal.Size = new System.Drawing.Size(99, 32);
            lbCartTotal.TabIndex = 53;
            lbCartTotal.Text = "TOTAL: ";
            // 
            // cbCartSorting
            // 
            cbCartSorting.BackColor = System.Drawing.Color.White;
            cbCartSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCartSorting.FormattingEnabled = true;
            cbCartSorting.Items.AddRange(new object[] { "Sort by", "Price asc", "Price desc" });
            cbCartSorting.Location = new System.Drawing.Point(9, 262);
            cbCartSorting.Name = "cbCartSorting";
            cbCartSorting.Size = new System.Drawing.Size(290, 28);
            cbCartSorting.TabIndex = 51;
            cbCartSorting.SelectedIndexChanged += cbCartSorting_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(7, 241);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(57, 20);
            label17.TabIndex = 52;
            label17.Text = "Sorting";
            // 
            // cbCartFilterCategory
            // 
            cbCartFilterCategory.BackColor = System.Drawing.Color.White;
            cbCartFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCartFilterCategory.FormattingEnabled = true;
            cbCartFilterCategory.Items.AddRange(new object[] { "Select the category" });
            cbCartFilterCategory.Location = new System.Drawing.Point(9, 190);
            cbCartFilterCategory.Name = "cbCartFilterCategory";
            cbCartFilterCategory.Size = new System.Drawing.Size(290, 28);
            cbCartFilterCategory.TabIndex = 3;
            cbCartFilterCategory.SelectedIndexChanged += cbCartFilterCategory_SelectedIndexChanged;
            cbCartFilterCategory.SelectedValueChanged += cbCartFilterCategory_SelectedValueChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(7, 169);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(69, 20);
            label18.TabIndex = 50;
            label18.Text = "Category";
            // 
            // txtCartFilterName
            // 
            txtCartFilterName.BackColor = System.Drawing.Color.White;
            txtCartFilterName.Location = new System.Drawing.Point(9, 121);
            txtCartFilterName.Name = "txtCartFilterName";
            txtCartFilterName.Size = new System.Drawing.Size(290, 27);
            txtCartFilterName.TabIndex = 0;
            txtCartFilterName.TextChanged += txtFilterName_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(7, 99);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(104, 20);
            label19.TabIndex = 48;
            label19.Text = "Product Name";
            // 
            // btnCartReset
            // 
            btnCartReset.Location = new System.Drawing.Point(185, 39);
            btnCartReset.Name = "btnCartReset";
            btnCartReset.Size = new System.Drawing.Size(114, 31);
            btnCartReset.TabIndex = 7;
            btnCartReset.Text = "Reset";
            btnCartReset.UseVisualStyleBackColor = true;
            btnCartReset.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(25, 39);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(142, 31);
            button2.TabIndex = 0;
            button2.Text = "Auto Filting";
            button2.UseVisualStyleBackColor = true;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer8.Location = new System.Drawing.Point(0, 0);
            splitContainer8.Name = "splitContainer8";
            splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(groupBox7);
            // 
            // splitContainer8.Panel2
            // 
            splitContainer8.Panel2.Controls.Add(dgvCarts);
            splitContainer8.Panel2.Controls.Add(button6);
            splitContainer8.Size = new System.Drawing.Size(1072, 717);
            splitContainer8.SplitterDistance = 374;
            splitContainer8.TabIndex = 88;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnCartDelete);
            groupBox7.Controls.Add(btnDecrease);
            groupBox7.Controls.Add(btnIncrease);
            groupBox7.Controls.Add(txtCartQuantity);
            groupBox7.Controls.Add(label28);
            groupBox7.Controls.Add(btnCheckout);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Controls.Add(txtCartAvailable);
            groupBox7.Controls.Add(txtCartPrice);
            groupBox7.Controls.Add(groupBox9);
            groupBox7.Controls.Add(label24);
            groupBox7.Controls.Add(label25);
            groupBox7.Controls.Add(label26);
            groupBox7.Controls.Add(lbCartName);
            groupBox7.Controls.Add(pbCartAvatar);
            groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox7.Location = new System.Drawing.Point(0, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(1072, 374);
            groupBox7.TabIndex = 86;
            groupBox7.TabStop = false;
            groupBox7.Text = "Product Name";
            // 
            // btnCartDelete
            // 
            btnCartDelete.BackColor = System.Drawing.Color.LemonChiffon;
            btnCartDelete.Location = new System.Drawing.Point(828, 159);
            btnCartDelete.Name = "btnCartDelete";
            btnCartDelete.Size = new System.Drawing.Size(144, 38);
            btnCartDelete.TabIndex = 97;
            btnCartDelete.Text = "Delete";
            btnCartDelete.UseVisualStyleBackColor = false;
            btnCartDelete.Click += btnCartDelete_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new System.Drawing.Point(938, 124);
            btnDecrease.Margin = new System.Windows.Forms.Padding(2);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new System.Drawing.Size(34, 24);
            btnDecrease.TabIndex = 96;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new System.Drawing.Point(938, 98);
            btnIncrease.Margin = new System.Windows.Forms.Padding(2);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new System.Drawing.Size(34, 21);
            btnIncrease.TabIndex = 95;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // txtCartQuantity
            // 
            txtCartQuantity.Location = new System.Drawing.Point(881, 110);
            txtCartQuantity.Name = "txtCartQuantity";
            txtCartQuantity.ReadOnly = true;
            txtCartQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCartQuantity.Size = new System.Drawing.Size(53, 27);
            txtCartQuantity.TabIndex = 94;
            txtCartQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label28.Location = new System.Drawing.Point(786, 110);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(92, 28);
            label28.TabIndex = 93;
            label28.Text = "Quantity:";
            label28.Click += label28_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = System.Drawing.Color.LemonChiffon;
            btnCheckout.Location = new System.Drawing.Point(878, 32);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(144, 38);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lblCartIndex);
            groupBox8.Controls.Add(btnCartBack);
            groupBox8.Controls.Add(btnCartNext);
            groupBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox8.Location = new System.Drawing.Point(3, 318);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new System.Drawing.Size(1066, 53);
            groupBox8.TabIndex = 92;
            groupBox8.TabStop = false;
            // 
            // lblCartIndex
            // 
            lblCartIndex.Location = new System.Drawing.Point(473, 18);
            lblCartIndex.Name = "lblCartIndex";
            lblCartIndex.ReadOnly = true;
            lblCartIndex.Size = new System.Drawing.Size(126, 27);
            lblCartIndex.TabIndex = 1;
            lblCartIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCartBack
            // 
            btnCartBack.Location = new System.Drawing.Point(323, 16);
            btnCartBack.Name = "btnCartBack";
            btnCartBack.Size = new System.Drawing.Size(144, 31);
            btnCartBack.TabIndex = 0;
            btnCartBack.Text = "<< Back";
            btnCartBack.UseVisualStyleBackColor = true;
            btnCartBack.Click += btnCartBack_Click;
            // 
            // btnCartNext
            // 
            btnCartNext.Location = new System.Drawing.Point(605, 16);
            btnCartNext.Name = "btnCartNext";
            btnCartNext.Size = new System.Drawing.Size(144, 31);
            btnCartNext.TabIndex = 2;
            btnCartNext.Text = "Next >>";
            btnCartNext.UseVisualStyleBackColor = true;
            btnCartNext.Click += btnCartNext_Click;
            // 
            // txtCartAvailable
            // 
            txtCartAvailable.Location = new System.Drawing.Point(630, 112);
            txtCartAvailable.Name = "txtCartAvailable";
            txtCartAvailable.ReadOnly = true;
            txtCartAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCartAvailable.Size = new System.Drawing.Size(110, 27);
            txtCartAvailable.TabIndex = 2;
            txtCartAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCartPrice
            // 
            txtCartPrice.Location = new System.Drawing.Point(362, 112);
            txtCartPrice.Name = "txtCartPrice";
            txtCartPrice.ReadOnly = true;
            txtCartPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCartPrice.Size = new System.Drawing.Size(110, 27);
            txtCartPrice.TabIndex = 1;
            txtCartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtCartDescription);
            groupBox9.Location = new System.Drawing.Point(290, 195);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(733, 115);
            groupBox9.TabIndex = 89;
            groupBox9.TabStop = false;
            groupBox9.Text = "Description";
            // 
            // txtCartDescription
            // 
            txtCartDescription.Location = new System.Drawing.Point(9, 26);
            txtCartDescription.Multiline = true;
            txtCartDescription.Name = "txtCartDescription";
            txtCartDescription.ReadOnly = true;
            txtCartDescription.Size = new System.Drawing.Size(715, 83);
            txtCartDescription.TabIndex = 0;
            txtCartDescription.TextChanged += textBox9_TextChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label24.Location = new System.Drawing.Point(300, 196);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(0, 28);
            label24.TabIndex = 88;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label25.Location = new System.Drawing.Point(531, 110);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(96, 28);
            label25.TabIndex = 87;
            label25.Text = "Available:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label26.Location = new System.Drawing.Point(298, 110);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(58, 28);
            label26.TabIndex = 86;
            label26.Text = "Price:";
            // 
            // lbCartName
            // 
            lbCartName.AutoSize = true;
            lbCartName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbCartName.Location = new System.Drawing.Point(290, 50);
            lbCartName.Name = "lbCartName";
            lbCartName.Size = new System.Drawing.Size(236, 45);
            lbCartName.TabIndex = 0;
            lbCartName.Text = "Product Name";
            // 
            // pbCartAvatar
            // 
            pbCartAvatar.Location = new System.Drawing.Point(17, 39);
            pbCartAvatar.Name = "pbCartAvatar";
            pbCartAvatar.Size = new System.Drawing.Size(240, 271);
            pbCartAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbCartAvatar.TabIndex = 85;
            pbCartAvatar.TabStop = false;
            // 
            // dgvCarts
            // 
            dgvCarts.AllowUserToAddRows = false;
            dgvCarts.AllowUserToDeleteRows = false;
            dgvCarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Check });
            dgvCarts.Dock = System.Windows.Forms.DockStyle.Top;
            dgvCarts.Location = new System.Drawing.Point(0, 0);
            dgvCarts.Name = "dgvCarts";
            dgvCarts.ReadOnly = true;
            dgvCarts.RowHeadersWidth = 51;
            dgvCarts.RowTemplate.Height = 29;
            dgvCarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarts.Size = new System.Drawing.Size(1072, 297);
            dgvCarts.TabIndex = 0;
            dgvCarts.CellClick += dgvCarts_CellClick;
            dgvCarts.CellContentClick += dgvCarts_CellContentClick;
            // 
            // Check
            // 
            Check.FalseValue = "false";
            Check.HeaderText = "Choose";
            Check.MinimumWidth = 8;
            Check.Name = "Check";
            Check.ReadOnly = true;
            Check.TrueValue = "true";
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button6.Location = new System.Drawing.Point(1914, 578);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(85, 29);
            button6.TabIndex = 83;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            // 
            // pbCustomerAvatar
            // 
            pbCustomerAvatar.Location = new System.Drawing.Point(1078, 119);
            pbCustomerAvatar.Name = "pbCustomerAvatar";
            pbCustomerAvatar.Size = new System.Drawing.Size(240, 278);
            pbCustomerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbCustomerAvatar.TabIndex = 86;
            pbCustomerAvatar.TabStop = false;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1417, 756);
            Controls.Add(tabcontrolCustomer);
            Name = "frmCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            FormClosing += frmCustomer_FormClosing;
            Load += frmCustomer_Load;
            tabMyProfile.ResumeLayout(false);
            tabMyProfile.PerformLayout();
            tabMyOrder.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            gbOrderProduct.ResumeLayout(false);
            gbOrderProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrderProductAvatar).EndInit();
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            gbOrderTarget.ResumeLayout(false);
            gbOrderTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            tabHome.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            gbSelect.ResumeLayout(false);
            gbSelect.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabcontrolCustomer.ResumeLayout(false);
            tabCart.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCartAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCustomerAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.TabPage tabMyOrder;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.Button btnCleanAllFilterOrder;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox gbOrderProduct;
        private System.Windows.Forms.PictureBox pbOrderProductAvatar;
        private System.Windows.Forms.TextBox txtOrderDetailTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbOrderProductName;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox gbOrderTarget;
        private System.Windows.Forms.Button btnCancelOrder;
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
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox cbProductSort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnitsInStockMaxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitsInStockMinSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPriceMaxSearch;
        private System.Windows.Forms.TextBox txtUnitPriceMinSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.PictureBox pbProductAvatar;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabcontrolCustomer;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbCartSorting;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCartFilterCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCartFilterName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCartReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox lblCartIndex;
        private System.Windows.Forms.Button btnCartBack;
        private System.Windows.Forms.Button btnCartNext;
        private System.Windows.Forms.TextBox txtCartAvailable;
        private System.Windows.Forms.TextBox txtCartPrice;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtCartDescription;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbCartName;
        private System.Windows.Forms.PictureBox pbCartAvatar;
        private System.Windows.Forms.DataGridView dgvCarts;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.TextBox txtCartQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.TextBox txtCartTotal;
        private System.Windows.Forms.Label lbCartTotal;
        private System.Windows.Forms.Button btnCartDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtYob;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbCustomerAvatar;
    }
}