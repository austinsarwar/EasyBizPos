using EasyBizPos.Models;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchCustomer = new FontAwesome.Sharp.IconButton();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new FontAwesome.Sharp.IconButton();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.transactionHistory = new FontAwesome.Sharp.IconButton();
            this.btnSelectCustomer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnSearchCustomer.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnSearchCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCustomer.IconSize = 32;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(300, 127);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchCustomer.Size = new System.Drawing.Size(250, 60);
            this.btnSearchCustomer.TabIndex = 17;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchQuery
            // 
            this.searchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuery.ImeMode = System.Windows.Forms.ImeMode.On;
            this.searchQuery.Location = new System.Drawing.Point(556, 134);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(1544, 53);
            this.searchQuery.TabIndex = 18;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnAddCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnAddCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnAddCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(1786, 1168);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(314, 84);
            this.btnAddCustomer.TabIndex = 19;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToAddRows = false;
            this.dataGridCustomer.AllowUserToDeleteRows = false;
            this.dataGridCustomer.AllowUserToOrderColumns = true;
            this.dataGridCustomer.AllowUserToResizeColumns = false;
            this.dataGridCustomer.AllowUserToResizeRows = false;
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.dataGridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridCustomer.ColumnHeadersHeight = 100;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCustomer.EnableHeadersVisualStyles = false;
            this.dataGridCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.dataGridCustomer.Location = new System.Drawing.Point(300, 193);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridCustomer.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.dataGridCustomer.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridCustomer.RowTemplate.Height = 28;
            this.dataGridCustomer.Size = new System.Drawing.Size(1800, 950);
            this.dataGridCustomer.TabIndex = 21;
            // 
            // transactionHistory
            // 
            this.transactionHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transactionHistory.FlatAppearance.BorderSize = 0;
            this.transactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.transactionHistory.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.transactionHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.transactionHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transactionHistory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.transactionHistory.Location = new System.Drawing.Point(1457, 1168);
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.transactionHistory.Size = new System.Drawing.Size(314, 84);
            this.transactionHistory.TabIndex = 23;
            this.transactionHistory.Text = "Transaction History";
            this.transactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transactionHistory.UseVisualStyleBackColor = false;
            this.transactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnSelectCustomer.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnSelectCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnSelectCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelectCustomer.Location = new System.Drawing.Point(300, 1168);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSelectCustomer.Size = new System.Drawing.Size(314, 84);
            this.btnSelectCustomer.TabIndex = 22;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(2586, 1354);
            this.ControlBox = false;
            this.Controls.Add(this.transactionHistory);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.dataGridCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSearchCustomer;
        private System.Windows.Forms.TextBox searchQuery;
        private FontAwesome.Sharp.IconButton btnAddCustomer;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private FontAwesome.Sharp.IconButton transactionHistory;
        private FontAwesome.Sharp.IconButton btnSelectCustomer;
    }
}