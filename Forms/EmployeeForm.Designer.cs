using EasyBizPos.Models;

namespace EasyBizPos.Forms
{
    partial class EmployeeForm
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
            this.btnSearchEmployee = new FontAwesome.Sharp.IconButton();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new FontAwesome.Sharp.IconButton();
            this.btnDeleteEmployee = new FontAwesome.Sharp.IconButton();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = AppColors.bg;
            this.btnSearchEmployee.FlatAppearance.BorderSize = 0;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.ForeColor = AppColors.text;
            this.btnSearchEmployee.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchEmployee.IconColor = AppColors.text;
            this.btnSearchEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchEmployee.IconSize = 32;
            this.btnSearchEmployee.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearchEmployee.Location = new System.Drawing.Point(300, 127);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchEmployee.Size = new System.Drawing.Size(250, 60);
            this.btnSearchEmployee.TabIndex = 17;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.SearchBtn_Click);
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
            // Clock In Button
            //
            this.btnClockIn = new FontAwesome.Sharp.IconButton();
            this.btnClockIn.BackColor = AppColors.green600;
            this.btnClockIn.FlatAppearance.BorderSize = 0;
            this.btnClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockIn.ForeColor = AppColors.text;
            this.btnClockIn.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnClockIn.IconColor = AppColors.text;
            this.btnClockIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClockIn.IconSize = 32;
            this.btnClockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClockIn.Location = new System.Drawing.Point(700, 1149);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(200, 100);
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            //
            // Clock Out Button
            //
            this.btnClockOut = new FontAwesome.Sharp.IconButton();
            this.btnClockOut.BackColor = AppColors.red600;
            this.btnClockOut.FlatAppearance.BorderSize = 0;
            this.btnClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockOut.ForeColor = AppColors.text;
            this.btnClockOut.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnClockOut.IconColor = AppColors.text;
            this.btnClockOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClockOut.IconSize = 32;
            this.btnClockOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClockOut.Location = new System.Drawing.Point(900, 1149); // Adjust location as needed
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(200, 100); // Adjust size as needed
            this.btnClockOut.Text = "Clock Out";
            this.btnClockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClockOut.UseVisualStyleBackColor = false;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = AppColors.green600;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = AppColors.text;
            this.btnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnAddEmployee.IconColor = AppColors.text;
            this.btnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEmployee.IconSize = 48;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(1466, 1149);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(314, 84);
            this.btnAddEmployee.TabIndex = 19;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = AppColors.red600;
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = AppColors.text;
            this.btnDeleteEmployee.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteEmployee.IconColor = AppColors.text;
            this.btnDeleteEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteEmployee.IconSize = 48;
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(1786, 1149);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDeleteEmployee.Size = new System.Drawing.Size(314, 84);
            this.btnDeleteEmployee.TabIndex = 20;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.AllowUserToAddRows = false;
            this.dataGridEmployee.AllowUserToDeleteRows = false;
            this.dataGridEmployee.AllowUserToOrderColumns = true;
            this.dataGridEmployee.AllowUserToResizeColumns = false;
            this.dataGridEmployee.AllowUserToResizeRows = false;
            this.dataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEmployee.BackgroundColor = AppColors.bg2;
            this.dataGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = AppColors.ui2;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = AppColors.text;
            dataGridViewCellStyle13.SelectionBackColor = AppColors.text;
            dataGridViewCellStyle13.SelectionForeColor = AppColors.text;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridEmployee.ColumnHeadersHeight = 100;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = AppColors.red400;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = AppColors.text;
            dataGridViewCellStyle14.SelectionBackColor = AppColors.text;
            dataGridViewCellStyle14.SelectionForeColor = AppColors.text;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployee.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridEmployee.EnableHeadersVisualStyles = false;
            this.dataGridEmployee.GridColor = AppColors.ui2;
            this.dataGridEmployee.Location = new System.Drawing.Point(300, 193);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = AppColors.ui3;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = AppColors.text;
            dataGridViewCellStyle15.SelectionBackColor = AppColors.ui2;
            dataGridViewCellStyle15.SelectionForeColor = AppColors.text;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridEmployee.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = AppColors.ui2;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = AppColors.text;
            dataGridViewCellStyle16.SelectionBackColor = AppColors.ui2;
            dataGridViewCellStyle16.SelectionForeColor = AppColors.text;
            this.dataGridEmployee.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridEmployee.RowTemplate.Height = 28;
            this.dataGridEmployee.Size = new System.Drawing.Size(1800, 950);
            this.dataGridEmployee.TabIndex = 21;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = AppColors.bg;
            this.ClientSize = new System.Drawing.Size(2425, 1354);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnClockIn);
            this.Controls.Add(this.btnClockOut);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.dataGridEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSearchEmployee;
        private System.Windows.Forms.TextBox searchQuery;
        private FontAwesome.Sharp.IconButton btnClockIn;
        private FontAwesome.Sharp.IconButton btnClockOut;
        private FontAwesome.Sharp.IconButton btnAddEmployee;
        private FontAwesome.Sharp.IconButton btnDeleteEmployee;
        private System.Windows.Forms.DataGridView dataGridEmployee;
    }
}