using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GiftHommieWinforms
{
    public partial class frmCustomer : Form
    {
        ICartRepository cartRepository = new CartRepository();
        private IProductRepository productRepository = new ProductRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private BindingSource bindingSource = null;
        private BindingSource orderDetailBindingSource = null;
        private bool orderTimeDescMode = true;
        private IUserRepository userRepository = new UserRepository();
        public frmCustomer()
        {
            InitializeComponent();
            if (GlobalData.AuthenticatedUser == null)
            {
                MessageBox.Show("Let's start with Login form!");
                this.Close();
                //frmLogin frmLogin = new frmLogin();
                //frmLogin.FormClosed += delegate
                //{
                //    this.Close();
                //};
                //frmLogin.VisibleChanged += delegate
                //{
                //    if (frmLogin.Visible == false)
                //        this.Close();
                //};
                //this.Hide();
                //frmLogin.ShowDialog();
            }
        }

        private void tabcontrolCustomer_Click(object sender, EventArgs e)
        {
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            tabHome_Click(sender, e);
        }

        // TAB HOME AREA ------------------------------------------------------------
        private void tabHome_Click(object sender, EventArgs e)
        {
            HomeInitDataForSearchComponent();
            HomeLoadData();
        }

        private void HomeInitDataForSearchComponent()
        {
            // Load for search
            List<Category> categories = productRepository.GetAllCategories();
            categories.Insert(0, new Category()
            {
                Id = 0,
                Name = "Select the category",
            });
            cbProductCategory.DataSource = categories;
            cbProductCategory.ValueMember = "Id";
            cbProductCategory.DisplayMember = "Name";
            cbProductCategory.SelectedValue = 0;
            cbProductSort.SelectedIndex = 0;
        }

        private void HomeLoadData()
        {
            //// Load for search
            //List<Category> categories = productRepository.GetAllCategories();
            //categories.Insert(0, new Category()
            //{
            //    Id = 0,
            //    Name = "Select the category",
            //});
            //cbProductCategory.DataSource = categories;
            //cbProductCategory.ValueMember = "Id";
            //cbProductCategory.DisplayMember = "Name";
            //cbProductCategory.SelectedValue = 0;

            // Load products
            //List<Product> products = productRepository.GetAllWithStatus(true);

            List<Product> products = productRepository.GetAllWithFilter(
                "",
                txtProductNameSearch.Text,
                txtUnitPriceMinSearch.Text, txtUnitPriceMaxSearch.Text,
                txtUnitsInStockMinSearch.Text, txtUnitsInStockMaxSearch.Text,
                ToIntOrZero(cbProductCategory.SelectedValue.ToString()),
                true
                );
            if (cbProductSort.SelectedIndex == 1)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            else if (cbProductSort.SelectedIndex == 2)
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }

            HomeLoadDataToGridView(products);


        }

        private void HomeLoadDataToGridView(IEnumerable<Product> products)
        {
            if (products == null)
                products = new List<Product>()
                {
                };

            try
            {


                bindingSource = new BindingSource();
                bindingSource.DataSource = products;

                HomeReBinding();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = bindingSource;
                dgvProducts.Columns["Id"].Visible = false;
                dgvProducts.Columns["Avatar"].Visible = false;
                dgvProducts.Columns["Status"].Visible = false;
                dgvProducts.Columns["Carts"].Visible = false;
                dgvProducts.Columns["Category"].Visible = false;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["OrderDetails"].Visible = false;
                setRowNumber(dgvProducts);



                //if (products.Count() == 0)
                //{
                //    ClearText();
                //    //btnNext.Enabled = false;
                //    //btnBack.Enabled = false;
                //}
                //else
                //{
                //    //btnNext.Enabled = true;
                //    //btnBack.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomeReBinding()
        {
            gbProduct.DataBindings.Clear();
            lbProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtAvailable.DataBindings.Clear();
            txtDesc.DataBindings.Clear();
            pbProductAvatar.DataBindings.Clear();


            gbProduct.DataBindings.Add("Text", bindingSource, "Name");
            lbProductName.DataBindings.Add("Text", bindingSource, "Name");
            txtPrice.DataBindings.Add("Text", bindingSource, "Price");
            txtAvailable.DataBindings.Add("Text", bindingSource, "Quantity");
            txtDesc.DataBindings.Add("Text", bindingSource, "Description");
            pbProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", bindingSource, "Avatar", true));

        }

        private void HomeClearText()
        {
            lbProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtAvailable.Text = string.Empty;
            txtDesc.Text = string.Empty;
        }

        private void txtProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitPriceMinSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitPriceMaxSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitsInStockMinSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void txtUnitsInStockMaxSearch_TextChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }
        private void cbProductSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeLoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductNameSearch.Text = string.Empty;

            txtUnitPriceMinSearch.Text = string.Empty;
            txtUnitPriceMaxSearch.Text = string.Empty;
            txtUnitsInStockMinSearch.Text = string.Empty;
            txtUnitsInStockMaxSearch.Text = string.Empty;
            cbProductCategory.SelectedValue = 0;
            cbProductSort.SelectedIndex = 0;
        }

        private int ToIntOrZero(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                return 0;
            }
        }

        private bool flagBtnNext_Click = false;
        private void lbProductName_TextChanged(object sender, EventArgs e)
        {
            txtCurrentIndex.Text = (bindingSource.Position + 1).ToString();
            btnBack.Enabled = (bindingSource.Position != 0);
            btnNext.Enabled = flagBtnNext_Click == true || bindingSource.Position + 1 < bindingSource.Count;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int index = bindingSource.Position - 1 < 0 ? 0 : bindingSource.Position - 1;
            bindingSource.Position = index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = bindingSource.Position;
            if (index + 1 < bindingSource.Count)
                index += 1;
            flagBtnNext_Click = true;
            bindingSource.Position = index;
            flagBtnNext_Click = false;
            btnNext.Enabled = bindingSource.Position + 1 < bindingSource.Count;
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to exit?",
                                    "Confirm to exit",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.No)
                e.Cancel = true;
            else
            {
                GlobalData.AuthenticatedUser = null;
            }
        }

        // TAB ORDER AREA -------------------------------------------------
        private void tabMyOrder_Click(object sender, EventArgs e)
        {
            OrderInitDataForSearchComponent();
            OrderLoadData();
        }

        private void OrderInitDataForSearchComponent()
        {
            OrderResetFilter();
        }

        private void OrderResetFilter()
        {
            orderTimeDescMode = true;
            if (orderTimeDescMode)
                btnSort.Text = "Sort In Ascending Date Order";
            else btnSort.Text = "Sort In Descending Date Order";

            txtOrderSearch.Text = string.Empty;
            dtpStartDate.Value = new DateTime(2015, 01, 31);
            dtpEndDate.Value = DateTime.Now;
            cbOrderStatus.SelectedIndex = 0;
        }

        private void OrderLoadData()
        {

            // Load orders
            List<Order> orders = orderRepository.GetAllOrdersOfCustomer(GlobalData.AuthenticatedUser.Username)
                            .Where(o => (
                                o.OrderTime >= dtpStartDate.Value && o.OrderTime < dtpEndDate.Value)
                                && (o.Id.ToString().Contains(txtOrderSearch.Text) || o.Name.ToLower().Contains(txtOrderSearch.Text.ToLower()))
                                && (cbOrderStatus.SelectedIndex == 0 || o.Status.Equals(cbOrderStatus.SelectedItem?.ToString()))
                            )
                            .ToList();

            if (orderTimeDescMode)
                orders = orders.OrderByDescending(o => o.OrderTime).ToList();
            else
                orders = orders.OrderBy(o => o.OrderTime).ToList();

            OrderLoadDataToGridView(orders);


        }

        private void OrderDetailLoadData()
        {
            IEnumerable<OrderDetail> orderDetails = new List<OrderDetail>();
            if (dgvOrders.DataSource != null && bindingSource.Count > 0)
            {

                Order order = bindingSource.Current as Order;
                orderDetails = order.OrderDetails;
            }

            OrderDetailLoadDataToGridView(orderDetails);


        }
        private void OrderLoadDataToGridView(IEnumerable<Order> orders)
        {
            if (orders == null)
                orders = new List<Order>()
                {
                };

            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = orders;

                OrderReBinding();

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = bindingSource;
                //dgvOrders.Columns["Id"].Visible = false;
                dgvOrders.Columns["Username"].Visible = false;

                dgvOrders.Columns["LastUpdatedTime"].Visible = false;
                dgvOrders.Columns["User"].Visible = false;
                dgvOrders.Columns["OrderDetails"].Visible = false;
                //dgvOrders.Columns["Comment"].Visible = false;
                //dgvOrders.Columns["Status"].Visible = false;

                setRowNumber(dgvOrders);



                if (orders.Count() == 0)
                {
                    // gbProduct => hide
                }
                else
                {
                    // gbProduct=> not hide

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderDetailLoadDataToGridView(IEnumerable<OrderDetail> orderDetails)
        {
            if (orderDetails == null)
                orderDetails = new List<OrderDetail>()
                {
                };

            foreach (OrderDetail detail in orderDetails)
            {
                Product product = productRepository.Get(detail.ProductId.Value);
                detail.Product = product;
            }

            try
            {
                orderDetailBindingSource = new BindingSource();
                orderDetailBindingSource.DataSource = orderDetails;

                OrderDetailReBinding();

                dgvOrderDetails.DataSource = null;
                dgvOrderDetails.DataSource = orderDetailBindingSource;
                dgvOrderDetails.Columns["Id"].Visible = false;
                dgvOrderDetails.Columns["OrderId"].Visible = false;
                dgvOrderDetails.Columns["ProductId"].Visible = false;
                dgvOrderDetails.Columns["Order"].Visible = false;
                dgvOrderDetails.Columns["Product"].DisplayIndex = 1;
                dgvOrderDetails.Columns["Product"].Width = 520;

                // Add the column to the DataGridView
                if (dgvOrderDetails.Columns["Total"] == null)
                    dgvOrderDetails.Columns.Add("Total", "Total");

                //Calculate and assign the total value for each row
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    decimal total = quantity * price;

                    row.Cells["Total"].Value = total;
                }
                dgvOrderDetails.Columns["Total"].DisplayIndex = 4;
                dgvOrderDetails.Columns["Total"].DataPropertyName = "Total";

                //dgvOrders.Columns["Comment"].Visible = false;
                //dgvOrders.Columns["Status"].Visible = false;

                setRowNumber(dgvOrderDetails);



                if (orderDetails.Count() == 0)
                {
                    // gbProduct => hide
                }
                else
                {
                    // gbProduct=> not hide

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OrderReBinding()
        {
            //gbOrderTarget.DataBindings.Clear();
            txtOrderStatus.DataBindings.Clear();
            dtpOrderTime.DataBindings.Clear();

            txtOrderReceiver.DataBindings.Clear();
            txtOrderPhone.DataBindings.Clear();
            txtOrderAddress.DataBindings.Clear();
            txtOrderMessage.DataBindings.Clear();

            txtOrderShippingFee.DataBindings.Clear();
            //txtOrderTotal.DataBindings.Clear();


            //gbProduct.DataBindings.Add("Text", bindingSource, "Name");
            txtOrderStatus.DataBindings.Add("Text", bindingSource, "Status");
            dtpOrderTime.DataBindings.Add("Text", bindingSource, "OrderTime");

            txtOrderReceiver.DataBindings.Add("Text", bindingSource, "Name");
            txtOrderPhone.DataBindings.Add("Text", bindingSource, "Phone");
            txtOrderAddress.DataBindings.Add("Text", bindingSource, "Address");
            txtOrderMessage.DataBindings.Add("Text", bindingSource, "Message");

            txtOrderShippingFee.DataBindings.Add("Text", bindingSource, "ShippingFee");
            //txtOrderTotal.DataBindings.Add("Text", bindingSource, "");

        }

        private void OrderDetailReBinding()
        {
            //gbOrderProduct.DataBindings.Clear();
            lbOrderProductName.DataBindings.Clear();
            txtOrderPrice.DataBindings.Clear();
            txtOrderQuantity.DataBindings.Clear();
            pbOrderProductAvatar.DataBindings.Clear();
            //txtOrderDetailTotal.DataBindings.Clear();


            ////gbProduct.DataBindings.Add("Text", orderDetailBindingSource, "Name");
            lbOrderProductName.DataBindings.Add("Text", orderDetailBindingSource, "Product.Name");
            txtOrderPrice.DataBindings.Add("Text", orderDetailBindingSource, "Price");
            txtOrderQuantity.DataBindings.Add("Text", orderDetailBindingSource, "Quantity");
            pbOrderProductAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", orderDetailBindingSource, "Product.Avatar", true));
            //if(dgvOrderDetails.DataSource != null)
            //    txtOrderDetailTotal.DataBindings.Add("Text", dgvOrderDetails.DataSource, "Total");

        }

        private void OrderDetailClearText()
        {
            lbOrderProductName.Text = string.Empty;
            txtOrderPrice.Text = string.Empty;
            txtOrderQuantity.Text = string.Empty;
        }

        private void tabcontrolCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrolCustomer.SelectedIndex == 0)
            {
                tabHome_Click(sender, e);
            }
            else if (tabcontrolCustomer.SelectedIndex == 1)
            {
                tabCart_Click(sender, e);
            }
            else if (tabcontrolCustomer.SelectedIndex == 2)
            {
                tabMyOrder_Click(sender, e);
            }
            else if (tabcontrolCustomer.SelectedIndex == 3)
            {
                tabMyProfile_Click(sender, e);
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            WhenSelectTheOrder();
        }

        private void WhenSelectTheOrder()
        {
            if (dgvOrders.DataSource != null && bindingSource.Count > 0)
            {
                Order order = bindingSource.Current as Order;
                gbOrderTarget.Text = "Order >> " + order.Id;
                txtOrderTotal.Text = orderRepository.GetTotalOfOrder(order.Id).ToString();
                OrderDetailLoadData();
                btnCancelOrder.Visible = order.Status.Equals("PENDING");
            }
        }
        private void WhenSelectTheOrderDetail()
        {
            if (dgvOrderDetails.DataSource != null && orderDetailBindingSource.Count > 0)
            {
                OrderDetail orderDetail = orderDetailBindingSource.Current as OrderDetail;
                txtOrderDetailTotal.Text = (orderDetail.Price * orderDetail.Quantity).ToString();
            }
        }
        private void dgvOrders_DataSourceChanged(object sender, EventArgs e)
        {
            WhenSelectTheOrder();
        }

        private void gbOrderTarget_Enter(object sender, EventArgs e)
        {

        }

        private void dgvOrderDetails_DataSourceChanged(object sender, EventArgs e)
        {
            WhenSelectTheOrderDetail();
        }

        private void dgvOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            WhenSelectTheOrderDetail();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            orderTimeDescMode = !orderTimeDescMode;
            if (orderTimeDescMode)
                btnSort.Text = "Sort In Ascending Date Order";
            else btnSort.Text = "Sort In Descending Date Order";
            OrderLoadData();
        }

        private void dtpRangeDate_ValueChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }

        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }

        private void cbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }



        private void btnCleanAllFilterOrder_Click(object sender, EventArgs e)
        {
            OrderResetFilter();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("You want to cancel this order?", "Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmResult == DialogResult.No)
            {
                // do nothing
            }
            else if (dgvOrders.DataSource != null && bindingSource.Count > 0)
            {
                Order order = bindingSource.Current as Order;
                order.Status = "CANCELLED";
                orderRepository.Update(order);
                int index = bindingSource.Position;
                OrderLoadData();
                bindingSource.Position = index;
            }
        }


        // END OF TAB HOME & ORDER AREA -------------------------------------------


        //================= TAB CART AREA =========================
        //CHOOSEN MEMORY
        private Dictionary<int, bool> memory = new Dictionary<int, bool>();
        private void CartPageReset()
        {
            cbCartFilterCategory.SelectedIndex = 0;
            cbCartSorting.SelectedIndex = 0;
            txtCartFilterName.Text = "";
            memory.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CartPageReset();
            LoadCart();
        }
        //CART EVENT TEXTCHANGED
        private void cbCartSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCartVisible();
        }
        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            SetCartVisible();
        }
        private void cbCartFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCartVisible();
        }
        //ADD TO CART
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ADD TO CART SUCCESSFULLY") == DialogResult.OK)
            {
                try
                {
                    int productId = ((Product)bindingSource.Current).Id;

                    Cart cart = new Cart
                    {
                        Username = GlobalData.AuthenticatedUser.Username,
                        ProductId = productId,
                        Quantity = 1,
                    };

                    cartRepository.Save(cart);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LoadChoosenItems()
        {
            foreach (DataGridViewRow row in dgvCarts.Rows)
            {
                int cartId = (int)row.Cells["Id"].Value;
                row.Cells["Check"].Value = (memory.ContainsKey(cartId)) ? memory[cartId] : false;
            }
        }
        private void SetCartCurrentProduct()
        {
            lbCartName.Text = "";
            txtCartPrice.Text = "";
            txtCartQuantity.Text = "";
            txtCartAvailable.Text = "";
            pbCartAvatar.ImageLocation = "";
            txtCartDescription.Text = "";

            lbCartName.DataBindings.Clear();
            txtCartPrice.DataBindings.Clear();
            txtCartQuantity.DataBindings.Clear();
            txtCartAvailable.DataBindings.Clear();
            pbCartAvatar.DataBindings.Clear();
            txtCartDescription.DataBindings.Clear();

            txtCartTotal.Text = "0";
            lblCartIndex.Text = "1";
            lbCartName.DataBindings.Add("Text", bindingSource, "Product.Name");
            txtCartPrice.DataBindings.Add("Text", bindingSource, "Product.Price");
            txtCartQuantity.DataBindings.Add("Text", bindingSource, "Quantity");
            txtCartDescription.DataBindings.Add("Text", bindingSource, "Product.Description");
            pbCartAvatar.DataBindings.Add(new System.Windows.Forms.Binding(
                                "ImageLocation", bindingSource, "Product.Avatar", true));
            try
            {
                int productId = (int)((Cart)bindingSource.Current).ProductId;
                txtCartAvailable.Text = orderRepository.GetAvailableProductQuantity(productId).ToString();
            }
            catch (Exception ex)
            {

            }
        }
        //LOAD LIST FILTER
        private List<Cart> CartFilterTheDataGridView(List<Cart> list)
        {
            list = list.Where(c => c.Product.Name.Trim().ToUpper()
                .Contains(txtCartFilterName.Text.ToUpper()))
                .ToList();

            if (cbCartFilterCategory.SelectedIndex > 0)
            {
                list = list.Where(c => c.Product.CategoryId == (int)cbCartFilterCategory.SelectedValue)
                    .ToList();
            }

            if (cbCartSorting.SelectedIndex > 0)
            {
                if (cbCartSorting.SelectedIndex == 1)
                {
                    list = list.OrderBy(c => c.Product.Price * c.Quantity).ToList();
                }
                else
                {
                    list = list.OrderByDescending(c => c.Product.Price * c.Quantity).ToList();
                }
            }
            return list;
        }

        private void SetCartVisible()
        {
            List<Cart> list = cartRepository.GetAllCartItemsByUsername(GlobalData.AuthenticatedUser.Username);
            bindingSource = new BindingSource();

            //RELOAD CART FILTER
            list = CartFilterTheDataGridView(list);

            bindingSource.DataSource = list;
            dgvCarts.DataSource = bindingSource;

            dgvCarts.Columns["ID"].Visible = false;
            dgvCarts.Columns["Username"].Visible = false;
            dgvCarts.Columns["ProductId"].Visible = false;
            dgvCarts.Columns["UsernameNavigation"].Visible = false;

            //SET DEFAULT VALUE FOR CHECKBOX
            LoadChoosenItems();
            SetCartCurrentProduct();
            LoadCartTotal();
        }

        //REFRESH CART
        private bool RefreshUserCart() => cartRepository.RefreshAllCart(GlobalData.AuthenticatedUser.Username);
        //TRONG LOADCART CO SAN REFRESH CART
        private void LoadCart()
        {
            if (RefreshUserCart())
                MessageBox.Show("YOUR CART HAS BEEN CHANGE");

            SetCartVisible();
        }
        private void LoadCartFilter()
        {
            List<Category> list = new List<Category> { new Category { Id = 0, Name = "Select the category" } };
            list.AddRange(productRepository.GetAllCategories());
            cbCartFilterCategory.DataSource = list;
            cbCartFilterCategory.ValueMember = "Id";
            cbCartFilterCategory.DisplayMember = "Name";
            cbCartFilterCategory.SelectedIndex = 0;
            cbCartSorting.SelectedIndex = 0;
        }
        private void tabCart_Click(object sender, EventArgs e)
        {
            // trig when click move to tab // START CODE IN HERE
            // example:
            LoadCartFilter();
            LoadCart();
            //SetCartVisible();
        }
        //CART CHECKOUT
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<Cart> list = new List<Cart>();
            LoadCart();

            foreach (int id in memory.Keys.Where(k => memory[k]))
            {
                list.Add(cartRepository
                            .GetCartById(GlobalData.AuthenticatedUser.Username, id));
            }

            if (list.Count > 0)
            {
                var form = new frmCheckout
                {
                    CartList = list,
                    Total = double.Parse(txtCartTotal.Text)
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("BUY SUCCESSFULLY");

                    DeleteChoosenCartItem();
                    LoadCart();
                }
            }
        }

        //CART CLICK
        private void dgvCarts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = (int)((Cart)bindingSource.Current).ProductId;
            lblCartIndex.Text = (bindingSource.Position + 1).ToString();
            txtCartAvailable.Text = orderRepository.GetAvailableProductQuantity(productId).ToString();
        }

        private void dgvCarts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCartIndex.Text = (bindingSource.Position + 1).ToString();
            int c, r;

            if (e.ColumnIndex == 0 && dgvCarts.RowCount > 0)
            {
                c = e.ColumnIndex;
                r = e.RowIndex;

                dgvCarts.Rows[r].Cells[c].Value = !((bool)dgvCarts.Rows[r].Cells[c].Value);

                bool check = (bool)dgvCarts.Rows[r].Cells[c].Value;
                int cartId = (int)dgvCarts.Rows[r].Cells["Id"].Value;

                memory[cartId] = check;
                LoadCartTotal();
            }
        }
        private void btnCartBack_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                int index = bindingSource.Position - 1;

                bindingSource.Position = index;
                lblCartIndex.Text = (index + 1).ToString();
            }
        }
        private void btnCartNext_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < dgvCarts.RowCount - 1)
            {
                int index = bindingSource.Position + 1;

                bindingSource.Position = index;
                lblCartIndex.Text = (index + 1).ToString();
            }
        }
        //LOAD TOTAL PRICE OF CART
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(txtCartQuantity.Text);
                int productId = (int)(bindingSource.Current as Cart).ProductId;

                if (quantity < orderRepository.GetAvailableProductQuantity(productId))
                {
                    Cart cart = bindingSource.Current as Cart;
                    txtCartQuantity.Text = (quantity + 1).ToString();
                    cartRepository.UpdateCartQuantityById(cart.Id, quantity + 1);
                    cart.Quantity = quantity + 1;
                    cart.LastUpdatedTime = DateTime.Now;
                    LoadCartTotal();
                    //SetCartVisible();
                }
                else
                    MessageBox.Show("QUANTITY CANNOT MORE THAN AVAILABLE");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(txtCartQuantity.Text);

                if (quantity > 1)
                {
                    Cart cart = bindingSource.Current as Cart;
                    txtCartQuantity.Text = (quantity - 1).ToString();
                    cartRepository.UpdateCartQuantityById(cart.Id, quantity - 1);
                    cart.Quantity = quantity - 1;
                    cart.LastUpdatedTime = DateTime.Now;
                    LoadCartTotal();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadCartTotal()
        {
            txtCartTotal.Text = "0";

            foreach (int cartId in memory.Keys.Where(k => memory[k]))
            {
                Cart cart = cartRepository.GetCartById(GlobalData.AuthenticatedUser.Username, cartId);

                txtCartTotal.Text = (int.Parse(txtCartTotal.Text)
                    + cart.Quantity
                    * (productRepository.Get((int)cart.ProductId).Price)).ToString();
            }
        }
        //GET ALL DATA GRID VIEW ROWS WITH STATUS OF CHECKBOX
        /*private List<DataGridViewRow> GetAllCartDataGridViewRows(bool status)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvCarts.Rows)
            {
                if ((bool)row.Cells["Check"].Value == true)
                    rows.Add(row);
            }
            return rows;
        }*/
        private void DeleteChoosenCartItem()
        {
            foreach (int id in memory.Keys.Where(i => memory[i]).ToList())
            {
                if (memory[id])
                    cartRepository.DeleteCartById(id);
            }
            memory.Clear();
        }
        private void btnCartDelete_Click(object sender, EventArgs e)
        {
            List<int> list = memory.Keys.Where(i => memory[i]).ToList();

            if (list.Count > 0 && MessageBox.Show("DO YOU WANT TO DELETE CART ITEMS?", "CONFIRM", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteChoosenCartItem();
            }

            LoadCart();
        }
        //===================================================================
        // ======================= TAB PROFILE AREA =============================
        private void tabMyProfile_Click(object sender, EventArgs e)
        {
            // trig when click move to tab // START CODE IN HERE
            // example:
            LoadUserProfile();
        }

        private void splitContainer7_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer8_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCartTotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbCartFilterCategory_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadUserProfile()
        {
            User user = userRepository.Get(GlobalData.AuthenticatedUser.Username);
            if (user == null)
            {
                MessageBox.Show("something went wrong");
            }
            else
            {
                txtUserName.Text = user.Username;
                txtEmail.Text = user.Email;
                txtRole.Text = user.Role;
                txtName.Text = user.Name;
                txtGender.Text = user.Gender == 1 ? "Male" : "Female";
                txtPhone.Text = user.Phone;
                txtAddress.Text = user.Address;
                txtYob.Text = user.Yob.ToString();
                btnSave.Visible = false;
            }
        }
        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckCharacterOfYob(String input)
        {
            string pattern = @"^\d{4,4}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckCharacter(String input)
        {
            string pattern = "^[a-zA-Z ]+$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool ValidateInputs()
        {
            if (
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtYob.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtPhone.Text)

                )

            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CheckCharacterOfPhone(txtPhone.Text) != true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số trong ô Phone từ 9 đến 12 số .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
                return false;
            }

            if (CheckCharacter(txtName.Text) != true)
            {
                MessageBox.Show("Tên không chứa chữ số .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                return false;
            }

            if (CheckCharacterOfYob(txtYob.Text) != true)
            {
                MessageBox.Show("Vui lòng chỉ nhập đúng năm sinh  .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYob.Clear();
                return false;

            }

            return true;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Cancel";
                txtName.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtYob.ReadOnly = false;
                btnSave.Visible = true;
            }
            else
            {
                btnEdit.Text = "Edit";
                ChangeReadOnly();
                LoadUserProfile();
            }
        }

        private void ChangeReadOnly()
        {
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtYob.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() == true)
            {
                User user = new User()
                {
                    Username = GlobalData.AuthenticatedUser.Username,
                    Email = GlobalData.AuthenticatedUser.Email,
                    Role = GlobalData.AuthenticatedUser.Role,
                    Password = GlobalData.AuthenticatedUser.Password,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Gender = GlobalData.AuthenticatedUser.Gender,
                    Yob = int.Parse(txtYob.Text.Trim()),
                    Address = txtAddress.Text,
                    Avatar = GlobalData.AuthenticatedUser.Avatar,
                    Enabled = GlobalData.AuthenticatedUser.Enabled
                };
                DialogResult d;
                d = MessageBox.Show($"Save User ", "Profile", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    userRepository.Save(user);
                    DialogResult = DialogResult.OK;
                    btnEdit.Text = "Edit";
                    ChangeReadOnly();
                    LoadUserProfile();
                }
            }

        }

        private void txtUnitPriceMinSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

}
