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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.CartIcon = new FontAwesome.Sharp.IconPictureBox();
            this.labelCartCounter = new System.Windows.Forms.Label();
            this.btnAddToCart = new FontAwesome.Sharp.IconButton();
            this.dataGridCatalog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalog)).BeginInit();
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
            this.CartIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.CartIcon.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.CartIcon.IconColor = System.Drawing.Color.White;
            this.CartIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CartIcon.IconSize = 110;
            this.CartIcon.Location = new System.Drawing.Point(1953, 102);
            this.CartIcon.Name = "CartIcon";
            this.CartIcon.Size = new System.Drawing.Size(284, 110);
            this.CartIcon.TabIndex = 1;
            this.CartIcon.TabStop = false;
            // 
            // labelCartCounter
            // 
            this.labelCartCounter.AutoSize = true;
            this.labelCartCounter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCartCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCartCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartCounter.ForeColor = System.Drawing.Color.Black;
            this.labelCartCounter.Location = new System.Drawing.Point(2064, 142);
            this.labelCartCounter.Name = "labelCartCounter";
            this.labelCartCounter.Size = new System.Drawing.Size(31, 32);
            this.labelCartCounter.TabIndex = 2;
            this.labelCartCounter.Text = "0";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddToCart.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddToCart.Location = new System.Drawing.Point(1777, 1149);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(318, 97);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dataGridCatalog
            // 
            this.dataGridCatalog.AllowUserToAddRows = false;
            this.dataGridCatalog.AllowUserToDeleteRows = false;
            this.dataGridCatalog.AllowUserToOrderColumns = true;
            this.dataGridCatalog.AllowUserToResizeColumns = false;
            this.dataGridCatalog.AllowUserToResizeRows = false;
            this.dataGridCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCatalog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCatalog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCatalog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCatalog.ColumnHeadersHeight = 100;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCatalog.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCatalog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCatalog.EnableHeadersVisualStyles = false;
            this.dataGridCatalog.GridColor = System.Drawing.Color.SlateBlue;
            this.dataGridCatalog.Location = new System.Drawing.Point(300, 193);
            this.dataGridCatalog.Name = "dataGridCatalog";
            this.dataGridCatalog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCatalog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCatalog.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridCatalog.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCatalog.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridCatalog.RowTemplate.Height = 28;
            this.dataGridCatalog.Size = new System.Drawing.Size(1800, 950);
            this.dataGridCatalog.TabIndex = 17;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(2417, 1520);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridCatalog);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.labelCartCounter);
            this.Controls.Add(this.CartIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CatalogView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private FontAwesome.Sharp.IconPictureBox CartIcon;
        private System.Windows.Forms.Label labelCartCounter;
        private FontAwesome.Sharp.IconButton btnAddToCart;
        private System.Windows.Forms.DataGridView dataGridCatalog;
    }
}