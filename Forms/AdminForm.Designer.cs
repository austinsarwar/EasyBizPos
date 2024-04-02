using EasyBizPos.Models;
using System.Windows.Forms;

namespace EasyBizPos.Forms
{
    partial class AdminForm
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
            this.adminBtn = new FontAwesome.Sharp.IconButton();
            this.activeUser = new System.Windows.Forms.Label();
            this.labelMainLogo = new System.Windows.Forms.Label();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.EmployeeBtn = new FontAwesome.Sharp.IconButton();
            this.SettingBtn = new FontAwesome.Sharp.IconButton();
            this.TransactionsBtn = new FontAwesome.Sharp.IconButton();
            this.CustomerBtn = new FontAwesome.Sharp.IconButton();
            this.CartBtn = new FontAwesome.Sharp.IconButton();
            this.activeUsernameLabel = new System.Windows.Forms.Label();
            this.activeUserLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CatalogBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panelMdiParent = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.ForeColor = AppColors.text;
            this.adminBtn.IconChar = FontAwesome.Sharp.IconChar.Binoculars;
            this.adminBtn.IconColor = AppColors.text;
            this.adminBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminBtn.IconSize = 32;
            this.adminBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.adminBtn.Location = new System.Drawing.Point(0, 396);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.adminBtn.Size = new System.Drawing.Size(167, 39);
            this.adminBtn.TabIndex = 19;
            this.adminBtn.Text = "Admin";
            this.adminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminBtn.UseVisualStyleBackColor = true;
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.ForeColor = AppColors.text;
            this.activeUser.Location = new System.Drawing.Point(2, 64);
            this.activeUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(65, 13);
            this.activeUser.TabIndex = 1;
            this.activeUser.Text = "Active User:";
            // 
            // labelMainLogo
            // 
            this.labelMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMainLogo.AutoSize = true;
            this.labelMainLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainLogo.ForeColor = AppColors.text;
            this.labelMainLogo.Location = new System.Drawing.Point(263, 23);
            this.labelMainLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainLogo.Name = "labelMainLogo";
            this.labelMainLogo.Size = new System.Drawing.Size(102, 37);
            this.labelMainLogo.TabIndex = 0;
            this.labelMainLogo.Text = "Admin";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = AppColors.text;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.logoutBtn.IconColor = AppColors.text;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 32;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 357);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.logoutBtn.Size = new System.Drawing.Size(167, 39);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBtn.ForeColor = AppColors.text;
            this.EmployeeBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.EmployeeBtn.IconColor = AppColors.text;
            this.EmployeeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeeBtn.IconSize = 32;
            this.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.EmployeeBtn.Location = new System.Drawing.Point(0, 318);
            this.EmployeeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.EmployeeBtn.Size = new System.Drawing.Size(167, 39);
            this.EmployeeBtn.TabIndex = 17;
            this.EmployeeBtn.Text = "Employee";
            this.EmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // SettingBtn
            // 
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.ForeColor = AppColors.text;
            this.SettingBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.SettingBtn.IconColor = AppColors.text;
            this.SettingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingBtn.IconSize = 32;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingBtn.Location = new System.Drawing.Point(0, 279);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.SettingBtn.Size = new System.Drawing.Size(167, 39);
            this.SettingBtn.TabIndex = 16;
            this.SettingBtn.Text = "Setting";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingBtn.UseVisualStyleBackColor = true;
            // 
            // TransactionsBtn
            // 
            this.TransactionsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionsBtn.FlatAppearance.BorderSize = 0;
            this.TransactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsBtn.ForeColor = AppColors.text;
            this.TransactionsBtn.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.TransactionsBtn.IconColor = AppColors.text;
            this.TransactionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TransactionsBtn.IconSize = 32;
            this.TransactionsBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TransactionsBtn.Location = new System.Drawing.Point(0, 240);
            this.TransactionsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransactionsBtn.Name = "TransactionsBtn";
            this.TransactionsBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.TransactionsBtn.Size = new System.Drawing.Size(167, 39);
            this.TransactionsBtn.TabIndex = 15;
            this.TransactionsBtn.Text = "transactions";
            this.TransactionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TransactionsBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerBtn.FlatAppearance.BorderSize = 0;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.ForeColor = AppColors.text;
            this.CustomerBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.CustomerBtn.IconColor = AppColors.text;
            this.CustomerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomerBtn.IconSize = 32;
            this.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CustomerBtn.Location = new System.Drawing.Point(0, 201);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.CustomerBtn.Size = new System.Drawing.Size(167, 39);
            this.CustomerBtn.TabIndex = 14;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomerBtn.UseVisualStyleBackColor = true;
            // 
            // CartBtn
            // 
            this.CartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartBtn.FlatAppearance.BorderSize = 0;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.ForeColor = AppColors.text;
            this.CartBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.CartBtn.IconColor = AppColors.text;
            this.CartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CartBtn.IconSize = 32;
            this.CartBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CartBtn.Location = new System.Drawing.Point(0, 162);
            this.CartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.CartBtn.Size = new System.Drawing.Size(167, 39);
            this.CartBtn.TabIndex = 13;
            this.CartBtn.Text = "Cart";
            this.CartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CartBtn.UseVisualStyleBackColor = true;
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.ForeColor = AppColors.text;
            this.activeUsernameLabel.Location = new System.Drawing.Point(103, 64);
            this.activeUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(35, 13);
            this.activeUsernameLabel.TabIndex = 3;
            this.activeUsernameLabel.Text = "label1";
            // 
            // activeUserLabel
            // 
            this.activeUserLabel.AutoSize = true;
            this.activeUserLabel.ForeColor = AppColors.text;
            this.activeUserLabel.Location = new System.Drawing.Point(99, 64);
            this.activeUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeUserLabel.Name = "activeUserLabel";
            this.activeUserLabel.Size = new System.Drawing.Size(0, 13);
            this.activeUserLabel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.activeUsernameLabel);
            this.panel3.Controls.Add(this.activeUserLabel);
            this.panel3.Controls.Add(this.activeUser);
            this.panel3.Controls.Add(this.labelMainLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 84);
            this.panel3.TabIndex = 25;
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CatalogBtn.FlatAppearance.BorderSize = 0;
            this.CatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogBtn.ForeColor = AppColors.text;
            this.CatalogBtn.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.CatalogBtn.IconColor = AppColors.text;
            this.CatalogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CatalogBtn.IconSize = 32;
            this.CatalogBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CatalogBtn.Location = new System.Drawing.Point(0, 123);
            this.CatalogBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.CatalogBtn.Size = new System.Drawing.Size(167, 39);
            this.CatalogBtn.TabIndex = 12;
            this.CatalogBtn.Text = "Catalog";
            this.CatalogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatalogBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CatalogBtn.UseVisualStyleBackColor = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = AppColors.text;
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.HomeBtn.IconColor = AppColors.text;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 32;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 84);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.HomeBtn.Size = new System.Drawing.Size(167, 39);
            this.HomeBtn.TabIndex = 11;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = AppColors.ui;
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.EmployeeBtn);
            this.panel1.Controls.Add(this.SettingBtn);
            this.panel1.Controls.Add(this.TransactionsBtn);
            this.panel1.Controls.Add(this.CustomerBtn);
            this.panel1.Controls.Add(this.CartBtn);
            this.panel1.Controls.Add(this.CatalogBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 471);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = AppColors.ui2;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 84);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = AppColors.bg;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.ForeColor = AppColors.text;
            this.RegisterBtn.Location = new System.Drawing.Point(235, 223);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(0, 0);
            this.RegisterBtn.TabIndex = 23;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // panelMdiParent
            // 
            this.panelMdiParent.BackColor = AppColors.bg;
            this.panelMdiParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdiParent.Location = new System.Drawing.Point(0, 0);
            this.panelMdiParent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMdiParent.Name = "panelMdiParent";
            this.panelMdiParent.Size = new System.Drawing.Size(863, 471);
            this.panelMdiParent.TabIndex = 26;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.panelMdiParent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton adminBtn;
        private System.Windows.Forms.Label activeUser;
        private System.Windows.Forms.Label labelMainLogo;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton EmployeeBtn;
        private FontAwesome.Sharp.IconButton SettingBtn;
        private FontAwesome.Sharp.IconButton TransactionsBtn;
        private FontAwesome.Sharp.IconButton CustomerBtn;
        private FontAwesome.Sharp.IconButton CartBtn;
        private System.Windows.Forms.Label activeUsernameLabel;
        private System.Windows.Forms.Label activeUserLabel;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton CatalogBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panelMdiParent;
        private PaintEventHandler panel2_Paint;
    }
}