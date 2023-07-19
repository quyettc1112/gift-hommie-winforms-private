using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiftHommieWinforms
{

    public partial class frmStaff : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private IUserRepository userRepository = new UserRepository();
        private BindingSource bindingSource = null;
        private BindingSource bindingSourceOrderInfo = null;
        private BindingSource bindingSourceOrderShipper = null;
        private BindingSource bingdingSourceShipper = null;
        private IOrderRepository orderRepository = new OrderRepository();
        private bool orderTimeDescMode = true;
        private const string DEFAULT_AVATAR = "https://thinksport.com.au/wp-content/uploads/2020/01/avatar-.jpg";
        public frmStaff()
        {
            InitializeComponent();

        }


        // Hàm này để lấy ID của Product từ DataGrdView
        private int GetSelectedRowIdValue()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["Id"];

                if (dgvProducts.Columns["Id"].Visible == false && idCell != null && idCell.Value != null
                    && int.TryParse(idCell.Value.ToString(), out int result))
                {
                    return result;
                }
            }
            // Nếu không thể chuyển đổi thành công hoặc không có giá trị, trả về giá trị mặc định (vd: -1)
            return -1;
        }
        private void dgvProducts_Click(object sender, EventArgs e)
        {
            btnEditProduct.Visible = true;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmStaffManageProduct frm = new frmStaffManageProduct()
            {

                Product = productRepository.Get(GetSelectedRowIdValue()),
                CreateOrUpdate = true
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HomeLoadData();
            }

        }



        // Hàm này để hiển thị Product Detail và có thể Update Product
        private void DgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditProduct.Visible = true;
            frmStaffManageProduct frm = new frmStaffManageProduct()
            {

                Product = productRepository.Get(GetSelectedRowIdValue()),
                CreateOrUpdate = true
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HomeLoadData();
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            frmStaffManageProduct frm = new frmStaffManageProduct()
            {

                CreateOrUpdate = false,
                Product = new Product() { }
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HomeLoadData();
            }

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            tabHome_Click(sender, e);
        }

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
            List<Product> products = productRepository.GetAllWithFilterWithoutStatus(
                "",
                txtProductNameSearch.Text,
                txtUnitPriceMinSearch.Text, txtUnitPriceMaxSearch.Text,
                txtUnitsInStockMinSearch.Text, txtUnitsInStockMaxSearch.Text,
                ToIntOrZero(cbProductCategory.SelectedValue.ToString())
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
                dgvProducts.Columns["isDelete"].Visible = false;
                setRowNumber(dgvProducts);
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

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
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
        private bool flagBtnNext_Click = false;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbProductName_Click(object sender, EventArgs e)
        {

        }

        private void lbProductName_TextChanged(object sender, EventArgs e)
        {
            txtCurrentIndex.Text = (bindingSource.Position + 1).ToString();
            btnBack.Enabled = (bindingSource.Position != 0);
            btnNext.Enabled = flagBtnNext_Click == true || bindingSource.Position + 1 < bindingSource.Count;
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

        private void frmStaff_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult d;
            try
            {
                Product p = productRepository.Get(GetSelectedRowIdValue());
                if (p != null)
                {
                    d = MessageBox.Show("Bạn có thật sự muốn xóa hay không sản phẩm " + p.Name + "?", "Quản lý thông tin Product - Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    p.IsDelete = true;
                    if (d == DialogResult.OK)
                    {
                        productRepository.Update(p);
                        HomeLoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //------------------------Order------------------------------------


        private void tabOrder_Click(object sender, EventArgs e)
        {
            OrderInitDataForSearchComponent();
            OrderLoadData();
            //dgvOrders.CellClick += dgvOrders_CellClick;

        }



        private void OrderInitDataForSearchComponent()
        {
            OrderResetFilter();
        }
        //test
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

        public void OrderLoadData()
        {

            // Load orders
            List<Order> orders = orderRepository.GetAll()
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
            //cbStatus.Visible = false;
            OrderLoadDataToGridView(orders);


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

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = bindingSource;
                dgvOrders.Columns["Id"].Visible = false;
                dgvOrders.Columns["Username"].Visible = false;

                dgvOrders.Columns["LastUpdatedTime"].Visible = false;
                dgvOrders.Columns["User"].Visible = false;
                dgvOrders.Columns["OrderDetails"].Visible = false;
                dgvOrders.Columns["Comment"].Width = 500;
                //dgvOrders.Columns["Status"].Visible = false;

                setRowNumber(dgvOrders);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabcontrolStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrolStaff.SelectedIndex == 0)
            {
                tabHome_Click(sender, e);
            }
            else if (tabcontrolStaff.SelectedIndex == 1)
            {
                tabOrder_Click(sender, e);
            }
            else if (tabcontrolStaff.SelectedIndex == 4)
            {
                tabShipper_Click(sender, e);
            }
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            orderTimeDescMode = !orderTimeDescMode;
            if (orderTimeDescMode)
                btnSort.Text = "Sort In Ascending Date Order";
            else btnSort.Text = "Sort In Descending Date Order";
            OrderLoadData();
        }



        private int GetSelectedRowOrderIdValue()
        {

            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["Id"];

                if (dgvOrders.Columns["Id"].Visible == false && idCell != null && idCell.Value != null
                    && int.TryParse(idCell.Value.ToString(), out int result))
                {
                    return result;
                }
            }

            // Nếu không thể chuyển đổi thành công hoặc không có giá trị, trả về giá trị mặc định (vd: -1)
            return -1;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            OrderLoadData();
        }
        //test
        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmStaffOrderDetail frm = new frmStaffOrderDetail(this)
            {
                orderDetails = orderRepository.GetOrderDetails(GetSelectedRowOrderIdValue()),
                Order = orderRepository.Get(GetSelectedRowOrderIdValue())
            };
            frm.ShowDialog();
        }

        private void VbtnViewOrderDetail_Click(object sender, EventArgs e)
        {
            frmStaffOrderDetail frm = new frmStaffOrderDetail(this)
            {
                orderDetails = orderRepository.GetOrderDetails(GetSelectedRowOrderIdValue()),
                Order = orderRepository.Get(GetSelectedRowOrderIdValue())
            };
            frm.ShowDialog();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirm.Visible = false;
            btnRefuse.Visible = false;

            if (GetSelectedStatusValue().Equals("CANCELLED"))
            {
                btnConfirm.Visible = false;
                btnRefuse.Visible = false;
            }
            if (GetSelectedStatusValue().Equals("PENDING"))
            {
                btnConfirm.Visible = true;
                btnRefuse.Visible = true;
            }

            Order order = orderRepository.Get(GetSelectedRowOrderIdValue());
            if (order != null)
            {
                LoadOrderInfo(order);
            }

        }
        public void LoadOrderInfo(Order order)
        {

            bindingSourceOrderInfo = new BindingSource();
            bindingSourceOrderInfo.DataSource = order;
            txtOrderStatus.DataBindings.Clear();
            dtpOrderTime.DataBindings.Clear();

            txtOrderReceiver.DataBindings.Clear();
            txtOrderPhone.DataBindings.Clear();
            txtOrderAddress.DataBindings.Clear();
            txtOrderMessage.DataBindings.Clear();

            txtOrderShippingFee.DataBindings.Clear();
            txtOrderTotal.DataBindings.Clear();
            rComment.DataBindings.Clear();

            txtOrderStatus.DataBindings.Add("Text", bindingSourceOrderInfo, "Status");
            dtpOrderTime.DataBindings.Add("Text", bindingSourceOrderInfo, "OrderTime");

            txtOrderReceiver.DataBindings.Add("Text", bindingSourceOrderInfo, "Name");
            txtOrderPhone.DataBindings.Add("Text", bindingSourceOrderInfo, "Phone");
            txtOrderAddress.DataBindings.Add("Text", bindingSourceOrderInfo, "Address");
            txtOrderMessage.DataBindings.Add("Text", bindingSourceOrderInfo, "Message");
            rComment.DataBindings.Add("Text", bindingSourceOrderInfo, "Comment");

            txtOrderShippingFee.DataBindings.Add("Text", bindingSourceOrderInfo, "ShippingFee");

            double? total = 0;
            double? fee = order.ShippingFee;
            List<OrderDetail> orderDetails = orderRepository.GetOrderDetails(order.Id);
            for (int i = 0; i < orderDetails.Count; i++)
            {
                total = total + (orderDetails[i].Price * orderDetails[i].Quantity);

            }

            txtOrderTotal.Text = (total + fee).ToString();

        }
        private string GetSelectedStatusValue()
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["Status"];

                if (dgvOrders.Columns["Status"].Visible != false && idCell != null && idCell.Value != null)
                {
                    return idCell.Value.ToString();
                }
            }

            // Nếu không có giá trị, trả về giá trị mặc định (vd: "")
            return "";
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (GetSelectedStatusValue().Equals("PENDING"))
            {
                Order order = orderRepository.Get(GetSelectedRowOrderIdValue());
                //User user = userRepository.Get(order.Username);
                if (order != null)
                {
                    DialogResult d;
                    d = MessageBox.Show($"Conform Order ", "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                    if (d == DialogResult.OK)
                    {
                        order.Status = "CONFIRMED";
                        orderRepository.Save(order);
                        DialogResult = DialogResult.OK;
                        OrderLoadData();
                        LoadOrderInfo(order);
                    }
                }

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            if (GetSelectedStatusValue().Equals("PENDING"))
            {
                Order order = orderRepository.Get(GetSelectedRowOrderIdValue());
                //User user = userRepository.Get(order.Username);
                if (order != null)
                {
                    DialogResult d;
                    d = MessageBox.Show($"Refuse Order ", "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                    if (d == DialogResult.OK)
                    {
                        order.Status = "REFUSED";
                        orderRepository.Save(order);
                        DialogResult = DialogResult.OK;
                        OrderLoadData();
                        LoadOrderInfo(order);
                    }
                }

            }
        }

        //======================== Profile

        private void tabcontrolStaff_Click(object sender, EventArgs e)
        {
            LoadUserProfile();
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
                pbStaffAvatar.ImageLocation = DEFAULT_AVATAR;
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

        private bool CheckName(String input)
        {
            string pattern = @"\d"; // Ký tự chữ cái không phải là số
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

            if (CheckName(txtName.Text) == true)
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

        
        //====================shipper=================
        private void tabShipper_Click(object sender, EventArgs e)
        {
            LoadOrderShipping();
            LoadShipper();
            OrderShippingInitDataForSearchComponent();
        }
        private void OrderShippingInitDataForSearchComponent()
        {
            OrderShippingResetFilter();
        }
        private void OrderShippingResetFilter()
        {
            orderTimeDescMode = true;
            if (orderTimeDescMode)
                btnSortOrder.Text = "Sort In Ascending Date Order";
            else btnSortOrder.Text = "Sort In Descending Date Order";

            txtSearchOrder.Text = string.Empty;
            cboOrderStatus.SelectedIndex = 0;
        }

        private void LoadOrderShipping()
        {
            List<Order> order = orderRepository.GetAll().Where(o => o.ShippingMode == true && o.Status == "ORDERED" && o.Shipper == null
            && o.Name.ToLower().Contains(txtSearchOrder.Text.ToLower())).ToList();
            LoadDataToGridView(order);

        }

        private void LoadDataToGridView(IEnumerable<Order> orders)
        {
            if (orders == null)
                orders = new List<Order>()
                {
                };
            bindingSourceOrderShipper = new BindingSource();
            bindingSourceOrderShipper.DataSource = orders;
            dgvOrderShipping.DataSource = null;
            dgvOrderShipping.DataSource = bindingSourceOrderShipper;
            setRowNumber(dgvOrderShipping);

            txtOrderId.DataBindings.Clear();
            txtOrderId.DataBindings.Add("Text", bindingSourceOrderShipper, "Id");

            dgvOrderShipping.Columns["Id"].Visible = false;
            dgvOrderShipping.Columns["ShippingFee"].Visible = false;
            dgvOrderShipping.Columns["ShippingStatus"].Visible = false;
            dgvOrderShipping.Columns["ShipperNavigation"].Visible = false;
            dgvOrderShipping.Columns["User"].Visible = false;
            dgvOrderShipping.Columns["OrderDetails"].Visible = false;
        }

        private void LoadShipper()
        {

            bingdingSourceShipper = new BindingSource();
            List<User> users = userRepository.GetUsersByRole("SHIPPER");
            LoadShipperToGridView(users);
        }

        private void LoadShipperToGridView(IEnumerable<User> shipper)
        {
            if (shipper == null)
                shipper = new List<User>()
                {
                };
            bingdingSourceShipper = new BindingSource();
            bingdingSourceShipper.DataSource = shipper;
            dgvShipper.DataSource = bingdingSourceShipper;
            setRowNumber(dgvShipper);
            dgvShipper.Columns["Enabled"].Visible = false;
            dgvShipper.Columns["Carts"].Visible = false;
            dgvShipper.Columns["OrderShipperNavigations"].Visible = false;
            dgvShipper.Columns["OrderUsernameNavigations"].Visible = false;
            txtShipperName.DataBindings.Clear();
            txtShipperName.DataBindings.Add("Text", bingdingSourceShipper, "Username");

        }


        //orderred
        private void btnShipperAdd_Click(object sender, EventArgs e)
        {
            DialogResult d;
            try
            {
                Order order = orderRepository.Get(int.Parse(txtOrderId.Text));
                order.Shipper = txtShipperName.Text;

                if (order != null)
                {
                    d = MessageBox.Show("Bạn có thật sự muốn giao đơn hàng này không ?", "Quản lý shipper", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                    if (d == DialogResult.OK)
                    {
                        orderRepository.Save(order);
                        LoadOrderShipping();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            LoadOrderShipping();
        }

        private void btnCreateOrder_Click_1(object sender, EventArgs e)
        {
            frmCreateOrder frmCreateOrder = new frmCreateOrder();
            frmCreateOrder.ShowDialog();
            OrderInitDataForSearchComponent();
            OrderLoadData();
        }



        //=========================== Create Order

    }
}
