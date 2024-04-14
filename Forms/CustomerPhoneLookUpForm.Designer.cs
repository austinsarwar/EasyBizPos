namespace EasyBizPos.Forms
{
    partial class CustomerPhoneLookUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSkip = new FontAwesome.Sharp.IconButton();
            this.btnSelect = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(205, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(173, 228);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(450, 74);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.btnSkip);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(240, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 653);
            this.panel1.TabIndex = 2;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnSkip.IconColor = System.Drawing.Color.Red;
            this.btnSkip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSkip.IconSize = 55;
            this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSkip.Location = new System.Drawing.Point(76, 391);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSkip.Size = new System.Drawing.Size(314, 85);
            this.btnSkip.TabIndex = 30;
            this.btnSkip.Text = "Skip";
            this.btnSkip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.btnSelect.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelect.IconSize = 55;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelect.Location = new System.Drawing.Point(398, 391);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSelect.Size = new System.Drawing.Size(314, 85);
            this.btnSelect.TabIndex = 29;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // CustomerPhoneLookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1433, 845);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerPhoneLookUpForm";
            this.Text = "CustomerPhoneLookUpForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSelect;
        private FontAwesome.Sharp.IconButton btnSkip;
    }
}