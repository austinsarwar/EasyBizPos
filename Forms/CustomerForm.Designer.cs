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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchCustomer = new FontAwesome.Sharp.IconButton();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new FontAwesome.Sharp.IconButton();
            this.btnDeleteCustomer = new FontAwesome.Sharp.IconButton();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
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
            this.btnAddCustomer.Location = new System.Drawing.Point(300, 1149);
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
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnDeleteCustomer.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnDeleteCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1786, 1149);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDeleteCustomer.Size = new System.Drawing.Size(314, 84);
            this.btnDeleteCustomer.TabIndex = 20;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomer.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCustomer.EnableHeadersVisualStyles = false;
            this.dataGridCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.dataGridCustomer.Location = new System.Drawing.Point(300, 193);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCustomer.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.dataGridCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCustomer.RowTemplate.Height = 28;
            this.dataGridCustomer.Size = new System.Drawing.Size(1800, 950);
            this.dataGridCustomer.TabIndex = 21;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnSelectCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnSelectCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnSelectCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelectCustomer.Location = new System.Drawing.Point(1456, 1149);
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
            this.ClientSize = new System.Drawing.Size(2425, 1354);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
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
        private FontAwesome.Sharp.IconButton btnDeleteCustomer;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private FontAwesome.Sharp.IconButton btnSelectCustomer;
    }
}