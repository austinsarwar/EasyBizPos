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
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.btnCartPreview = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.CartIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
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
            this.labelCartCounter.Location = new System.Drawing.Point(2064, 158);
            this.labelCartCounter.Name = "labelCartCounter";
            this.labelCartCounter.Size = new System.Drawing.Size(0, 32);
            this.labelCartCounter.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddToCart.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddToCart.Location = new System.Drawing.Point(1103, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(318, 97);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
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
            this.dataGridCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCart.ColumnHeadersHeight = 100;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCart.EnableHeadersVisualStyles = false;
            this.dataGridCart.GridColor = System.Drawing.Color.SlateBlue;
            this.dataGridCart.Location = new System.Drawing.Point(300, 193);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridCart.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCart.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridCart.RowTemplate.Height = 28;
            this.dataGridCart.Size = new System.Drawing.Size(1800, 950);
            this.dataGridCart.TabIndex = 17;
            // 
            // btnCartPreview
            // 
            this.btnCartPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCartPreview.FlatAppearance.BorderSize = 0;
            this.btnCartPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartPreview.ForeColor = System.Drawing.Color.Black;
            this.btnCartPreview.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCartPreview.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCartPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCartPreview.Location = new System.Drawing.Point(1427, 3);
            this.btnCartPreview.Name = "btnCartPreview";
            this.btnCartPreview.Size = new System.Drawing.Size(318, 97);
            this.btnCartPreview.TabIndex = 18;
            this.btnCartPreview.Text = "Cart Preview";
            this.btnCartPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartPreview.UseVisualStyleBackColor = false;
            this.btnCartPreview.Click += new System.EventHandler(this.btnCartPreview_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCartPreview);
            this.flowLayoutPanel1.Controls.Add(this.btnAddToCart);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(352, 1186);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1748, 125);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(2417, 1520);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridCart);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private FontAwesome.Sharp.IconPictureBox CartIcon;
        private System.Windows.Forms.Label labelCartCounter;
        private FontAwesome.Sharp.IconButton btnAddToCart;
        private System.Windows.Forms.DataGridView dataGridCart;
        private FontAwesome.Sharp.IconButton btnCartPreview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}