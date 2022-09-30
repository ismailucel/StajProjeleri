
namespace StockManagement.WinformUI
{
    partial class CustomerModuleForm
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
            this.panelTopCustomerModule = new System.Windows.Forms.Panel();
            this.lbCustomerModuleHeader = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTopCustomerModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopCustomerModule
            // 
            this.panelTopCustomerModule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTopCustomerModule.Controls.Add(this.lbCustomerModuleHeader);
            this.panelTopCustomerModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCustomerModule.Location = new System.Drawing.Point(0, 0);
            this.panelTopCustomerModule.Name = "panelTopCustomerModule";
            this.panelTopCustomerModule.Size = new System.Drawing.Size(763, 84);
            this.panelTopCustomerModule.TabIndex = 2;
            // 
            // lbCustomerModuleHeader
            // 
            this.lbCustomerModuleHeader.AutoSize = true;
            this.lbCustomerModuleHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerModuleHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCustomerModuleHeader.Location = new System.Drawing.Point(32, 29);
            this.lbCustomerModuleHeader.Name = "lbCustomerModuleHeader";
            this.lbCustomerModuleHeader.Size = new System.Drawing.Size(145, 19);
            this.lbCustomerModuleHeader.TabIndex = 0;
            this.lbCustomerModuleHeader.Text = "Customer Module";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(222, 100);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(499, 20);
            this.textBoxId.TabIndex = 46;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(54, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 21);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "Id:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(222, 139);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(499, 20);
            this.textBoxFullName.TabIndex = 48;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(54, 141);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 21);
            this.lblFullName.TabIndex = 47;
            this.lblFullName.Text = "Full Name:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(222, 230);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(499, 20);
            this.textBoxCity.TabIndex = 52;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(54, 232);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 21);
            this.lblCity.TabIndex = 51;
            this.lblCity.Text = "City:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(222, 184);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(499, 20);
            this.textBoxAddress.TabIndex = 50;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(54, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 21);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(54, 277);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 21);
            this.lblPhone.TabIndex = 53;
            this.lblPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(222, 280);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(499, 20);
            this.textBoxPhone.TabIndex = 54;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(621, 355);
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
            this.btnUpdate.Location = new System.Drawing.Point(507, 355);
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
            this.btnSave.Location = new System.Drawing.Point(393, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CustomerModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 464);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panelTopCustomerModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerModuleForm";
            this.Text = "CustomerModuleForm";
            this.panelTopCustomerModule.ResumeLayout(false);
            this.panelTopCustomerModule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopCustomerModule;
        private System.Windows.Forms.Label lbCustomerModuleHeader;
        internal System.Windows.Forms.TextBox textBoxId;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.TextBox textBoxFullName;
        internal System.Windows.Forms.Label lblFullName;
        internal System.Windows.Forms.TextBox textBoxCity;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.TextBox textBoxAddress;
        internal System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.TextBox textBoxPhone;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
    }
}