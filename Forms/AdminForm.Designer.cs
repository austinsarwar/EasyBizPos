namespace EasyBizPos.Forms
{
    partial class AdminForm
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
            this.changeTaxRate = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // changeTaxRate
            // 
            this.changeTaxRate.BackColor = System.Drawing.Color.IndianRed;
            this.changeTaxRate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.changeTaxRate.IconColor = System.Drawing.Color.Black;
            this.changeTaxRate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeTaxRate.Location = new System.Drawing.Point(143, 131);
            this.changeTaxRate.Name = "changeTaxRate";
            this.changeTaxRate.Size = new System.Drawing.Size(134, 128);
            this.changeTaxRate.TabIndex = 0;
            this.changeTaxRate.Text = "Change Tax Rate";
            this.changeTaxRate.UseVisualStyleBackColor = false;
            this.changeTaxRate.Click += new System.EventHandler(this.changeTaxRate_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1727, 1083);
            this.Controls.Add(this.changeTaxRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Click += new System.EventHandler(this.changeTaxRate_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton changeTaxRate;
    }
}