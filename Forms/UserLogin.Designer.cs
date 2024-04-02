using EasyBizPos.Models;

namespace EasyBizPos.Forms
{
    partial class UserLogin
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMainLogo = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panelMdiParent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMdiParent
            // 
            this.panelMdiParent.BackColor = AppColors.bg;
            this.panelMdiParent.Controls.Add(this.LoginBtn);
            this.panelMdiParent.Controls.Add(this.PasswordTextBox);
            this.panelMdiParent.Controls.Add(this.UsernameTextBox);
            this.panelMdiParent.Controls.Add(this.PasswordLabel);
            this.panelMdiParent.Controls.Add(this.UserIdLabel);
            this.panelMdiParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdiParent.Location = new System.Drawing.Point(0, 130);
            this.panelMdiParent.Name = "panelMdiParent";
            this.panelMdiParent.Size = new System.Drawing.Size(1127, 568);
            this.panelMdiParent.TabIndex = 26;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = AppColors.blue600;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.ForeColor = AppColors.text;
            this.RegisterBtn.Location = new System.Drawing.Point(352, 343);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(0, 0);
            this.RegisterBtn.TabIndex = 23;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = AppColors.ui;
            this.panel3.Controls.Add(this.labelMainLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1127, 130);
            this.panel3.TabIndex = 25;
            // 
            // labelMainLogo
            // 
            this.labelMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMainLogo.AutoSize = true;
            this.labelMainLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainLogo.ForeColor = AppColors.text;
            this.labelMainLogo.Location = new System.Drawing.Point(436, 35);
            this.labelMainLogo.Name = "labelMainLogo";
            this.labelMainLogo.Size = new System.Drawing.Size(223, 54);
            this.labelMainLogo.TabIndex = 0;
            this.labelMainLogo.Text = "User Login";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = AppColors.text;
            this.PasswordLabel.Location = new System.Drawing.Point(356, 267);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(160, 45);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.ForeColor = AppColors.text;
            this.UserIdLabel.Location = new System.Drawing.Point(356, 155);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(131, 45);
            this.UserIdLabel.TabIndex = 4;
            this.UserIdLabel.Text = "User ID:";
            this.UserIdLabel.Click += new System.EventHandler(this.AddName_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(592, 165);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(159, 35);
            this.UsernameTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(592, 267);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(159, 35);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(503, 408);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(101, 49);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.BackColor = AppColors.blue400;
            this.LoginBtn.ForeColor = AppColors.text;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 698);
            this.Controls.Add(this.panelMdiParent);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.panel3);
            this.Name = "UserLogin";
            this.Text = "Form1";
            this.panelMdiParent.ResumeLayout(false);
            this.panelMdiParent.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMdiParent;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelMainLogo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginBtn;
    }
}