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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.subtotalPrice = new System.Windows.Forms.Label();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.btnClearCart = new FontAwesome.Sharp.IconButton();
            this.taxPrice = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
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
            this.subtotalPrice.Location = new System.Drawing.Point(725, 1096);
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
            this.dataGridCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dataGridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCart.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCart.EnableHeadersVisualStyles = false;
            this.dataGridCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.dataGridCart.Location = new System.Drawing.Point(270, 12);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCart.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.dataGridCart.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCart.RowTemplate.Height = 28;
            this.dataGridCart.Size = new System.Drawing.Size(1800, 950);
            this.dataGridCart.TabIndex = 18;
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnClearCart.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnClearCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnClearCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearCart.IconSize = 55;
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClearCart.Location = new System.Drawing.Point(381, 1071);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClearCart.Size = new System.Drawing.Size(314, 84);
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
            this.taxPrice.Location = new System.Drawing.Point(1004, 1096);
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
            this.taxLabel.Location = new System.Drawing.Point(1003, 1002);
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
            this.totalPriceLabel.Location = new System.Drawing.Point(1334, 1096);
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
            this.totalLabel.Location = new System.Drawing.Point(1333, 1002);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(152, 64);
            this.totalLabel.TabIndex = 24;
            this.totalLabel.Text = "Total";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(2013, 1214);
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
    }
}