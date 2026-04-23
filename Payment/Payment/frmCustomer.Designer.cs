namespace Payment;

partial class frmCustomer
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        cboNames = new ComboBox();
        label2 = new Label();
        btnSelectPayment = new Button();
        btnSave = new Button();
        btnExit = new Button();
        lblPayment = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(19, 16);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(95, 15);
        label1.TabIndex = 5;
        label1.Text = "Customer name:";
        // 
        // cboNames
        // 
        cboNames.DropDownStyle = ComboBoxStyle.DropDownList;
        cboNames.FormattingEnabled = true;
        cboNames.Location = new Point(132, 14);
        cboNames.Margin = new Padding(2);
        cboNames.Name = "cboNames";
        cboNames.Size = new Size(264, 23);
        cboNames.TabIndex = 0;
        cboNames.SelectedIndexChanged += cboNames_SelectIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(19, 62);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(102, 15);
        label2.TabIndex = 6;
        label2.Text = "Payment method:";
        // 
        // btnSelectPayment
        // 
        btnSelectPayment.Location = new Point(272, 82);
        btnSelectPayment.Margin = new Padding(2);
        btnSelectPayment.Name = "btnSelectPayment";
        btnSelectPayment.Size = new Size(124, 23);
        btnSelectPayment.TabIndex = 1;
        btnSelectPayment.Text = "Select Payment";
        btnSelectPayment.UseVisualStyleBackColor = true;
        btnSelectPayment.Click += btnSelectPayment_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(230, 204);
        btnSave.Margin = new Padding(2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(75, 23);
        btnSave.TabIndex = 2;
        btnSave.Text = "&Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnExit
        // 
        btnExit.DialogResult = DialogResult.Cancel;
        btnExit.Location = new Point(321, 204);
        btnExit.Margin = new Padding(2);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(75, 23);
        btnExit.TabIndex = 3;
        btnExit.Text = "E&xit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // lblPayment
        // 
        lblPayment.BorderStyle = BorderStyle.Fixed3D;
        lblPayment.Location = new Point(19, 82);
        lblPayment.Margin = new Padding(2, 0, 2, 0);
        lblPayment.Name = "lblPayment";
        lblPayment.Size = new Size(230, 103);
        lblPayment.TabIndex = 4;
        lblPayment.TextChanged += lblPayment_TextChanged;
        // 
        // frmCustomer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnExit;
        ClientSize = new Size(416, 238);
        Controls.Add(lblPayment);
        Controls.Add(btnExit);
        Controls.Add(btnSave);
        Controls.Add(btnSelectPayment);
        Controls.Add(label2);
        Controls.Add(cboNames);
        Controls.Add(label1);
        Margin = new Padding(2);
        Name = "frmCustomer";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Customer";
        Load += frmCustomer_Load;
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private Label label1;
    private ComboBox cboNames;
    private Label label2;
    private Button btnSelectPayment;
    private Button btnSave;
    private Button btnExit;
    private Label lblPayment;
}
