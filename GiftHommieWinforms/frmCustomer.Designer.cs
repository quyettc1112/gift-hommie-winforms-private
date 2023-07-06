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
            this.tabcontrolCustomer = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
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
            this.tabCart = new System.Windows.Forms.TabPage();
            this.tabMyOrder = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnCleanAllFilterOrder = new System.Windows.Forms.Button();
            this.tabcontrolCustomer.SuspendLayout();
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
            this.tabMyOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
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
            this.tabcontrolCustomer.Click += new System.EventHandler(this.tabcontrolCustomer_Click);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.splitContainer1);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1409, 723);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
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
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 87;
            // 
            // groupBoxSearch
            // 
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
            this.groupBoxSearch.Size = new System.Drawing.Size(366, 717);
            this.groupBoxSearch.TabIndex = 82;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.BackColor = System.Drawing.Color.White;
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Items.AddRange(new object[] {
            "Select the category"});
            this.cbProductCategory.Location = new System.Drawing.Point(9, 190);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(334, 28);
            this.cbProductCategory.TabIndex = 51;
            this.cbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cbProductCategory_SelectedIndexChanged);
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
            this.txtProductNameSearch.Size = new System.Drawing.Size(331, 27);
            this.txtProductNameSearch.TabIndex = 49;
            this.txtProductNameSearch.TextChanged += new System.EventHandler(this.txtProductNameSearch_TextChanged);
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
            this.btnReset.Location = new System.Drawing.Point(183, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 31);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnitsInStockMaxSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUnitsInStockMinSearch);
            this.groupBox2.Location = new System.Drawing.Point(9, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Units In Stock";
            // 
            // txtUnitsInStockMaxSearch
            // 
            this.txtUnitsInStockMaxSearch.Location = new System.Drawing.Point(152, 84);
            this.txtUnitsInStockMaxSearch.Name = "txtUnitsInStockMaxSearch";
            this.txtUnitsInStockMaxSearch.Size = new System.Drawing.Size(156, 27);
            this.txtUnitsInStockMaxSearch.TabIndex = 3;
            this.txtUnitsInStockMaxSearch.TextChanged += new System.EventHandler(this.txtUnitsInStockMaxSearch_TextChanged);
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
            this.txtUnitsInStockMinSearch.Size = new System.Drawing.Size(156, 27);
            this.txtUnitsInStockMinSearch.TabIndex = 1;
            this.txtUnitsInStockMinSearch.TextChanged += new System.EventHandler(this.txtUnitsInStockMinSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnitPriceMaxSearch);
            this.groupBox1.Controls.Add(this.txtUnitPriceMinSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 125);
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
            this.txtUnitPriceMaxSearch.Size = new System.Drawing.Size(156, 27);
            this.txtUnitPriceMaxSearch.TabIndex = 3;
            this.txtUnitPriceMaxSearch.TextChanged += new System.EventHandler(this.txtUnitPriceMaxSearch_TextChanged);
            // 
            // txtUnitPriceMinSearch
            // 
            this.txtUnitPriceMinSearch.Location = new System.Drawing.Point(152, 45);
            this.txtUnitPriceMinSearch.Name = "txtUnitPriceMinSearch";
            this.txtUnitPriceMinSearch.Size = new System.Drawing.Size(156, 27);
            this.txtUnitPriceMinSearch.TabIndex = 1;
            this.txtUnitPriceMinSearch.TextChanged += new System.EventHandler(this.txtUnitPriceMinSearch_TextChanged);
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
            this.btnSearch.TabIndex = 44;
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
            this.splitContainer2.Size = new System.Drawing.Size(1033, 717);
            this.splitContainer2.SplitterDistance = 376;
            this.splitContainer2.TabIndex = 87;
            // 
            // gbProduct
            // 
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
            this.gbProduct.Size = new System.Drawing.Size(1033, 376);
            this.gbProduct.TabIndex = 86;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product Name";
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.txtCurrentIndex);
            this.gbSelect.Controls.Add(this.btnBack);
            this.gbSelect.Controls.Add(this.btnNext);
            this.gbSelect.Location = new System.Drawing.Point(6, 320);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(1027, 53);
            this.gbSelect.TabIndex = 92;
            this.gbSelect.TabStop = false;
            // 
            // txtCurrentIndex
            // 
            this.txtCurrentIndex.Location = new System.Drawing.Point(434, 18);
            this.txtCurrentIndex.Name = "txtCurrentIndex";
            this.txtCurrentIndex.ReadOnly = true;
            this.txtCurrentIndex.Size = new System.Drawing.Size(126, 27);
            this.txtCurrentIndex.TabIndex = 52;
            this.txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(284, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 31);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(566, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 31);
            this.btnNext.TabIndex = 91;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(637, 122);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAvailable.Size = new System.Drawing.Size(110, 27);
            this.txtAvailable.TabIndex = 90;
            this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(363, 122);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(110, 27);
            this.txtPrice.TabIndex = 0;
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
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product Name";
            this.lbProductName.TextChanged += new System.EventHandler(this.lbProductName_TextChanged);
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
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1033, 297);
            this.dgvProducts.TabIndex = 84;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(929, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 29);
            this.btnClose.TabIndex = 83;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabCart
            // 
            this.tabCart.Location = new System.Drawing.Point(4, 29);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(1409, 723);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "My Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // tabMyOrder
            // 
            this.tabMyOrder.Controls.Add(this.splitContainer3);
            this.tabMyOrder.Location = new System.Drawing.Point(4, 29);
            this.tabMyOrder.Name = "tabMyOrder";
            this.tabMyOrder.Padding = new System.Windows.Forms.Padding(3);
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
            this.splitContainer3.Size = new System.Drawing.Size(1403, 717);
            this.splitContainer3.SplitterDistance = 297;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer3_SplitterMoved);
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyProfile.Size = new System.Drawing.Size(1409, 723);
            this.tabMyProfile.TabIndex = 3;
            this.tabMyProfile.Text = "My Profile";
            this.tabMyProfile.UseVisualStyleBackColor = true;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnSort);
            this.splitContainer4.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer4.Panel1.Controls.Add(this.dtpStartDate);
            this.splitContainer4.Panel1.Controls.Add(this.lbEndDate);
            this.splitContainer4.Panel1.Controls.Add(this.lbStartDate);
            this.splitContainer4.Panel1.Controls.Add(this.gbFilter);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnCleanAllFilterOrder);
            this.splitContainer4.Panel2.Controls.Add(this.btnSearchOrder);
            this.splitContainer4.Panel2.Controls.Add(this.textBox1);
            this.splitContainer4.Panel2.Controls.Add(this.dgvOrderList);
            this.splitContainer4.Size = new System.Drawing.Size(1403, 297);
            this.splitContainer4.SplitterDistance = 467;
            this.splitContainer4.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(128, 203);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(262, 27);
            this.dtpEndDate.TabIndex = 112;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(128, 156);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(262, 27);
            this.dtpStartDate.TabIndex = 111;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(29, 208);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(70, 20);
            this.lbEndDate.TabIndex = 109;
            this.lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(29, 161);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(76, 20);
            this.lbStartDate.TabIndex = 108;
            this.lbStartDate.Text = "Start Date";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Location = new System.Drawing.Point(5, 116);
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
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(98, 34);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(278, 53);
            this.btnSort.TabIndex = 113;
            this.btnSort.Text = "Sort In Descending Date Order";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 67);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(932, 230);
            this.dgvOrderList.TabIndex = 104;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 27);
            this.textBox1.TabIndex = 105;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(15, 20);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(94, 29);
            this.btnSearchOrder.TabIndex = 1;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            // 
            // btnCleanAllFilterOrder
            // 
            this.btnCleanAllFilterOrder.Location = new System.Drawing.Point(802, 14);
            this.btnCleanAllFilterOrder.Name = "btnCleanAllFilterOrder";
            this.btnCleanAllFilterOrder.Size = new System.Drawing.Size(125, 41);
            this.btnCleanAllFilterOrder.TabIndex = 106;
            this.btnCleanAllFilterOrder.Text = "Clean all filters";
            this.btnCleanAllFilterOrder.UseVisualStyleBackColor = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.tabcontrolCustomer.ResumeLayout(false);
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
            this.tabMyOrder.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolCustomer;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.TabPage tabMyOrder;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxSearch;
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
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.PictureBox pbProductAvatar;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnCleanAllFilterOrder;
    }
}