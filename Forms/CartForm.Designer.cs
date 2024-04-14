using EasyBizPos.Models;

namespace EasyBizPos.Forms
{
    partial class CartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.subtotalPrice = new System.Windows.Forms.Label();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.btnClearCart = new FontAwesome.Sharp.IconButton();
            this.taxPrice = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxRateTitle = new System.Windows.Forms.Label();
            this.taxRateLabel = new System.Windows.Forms.Label();
            this.btnCheckout = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.labelSubtotal.Location = new System.Drawing.Point(724, 1002);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(233, 64);
            this.labelSubtotal.TabIndex = 0;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // subtotalPrice
            // 
            this.subtotalPrice.AutoSize = true;
            this.subtotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.subtotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.subtotalPrice.Location = new System.Drawing.Point(724, 1095);
            this.subtotalPrice.Name = "subtotalPrice";
            this.subtotalPrice.Size = new System.Drawing.Size(54, 59);
            this.subtotalPrice.TabIndex = 1;
            this.subtotalPrice.Text = "0";
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.AllowUserToDeleteRows = false;
            this.dataGridCart.AllowUserToOrderColumns = true;
            this.dataGridCart.AllowUserToResizeColumns = false;
            this.dataGridCart.AllowUserToResizeRows = false;
            this.dataGridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.dataGridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCart.ColumnHeadersHeight = 100;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCart.EnableHeadersVisualStyles = false;
            this.dataGridCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.dataGridCart.Location = new System.Drawing.Point(270, 12);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridCart.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.dataGridCart.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridCart.RowTemplate.Height = 28;
            this.dataGridCart.Size = new System.Drawing.Size(1800, 951);
            this.dataGridCart.TabIndex = 18;
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnClearCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnClearCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearCart.IconSize = 55;
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClearCart.Location = new System.Drawing.Point(381, 1071);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClearCart.Size = new System.Drawing.Size(314, 85);
            this.btnClearCart.TabIndex = 21;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // taxPrice
            // 
            this.taxPrice.AutoSize = true;
            this.taxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.taxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.taxPrice.Location = new System.Drawing.Point(1004, 1095);
            this.taxPrice.Name = "taxPrice";
            this.taxPrice.Size = new System.Drawing.Size(54, 59);
            this.taxPrice.TabIndex = 23;
            this.taxPrice.Text = "0";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.taxLabel.Location = new System.Drawing.Point(1004, 1002);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(275, 64);
            this.taxLabel.TabIndex = 22;
            this.taxLabel.Text = "Sales Tax";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.totalPriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(1334, 1095);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(54, 59);
            this.totalPriceLabel.TabIndex = 25;
            this.totalPriceLabel.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.totalLabel.Location = new System.Drawing.Point(1334, 1002);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(152, 64);
            this.totalLabel.TabIndex = 24;
            this.totalLabel.Text = "Total";
            // 
            // taxRateTitle
            // 
            this.taxRateTitle.AutoSize = true;
            this.taxRateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.taxRateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.taxRateTitle.Location = new System.Drawing.Point(1048, 965);
            this.taxRateTitle.Name = "taxRateTitle";
            this.taxRateTitle.Size = new System.Drawing.Size(115, 29);
            this.taxRateTitle.TabIndex = 26;
            this.taxRateTitle.Text = "Tax Rate:";
            // 
            // taxRateLabel
            // 
            this.taxRateLabel.AutoSize = true;
            this.taxRateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.taxRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.taxRateLabel.Location = new System.Drawing.Point(1190, 965);
            this.taxRateLabel.Name = "taxRateLabel";
            this.taxRateLabel.Size = new System.Drawing.Size(26, 29);
            this.taxRateLabel.TabIndex = 27;
            this.taxRateLabel.Text = "0";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCheckout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckout.IconSize = 55;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCheckout.Location = new System.Drawing.Point(1536, 1071);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCheckout.Size = new System.Drawing.Size(314, 85);
            this.btnCheckout.TabIndex = 28;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(852, 1241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Customer Name:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.White;
            this.labelCustomerName.Location = new System.Drawing.Point(1104, 1244);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(298, 32);
            this.labelCustomerName.TabIndex = 30;
            this.labelCustomerName.Text = "No Customer Selected";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(2564, 1570);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.taxRateLabel);
            this.Controls.Add(this.taxRateTitle);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxPrice);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.subtotalPrice);
            this.Controls.Add(this.labelSubtotal);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label subtotalPrice;
        private System.Windows.Forms.DataGridView dataGridCart;
        private FontAwesome.Sharp.IconButton btnClearCart;
        private System.Windows.Forms.Label taxPrice;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxRateTitle;
        private System.Windows.Forms.Label taxRateLabel;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustomerName;
    }
}