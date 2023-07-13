namespace GiftHommieWinforms
{
    partial class frmStaff
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
            label6 = new System.Windows.Forms.Label();
            txtUnitPriceMaxSearch = new System.Windows.Forms.TextBox();
            txtUnitPriceMinSearch = new System.Windows.Forms.TextBox();
            cbProductSort = new System.Windows.Forms.ComboBox();
            label15 = new System.Windows.Forms.Label();
            cbProductCategory = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtProductNameSearch = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtUnitsInStockMinSearch = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtUnitsInStockMaxSearch = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBoxSearch = new System.Windows.Forms.GroupBox();
            btnDeleteProduct = new System.Windows.Forms.Button();
            btnAddProduct = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            gbProduct = new System.Windows.Forms.GroupBox();
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
            button1 = new System.Windows.Forms.Button();
            dgvProducts = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            tabHome = new System.Windows.Forms.TabPage();
            tabcontrolStaff = new System.Windows.Forms.TabControl();
            tabOrder = new System.Windows.Forms.TabPage();
            dgvOrders = new System.Windows.Forms.DataGridView();
            btnRefuse = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            btnCleanAllFilterOrder = new System.Windows.Forms.Button();
            cbOrderStatus = new System.Windows.Forms.ComboBox();
            txtOrderSearch = new System.Windows.Forms.TextBox();
            btnSearchOrder = new System.Windows.Forms.Button();
            btnSort = new System.Windows.Forms.Button();
            gbFilter = new System.Windows.Forms.GroupBox();
            btnFilter = new System.Windows.Forms.Button();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            lbStartDate = new System.Windows.Forms.Label();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            lbEndDate = new System.Windows.Forms.Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbProduct.SuspendLayout();
            gbSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabHome.SuspendLayout();
            tabcontrolStaff.SuspendLayout();
            tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox4.SuspendLayout();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(14, 34);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 0;
            label6.Text = "Unit Price Min";
            // 
            // txtUnitPriceMaxSearch
            // 
            txtUnitPriceMaxSearch.Location = new System.Drawing.Point(133, 65);
            txtUnitPriceMaxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitPriceMaxSearch.Name = "txtUnitPriceMaxSearch";
            txtUnitPriceMaxSearch.Size = new System.Drawing.Size(121, 23);
            txtUnitPriceMaxSearch.TabIndex = 1;
            txtUnitPriceMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitPriceMaxSearch.TextChanged += txtUnitPriceMaxSearch_TextChanged;
            // 
            // txtUnitPriceMinSearch
            // 
            txtUnitPriceMinSearch.Location = new System.Drawing.Point(133, 34);
            txtUnitPriceMinSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitPriceMinSearch.Name = "txtUnitPriceMinSearch";
            txtUnitPriceMinSearch.Size = new System.Drawing.Size(121, 23);
            txtUnitPriceMinSearch.TabIndex = 0;
            txtUnitPriceMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitPriceMinSearch.TextChanged += txtUnitPriceMinSearch_TextChanged;
            // 
            // cbProductSort
            // 
            cbProductSort.BackColor = System.Drawing.Color.White;
            cbProductSort.FormattingEnabled = true;
            cbProductSort.Items.AddRange(new object[] { "Sort by", "Price asc", "Price desc" });
            cbProductSort.Location = new System.Drawing.Point(8, 196);
            cbProductSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbProductSort.Name = "cbProductSort";
            cbProductSort.Size = new System.Drawing.Size(254, 23);
            cbProductSort.TabIndex = 51;
            cbProductSort.SelectedIndexChanged += cbProductSort_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(5, 180);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(45, 15);
            label15.TabIndex = 52;
            label15.Text = "Sorting";
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = System.Drawing.Color.White;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "Select the category" });
            cbProductCategory.Location = new System.Drawing.Point(8, 142);
            cbProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new System.Drawing.Size(254, 23);
            cbProductCategory.TabIndex = 3;
            cbProductCategory.SelectedIndexChanged += cbProductCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 50;
            label4.Text = "Category";
            // 
            // txtProductNameSearch
            // 
            txtProductNameSearch.BackColor = System.Drawing.Color.White;
            txtProductNameSearch.Location = new System.Drawing.Point(8, 91);
            txtProductNameSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductNameSearch.Name = "txtProductNameSearch";
            txtProductNameSearch.Size = new System.Drawing.Size(254, 23);
            txtProductNameSearch.TabIndex = 0;
            txtProductNameSearch.TextChanged += txtProductNameSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(5, 74);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 15);
            label5.TabIndex = 48;
            label5.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Units In Stock Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(14, 34);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 15);
            label7.TabIndex = 0;
            label7.Text = "Units In Stock Min";
            // 
            // txtUnitsInStockMinSearch
            // 
            txtUnitsInStockMinSearch.Location = new System.Drawing.Point(133, 34);
            txtUnitsInStockMinSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitsInStockMinSearch.Name = "txtUnitsInStockMinSearch";
            txtUnitsInStockMinSearch.Size = new System.Drawing.Size(121, 23);
            txtUnitsInStockMinSearch.TabIndex = 0;
            txtUnitsInStockMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitsInStockMinSearch.TextChanged += txtUnitsInStockMinSearch_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(162, 29);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(100, 23);
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
            groupBox2.Location = new System.Drawing.Point(8, 352);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(272, 94);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Units In Stock";
            // 
            // txtUnitsInStockMaxSearch
            // 
            txtUnitsInStockMaxSearch.Location = new System.Drawing.Point(133, 63);
            txtUnitsInStockMaxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitsInStockMaxSearch.Name = "txtUnitsInStockMaxSearch";
            txtUnitsInStockMaxSearch.Size = new System.Drawing.Size(121, 23);
            txtUnitsInStockMaxSearch.TabIndex = 1;
            txtUnitsInStockMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitsInStockMaxSearch.TextChanged += txtUnitsInStockMaxSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Unit Price Max";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUnitPriceMaxSearch);
            groupBox1.Controls.Add(txtUnitPriceMinSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(8, 237);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(272, 94);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unit Price";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBoxSearch.Controls.Add(btnDeleteProduct);
            groupBoxSearch.Controls.Add(btnAddProduct);
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
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new System.Drawing.Size(298, 540);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = System.Drawing.Color.LemonChiffon;
            btnDeleteProduct.Location = new System.Drawing.Point(162, 467);
            btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new System.Drawing.Size(88, 28);
            btnDeleteProduct.TabIndex = 53;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = System.Drawing.Color.LemonChiffon;
            btnAddProduct.Location = new System.Drawing.Point(24, 467);
            btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(88, 28);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddToCart_Click;
            // 
            // btnSearch
            // 
            btnSearch.Enabled = false;
            btnSearch.Location = new System.Drawing.Point(22, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(124, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Auto Filting";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 2);
            splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(1243, 540);
            splitContainer1.SplitterDistance = 298;
            splitContainer1.TabIndex = 87;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(gbProduct);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button1);
            splitContainer2.Panel2.Controls.Add(dgvProducts);
            splitContainer2.Panel2.Controls.Add(btnClose);
            splitContainer2.Size = new System.Drawing.Size(941, 540);
            splitContainer2.SplitterDistance = 282;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 87;
            // 
            // gbProduct
            // 
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
            gbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbProduct.Name = "gbProduct";
            gbProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbProduct.Size = new System.Drawing.Size(941, 282);
            gbProduct.TabIndex = 86;
            gbProduct.TabStop = false;
            gbProduct.Text = "Product Name";
            // 
            // gbSelect
            // 
            gbSelect.Controls.Add(txtCurrentIndex);
            gbSelect.Controls.Add(btnBack);
            gbSelect.Controls.Add(btnNext);
            gbSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbSelect.Location = new System.Drawing.Point(3, 240);
            gbSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbSelect.Name = "gbSelect";
            gbSelect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbSelect.Size = new System.Drawing.Size(935, 40);
            gbSelect.TabIndex = 92;
            gbSelect.TabStop = false;
            // 
            // txtCurrentIndex
            // 
            txtCurrentIndex.Location = new System.Drawing.Point(414, 14);
            txtCurrentIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCurrentIndex.Name = "txtCurrentIndex";
            txtCurrentIndex.ReadOnly = true;
            txtCurrentIndex.Size = new System.Drawing.Size(111, 23);
            txtCurrentIndex.TabIndex = 1;
            txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(283, 12);
            btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(126, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "<< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(529, 12);
            btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(126, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next >>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new System.Drawing.Point(557, 92);
            txtAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtAvailable.Size = new System.Drawing.Size(97, 23);
            txtAvailable.TabIndex = 2;
            txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(318, 92);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPrice.Size = new System.Drawing.Size(97, 23);
            txtPrice.TabIndex = 1;
            txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDesc);
            groupBox3.Location = new System.Drawing.Point(254, 146);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Size = new System.Drawing.Size(641, 86);
            groupBox3.TabIndex = 89;
            groupBox3.TabStop = false;
            groupBox3.Text = "Description";
            // 
            // txtDesc
            // 
            txtDesc.Location = new System.Drawing.Point(8, 20);
            txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new System.Drawing.Size(626, 63);
            txtDesc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(262, 146);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 21);
            label1.TabIndex = 88;
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAvailable.Location = new System.Drawing.Point(468, 91);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new System.Drawing.Size(76, 21);
            lbAvailable.TabIndex = 87;
            lbAvailable.Text = "Available:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(262, 91);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(47, 21);
            lbPrice.TabIndex = 86;
            lbPrice.Text = "Price:";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductName.Location = new System.Drawing.Point(254, 37);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(194, 37);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            lbProductName.TextChanged += lbProductName_TextChanged;
            lbProductName.Click += lbProductName_Click;
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new System.Drawing.Point(15, 29);
            pbProductAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new System.Drawing.Size(210, 203);
            pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 85;
            pbProductAvatar.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(842, 239);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(74, 22);
            button1.TabIndex = 84;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            dgvProducts.Location = new System.Drawing.Point(0, 0);
            dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new System.Drawing.Size(941, 223);
            dgvProducts.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(1650, 458);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(74, 22);
            btnClose.TabIndex = 83;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(splitContainer1);
            tabHome.Location = new System.Drawing.Point(4, 24);
            tabHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabHome.Name = "tabHome";
            tabHome.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabHome.Size = new System.Drawing.Size(1249, 544);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Click += tabHome_Click;
            // 
            // tabcontrolStaff
            // 
            tabcontrolStaff.Controls.Add(tabHome);
            tabcontrolStaff.Controls.Add(tabOrder);
            tabcontrolStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            tabcontrolStaff.Location = new System.Drawing.Point(0, 0);
            tabcontrolStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabcontrolStaff.Name = "tabcontrolStaff";
            tabcontrolStaff.SelectedIndex = 0;
            tabcontrolStaff.Size = new System.Drawing.Size(1257, 572);
            tabcontrolStaff.TabIndex = 1;
            tabcontrolStaff.TabStop = false;
            tabcontrolStaff.SelectedIndexChanged += tabcontrolStaff_SelectedIndexChanged;
            // 
            // tabOrder
            // 
            tabOrder.Controls.Add(dgvOrders);
            tabOrder.Controls.Add(btnRefuse);
            tabOrder.Controls.Add(btnConfirm);
            tabOrder.Controls.Add(groupBox4);
            tabOrder.Location = new System.Drawing.Point(4, 24);
            tabOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabOrder.Name = "tabOrder";
            tabOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabOrder.Size = new System.Drawing.Size(1249, 544);
            tabOrder.TabIndex = 1;
            tabOrder.Text = "Order";
            tabOrder.UseVisualStyleBackColor = true;
            tabOrder.Click += tabOrder_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new System.Drawing.Point(3, 317);
            dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new System.Drawing.Size(1011, 242);
            dgvOrders.TabIndex = 117;
            dgvOrders.CellClick += dgvOrders_CellClick;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            // 
            // btnRefuse
            // 
            btnRefuse.BackColor = System.Drawing.Color.Red;
            btnRefuse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRefuse.Location = new System.Drawing.Point(1039, 376);
            btnRefuse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRefuse.Name = "btnRefuse";
            btnRefuse.Size = new System.Drawing.Size(108, 33);
            btnRefuse.TabIndex = 4;
            btnRefuse.Text = "Refuse";
            btnRefuse.UseVisualStyleBackColor = false;
            btnRefuse.Visible = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.Cyan;
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Location = new System.Drawing.Point(1039, 317);
            btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(108, 33);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCleanAllFilterOrder);
            groupBox4.Controls.Add(cbOrderStatus);
            groupBox4.Controls.Add(txtOrderSearch);
            groupBox4.Controls.Add(btnSearchOrder);
            groupBox4.Controls.Add(btnSort);
            groupBox4.Controls.Add(gbFilter);
            groupBox4.Location = new System.Drawing.Point(0, 0);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox4.Size = new System.Drawing.Size(516, 320);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search";
            // 
            // btnCleanAllFilterOrder
            // 
            btnCleanAllFilterOrder.Location = new System.Drawing.Point(186, 74);
            btnCleanAllFilterOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCleanAllFilterOrder.Name = "btnCleanAllFilterOrder";
            btnCleanAllFilterOrder.Size = new System.Drawing.Size(105, 26);
            btnCleanAllFilterOrder.TabIndex = 118;
            btnCleanAllFilterOrder.Text = "Clean all filters";
            btnCleanAllFilterOrder.UseVisualStyleBackColor = false;
            btnCleanAllFilterOrder.Click += btnCleanAllFilterOrder_Click;
            // 
            // cbOrderStatus
            // 
            cbOrderStatus.FormattingEnabled = true;
            cbOrderStatus.Items.AddRange(new object[] { "All status", "PENDING", "CONFIRMED", "DELIVERYING", "SUCCESSFUL", "CANCALLED", "REFUSED", "FAIL" });
            cbOrderStatus.Location = new System.Drawing.Point(301, 34);
            cbOrderStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbOrderStatus.Name = "cbOrderStatus";
            cbOrderStatus.Size = new System.Drawing.Size(133, 23);
            cbOrderStatus.TabIndex = 115;
            cbOrderStatus.SelectedIndexChanged += cbOrderStatus_SelectedIndexChanged;
            // 
            // txtOrderSearch
            // 
            txtOrderSearch.Location = new System.Drawing.Point(7, 35);
            txtOrderSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderSearch.Name = "txtOrderSearch";
            txtOrderSearch.Size = new System.Drawing.Size(289, 23);
            txtOrderSearch.TabIndex = 114;
            txtOrderSearch.TextChanged += txtOrderSearch_TextChanged;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Location = new System.Drawing.Point(438, 34);
            btnSearchOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new System.Drawing.Size(67, 22);
            btnSearchOrder.TabIndex = 113;
            btnSearchOrder.Text = "Search";
            btnSearchOrder.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            btnSort.Location = new System.Drawing.Point(117, 124);
            btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(243, 40);
            btnSort.TabIndex = 111;
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
            gbFilter.Location = new System.Drawing.Point(36, 174);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new System.Drawing.Size(402, 128);
            gbFilter.TabIndex = 112;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filt by Date";
            // 
            // btnFilter
            // 
            btnFilter.Enabled = false;
            btnFilter.Location = new System.Drawing.Point(136, 99);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(118, 23);
            btnFilter.TabIndex = 44;
            btnFilter.Text = "Auto Filting";
            btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(110, 66);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(230, 23);
            dtpEndDate.TabIndex = 1;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new System.Drawing.Point(24, 35);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new System.Drawing.Size(58, 15);
            lbStartDate.TabIndex = 108;
            lbStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(110, 31);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(230, 23);
            dtpStartDate.TabIndex = 0;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new System.Drawing.Point(24, 70);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new System.Drawing.Size(54, 15);
            lbEndDate.TabIndex = 109;
            lbEndDate.Text = "End Date";
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1257, 572);
            Controls.Add(tabcontrolStaff);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmStaff";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaff";
            FormClosing += frmStaff_FormClosing;
            Load += frmStaff_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
            tabHome.ResumeLayout(false);
            tabcontrolStaff.ResumeLayout(false);
            tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPriceMaxSearch;
        private System.Windows.Forms.TextBox txtUnitPriceMinSearch;
        private System.Windows.Forms.ComboBox cbProductSort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitsInStockMinSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnitsInStockMaxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbProduct;
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
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabControl tabcontrolStaff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.Button btnRefuse;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnCleanAllFilterOrder;
    }
}