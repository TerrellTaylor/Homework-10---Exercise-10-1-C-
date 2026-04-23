namespace Payment
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            groupBox1 = new GroupBox();
            rdoBillCustomer = new RadioButton();
            rdoCreditCard = new RadioButton();
            btnOK = new Button();
            btnCancel = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            lstCreditCardType = new ListBox();
            txtCardNumber = new TextBox();
            cboExpirationMonth = new ComboBox();
            cboExpirationYear = new ComboBox();
            chkDefault = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoBillCustomer);
            groupBox1.Controls.Add(rdoCreditCard);
            groupBox1.Location = new Point(25, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            rdoBillCustomer.AutoSize = true;
            rdoBillCustomer.Location = new Point(277, 44);
            rdoBillCustomer.Name = "rdoBillCustomer";
            rdoBillCustomer.Size = new Size(94, 19);
            rdoBillCustomer.TabIndex = 1;
            rdoBillCustomer.TabStop = true;
            rdoBillCustomer.Text = "Bill customer";
            rdoBillCustomer.UseVisualStyleBackColor = true;
            rdoBillCustomer.CheckedChanged += Billing_CheckedChanged;
            // 
            // rdoCreditCard
            // 
            rdoCreditCard.AutoSize = true;
            rdoCreditCard.Checked = true;
            rdoCreditCard.Location = new Point(43, 44);
            rdoCreditCard.Name = "rdoCreditCard";
            rdoCreditCard.Size = new Size(83, 19);
            rdoCreditCard.TabIndex = 0;
            rdoCreditCard.TabStop = true;
            rdoCreditCard.Text = "Credit card";
            rdoCreditCard.UseVisualStyleBackColor = true;
            rdoCreditCard.CheckedChanged += Billing_CheckedChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(258, 397);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 30);
            btnOK.TabIndex = 7;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(363, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 30);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // lstCreditCardType
            // 
            lstCreditCardType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCreditCardType.FormattingEnabled = true;
            lstCreditCardType.ItemHeight = 21;
            lstCreditCardType.Location = new Point(178, 155);
            lstCreditCardType.Name = "lstCreditCardType";
            lstCreditCardType.Size = new Size(271, 109);
            lstCreditCardType.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(178, 279);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(271, 23);
            txtCardNumber.TabIndex = 3;
            // 
            // cboExpirationMonth
            // 
            cboExpirationMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationMonth.FormattingEnabled = true;
            cboExpirationMonth.Location = new Point(178, 318);
            cboExpirationMonth.Name = "cboExpirationMonth";
            cboExpirationMonth.Size = new Size(121, 23);
            cboExpirationMonth.TabIndex = 4;
            // 
            // cboExpirationYear
            // 
            cboExpirationYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationYear.FormattingEnabled = true;
            cboExpirationYear.Location = new Point(328, 318);
            cboExpirationYear.Name = "cboExpirationYear";
            cboExpirationYear.Size = new Size(121, 23);
            cboExpirationYear.TabIndex = 5;
            // 
            // chkDefault
            // 
            chkDefault.AutoSize = true;
            chkDefault.Checked = true;
            chkDefault.CheckState = CheckState.Checked;
            chkDefault.Location = new Point(25, 359);
            chkDefault.Name = "chkDefault";
            chkDefault.Size = new Size(177, 19);
            chkDefault.TabIndex = 6;
            chkDefault.Text = "Set as default billing method";
            chkDefault.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(477, 450);
            ControlBox = false;
            Controls.Add(chkDefault);
            Controls.Add(cboExpirationYear);
            Controls.Add(cboExpirationMonth);
            Controls.Add(txtCardNumber);
            Controls.Add(lstCreditCardType);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += frmPayment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOK;
        private Button btnCancel;
        private PrintPreviewDialog printPreviewDialog1;
        private RadioButton rdoBillCustomer;
        private RadioButton rdoCreditCard;
        private ListBox lstCreditCardType;
        private TextBox txtCardNumber;
        private ComboBox cboExpirationMonth;
        private ComboBox cboExpirationYear;
        private CheckBox chkDefault;
    }
}