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
            this.LoadData = new FontAwesome.Sharp.IconButton();
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            this.Close = new FontAwesome.Sharp.IconButton();
            this.SearchBtn = new FontAwesome.Sharp.IconButton();
            this.searchQuery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadData
            // 
            this.LoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.LoadData.FlatAppearance.BorderSize = 0;
            this.LoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadData.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoadData.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.LoadData.IconColor = System.Drawing.Color.Gainsboro;
            this.LoadData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoadData.IconSize = 55;
            this.LoadData.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoadData.Location = new System.Drawing.Point(501, 824);
            this.LoadData.Name = "LoadData";
            this.LoadData.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LoadData.Size = new System.Drawing.Size(250, 60);
            this.LoadData.TabIndex = 15;
            this.LoadData.Text = "Load";
            this.LoadData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadData.UseVisualStyleBackColor = false;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGrid.Location = new System.Drawing.Point(501, 211);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerDataGrid.RowHeadersWidth = 62;
            this.CustomerDataGrid.RowTemplate.Height = 28;
            this.CustomerDataGrid.Size = new System.Drawing.Size(933, 607);
            this.CustomerDataGrid.TabIndex = 16;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.Gainsboro;
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Close.IconColor = System.Drawing.Color.Gainsboro;
            this.Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close.IconSize = 55;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Close.Location = new System.Drawing.Point(1184, 824);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Close.Size = new System.Drawing.Size(250, 60);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.iconButton3_Click);
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
            this.SearchBtn.Location = new System.Drawing.Point(1184, 144);
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
            this.searchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuery.Location = new System.Drawing.Point(501, 169);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(677, 35);
            this.searchQuery.TabIndex = 18;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1697, 933);
            this.ControlBox = false;
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CustomerDataGrid);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LoadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton LoadData;
        private System.Windows.Forms.DataGridView CustomerDataGrid;
        private new FontAwesome.Sharp.IconButton Close;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private System.Windows.Forms.TextBox searchQuery;
    }
}