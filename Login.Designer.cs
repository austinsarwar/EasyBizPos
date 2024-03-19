namespace EasyBizPos.Forms
{
    partial class Login
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
            this.panelMdiParent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingBtn = new FontAwesome.Sharp.IconButton();
            this.TransactionsBtn = new FontAwesome.Sharp.IconButton();
            this.CustomerBtn = new FontAwesome.Sharp.IconButton();
            this.CartBtn = new FontAwesome.Sharp.IconButton();
            this.CatalogBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMainLogo = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panelMdiParent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMdiParent
            // 
            this.panelMdiParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMdiParent.Controls.Add(this.LoginBtn);
            this.panelMdiParent.Controls.Add(this.PasswordTextBox);
            this.panelMdiParent.Controls.Add(this.UsernameTextBox);
            this.panelMdiParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdiParent.Location = new System.Drawing.Point(250, 130);
            this.panelMdiParent.Name = "panelMdiParent";
            this.panelMdiParent.Size = new System.Drawing.Size(801, 672);
            this.panelMdiParent.TabIndex = 26;
            this.panelMdiParent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMdiParent_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.SettingBtn);
            this.panel1.Controls.Add(this.TransactionsBtn);
            this.panel1.Controls.Add(this.CustomerBtn);
            this.panel1.Controls.Add(this.CartBtn);
            this.panel1.Controls.Add(this.CatalogBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 672);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.SettingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingBtn.IconSize = 55;
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
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // TransactionsBtn
            // 
            this.TransactionsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionsBtn.FlatAppearance.BorderSize = 0;
            this.TransactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.TransactionsBtn.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.TransactionsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.TransactionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TransactionsBtn.IconSize = 55;
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
            this.CustomerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.CustomerBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.CustomerBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.CustomerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomerBtn.IconSize = 55;
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
            this.CartBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.CartBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.CartBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.CartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CartBtn.IconSize = 55;
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
            this.CatalogBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.CatalogBtn.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.CatalogBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.CatalogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CatalogBtn.IconSize = 55;
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
            this.HomeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.HomeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 55;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 130);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterBtn.Location = new System.Drawing.Point(352, 343);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(0, 0);
            this.RegisterBtn.TabIndex = 23;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.labelMainLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 130);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelMainLogo
            // 
            this.labelMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMainLogo.AutoSize = true;
            this.labelMainLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainLogo.ForeColor = System.Drawing.Color.White;
            this.labelMainLogo.Location = new System.Drawing.Point(482, 37);
            this.labelMainLogo.Name = "labelMainLogo";
            this.labelMainLogo.Size = new System.Drawing.Size(127, 54);
            this.labelMainLogo.TabIndex = 0;
            this.labelMainLogo.Text = "Login";
            this.labelMainLogo.Click += new System.EventHandler(this.labelMainLogo_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(395, 147);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 26);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(395, 250);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 26);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(333, 370);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 48);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 802);
            this.Controls.Add(this.panelMdiParent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.panel3);
            this.Name = "Login";
            this.Text = "Form1";
            this.panelMdiParent.ResumeLayout(false);
            this.panelMdiParent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMdiParent;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton SettingBtn;
        private FontAwesome.Sharp.IconButton TransactionsBtn;
        private FontAwesome.Sharp.IconButton CustomerBtn;
        private FontAwesome.Sharp.IconButton CartBtn;
        private FontAwesome.Sharp.IconButton CatalogBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelMainLogo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginBtn;
    }
}