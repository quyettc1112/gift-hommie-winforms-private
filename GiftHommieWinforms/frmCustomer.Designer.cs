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
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.tabMyOrder = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnSort = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnCleanAllFilterOrder = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.txtOrderSearch = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.gbOrderProduct = new System.Windows.Forms.GroupBox();
            this.pbOrderProductAvatar = new System.Windows.Forms.PictureBox();
            this.txtOrderDetailTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbOrderProductName = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.gbOrderTarget = new System.Windows.Forms.GroupBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOrderMessage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOrderShippingFee = new System.Windows.Forms.TextBox();
            this.txtOrderReceiver = new System.Windows.Forms.TextBox();
            this.lbOrderShippingFee = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtOrderPhone = new System.Windows.Forms.TextBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lbReceiver = new System.Windows.Forms.Label();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.cbProductSort = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbProductCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductNameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnitsInStockMaxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitsInStockMinSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPriceMaxSearch = new System.Windows.Forms.TextBox();
            this.txtUnitPriceMinSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.txtCurrentIndex = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.pbProductAvatar = new System.Windows.Forms.PictureBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabcontrolCustomer = new System.Windows.Forms.TabControl();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCartTotal = new System.Windows.Forms.TextBox();
            this.lbCartTotal = new System.Windows.Forms.Label();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCartFilterName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCartDelete = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.txtCartQuantity = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblCartIndex = new System.Windows.Forms.TextBox();
            this.btnCartBack = new System.Windows.Forms.Button();
            this.btnCartNext = new System.Windows.Forms.Button();
            this.txtCartAvailable = new System.Windows.Forms.TextBox();
            this.txtCartPrice = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtCartDescription = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbCartName = new System.Windows.Forms.Label();
            this.pbCartAvatar = new System.Windows.Forms.PictureBox();
            this.dgvCarts = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.tabMyOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.gbOrderProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderProductAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.gbOrderTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbProduct.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabcontrolCustomer.SuspendLayout();
            this.tabCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarts)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMyProfile.Size = new System.Drawing.Size(1409, 723);
            this.tabMyProfile.TabIndex = 3;
            this.tabMyProfile.Text = "My Profile";
            this.tabMyProfile.UseVisualStyleBackColor = true;
            // 
            // tabMyOrder
            // 
            this.tabMyOrder.Controls.Add(this.splitContainer3);
            this.tabMyOrder.Location = new System.Drawing.Point(4, 29);
            this.tabMyOrder.Name = "tabMyOrder";
            this.tabMyOrder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMyOrder.Size = new System.Drawing.Size(1409, 723);
            this.tabMyOrder.TabIndex = 2;
            this.tabMyOrder.Text = "My Order";
            this.tabMyOrder.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(1403, 717);
            this.splitContainer3.SplitterDistance = 278;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer4.Panel1.Controls.Add(this.btnSort);
            this.splitContainer4.Panel1.Controls.Add(this.gbFilter);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Panel2.Controls.Add(this.cbOrderStatus);
            this.splitContainer4.Panel2.Controls.Add(this.btnCleanAllFilterOrder);
            this.splitContainer4.Panel2.Controls.Add(this.btnSearchOrder);
            this.splitContainer4.Panel2.Controls.Add(this.txtOrderSearch);
            this.splitContainer4.Panel2.Controls.Add(this.dgvOrders);
            this.splitContainer4.Size = new System.Drawing.Size(1403, 278);
            this.splitContainer4.SplitterDistance = 466;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(98, 34);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(278, 53);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort In Ascending Date Order";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.dtpEndDate);
            this.gbFilter.Controls.Add(this.lbStartDate);
            this.gbFilter.Controls.Add(this.dtpStartDate);
            this.gbFilter.Controls.Add(this.lbEndDate);
            this.gbFilter.Location = new System.Drawing.Point(5, 100);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFilter.Size = new System.Drawing.Size(459, 171);
            this.gbFilter.TabIndex = 110;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filt by Date";
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(156, 132);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(135, 31);
            this.btnFilter.TabIndex = 44;
            this.btnFilter.Text = "Auto Filting";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(126, 88);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(262, 27);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(27, 46);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(76, 20);
            this.lbStartDate.TabIndex = 108;
            this.lbStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(126, 41);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(262, 27);
            this.dtpStartDate.TabIndex = 0;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(27, 93);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(70, 20);
            this.lbEndDate.TabIndex = 109;
            this.lbEndDate.Text = "End Date";
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Items.AddRange(new object[] {
            "All status",
            "PENDING",
            "CONFIRMED",
            "DELIVERYING",
            "SUCCESSFUL",
            "CANCALLED",
            "REFUSED",
            "FAIL"});
            this.cbOrderStatus.Location = new System.Drawing.Point(442, 12);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(151, 28);
            this.cbOrderStatus.TabIndex = 2;
            // 
            // btnCleanAllFilterOrder
            // 
            this.btnCleanAllFilterOrder.Location = new System.Drawing.Point(806, 6);
            this.btnCleanAllFilterOrder.Name = "btnCleanAllFilterOrder";
            this.btnCleanAllFilterOrder.Size = new System.Drawing.Size(120, 35);
            this.btnCleanAllFilterOrder.TabIndex = 3;
            this.btnCleanAllFilterOrder.Text = "Clean all filters";
            this.btnCleanAllFilterOrder.UseVisualStyleBackColor = false;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(6, 12);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(77, 29);
            this.btnSearchOrder.TabIndex = 0;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            // 
            // txtOrderSearch
            // 
            this.txtOrderSearch.Location = new System.Drawing.Point(89, 13);
            this.txtOrderSearch.Name = "txtOrderSearch";
            this.txtOrderSearch.Size = new System.Drawing.Size(330, 27);
            this.txtOrderSearch.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrders.Location = new System.Drawing.Point(0, 46);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(931, 230);
            this.dgvOrders.TabIndex = 1;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitContainer5.Panel1.Controls.Add(this.gbOrderProduct);
            this.splitContainer5.Panel1.Controls.Add(this.label12);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(1403, 435);
            this.splitContainer5.SplitterDistance = 466;
            this.splitContainer5.TabIndex = 0;
            // 
            // gbOrderProduct
            // 
            this.gbOrderProduct.Controls.Add(this.pbOrderProductAvatar);
            this.gbOrderProduct.Controls.Add(this.txtOrderDetailTotal);
            this.gbOrderProduct.Controls.Add(this.label11);
            this.gbOrderProduct.Controls.Add(this.label14);
            this.gbOrderProduct.Controls.Add(this.label10);
            this.gbOrderProduct.Controls.Add(this.lbOrderProductName);
            this.gbOrderProduct.Controls.Add(this.txtOrderPrice);
            this.gbOrderProduct.Controls.Add(this.txtOrderQuantity);
            this.gbOrderProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbOrderProduct.Location = new System.Drawing.Point(0, 59);
            this.gbOrderProduct.Name = "gbOrderProduct";
            this.gbOrderProduct.Size = new System.Drawing.Size(464, 374);
            this.gbOrderProduct.TabIndex = 99;
            this.gbOrderProduct.TabStop = false;
            this.gbOrderProduct.Text = "Product";
            // 
            // pbOrderProductAvatar
            // 
            this.pbOrderProductAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOrderProductAvatar.Location = new System.Drawing.Point(16, 113);
            this.pbOrderProductAvatar.Name = "pbOrderProductAvatar";
            this.pbOrderProductAvatar.Size = new System.Drawing.Size(163, 192);
            this.pbOrderProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrderProductAvatar.TabIndex = 86;
            this.pbOrderProductAvatar.TabStop = false;
            // 
            // txtOrderDetailTotal
            // 
            this.txtOrderDetailTotal.Location = new System.Drawing.Point(297, 257);
            this.txtOrderDetailTotal.Name = "txtOrderDetailTotal";
            this.txtOrderDetailTotal.ReadOnly = true;
            this.txtOrderDetailTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderDetailTotal.Size = new System.Drawing.Size(99, 27);
            this.txtOrderDetailTotal.TabIndex = 2;
            this.txtOrderDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(203, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 28);
            this.label11.TabIndex = 93;
            this.label11.Text = "Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(207, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 28);
            this.label14.TabIndex = 97;
            this.label14.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(203, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 94;
            this.label10.Text = "Quantity";
            // 
            // lbOrderProductName
            // 
            this.lbOrderProductName.AutoSize = true;
            this.lbOrderProductName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderProductName.Location = new System.Drawing.Point(16, 40);
            this.lbOrderProductName.Name = "lbOrderProductName";
            this.lbOrderProductName.Size = new System.Drawing.Size(199, 41);
            this.lbOrderProductName.TabIndex = 96;
            this.lbOrderProductName.Text = "Product Name";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(297, 132);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.ReadOnly = true;
            this.txtOrderPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderPrice.Size = new System.Drawing.Size(99, 27);
            this.txtOrderPrice.TabIndex = 0;
            this.txtOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(297, 198);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.ReadOnly = true;
            this.txtOrderQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderQuantity.Size = new System.Drawing.Size(99, 27);
            this.txtOrderQuantity.TabIndex = 1;
            this.txtOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(60, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(349, 41);
            this.label12.TabIndex = 92;
            this.label12.Text = "Order Detail Information";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.gbOrderTarget);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.dgvOrderDetails);
            this.splitContainer6.Size = new System.Drawing.Size(931, 433);
            this.splitContainer6.SplitterDistance = 254;
            this.splitContainer6.TabIndex = 0;
            // 
            // gbOrderTarget
            // 
            this.gbOrderTarget.BackColor = System.Drawing.Color.Azure;
            this.gbOrderTarget.Controls.Add(this.btnCancelOrder);
            this.gbOrderTarget.Controls.Add(this.label16);
            this.gbOrderTarget.Controls.Add(this.txtOrderMessage);
            this.gbOrderTarget.Controls.Add(this.label13);
            this.gbOrderTarget.Controls.Add(this.txtOrderShippingFee);
            this.gbOrderTarget.Controls.Add(this.txtOrderReceiver);
            this.gbOrderTarget.Controls.Add(this.lbOrderShippingFee);
            this.gbOrderTarget.Controls.Add(this.txtOrderTotal);
            this.gbOrderTarget.Controls.Add(this.txtOrderAddress);
            this.gbOrderTarget.Controls.Add(this.lbOrderDate);
            this.gbOrderTarget.Controls.Add(this.label9);
            this.gbOrderTarget.Controls.Add(this.lbTotal);
            this.gbOrderTarget.Controls.Add(this.txtOrderPhone);
            this.gbOrderTarget.Controls.Add(this.dtpOrderTime);
            this.gbOrderTarget.Controls.Add(this.label8);
            this.gbOrderTarget.Controls.Add(this.lbReceiver);
            this.gbOrderTarget.Controls.Add(this.txtOrderStatus);
            this.gbOrderTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderTarget.Location = new System.Drawing.Point(0, 0);
            this.gbOrderTarget.Name = "gbOrderTarget";
            this.gbOrderTarget.Size = new System.Drawing.Size(931, 254);
            this.gbOrderTarget.TabIndex = 107;
            this.gbOrderTarget.TabStop = false;
            this.gbOrderTarget.Text = "Order >> ID";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelOrder.Location = new System.Drawing.Point(788, 213);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(136, 29);
            this.btnCancelOrder.TabIndex = 8;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(506, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Status";
            // 
            // txtOrderMessage
            // 
            this.txtOrderMessage.Location = new System.Drawing.Point(167, 156);
            this.txtOrderMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderMessage.Name = "txtOrderMessage";
            this.txtOrderMessage.ReadOnly = true;
            this.txtOrderMessage.Size = new System.Drawing.Size(276, 27);
            this.txtOrderMessage.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 158;
            this.label13.Text = "Message";
            // 
            // txtOrderShippingFee
            // 
            this.txtOrderShippingFee.Location = new System.Drawing.Point(686, 156);
            this.txtOrderShippingFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderShippingFee.Name = "txtOrderShippingFee";
            this.txtOrderShippingFee.ReadOnly = true;
            this.txtOrderShippingFee.Size = new System.Drawing.Size(215, 27);
            this.txtOrderShippingFee.TabIndex = 5;
            this.txtOrderShippingFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiver
            // 
            this.txtOrderReceiver.Location = new System.Drawing.Point(167, 51);
            this.txtOrderReceiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderReceiver.Name = "txtOrderReceiver";
            this.txtOrderReceiver.ReadOnly = true;
            this.txtOrderReceiver.Size = new System.Drawing.Size(273, 27);
            this.txtOrderReceiver.TabIndex = 0;
            // 
            // lbOrderShippingFee
            // 
            this.lbOrderShippingFee.AutoSize = true;
            this.lbOrderShippingFee.Location = new System.Drawing.Point(561, 159);
            this.lbOrderShippingFee.Name = "lbOrderShippingFee";
            this.lbOrderShippingFee.Size = new System.Drawing.Size(95, 20);
            this.lbOrderShippingFee.TabIndex = 156;
            this.lbOrderShippingFee.Text = "Shipping Fee";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(301, 210);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(176, 27);
            this.txtOrderTotal.TabIndex = 6;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(167, 104);
            this.txtOrderAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.ReadOnly = true;
            this.txtOrderAddress.Size = new System.Drawing.Size(276, 27);
            this.txtOrderAddress.TabIndex = 2;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(561, 49);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(84, 20);
            this.lbOrderDate.TabIndex = 148;
            this.lbOrderDate.Text = "Order Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 154;
            this.label9.Text = "Address";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(228, 213);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(42, 20);
            this.lbTotal.TabIndex = 143;
            this.lbTotal.Text = "Total";
            // 
            // txtOrderPhone
            // 
            this.txtOrderPhone.Location = new System.Drawing.Point(685, 104);
            this.txtOrderPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderPhone.Name = "txtOrderPhone";
            this.txtOrderPhone.ReadOnly = true;
            this.txtOrderPhone.Size = new System.Drawing.Size(216, 27);
            this.txtOrderPhone.TabIndex = 3;
            this.txtOrderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.CustomFormat = "MMM dd, yyyy hh:ss";
            this.dtpOrderTime.Enabled = false;
            this.dtpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderTime.Location = new System.Drawing.Point(686, 44);
            this.dtpOrderTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Size = new System.Drawing.Size(215, 27);
            this.dtpOrderTime.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 152;
            this.label8.Text = "Phone";
            // 
            // lbReceiver
            // 
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Location = new System.Drawing.Point(35, 51);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(65, 20);
            this.lbReceiver.TabIndex = 142;
            this.lbReceiver.Text = "Receiver";
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(561, 210);
            this.txtOrderStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.ReadOnly = true;
            this.txtOrderStatus.Size = new System.Drawing.Size(121, 27);
            this.txtOrderStatus.TabIndex = 151;
            this.txtOrderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 29;
            this.dgvOrderDetails.Size = new System.Drawing.Size(931, 175);
            this.dgvOrderDetails.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.splitContainer1);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHome.Size = new System.Drawing.Size(1409, 723);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1403, 717);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 87;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSearch.Controls.Add(this.cbProductSort);
            this.groupBoxSearch.Controls.Add(this.label15);
            this.groupBoxSearch.Controls.Add(this.cbProductCategory);
            this.groupBoxSearch.Controls.Add(this.label4);
            this.groupBoxSearch.Controls.Add(this.txtProductNameSearch);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.btnReset);
            this.groupBoxSearch.Controls.Add(this.groupBox2);
            this.groupBoxSearch.Controls.Add(this.groupBox1);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSearch.Size = new System.Drawing.Size(331, 717);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // cbProductSort
            // 
            this.cbProductSort.BackColor = System.Drawing.Color.White;
            this.cbProductSort.FormattingEnabled = true;
            this.cbProductSort.Items.AddRange(new object[] {
            "Sort by",
            "Price asc",
            "Price desc"});
            this.cbProductSort.Location = new System.Drawing.Point(9, 262);
            this.cbProductSort.Name = "cbProductSort";
            this.cbProductSort.Size = new System.Drawing.Size(290, 28);
            this.cbProductSort.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 52;
            this.label15.Text = "Sorting";
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.BackColor = System.Drawing.Color.White;
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Items.AddRange(new object[] {
            "Select the category"});
            this.cbProductCategory.Location = new System.Drawing.Point(9, 190);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(290, 28);
            this.cbProductCategory.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Category";
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.BackColor = System.Drawing.Color.White;
            this.txtProductNameSearch.Location = new System.Drawing.Point(9, 121);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(290, 27);
            this.txtProductNameSearch.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Product Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(185, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 31);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnitsInStockMaxSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUnitsInStockMinSearch);
            this.groupBox2.Location = new System.Drawing.Point(9, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Units In Stock";
            // 
            // txtUnitsInStockMaxSearch
            // 
            this.txtUnitsInStockMaxSearch.Location = new System.Drawing.Point(152, 84);
            this.txtUnitsInStockMaxSearch.Name = "txtUnitsInStockMaxSearch";
            this.txtUnitsInStockMaxSearch.Size = new System.Drawing.Size(138, 27);
            this.txtUnitsInStockMaxSearch.TabIndex = 1;
            this.txtUnitsInStockMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units In Stock Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Units In Stock Min";
            // 
            // txtUnitsInStockMinSearch
            // 
            this.txtUnitsInStockMinSearch.Location = new System.Drawing.Point(152, 45);
            this.txtUnitsInStockMinSearch.Name = "txtUnitsInStockMinSearch";
            this.txtUnitsInStockMinSearch.Size = new System.Drawing.Size(138, 27);
            this.txtUnitsInStockMinSearch.TabIndex = 0;
            this.txtUnitsInStockMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnitPriceMaxSearch);
            this.groupBox1.Controls.Add(this.txtUnitPriceMinSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unit Price Min";
            // 
            // txtUnitPriceMaxSearch
            // 
            this.txtUnitPriceMaxSearch.Location = new System.Drawing.Point(152, 87);
            this.txtUnitPriceMaxSearch.Name = "txtUnitPriceMaxSearch";
            this.txtUnitPriceMaxSearch.Size = new System.Drawing.Size(138, 27);
            this.txtUnitPriceMaxSearch.TabIndex = 1;
            this.txtUnitPriceMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPriceMinSearch
            // 
            this.txtUnitPriceMinSearch.Location = new System.Drawing.Point(152, 45);
            this.txtUnitPriceMinSearch.Name = "txtUnitPriceMinSearch";
            this.txtUnitPriceMinSearch.Size = new System.Drawing.Size(138, 27);
            this.txtUnitPriceMinSearch.TabIndex = 0;
            this.txtUnitPriceMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Price Max";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(25, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Auto Filting";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbProduct);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvProducts);
            this.splitContainer2.Panel2.Controls.Add(this.btnClose);
            this.splitContainer2.Size = new System.Drawing.Size(1068, 717);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.TabIndex = 87;
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.btnAddToCart);
            this.gbProduct.Controls.Add(this.gbSelect);
            this.gbProduct.Controls.Add(this.txtAvailable);
            this.gbProduct.Controls.Add(this.txtPrice);
            this.gbProduct.Controls.Add(this.groupBox3);
            this.gbProduct.Controls.Add(this.label1);
            this.gbProduct.Controls.Add(this.lbAvailable);
            this.gbProduct.Controls.Add(this.lbPrice);
            this.gbProduct.Controls.Add(this.lbProductName);
            this.gbProduct.Controls.Add(this.pbProductAvatar);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProduct.Location = new System.Drawing.Point(0, 0);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(1068, 375);
            this.gbProduct.TabIndex = 86;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product Name";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAddToCart.Location = new System.Drawing.Point(858, 160);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(144, 38);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.txtCurrentIndex);
            this.gbSelect.Controls.Add(this.btnBack);
            this.gbSelect.Controls.Add(this.btnNext);
            this.gbSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSelect.Location = new System.Drawing.Point(3, 319);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(1062, 53);
            this.gbSelect.TabIndex = 92;
            this.gbSelect.TabStop = false;
            // 
            // txtCurrentIndex
            // 
            this.txtCurrentIndex.Location = new System.Drawing.Point(473, 18);
            this.txtCurrentIndex.Name = "txtCurrentIndex";
            this.txtCurrentIndex.ReadOnly = true;
            this.txtCurrentIndex.Size = new System.Drawing.Size(126, 27);
            this.txtCurrentIndex.TabIndex = 1;
            this.txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(323, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(605, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 31);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(637, 122);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAvailable.Size = new System.Drawing.Size(110, 27);
            this.txtAvailable.TabIndex = 2;
            this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(363, 122);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(110, 27);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Location = new System.Drawing.Point(290, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 115);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(9, 26);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(715, 83);
            this.txtDesc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 88;
            // 
            // lbAvailable
            // 
            this.lbAvailable.AutoSize = true;
            this.lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAvailable.Location = new System.Drawing.Point(535, 121);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(96, 28);
            this.lbAvailable.TabIndex = 87;
            this.lbAvailable.Text = "Available:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(299, 121);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 28);
            this.lbPrice.TabIndex = 86;
            this.lbPrice.Text = "Price:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(290, 49);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(236, 45);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            // 
            // pbProductAvatar
            // 
            this.pbProductAvatar.Location = new System.Drawing.Point(17, 39);
            this.pbProductAvatar.Name = "pbProductAvatar";
            this.pbProductAvatar.Size = new System.Drawing.Size(240, 271);
            this.pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductAvatar.TabIndex = 85;
            this.pbProductAvatar.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1068, 297);
            this.dgvProducts.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(978, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 29);
            this.btnClose.TabIndex = 83;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabcontrolCustomer
            // 
            this.tabcontrolCustomer.Controls.Add(this.tabHome);
            this.tabcontrolCustomer.Controls.Add(this.tabCart);
            this.tabcontrolCustomer.Controls.Add(this.tabMyOrder);
            this.tabcontrolCustomer.Controls.Add(this.tabMyProfile);
            this.tabcontrolCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabcontrolCustomer.Name = "tabcontrolCustomer";
            this.tabcontrolCustomer.SelectedIndex = 0;
            this.tabcontrolCustomer.Size = new System.Drawing.Size(1417, 756);
            this.tabcontrolCustomer.TabIndex = 0;
            this.tabcontrolCustomer.TabStop = false;
            // 
            // tabCart
            // 
            this.tabCart.Controls.Add(this.splitContainer7);
            this.tabCart.Location = new System.Drawing.Point(4, 29);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCart.Size = new System.Drawing.Size(1409, 723);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "My Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer7.Size = new System.Drawing.Size(1403, 717);
            this.splitContainer7.SplitterDistance = 330;
            this.splitContainer7.SplitterWidth = 3;
            this.splitContainer7.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.txtCartTotal);
            this.groupBox4.Controls.Add(this.lbCartTotal);
            this.groupBox4.Controls.Add(this.cbSorting);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cbFilterCategory);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtCartFilterName);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(330, 717);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // txtCartTotal
            // 
            this.txtCartTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCartTotal.Location = new System.Drawing.Point(93, 331);
            this.txtCartTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCartTotal.Name = "txtCartTotal";
            this.txtCartTotal.ReadOnly = true;
            this.txtCartTotal.Size = new System.Drawing.Size(206, 39);
            this.txtCartTotal.TabIndex = 54;
            // 
            // lbCartTotal
            // 
            this.lbCartTotal.AutoSize = true;
            this.lbCartTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCartTotal.Location = new System.Drawing.Point(7, 332);
            this.lbCartTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCartTotal.Name = "lbCartTotal";
            this.lbCartTotal.Size = new System.Drawing.Size(99, 32);
            this.lbCartTotal.TabIndex = 53;
            this.lbCartTotal.Text = "TOTAL: ";
            // 
            // cbSorting
            // 
            this.cbSorting.BackColor = System.Drawing.Color.White;
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Items.AddRange(new object[] {
            "Sort by",
            "Price asc",
            "Price desc"});
            this.cbSorting.Location = new System.Drawing.Point(9, 262);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(290, 28);
            this.cbSorting.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 52;
            this.label17.Text = "Sorting";
            // 
            // cbFilterCategory
            // 
            this.cbFilterCategory.BackColor = System.Drawing.Color.White;
            this.cbFilterCategory.FormattingEnabled = true;
            this.cbFilterCategory.Items.AddRange(new object[] {
            "Select the category"});
            this.cbFilterCategory.Location = new System.Drawing.Point(9, 190);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(290, 28);
            this.cbFilterCategory.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "Category";
            // 
            // txtCartFilterName
            // 
            this.txtCartFilterName.BackColor = System.Drawing.Color.White;
            this.txtCartFilterName.Location = new System.Drawing.Point(9, 121);
            this.txtCartFilterName.Name = "txtCartFilterName";
            this.txtCartFilterName.Size = new System.Drawing.Size(290, 27);
            this.txtCartFilterName.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 20);
            this.label19.TabIndex = 48;
            this.label19.Text = "Product Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(25, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Auto Filting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.dgvCarts);
            this.splitContainer8.Panel2.Controls.Add(this.button6);
            this.splitContainer8.Size = new System.Drawing.Size(1070, 717);
            this.splitContainer8.SplitterDistance = 375;
            this.splitContainer8.TabIndex = 88;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCartDelete);
            this.groupBox7.Controls.Add(this.btnDecrease);
            this.groupBox7.Controls.Add(this.btnIncrease);
            this.groupBox7.Controls.Add(this.txtCartQuantity);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.btnCheckout);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.txtCartAvailable);
            this.groupBox7.Controls.Add(this.txtCartPrice);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.lbCartName);
            this.groupBox7.Controls.Add(this.pbCartAvatar);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1070, 375);
            this.groupBox7.TabIndex = 86;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Product Name";
            // 
            // btnCartDelete
            // 
            this.btnCartDelete.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCartDelete.Location = new System.Drawing.Point(828, 159);
            this.btnCartDelete.Name = "btnCartDelete";
            this.btnCartDelete.Size = new System.Drawing.Size(144, 38);
            this.btnCartDelete.TabIndex = 97;
            this.btnCartDelete.Text = "Delete";
            this.btnCartDelete.UseVisualStyleBackColor = false;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(938, 124);
            this.btnDecrease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(34, 24);
            this.btnDecrease.TabIndex = 96;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(938, 98);
            this.btnIncrease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(34, 21);
            this.btnIncrease.TabIndex = 95;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            // 
            // txtCartQuantity
            // 
            this.txtCartQuantity.Location = new System.Drawing.Point(881, 110);
            this.txtCartQuantity.Name = "txtCartQuantity";
            this.txtCartQuantity.ReadOnly = true;
            this.txtCartQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCartQuantity.Size = new System.Drawing.Size(53, 27);
            this.txtCartQuantity.TabIndex = 94;
            this.txtCartQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(786, 110);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 28);
            this.label28.TabIndex = 93;
            this.label28.Text = "Quantity:";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCheckout.Location = new System.Drawing.Point(878, 32);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(144, 38);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblCartIndex);
            this.groupBox8.Controls.Add(this.btnCartBack);
            this.groupBox8.Controls.Add(this.btnCartNext);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox8.Location = new System.Drawing.Point(3, 319);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1064, 53);
            this.groupBox8.TabIndex = 92;
            this.groupBox8.TabStop = false;
            // 
            // lblCartIndex
            // 
            this.lblCartIndex.Location = new System.Drawing.Point(473, 18);
            this.lblCartIndex.Name = "lblCartIndex";
            this.lblCartIndex.ReadOnly = true;
            this.lblCartIndex.Size = new System.Drawing.Size(126, 27);
            this.lblCartIndex.TabIndex = 1;
            this.lblCartIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCartBack
            // 
            this.btnCartBack.Location = new System.Drawing.Point(323, 16);
            this.btnCartBack.Name = "btnCartBack";
            this.btnCartBack.Size = new System.Drawing.Size(144, 31);
            this.btnCartBack.TabIndex = 0;
            this.btnCartBack.Text = "<< Back";
            this.btnCartBack.UseVisualStyleBackColor = true;
            // 
            // btnCartNext
            // 
            this.btnCartNext.Location = new System.Drawing.Point(605, 16);
            this.btnCartNext.Name = "btnCartNext";
            this.btnCartNext.Size = new System.Drawing.Size(144, 31);
            this.btnCartNext.TabIndex = 2;
            this.btnCartNext.Text = "Next >>";
            this.btnCartNext.UseVisualStyleBackColor = true;
            // 
            // txtCartAvailable
            // 
            this.txtCartAvailable.Location = new System.Drawing.Point(630, 112);
            this.txtCartAvailable.Name = "txtCartAvailable";
            this.txtCartAvailable.ReadOnly = true;
            this.txtCartAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCartAvailable.Size = new System.Drawing.Size(110, 27);
            this.txtCartAvailable.TabIndex = 2;
            this.txtCartAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCartPrice
            // 
            this.txtCartPrice.Location = new System.Drawing.Point(362, 112);
            this.txtCartPrice.Name = "txtCartPrice";
            this.txtCartPrice.ReadOnly = true;
            this.txtCartPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCartPrice.Size = new System.Drawing.Size(110, 27);
            this.txtCartPrice.TabIndex = 1;
            this.txtCartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtCartDescription);
            this.groupBox9.Location = new System.Drawing.Point(290, 195);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(733, 115);
            this.groupBox9.TabIndex = 89;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Description";
            // 
            // txtCartDescription
            // 
            this.txtCartDescription.Location = new System.Drawing.Point(9, 26);
            this.txtCartDescription.Multiline = true;
            this.txtCartDescription.Name = "txtCartDescription";
            this.txtCartDescription.ReadOnly = true;
            this.txtCartDescription.Size = new System.Drawing.Size(715, 83);
            this.txtCartDescription.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(300, 196);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 28);
            this.label24.TabIndex = 88;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(531, 110);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 28);
            this.label25.TabIndex = 87;
            this.label25.Text = "Available:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(298, 110);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 28);
            this.label26.TabIndex = 86;
            this.label26.Text = "Price:";
            // 
            // lbCartName
            // 
            this.lbCartName.AutoSize = true;
            this.lbCartName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCartName.Location = new System.Drawing.Point(290, 50);
            this.lbCartName.Name = "lbCartName";
            this.lbCartName.Size = new System.Drawing.Size(236, 45);
            this.lbCartName.TabIndex = 0;
            this.lbCartName.Text = "Product Name";
            // 
            // pbCartAvatar
            // 
            this.pbCartAvatar.Location = new System.Drawing.Point(17, 39);
            this.pbCartAvatar.Name = "pbCartAvatar";
            this.pbCartAvatar.Size = new System.Drawing.Size(240, 271);
            this.pbCartAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartAvatar.TabIndex = 85;
            this.pbCartAvatar.TabStop = false;
            // 
            // dgvCarts
            // 
            this.dgvCarts.AllowUserToAddRows = false;
            this.dgvCarts.AllowUserToDeleteRows = false;
            this.dgvCarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvCarts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCarts.Location = new System.Drawing.Point(0, 0);
            this.dgvCarts.Name = "dgvCarts";
            this.dgvCarts.ReadOnly = true;
            this.dgvCarts.RowHeadersWidth = 51;
            this.dgvCarts.RowTemplate.Height = 29;
            this.dgvCarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarts.Size = new System.Drawing.Size(1070, 297);
            this.dgvCarts.TabIndex = 0;
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
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(1913, 583);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 29);
            this.button6.TabIndex = 83;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 756);
            this.Controls.Add(this.tabcontrolCustomer);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomer";
            this.tabMyOrder.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.gbOrderProduct.ResumeLayout(false);
            this.gbOrderProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderProductAvatar)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.gbOrderTarget.ResumeLayout(false);
            this.gbOrderTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tabHome.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabcontrolCustomer.ResumeLayout(false);
            this.tabCart.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarts)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cbSorting;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbFilterCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCartFilterName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
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
    }
}