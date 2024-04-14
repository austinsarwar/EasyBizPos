﻿using EasyBizPos.Models;
using System.Windows.Forms;

namespace EasyBizPos
{
    partial class HomeFormMain
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.activeUsernameLabel = new System.Windows.Forms.Label();
            this.activeUserLabel = new System.Windows.Forms.Label();
            this.activeUser = new System.Windows.Forms.Label();
            this.labelMainLogo = new System.Windows.Forms.Label();
            this.panelMdiParent = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.adminBtn = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.EmployeeBtn = new FontAwesome.Sharp.IconButton();
            this.SettingBtn = new FontAwesome.Sharp.IconButton();
            this.TransactionsBtn = new FontAwesome.Sharp.IconButton();
            this.CustomerBtn = new FontAwesome.Sharp.IconButton();
            this.CartBtn = new FontAwesome.Sharp.IconButton();
            this.CatalogBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.RegisterBtn.Location = new System.Drawing.Point(352, 343);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(0, 0);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 990);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 130);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.activeUsernameLabel);
            this.panel3.Controls.Add(this.activeUserLabel);
            this.panel3.Controls.Add(this.activeUser);
            this.panel3.Controls.Add(this.labelMainLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1295, 130);
            this.panel3.TabIndex = 18;
            // 
            // activeUsernameLabel
            // 
            this.activeUsernameLabel.AutoSize = true;
            this.activeUsernameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.activeUsernameLabel.Location = new System.Drawing.Point(155, 98);
            this.activeUsernameLabel.Name = "activeUsernameLabel";
            this.activeUsernameLabel.Size = new System.Drawing.Size(79, 29);
            this.activeUsernameLabel.TabIndex = 3;
            this.activeUsernameLabel.Text = "label1";
            // 
            // activeUserLabel
            // 
            this.activeUserLabel.AutoSize = true;
            this.activeUserLabel.ForeColor = System.Drawing.Color.White;
            this.activeUserLabel.Location = new System.Drawing.Point(149, 98);
            this.activeUserLabel.Name = "activeUserLabel";
            this.activeUserLabel.Size = new System.Drawing.Size(0, 29);
            this.activeUserLabel.TabIndex = 2;
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.ForeColor = System.Drawing.Color.White;
            this.activeUser.Location = new System.Drawing.Point(3, 98);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(140, 29);
            this.activeUser.TabIndex = 1;
            this.activeUser.Text = "Active User:";
            this.activeUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMainLogo
            // 
            this.labelMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMainLogo.AutoSize = true;
            this.labelMainLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainLogo.ForeColor = System.Drawing.Color.White;
            this.labelMainLogo.Location = new System.Drawing.Point(520, 35);
            this.labelMainLogo.Name = "labelMainLogo";
            this.labelMainLogo.Size = new System.Drawing.Size(137, 54);
            this.labelMainLogo.TabIndex = 0;
            this.labelMainLogo.Text = "Home";
            // 
            // panelMdiParent
            // 
            this.panelMdiParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panelMdiParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdiParent.Location = new System.Drawing.Point(250, 130);
            this.panelMdiParent.Name = "panelMdiParent";
            this.panelMdiParent.Size = new System.Drawing.Size(1295, 860);
            this.panelMdiParent.TabIndex = 22;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // adminBtn
            // 
            this.adminBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.adminBtn.IconChar = FontAwesome.Sharp.IconChar.Binoculars;
            this.adminBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.adminBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminBtn.IconSize = 32;
            this.adminBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.adminBtn.Location = new System.Drawing.Point(0, 610);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.adminBtn.Size = new System.Drawing.Size(250, 60);
            this.adminBtn.TabIndex = 19;
            this.adminBtn.Text = "Admin";
            this.adminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.logoutBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 32;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 550);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutBtn.Size = new System.Drawing.Size(250, 60);
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
            this.EmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.EmployeeBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.EmployeeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.EmployeeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeeBtn.IconSize = 32;
            this.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.EmployeeBtn.Location = new System.Drawing.Point(0, 490);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EmployeeBtn.Size = new System.Drawing.Size(250, 60);
            this.EmployeeBtn.TabIndex = 17;
            this.EmployeeBtn.Text = "Employee";
            this.EmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.SettingBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.SettingBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.SettingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingBtn.IconSize = 32;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingBtn.Location = new System.Drawing.Point(0, 430);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingBtn.Size = new System.Drawing.Size(250, 60);
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
            this.TransactionsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.TransactionsBtn.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.TransactionsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.TransactionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TransactionsBtn.IconSize = 32;
            this.TransactionsBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TransactionsBtn.Location = new System.Drawing.Point(0, 370);
            this.TransactionsBtn.Name = "TransactionsBtn";
            this.TransactionsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TransactionsBtn.Size = new System.Drawing.Size(250, 60);
            this.TransactionsBtn.TabIndex = 15;
            this.TransactionsBtn.Text = "transactions";
            this.TransactionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TransactionsBtn.UseVisualStyleBackColor = true;
            this.TransactionsBtn.Click += new System.EventHandler(this.TransactionsBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerBtn.FlatAppearance.BorderSize = 0;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.CustomerBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.CustomerBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.CustomerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomerBtn.IconSize = 32;
            this.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CustomerBtn.Location = new System.Drawing.Point(0, 310);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CustomerBtn.Size = new System.Drawing.Size(250, 60);
            this.CustomerBtn.TabIndex = 14;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // CartBtn
            // 
            this.CartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartBtn.FlatAppearance.BorderSize = 0;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.CartBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.CartBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.CartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CartBtn.IconSize = 32;
            this.CartBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CartBtn.Location = new System.Drawing.Point(0, 250);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CartBtn.Size = new System.Drawing.Size(250, 60);
            this.CartBtn.TabIndex = 13;
            this.CartBtn.Text = "Cart";
            this.CartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CartBtn.UseVisualStyleBackColor = true;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CatalogBtn.FlatAppearance.BorderSize = 0;
            this.CatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.CatalogBtn.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.CatalogBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.CatalogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CatalogBtn.IconSize = 32;
            this.CatalogBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CatalogBtn.Location = new System.Drawing.Point(0, 190);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CatalogBtn.Size = new System.Drawing.Size(250, 60);
            this.CatalogBtn.TabIndex = 12;
            this.CatalogBtn.Text = "Catalog";
            this.CatalogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatalogBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CatalogBtn.UseVisualStyleBackColor = true;
            this.CatalogBtn.Click += new System.EventHandler(this.CatalogBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.HomeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 32;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 130);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HomeBtn.Size = new System.Drawing.Size(250, 60);
            this.HomeBtn.TabIndex = 11;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // HomeFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1545, 990);
            this.Controls.Add(this.panelMdiParent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisterBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "HomeFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeFormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private FontAwesome.Sharp.IconButton SettingBtn;
        private FontAwesome.Sharp.IconButton TransactionsBtn;
        private FontAwesome.Sharp.IconButton CustomerBtn;
        private FontAwesome.Sharp.IconButton CartBtn;
        private FontAwesome.Sharp.IconButton CatalogBtn;
        private FontAwesome.Sharp.IconButton EmployeeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelMainLogo;
        private Panel panelMdiParent;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label activeUser;
        private Label activeUserLabel;
        private Label activeUsernameLabel;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton adminBtn;
    }
}

