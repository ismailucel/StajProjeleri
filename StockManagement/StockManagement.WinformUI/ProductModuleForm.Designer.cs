
namespace StockManagement.WinformUI
{
    partial class ProductModuleForm
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
            this.panelTopProductModule = new System.Windows.Forms.Panel();
            this.panelTopUserModele = new System.Windows.Forms.Panel();
            this.lblProductModuleHeader = new System.Windows.Forms.Label();
            this.lblProductOrderModule = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTopProductModule.SuspendLayout();
            this.panelTopUserModele.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopProductModule
            // 
            this.panelTopProductModule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTopProductModule.Controls.Add(this.panelTopUserModele);
            this.panelTopProductModule.Controls.Add(this.lblProductOrderModule);
            this.panelTopProductModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopProductModule.Location = new System.Drawing.Point(0, 0);
            this.panelTopProductModule.Name = "panelTopProductModule";
            this.panelTopProductModule.Size = new System.Drawing.Size(778, 84);
            this.panelTopProductModule.TabIndex = 2;
            // 
            // panelTopUserModele
            // 
            this.panelTopUserModele.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTopUserModele.Controls.Add(this.lblProductModuleHeader);
            this.panelTopUserModele.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopUserModele.Location = new System.Drawing.Point(0, 0);
            this.panelTopUserModele.Name = "panelTopUserModele";
            this.panelTopUserModele.Size = new System.Drawing.Size(778, 84);
            this.panelTopUserModele.TabIndex = 2;
            // 
            // lblProductModuleHeader
            // 
            this.lblProductModuleHeader.AutoSize = true;
            this.lblProductModuleHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductModuleHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductModuleHeader.Location = new System.Drawing.Point(32, 29);
            this.lblProductModuleHeader.Name = "lblProductModuleHeader";
            this.lblProductModuleHeader.Size = new System.Drawing.Size(131, 19);
            this.lblProductModuleHeader.TabIndex = 0;
            this.lblProductModuleHeader.Text = "Product Module";
            // 
            // lblProductOrderModule
            // 
            this.lblProductOrderModule.AutoSize = true;
            this.lblProductOrderModule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductOrderModule.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductOrderModule.Location = new System.Drawing.Point(32, 29);
            this.lblProductOrderModule.Name = "lblProductOrderModule";
            this.lblProductOrderModule.Size = new System.Drawing.Size(144, 19);
            this.lblProductOrderModule.TabIndex = 0;
            this.lblProductOrderModule.Text = "Category Module";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(48, 340);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 21);
            this.lblCategory.TabIndex = 53;
            this.lblCategory.Text = "Category";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(216, 292);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(499, 20);
            this.textBoxDescription.TabIndex = 52;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(48, 292);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 21);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Description";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(216, 243);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(499, 20);
            this.textBoxQuantity.TabIndex = 50;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(48, 242);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(84, 21);
            this.lblQuantity.TabIndex = 49;
            this.lblQuantity.Text = "Quantity:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(216, 190);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(499, 20);
            this.textBoxPrice.TabIndex = 48;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(48, 192);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 21);
            this.lblPrice.TabIndex = 47;
            this.lblPrice.Text = "Price:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(216, 147);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(499, 20);
            this.textBoxProductName.TabIndex = 46;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(48, 146);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(128, 21);
            this.lblProductName.TabIndex = 45;
            this.lblProductName.Text = "Product Name:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(216, 104);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(499, 20);
            this.textBoxId.TabIndex = 44;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(48, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 21);
            this.lblId.TabIndex = 43;
            this.lblId.Text = "Id:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(216, 340);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(499, 21);
            this.comboBoxCategory.TabIndex = 54;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(615, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 43);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(501, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(387, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 513);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panelTopProductModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductModuleForm";
            this.Text = "ProductModuleForm";
            this.panelTopProductModule.ResumeLayout(false);
            this.panelTopProductModule.PerformLayout();
            this.panelTopUserModele.ResumeLayout(false);
            this.panelTopUserModele.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopProductModule;
        private System.Windows.Forms.Label lblProductOrderModule;
        private System.Windows.Forms.Panel panelTopUserModele;
        private System.Windows.Forms.Label lblProductModuleHeader;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.TextBox textBoxDescription;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.TextBox textBoxQuantity;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.TextBox textBoxPrice;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.TextBox textBoxProductName;
        internal System.Windows.Forms.Label lblProductName;
        internal System.Windows.Forms.TextBox textBoxId;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.ComboBox comboBoxCategory;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
    }
}