using EasyBizPos.Models;

namespace EasyBizPos.Forms
{
    partial class PreviewCartForm
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
            this.dataGridCartPreview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCartPreview
            // 
            this.dataGridCartPreview.AllowUserToAddRows = false;
            this.dataGridCartPreview.AllowUserToDeleteRows = false;
            this.dataGridCartPreview.AllowUserToOrderColumns = true;
            this.dataGridCartPreview.AllowUserToResizeColumns = false;
            this.dataGridCartPreview.AllowUserToResizeRows = false;
            this.dataGridCartPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCartPreview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCartPreview.BackgroundColor = AppColors.bg;
            this.dataGridCartPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCartPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = AppColors.bg;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = AppColors.text;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCartPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCartPreview.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = AppColors.bg;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = AppColors.text;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCartPreview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCartPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCartPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridCartPreview.EnableHeadersVisualStyles = false;
            this.dataGridCartPreview.GridColor = AppColors.blue400;
            this.dataGridCartPreview.Location = new System.Drawing.Point(0, 0);
            this.dataGridCartPreview.Name = "dataGridCartPreview";
            this.dataGridCartPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridCartPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = AppColors.bg;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = AppColors.text;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCartPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCartPreview.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = AppColors.bg;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = AppColors.text;
            dataGridViewCellStyle4.SelectionBackColor = AppColors.blue400;
            dataGridViewCellStyle4.SelectionForeColor = AppColors.text;
            this.dataGridCartPreview.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCartPreview.RowTemplate.Height = 28;
            this.dataGridCartPreview.Size = new System.Drawing.Size(800, 450);
            this.dataGridCartPreview.TabIndex = 18;
            // 
            // PreviewCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridCartPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreviewCartForm";
            this.Text = "PreviewCartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCartPreview;
    }
}