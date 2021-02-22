namespace Project2
{
    partial class LoanAmortization
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
            this.labelLoanAmount = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelAPR = new System.Windows.Forms.Label();
            this.labelMonthly = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtAPR = new System.Windows.Forms.TextBox();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAmortize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Data Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLoanAmount
            // 
            this.labelLoanAmount.AutoSize = true;
            this.labelLoanAmount.Location = new System.Drawing.Point(38, 95);
            this.labelLoanAmount.Name = "labelLoanAmount";
            this.labelLoanAmount.Size = new System.Drawing.Size(70, 13);
            this.labelLoanAmount.TabIndex = 1;
            this.labelLoanAmount.Text = "Loan Amount";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(35, 134);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(102, 13);
            this.labelTerm.TabIndex = 2;
            this.labelTerm.Text = "Term in Years (1-50)";
            // 
            // labelAPR
            // 
            this.labelAPR.AutoSize = true;
            this.labelAPR.Location = new System.Drawing.Point(39, 176);
            this.labelAPR.Name = "labelAPR";
            this.labelAPR.Size = new System.Drawing.Size(40, 13);
            this.labelAPR.TabIndex = 3;
            this.labelAPR.Text = "APR %";
            // 
            // labelMonthly
            // 
            this.labelMonthly.AutoSize = true;
            this.labelMonthly.Location = new System.Drawing.Point(37, 215);
            this.labelMonthly.Name = "labelMonthly";
            this.labelMonthly.Size = new System.Drawing.Size(88, 13);
            this.labelMonthly.TabIndex = 4;
            this.labelMonthly.Text = "Monthly Payment";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(37, 256);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(90, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Money Paid";
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(147, 91);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(151, 20);
            this.txtLoanAmt.TabIndex = 0;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(147, 131);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(151, 20);
            this.txtTerm.TabIndex = 1;
            // 
            // txtAPR
            // 
            this.txtAPR.Location = new System.Drawing.Point(147, 172);
            this.txtAPR.Name = "txtAPR";
            this.txtAPR.Size = new System.Drawing.Size(151, 20);
            this.txtAPR.TabIndex = 3;
            // 
            // txtMonthly
            // 
            this.txtMonthly.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMonthly.Location = new System.Drawing.Point(147, 211);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.ReadOnly = true;
            this.txtMonthly.Size = new System.Drawing.Size(151, 20);
            this.txtMonthly.TabIndex = 10;
            this.txtMonthly.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotal.Location = new System.Drawing.Point(147, 251);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(151, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            // 
            // btnAmortize
            // 
            this.btnAmortize.Location = new System.Drawing.Point(198, 297);
            this.btnAmortize.Name = "btnAmortize";
            this.btnAmortize.Size = new System.Drawing.Size(120, 64);
            this.btnAmortize.TabIndex = 4;
            this.btnAmortize.Text = "Amortize";
            this.btnAmortize.UseVisualStyleBackColor = true;
            this.btnAmortize.Click += new System.EventHandler(this.btnAmortize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 64);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(335, 28);
            this.lstBox.Name = "lstBox";
            this.lstBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBox.Size = new System.Drawing.Size(399, 355);
            this.lstBox.TabIndex = 13;
            this.lstBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(293, 56);
            this.panel1.TabIndex = 14;
            // 
            // LoanAmortization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAmortize);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMonthly);
            this.Controls.Add(this.txtAPR);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtLoanAmt);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelMonthly);
            this.Controls.Add(this.labelAPR);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelLoanAmount);
            this.Name = "LoanAmortization";
            this.Text = "Loan Amortization";
            this.Load += new System.EventHandler(this.Loan_Amortization_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoanAmount;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelAPR;
        private System.Windows.Forms.Label labelMonthly;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtAPR;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAmortize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Panel panel1;
    }
}

