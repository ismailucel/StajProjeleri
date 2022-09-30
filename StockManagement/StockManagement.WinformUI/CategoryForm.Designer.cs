
namespace StockManagement.WinformUI
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panelBottomCategory = new System.Windows.Forms.Panel();
            this.uCCategory = new StockManagement.WinformUI.UserControl1();
            this.lblManageCategories = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panelBottomCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(972, 532);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // panelBottomCategory
            // 
            this.panelBottomCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelBottomCategory.Controls.Add(this.uCCategory);
            this.panelBottomCategory.Controls.Add(this.lblManageCategories);
            this.panelBottomCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomCategory.Location = new System.Drawing.Point(0, 529);
            this.panelBottomCategory.Name = "panelBottomCategory";
            this.panelBottomCategory.Size = new System.Drawing.Size(956, 59);
            this.panelBottomCategory.TabIndex = 3;
            // 
            // uCCategory
            // 
            this.uCCategory.Image = ((System.Drawing.Image)(resources.GetObject("uCCategory.Image")));
            this.uCCategory.ImageHover = ((System.Drawing.Image)(resources.GetObject("uCCategory.ImageHover")));
            this.uCCategory.ImageNormal = ((System.Drawing.Image)(resources.GetObject("uCCategory.ImageNormal")));
            this.uCCategory.Location = new System.Drawing.Point(929, 10);
            this.uCCategory.Name = "uCCategory";
            this.uCCategory.Size = new System.Drawing.Size(32, 36);
            this.uCCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uCCategory.TabIndex = 22;
            this.uCCategory.TabStop = false;
            this.uCCategory.Click += new System.EventHandler(this.uCCategory_Click);
            // 
            // lblManageCategories
            // 
            this.lblManageCategories.AutoSize = true;
            this.lblManageCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.lblManageCategories.Location = new System.Drawing.Point(12, 19);
            this.lblManageCategories.Name = "lblManageCategories";
            this.lblManageCategories.Size = new System.Drawing.Size(163, 19);
            this.lblManageCategories.TabIndex = 0;
            this.lblManageCategories.Text = "Manage Categories";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "No";
            this.Column2.Name = "Column2";
            this.Column2.Width = 52;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.Width = 46;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.Width = 105;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 588);
            this.Controls.Add(this.panelBottomCategory);
            this.Controls.Add(this.dgvCategory);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panelBottomCategory.ResumeLayout(false);
            this.panelBottomCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel panelBottomCategory;
        private UserControl1 uCCategory;
        private System.Windows.Forms.Label lblManageCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}