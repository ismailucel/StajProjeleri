
namespace StockManagement.WinformUI
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBottomOrder = new System.Windows.Forms.Panel();
            this.lblTotalBottom = new System.Windows.Forms.Label();
            this.lblQtyBottom = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.uCOrder = new StockManagement.WinformUI.UserControl1();
            this.lblManageOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panelBottomOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeight = 29;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column12,
            this.Column9,
            this.ProductName,
            this.Column10,
            this.Column11,
            this.CustomerName,
            this.Delete});
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Location = new System.Drawing.Point(4, -1);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(5);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.Size = new System.Drawing.Size(1463, 317);
            this.dgvOrder.TabIndex = 4;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "No";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 57;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "OrderId";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 86;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 68;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "Quantity";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 91;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "ProductId";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 133;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "ProductPrice";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 123;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "CustomerId";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 114;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 147;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // panelBottomOrder
            // 
            this.panelBottomOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelBottomOrder.Controls.Add(this.lblTotalBottom);
            this.panelBottomOrder.Controls.Add(this.lblQtyBottom);
            this.panelBottomOrder.Controls.Add(this.lblSearch);
            this.panelBottomOrder.Controls.Add(this.textBoxSearch);
            this.panelBottomOrder.Controls.Add(this.lblTotalAmount);
            this.panelBottomOrder.Controls.Add(this.lblQuantity);
            this.panelBottomOrder.Controls.Add(this.lblOrderTotal);
            this.panelBottomOrder.Controls.Add(this.uCOrder);
            this.panelBottomOrder.Controls.Add(this.lblManageOrders);
            this.panelBottomOrder.Location = new System.Drawing.Point(4, 310);
            this.panelBottomOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottomOrder.Name = "panelBottomOrder";
            this.panelBottomOrder.Size = new System.Drawing.Size(1463, 320);
            this.panelBottomOrder.TabIndex = 5;
            // 
            // lblTotalBottom
            // 
            this.lblTotalBottom.AutoSize = true;
            this.lblTotalBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalBottom.Location = new System.Drawing.Point(689, 70);
            this.lblTotalBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBottom.Name = "lblTotalBottom";
            this.lblTotalBottom.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBottom.TabIndex = 29;
            this.lblTotalBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQtyBottom
            // 
            this.lblQtyBottom.AutoSize = true;
            this.lblQtyBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQtyBottom.Location = new System.Drawing.Point(469, 70);
            this.lblQtyBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtyBottom.Name = "lblQtyBottom";
            this.lblQtyBottom.Size = new System.Drawing.Size(0, 25);
            this.lblQtyBottom.TabIndex = 28;
            this.lblQtyBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.AccessibleName = "lblSearchOrder";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(9, 24);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 25);
            this.lblSearch.TabIndex = 27;
            this.lblSearch.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AccessibleName = "textBoxSearchOrder";
            this.textBoxSearch.Location = new System.Drawing.Point(130, 26);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(225, 22);
            this.textBoxSearch.TabIndex = 26;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalAmount.Location = new System.Drawing.Point(689, 15);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(148, 25);
            this.lblTotalAmount.TabIndex = 25;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.Location = new System.Drawing.Point(469, 15);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 25);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderTotal.Location = new System.Drawing.Point(279, 70);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(74, 25);
            this.lblOrderTotal.TabIndex = 23;
            this.lblOrderTotal.Text = "Order:";
            // 
            // uCOrder
            // 
            this.uCOrder.Image = ((System.Drawing.Image)(resources.GetObject("uCOrder.Image")));
            this.uCOrder.ImageHover = ((System.Drawing.Image)(resources.GetObject("uCOrder.ImageHover")));
            this.uCOrder.ImageNormal = ((System.Drawing.Image)(resources.GetObject("uCOrder.ImageNormal")));
            this.uCOrder.Location = new System.Drawing.Point(919, 15);
            this.uCOrder.Margin = new System.Windows.Forms.Padding(4);
            this.uCOrder.Name = "uCOrder";
            this.uCOrder.Size = new System.Drawing.Size(43, 44);
            this.uCOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uCOrder.TabIndex = 22;
            this.uCOrder.TabStop = false;
            this.uCOrder.Click += new System.EventHandler(this.uCOrder_Click);
            // 
            // lblManageOrders
            // 
            this.lblManageOrders.AutoSize = true;
            this.lblManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.lblManageOrders.Location = new System.Drawing.Point(31, 70);
            this.lblManageOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageOrders.Name = "lblManageOrders";
            this.lblManageOrders.Size = new System.Drawing.Size(162, 25);
            this.lblManageOrders.TabIndex = 0;
            this.lblManageOrders.Text = "Manage Orders";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 626);
            this.Controls.Add(this.panelBottomOrder);
            this.Controls.Add(this.dgvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panelBottomOrder.ResumeLayout(false);
            this.panelBottomOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel panelBottomOrder;
        private UserControl1 uCOrder;
        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        internal System.Windows.Forms.Label lblSearch;
        internal System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblTotalBottom;
        public System.Windows.Forms.Label lblQtyBottom;
    }
}