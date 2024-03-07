namespace EasyBizPos
{
    partial class CustomerInfoView
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
            this.CatalogBtn = new System.Windows.Forms.Button();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.CustomerInfoBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CatalogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CatalogBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatalogBtn.Location = new System.Drawing.Point(134, 340);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Size = new System.Drawing.Size(208, 81);
            this.CatalogBtn.TabIndex = 0;
            this.CatalogBtn.Text = "Catalog";
            this.CatalogBtn.UseVisualStyleBackColor = false;
            this.CatalogBtn.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // customerView
            // 
            this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerView.Location = new System.Drawing.Point(708, 182);
            this.customerView.Name = "customerView";
            this.customerView.RowHeadersWidth = 62;
            this.customerView.RowTemplate.Height = 28;
            this.customerView.Size = new System.Drawing.Size(851, 796);
            this.customerView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.CustomerInfoBtn);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.CatalogBtn);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1800);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(68, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "EasyBizPos";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Location = new System.Drawing.Point(134, 219);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(208, 81);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // CustomerInfoBtn
            // 
            this.CustomerInfoBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CustomerInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CustomerInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerInfoBtn.Location = new System.Drawing.Point(134, 611);
            this.CustomerInfoBtn.Name = "CustomerInfoBtn";
            this.CustomerInfoBtn.Size = new System.Drawing.Size(208, 81);
            this.CustomerInfoBtn.TabIndex = 2;
            this.CustomerInfoBtn.Text = "Customer Info";
            this.CustomerInfoBtn.UseVisualStyleBackColor = false;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterBtn.Location = new System.Drawing.Point(134, 477);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(208, 81);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1386, 984);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Refresh);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Information";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(1346, 118);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(230, 49);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(883, 127);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(457, 26);
            this.SearchText.TabIndex = 6;
            // 
            // CustomerInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1778, 1544);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerView);
            this.Name = "CustomerInfoView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatalogBtn;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CustomerInfoBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchText;
    }
}

