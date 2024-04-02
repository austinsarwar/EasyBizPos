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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Label();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.btnClearCart = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = AppColors.bg;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = AppColors.text;
            this.labelTitle.Location = new System.Drawing.Point(1053, 999);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(273, 64);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Cart Total";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.AutoSize = true;
            this.btnTotalPrice.BackColor = AppColors.bg;
            this.btnTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPrice.ForeColor = AppColors.text;
            this.btnTotalPrice.Location = new System.Drawing.Point(1097, 1093);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(54, 59);
            this.btnTotalPrice.TabIndex = 1;
            this.btnTotalPrice.Text = "0";
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
            this.dataGridCart.BackgroundColor = AppColors.bg;
            this.dataGridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = AppColors.ui;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = AppColors.text;
            dataGridViewCellStyle1.SelectionBackColor = AppColors.text;
            dataGridViewCellStyle1.SelectionForeColor = AppColors.text;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCart.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = AppColors.red400;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = AppColors.text;
            dataGridViewCellStyle2.SelectionBackColor = AppColors.text;
            dataGridViewCellStyle2.SelectionForeColor = AppColors.text;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCart.EnableHeadersVisualStyles = false;
            this.dataGridCart.GridColor = AppColors.ui2;
            this.dataGridCart.Location = new System.Drawing.Point(270, 12);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = AppColors.ui3;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = AppColors.text;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCart.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = AppColors.ui2;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = AppColors.text;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = AppColors.text;
            this.dataGridCart.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCart.RowTemplate.Height = 28;
            this.dataGridCart.Size = new System.Drawing.Size(1800, 950);
            this.dataGridCart.TabIndex = 18;
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = AppColors.bg;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = AppColors.text;
            this.btnClearCart.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnClearCart.IconColor = AppColors.text;
            this.btnClearCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearCart.IconSize = 55;
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClearCart.Location = new System.Drawing.Point(1502, 1048);
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
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.bg;
            this.ClientSize = new System.Drawing.Size(2013, 1214);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.labelTitle);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label btnTotalPrice;
        private System.Windows.Forms.DataGridView dataGridCart;
        private FontAwesome.Sharp.IconButton btnClearCart;
    }
}