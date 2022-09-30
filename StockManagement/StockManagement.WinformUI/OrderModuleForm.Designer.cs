
namespace StockManagement.WinformUI
{
    partial class OrderModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModuleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopOrderModule = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lbOrderModuleHeader = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxProductSearch = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.panelTopOrderModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopOrderModule
            // 
            this.panelTopOrderModule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTopOrderModule.Controls.Add(this.pictureBoxClose);
            this.panelTopOrderModule.Controls.Add(this.lbOrderModuleHeader);
            this.panelTopOrderModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOrderModule.Location = new System.Drawing.Point(0, 0);
            this.panelTopOrderModule.Name = "panelTopOrderModule";
            this.panelTopOrderModule.Size = new System.Drawing.Size(1239, 84);
            this.panelTopOrderModule.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1191, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(48, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 51;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lbOrderModuleHeader
            // 
            this.lbOrderModuleHeader.AutoSize = true;
            this.lbOrderModuleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderModuleHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOrderModuleHeader.Location = new System.Drawing.Point(32, 29);
            this.lbOrderModuleHeader.Name = "lbOrderModuleHeader";
            this.lbOrderModuleHeader.Size = new System.Drawing.Size(144, 25);
            this.lbOrderModuleHeader.TabIndex = 0;
            this.lbOrderModuleHeader.Text = "Order Module";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeight = 29;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1,
            this.City,
            this.PhoneNumber,
            this.FullName});
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(525, 206);
            this.dgvCustomer.TabIndex = 4;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "No";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 59;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Address";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 67;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 149;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 29;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column9,
            this.Column10,
            this.Price,
            this.Column12,
            this.Description,
            this.Column4});
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(658, 202);
            this.dgvProduct.TabIndex = 5;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ProductId";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ProductName";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Quantity";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Category";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 125;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(30, 234);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(81, 25);
            this.lblSearchCustomer.TabIndex = 28;
            this.lblSearchCustomer.Text = "Search:";
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(127, 232);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(371, 26);
            this.textBoxCustomerSearch.TabIndex = 29;
            this.textBoxCustomerSearch.TextChanged += new System.EventHandler(this.textBoxCustomerSearch_TextChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Green;
            this.lblCustomer.Location = new System.Drawing.Point(24, 265);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(125, 29);
            this.lblCustomer.TabIndex = 30;
            this.lblCustomer.Text = "Customer";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(25, 310);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(124, 25);
            this.lblCustomerID.TabIndex = 31;
            this.lblCustomerID.Text = "Customer Id:";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(29, 344);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(133, 26);
            this.textBoxCustomerID.TabIndex = 32;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(25, 398);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(160, 25);
            this.lblCustomerName.TabIndex = 33;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(28, 441);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(133, 26);
            this.textBoxCustomerName.TabIndex = 34;
            // 
            // textBoxProductSearch
            // 
            this.textBoxProductSearch.Location = new System.Drawing.Point(104, 233);
            this.textBoxProductSearch.Name = "textBoxProductSearch";
            this.textBoxProductSearch.Size = new System.Drawing.Size(498, 26);
            this.textBoxProductSearch.TabIndex = 36;
            this.textBoxProductSearch.TextChanged += new System.EventHandler(this.textBoxProductSearch_TextChanged);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(30, 232);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(81, 25);
            this.lblSearchProduct.TabIndex = 35;
            this.lblSearchProduct.Text = "Search:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(21, 441);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(133, 26);
            this.textBoxProductName.TabIndex = 41;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(17, 398);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 25);
            this.lblProductName.TabIndex = 40;
            this.lblProductName.Text = "Product Name:";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(21, 353);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(133, 26);
            this.textBoxProductId.TabIndex = 39;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(17, 310);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(106, 25);
            this.lblProductId.TabIndex = 38;
            this.lblProductId.Text = "Product Id:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Green;
            this.lblProduct.Location = new System.Drawing.Point(17, 265);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(103, 29);
            this.lblProduct.TabIndex = 37;
            this.lblProduct.Text = "Product";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(19, 486);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(114, 25);
            this.lblOrderDate.TabIndex = 42;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblDateTimePicker
            // 
            this.lblDateTimePicker.Location = new System.Drawing.Point(21, 540);
            this.lblDateTimePicker.Name = "lblDateTimePicker";
            this.lblDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.lblDateTimePicker.TabIndex = 43;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(263, 323);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "Price:";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(381, 323);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(205, 26);
            this.textBoxProductPrice.TabIndex = 45;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(263, 377);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(91, 25);
            this.lblQuantity.TabIndex = 46;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(486, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 43);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(380, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.lblOrderId);
            this.panelCustomer.Controls.Add(this.dgvCustomer);
            this.panelCustomer.Controls.Add(this.textBoxCustomerSearch);
            this.panelCustomer.Controls.Add(this.lblSearchCustomer);
            this.panelCustomer.Controls.Add(this.lblCustomer);
            this.panelCustomer.Controls.Add(this.lblCustomerID);
            this.panelCustomer.Controls.Add(this.textBoxCustomerID);
            this.panelCustomer.Controls.Add(this.lblCustomerName);
            this.panelCustomer.Controls.Add(this.textBoxCustomerName);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCustomer.Location = new System.Drawing.Point(0, 84);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(525, 616);
            this.panelCustomer.TabIndex = 51;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(164, 531);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(89, 25);
            this.lblOrderId.TabIndex = 46;
            this.lblOrderId.Text = "Order Id:";
            this.lblOrderId.Visible = false;
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.textBoxTotal);
            this.panelProduct.Controls.Add(this.lblTotal);
            this.panelProduct.Controls.Add(this.numericQuantity);
            this.panelProduct.Controls.Add(this.dgvProduct);
            this.panelProduct.Controls.Add(this.lblProduct);
            this.panelProduct.Controls.Add(this.btnClear);
            this.panelProduct.Controls.Add(this.lblProductId);
            this.panelProduct.Controls.Add(this.textBoxProductSearch);
            this.panelProduct.Controls.Add(this.textBoxProductId);
            this.panelProduct.Controls.Add(this.btnSave);
            this.panelProduct.Controls.Add(this.lblProductName);
            this.panelProduct.Controls.Add(this.lblSearchProduct);
            this.panelProduct.Controls.Add(this.textBoxProductName);
            this.panelProduct.Controls.Add(this.lblQuantity);
            this.panelProduct.Controls.Add(this.lblOrderDate);
            this.panelProduct.Controls.Add(this.textBoxProductPrice);
            this.panelProduct.Controls.Add(this.lblDateTimePicker);
            this.panelProduct.Controls.Add(this.lblPrice);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelProduct.Location = new System.Drawing.Point(577, 84);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(662, 616);
            this.panelProduct.TabIndex = 52;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(381, 441);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(205, 26);
            this.textBoxTotal.TabIndex = 53;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(263, 443);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 52;
            this.lblTotal.Text = "Total:";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(381, 375);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(205, 26);
            this.numericQuantity.TabIndex = 51;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 700);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelTopOrderModule);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderModuleForm";
            this.Text = "OrderModuleForm";
            this.panelTopOrderModule.ResumeLayout(false);
            this.panelTopOrderModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopOrderModule;
        private System.Windows.Forms.Label lbOrderModuleHeader;
        internal System.Windows.Forms.DataGridView dgvCustomer;
        internal System.Windows.Forms.Panel panelCustomer;
        internal System.Windows.Forms.DataGridView dgvProduct;
        internal System.Windows.Forms.Label lblSearchCustomer;
        internal System.Windows.Forms.TextBox textBoxCustomerSearch;
        internal System.Windows.Forms.Label lblCustomer;
        internal System.Windows.Forms.Label lblCustomerID;
        internal System.Windows.Forms.TextBox textBoxCustomerID;
        internal System.Windows.Forms.Label lblCustomerName;
        internal System.Windows.Forms.TextBox textBoxCustomerName;
        internal System.Windows.Forms.TextBox textBoxProductSearch;
        internal System.Windows.Forms.Label lblSearchProduct;
        internal System.Windows.Forms.Label lblProductId;
        internal System.Windows.Forms.Label lblProduct;
        internal System.Windows.Forms.TextBox textBoxProductId;
        internal System.Windows.Forms.TextBox textBoxProductName;
        internal System.Windows.Forms.Label lblProductName;
        internal System.Windows.Forms.Label lblOrderDate;
        internal System.Windows.Forms.DateTimePicker lblDateTimePicker;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.TextBox textBoxProductPrice;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Panel panelProduct;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.NumericUpDown numericQuantity;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.TextBox textBoxTotal;
        public System.Windows.Forms.Label lblOrderId;
    }
}