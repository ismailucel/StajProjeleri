
namespace StockManagement.WinformUI
{
    partial class CategoryModuleForm
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
            this.panelTopCategoryModule = new System.Windows.Forms.Panel();
            this.lblCategoryModuleHeader = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTopCategoryModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopCategoryModule
            // 
            this.panelTopCategoryModule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTopCategoryModule.Controls.Add(this.lblCategoryModuleHeader);
            this.panelTopCategoryModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCategoryModule.Location = new System.Drawing.Point(0, 0);
            this.panelTopCategoryModule.Name = "panelTopCategoryModule";
            this.panelTopCategoryModule.Size = new System.Drawing.Size(763, 84);
            this.panelTopCategoryModule.TabIndex = 1;
            // 
            // lblCategoryModuleHeader
            // 
            this.lblCategoryModuleHeader.AutoSize = true;
            this.lblCategoryModuleHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryModuleHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoryModuleHeader.Location = new System.Drawing.Point(32, 29);
            this.lblCategoryModuleHeader.Name = "lblCategoryModuleHeader";
            this.lblCategoryModuleHeader.Size = new System.Drawing.Size(144, 19);
            this.lblCategoryModuleHeader.TabIndex = 0;
            this.lblCategoryModuleHeader.Text = "Category Module";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(207, 199);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(499, 26);
            this.textBoxDescription.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(39, 201);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 21);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(207, 156);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(499, 26);
            this.textBoxName.TabIndex = 10;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(39, 155);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(141, 21);
            this.lblCategoryName.TabIndex = 9;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(207, 113);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(499, 26);
            this.textBoxId.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(39, 115);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 21);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(606, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 43);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(492, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(378, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CategoryModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 464);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panelTopCategoryModule);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryModuleForm";
            this.Text = "CategoryModuleForm";
            this.panelTopCategoryModule.ResumeLayout(false);
            this.panelTopCategoryModule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopCategoryModule;
        private System.Windows.Forms.Label lblCategoryModuleHeader;
        internal System.Windows.Forms.TextBox textBoxDescription;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.TextBox textBoxName;
        internal System.Windows.Forms.Label lblCategoryName;
        internal System.Windows.Forms.TextBox textBoxId;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
    }
}