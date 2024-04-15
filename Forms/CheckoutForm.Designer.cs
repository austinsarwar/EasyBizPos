namespace EasyBizPos.Forms
{
    partial class CheckoutForm
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
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterCash = new System.Windows.Forms.TextBox();
            this.cardBtn = new FontAwesome.Sharp.IconButton();
            this.cashBtn = new FontAwesome.Sharp.IconButton();
            this.btnCompleteTransaction = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(283, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount Due:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.totalPriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(517, 408);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(37, 40);
            this.totalPriceLabel.TabIndex = 26;
            this.totalPriceLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(538, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "OR";
            // 
            // txtEnterCash
            // 
            this.txtEnterCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCash.Location = new System.Drawing.Point(144, 477);
            this.txtEnterCash.Multiline = true;
            this.txtEnterCash.Name = "txtEnterCash";
            this.txtEnterCash.Size = new System.Drawing.Size(410, 78);
            this.txtEnterCash.TabIndex = 29;
            this.txtEnterCash.TextChanged += new System.EventHandler(this.txtEnterCash_TextChanged);
            // 
            // cardBtn
            // 
            this.cardBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cardBtn.FlatAppearance.BorderSize = 0;
            this.cardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.cardBtn.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.cardBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.cardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cardBtn.Location = new System.Drawing.Point(524, 237);
            this.cardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(286, 102);
            this.cardBtn.TabIndex = 1;
            this.cardBtn.Text = "Card";
            this.cardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cardBtn.UseVisualStyleBackColor = false;
            // 
            // cashBtn
            // 
            this.cashBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashBtn.FlatAppearance.BorderSize = 0;
            this.cashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.cashBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.cashBtn.IconColor = System.Drawing.Color.ForestGreen;
            this.cashBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cashBtn.Location = new System.Drawing.Point(144, 237);
            this.cashBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(286, 102);
            this.cashBtn.TabIndex = 0;
            this.cashBtn.Text = "Cash";
            this.cashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cashBtn.UseVisualStyleBackColor = false;
            this.cashBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // btnCompleteTransaction
            // 
            this.btnCompleteTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompleteTransaction.FlatAppearance.BorderSize = 0;
            this.btnCompleteTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTransaction.ForeColor = System.Drawing.Color.White;
            this.btnCompleteTransaction.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCompleteTransaction.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnCompleteTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompleteTransaction.IconSize = 55;
            this.btnCompleteTransaction.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCompleteTransaction.Location = new System.Drawing.Point(561, 477);
            this.btnCompleteTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompleteTransaction.Name = "btnCompleteTransaction";
            this.btnCompleteTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompleteTransaction.Size = new System.Drawing.Size(314, 85);
            this.btnCompleteTransaction.TabIndex = 30;
            this.btnCompleteTransaction.Text = "Complete Payment";
            this.btnCompleteTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleteTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompleteTransaction.UseVisualStyleBackColor = false;
            this.btnCompleteTransaction.Click += new System.EventHandler(this.btnCompleteTransaction_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEnterCash);
            this.panel1.Controls.Add(this.cashBtn);
            this.panel1.Controls.Add(this.cardBtn);
            this.panel1.Controls.Add(this.btnCompleteTransaction);
            this.panel1.Controls.Add(this.totalPriceLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 614);
            this.panel1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(271, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "(Please select a form of payment)";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1155, 717);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton cashBtn;
        private FontAwesome.Sharp.IconButton cardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterCash;
        private FontAwesome.Sharp.IconButton btnCompleteTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}