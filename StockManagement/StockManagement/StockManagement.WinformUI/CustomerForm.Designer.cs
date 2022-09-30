
namespace StockManagement.WinformUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panelBottomCustomer = new System.Windows.Forms.Panel();
            this.lblManageCustomers = new System.Windows.Forms.Label();
            this.uCCustomer = new StockManagement.WinformUI.UserControl1();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panelBottomCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.City,
            this.Column5,
            this.FullName,
            this.Edit,
            this.Delete});
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(0, -1);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(961, 589);
            this.dgvCustomer.TabIndex = 3;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // panelBottomCustomer
            // 
            this.panelBottomCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelBottomCustomer.Controls.Add(this.uCCustomer);
            this.panelBottomCustomer.Controls.Add(this.lblManageCustomers);
            this.panelBottomCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomCustomer.Location = new System.Drawing.Point(0, 531);
            this.panelBottomCustomer.Name = "panelBottomCustomer";
            this.panelBottomCustomer.Size = new System.Drawing.Size(1069, 58);
            this.panelBottomCustomer.TabIndex = 4;
            // 
            // lblManageCustomers
            // 
            this.lblManageCustomers.AutoSize = true;
            this.lblManageCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.lblManageCustomers.Location = new System.Drawing.Point(12, 19);
            this.lblManageCustomers.Name = "lblManageCustomers";
            this.lblManageCustomers.Size = new System.Drawing.Size(159, 19);
            this.lblManageCustomers.TabIndex = 0;
            this.lblManageCustomers.Text = "Manage Customers";
            // 
            // uCCustomer
            // 
            this.uCCustomer.Image = ((System.Drawing.Image)(resources.GetObject("uCCustomer.Image")));
            this.uCCustomer.ImageHover = ((System.Drawing.Image)(resources.GetObject("uCCustomer.ImageHover")));
            this.uCCustomer.ImageNormal = ((System.Drawing.Image)(resources.GetObject("uCCustomer.ImageNormal")));
            this.uCCustomer.Location = new System.Drawing.Point(929, 10);
            this.uCCustomer.Name = "uCCustomer";
            this.uCCustomer.Size = new System.Drawing.Size(32, 36);
            this.uCCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uCCustomer.TabIndex = 22;
            this.uCCustomer.TabStop = false;
            this.uCCustomer.Click += new System.EventHandler(this.uCCustomer_Click);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "No";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.Width = 45;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Width = 56;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 589);
            this.Controls.Add(this.panelBottomCustomer);
            this.Controls.Add(this.dgvCustomer);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panelBottomCustomer.ResumeLayout(false);
            this.panelBottomCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panelBottomCustomer;
        private UserControl1 uCCustomer;
        private System.Windows.Forms.Label lblManageCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}