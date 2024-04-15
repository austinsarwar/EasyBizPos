using EasyBizPos.Models;

namespace EasyBizPos
{
    partial class CatalogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.CartIcon = new FontAwesome.Sharp.IconPictureBox();
            this.labelCartCounter = new System.Windows.Forms.Label();
            this.btnAddToCart = new FontAwesome.Sharp.IconButton();
            this.btnCartPreview = new FontAwesome.Sharp.IconButton();
            this.AddItemEntry = new FontAwesome.Sharp.IconButton();
            this.editEntry = new FontAwesome.Sharp.IconButton();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // CartIcon
            // 
            this.CartIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CartIcon.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.CartIcon.IconColor = System.Drawing.Color.White;
            this.CartIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CartIcon.IconSize = 99;
            this.CartIcon.Location = new System.Drawing.Point(1886, 57);
            this.CartIcon.Name = "CartIcon";
            this.CartIcon.Size = new System.Drawing.Size(192, 99);
            this.CartIcon.TabIndex = 1;
            this.CartIcon.TabStop = false;
            this.CartIcon.Click += new System.EventHandler(this.CartIcon_Click);
            // 
            // labelCartCounter
            // 
            this.labelCartCounter.AutoSize = true;
            this.labelCartCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.labelCartCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCartCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelCartCounter.Location = new System.Drawing.Point(2013, 110);
            this.labelCartCounter.Name = "labelCartCounter";
            this.labelCartCounter.Size = new System.Drawing.Size(0, 32);
            this.labelCartCounter.TabIndex = 2;
            this.labelCartCounter.Click += new System.EventHandler(this.labelCartCounter_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddToCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnAddToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddToCart.Location = new System.Drawing.Point(278, 1137);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(318, 97);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCartPreview
            // 
            this.btnCartPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCartPreview.FlatAppearance.BorderSize = 0;
            this.btnCartPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartPreview.ForeColor = System.Drawing.Color.White;
            this.btnCartPreview.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCartPreview.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnCartPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCartPreview.Location = new System.Drawing.Point(1102, 1137);
            this.btnCartPreview.Name = "btnCartPreview";
            this.btnCartPreview.Size = new System.Drawing.Size(318, 97);
            this.btnCartPreview.TabIndex = 18;
            this.btnCartPreview.Text = "Cart Preview";
            this.btnCartPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartPreview.UseVisualStyleBackColor = false;
            this.btnCartPreview.Click += new System.EventHandler(this.btnCartPreview_Click);
            // 
            // AddItemEntry
            // 
            this.AddItemEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddItemEntry.FlatAppearance.BorderSize = 0;
            this.AddItemEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemEntry.ForeColor = System.Drawing.Color.White;
            this.AddItemEntry.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddItemEntry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.AddItemEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddItemEntry.Location = new System.Drawing.Point(1426, 1137);
            this.AddItemEntry.Name = "AddItemEntry";
            this.AddItemEntry.Size = new System.Drawing.Size(318, 97);
            this.AddItemEntry.TabIndex = 19;
            this.AddItemEntry.Text = "Add New Item to Catalogue";
            this.AddItemEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddItemEntry.UseVisualStyleBackColor = false;
            this.AddItemEntry.Click += new System.EventHandler(this.AddToCatalogue_click);
            // 
            // editEntry
            // 
            this.editEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editEntry.FlatAppearance.BorderSize = 0;
            this.editEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEntry.ForeColor = System.Drawing.Color.White;
            this.editEntry.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editEntry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.editEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editEntry.Location = new System.Drawing.Point(1760, 1137);
            this.editEntry.Name = "editEntry";
            this.editEntry.Size = new System.Drawing.Size(318, 97);
            this.editEntry.TabIndex = 20;
            this.editEntry.Text = "Edit Product Information";
            this.editEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editEntry.UseVisualStyleBackColor = false;
            this.editEntry.Click += new System.EventHandler(this.editEntry_Click);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridCart.ColumnHeadersHeight = 100;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCart.EnableHeadersVisualStyles = false;
            this.dataGridCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.dataGridCart.Location = new System.Drawing.Point(278, 162);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridCart.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.dataGridCart.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridCart.RowTemplate.Height = 28;
            this.dataGridCart.Size = new System.Drawing.Size(1800, 951);
            this.dataGridCart.TabIndex = 19;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(2417, 1520);
            this.ControlBox = false;
            this.Controls.Add(this.btnCartPreview);
            this.Controls.Add(this.editEntry);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.AddItemEntry);
            this.Controls.Add(this.labelCartCounter);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.CartIcon);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CatalogView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private FontAwesome.Sharp.IconPictureBox CartIcon;
        private System.Windows.Forms.Label labelCartCounter;
        private FontAwesome.Sharp.IconButton btnAddToCart;
        private FontAwesome.Sharp.IconButton btnCartPreview;
        private System.Windows.Forms.DataGridView dataGridCart;
        private FontAwesome.Sharp.IconButton AddItemEntry;
        private FontAwesome.Sharp.IconButton editEntry;
    }
}