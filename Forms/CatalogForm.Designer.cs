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
            this.catView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.CatalogBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catView
            // 
            this.catView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catView.Location = new System.Drawing.Point(600, 101);
            this.catView.Name = "catView";
            this.catView.RowHeadersWidth = 62;
            this.catView.RowTemplate.Height = 28;
            this.catView.Size = new System.Drawing.Size(439, 485);
            this.catView.TabIndex = 0;
            this.catView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.CustomerBtn);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.CatalogBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1800);
            this.panel1.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeBtn.Location = new System.Drawing.Point(96, 197);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(208, 81);
            this.HomeBtn.TabIndex = 5;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CustomerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerBtn.Location = new System.Drawing.Point(96, 371);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(208, 81);
            this.CustomerBtn.TabIndex = 4;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.UseVisualStyleBackColor = false;
            this.CustomerBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegisterBtn.Location = new System.Drawing.Point(96, 284);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(208, 81);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CatalogBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CatalogBtn.Location = new System.Drawing.Point(96, 458);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Size = new System.Drawing.Size(208, 81);
            this.CatalogBtn.TabIndex = 2;
            this.CatalogBtn.Text = "Catalog";
            this.CatalogBtn.UseVisualStyleBackColor = false;
            this.CatalogBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RefreshBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshBtn.Location = new System.Drawing.Point(1374, 882);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(173, 64);
            this.RefreshBtn.TabIndex = 6;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Catalog";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.catView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CatalogView";
            this.Load += new System.EventHandler(this.CatalogView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button CatalogBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
    }
}