using EasyBizPos.Models;
namespace EasyBizPos.Forms
{
    partial class AddCustomer
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
            this.AddName = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddName.ForeColor = AppColors.text;
            this.AddName.Location = new System.Drawing.Point(293, 178);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(171, 45);
            this.AddName.TabIndex = 0;
            this.AddName.Text = "Full Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(461, 178);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(683, 44);
            this.nameTxt.TabIndex = 1;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(461, 291);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(683, 44);
            this.phoneNumberTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = AppColors.text;
            this.label1.Location = new System.Drawing.Point(212, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone Number:";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(461, 411);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(683, 44);
            this.emailTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = AppColors.text;
            this.label2.Location = new System.Drawing.Point(332, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = AppColors.ui;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = AppColors.text;
            this.label3.Location = new System.Drawing.Point(601, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Customer";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = AppColors.blue400;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = AppColors.text;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButton1.IconColor = AppColors.text;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 48;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(894, 589);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(250, 80);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.Text = "Add Customer";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = AppColors.ui;
            this.ClientSize = new System.Drawing.Size(1491, 984);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.AddName);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddName;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}