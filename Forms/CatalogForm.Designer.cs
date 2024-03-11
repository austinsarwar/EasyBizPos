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
            this.catalogView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.catalogView)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogView
            // 
            this.catalogView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catalogView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.catalogView.ColumnHeadersHeight = 34;
            this.catalogView.Location = new System.Drawing.Point(556, 169);
            this.catalogView.Name = "catalogView";
            this.catalogView.RowHeadersWidth = 62;
            this.catalogView.RowTemplate.Height = 28;
            this.catalogView.Size = new System.Drawing.Size(1440, 1082);
            this.catalogView.TabIndex = 1;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2261, 1234);
            this.ControlBox = false;
            this.Controls.Add(this.catalogView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CatalogView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.catalogView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView catalogView;
    }
}