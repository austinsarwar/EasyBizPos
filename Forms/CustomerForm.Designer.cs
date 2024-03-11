namespace EasyBizPos.Forms
{
    partial class CustomerForm
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
            this.SearchBtn = new FontAwesome.Sharp.IconButton();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            this.addCustomer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchBtn.IconSize = 55;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SearchBtn.Location = new System.Drawing.Point(76, 93);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SearchBtn.Size = new System.Drawing.Size(250, 60);
            this.SearchBtn.TabIndex = 17;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchQuery
            // 
            this.searchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuery.ImeMode = System.Windows.Forms.ImeMode.On;
            this.searchQuery.Location = new System.Drawing.Point(332, 93);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(1845, 53);
            this.searchQuery.TabIndex = 18;
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AllowUserToAddRows = false;
            this.CustomerDataGrid.AllowUserToDeleteRows = false;
            this.CustomerDataGrid.AllowUserToOrderColumns = true;
            this.CustomerDataGrid.AllowUserToResizeColumns = false;
            this.CustomerDataGrid.AllowUserToResizeRows = false;
            this.CustomerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CustomerDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDataGrid.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.CustomerDataGrid.Location = new System.Drawing.Point(76, 159);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerDataGrid.RowHeadersWidth = 62;
            this.CustomerDataGrid.RowTemplate.Height = 28;
            this.CustomerDataGrid.Size = new System.Drawing.Size(2101, 1052);
            this.CustomerDataGrid.TabIndex = 16;
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addCustomer.FlatAppearance.BorderSize = 0;
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.addCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.addCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.addCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addCustomer.IconSize = 55;
            this.addCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addCustomer.Location = new System.Drawing.Point(1084, 1226);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addCustomer.Size = new System.Drawing.Size(250, 60);
            this.addCustomer.TabIndex = 19;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2243, 1298);
            this.ControlBox = false;
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CustomerDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton SearchBtn;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.DataGridView CustomerDataGrid;
        private FontAwesome.Sharp.IconButton addCustomer;
    }
}