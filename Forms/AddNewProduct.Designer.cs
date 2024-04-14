namespace EasyBizPos.Forms
{
    partial class AddNewProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.stockText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.Label();
            this.upcText = new System.Windows.Forms.TextBox();
            this.AddRole = new System.Windows.Forms.Label();
            this.AddProductButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.label3.Location = new System.Drawing.Point(673, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 54);
            this.label3.TabIndex = 38;
            this.label3.Text = "Add Product";
            // 
            // stockText
            // 
            this.stockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockText.Location = new System.Drawing.Point(532, 395);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(683, 44);
            this.stockText.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(403, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 45);
            this.label2.TabIndex = 36;
            this.label2.Text = "Stock:";
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(532, 321);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(683, 44);
            this.priceText.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(408, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Price:";
            // 
            // productNameTxt
            // 
            this.productNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTxt.Location = new System.Drawing.Point(533, 179);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(683, 44);
            this.productNameTxt.TabIndex = 31;
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.AddName.Location = new System.Drawing.Point(274, 179);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(232, 45);
            this.AddName.TabIndex = 30;
            this.AddName.Text = "Product Name:";
            // 
            // upcText
            // 
            this.upcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcText.Location = new System.Drawing.Point(533, 251);
            this.upcText.Name = "upcText";
            this.upcText.Size = new System.Drawing.Size(683, 44);
            this.upcText.TabIndex = 35;
            // 
            // AddRole
            // 
            this.AddRole.AutoSize = true;
            this.AddRole.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.AddRole.Location = new System.Drawing.Point(417, 251);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(87, 45);
            this.AddRole.TabIndex = 32;
            this.AddRole.Text = "UPC:";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.AddProductButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.AddProductButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.AddProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddProductButton.Location = new System.Drawing.Point(966, 632);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddProductButton.Size = new System.Drawing.Size(250, 80);
            this.AddProductButton.TabIndex = 39;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1435, 833);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.upcText);
            this.Controls.Add(this.AddRole);
            this.Name = "AddNewProduct";
            this.Text = "AddNewProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton AddProductButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label AddName;
        private System.Windows.Forms.TextBox upcText;
        private System.Windows.Forms.Label AddRole;
    }
}