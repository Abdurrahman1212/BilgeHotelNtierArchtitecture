namespace ReservationWinForms;

partial class ExtraChargeForm
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
        this.lblChargeType = new System.Windows.Forms.Label();
        this.lblDescription = new System.Windows.Forms.Label();
        this.lblAmount = new System.Windows.Forms.Label();
        this.lblQuantity = new System.Windows.Forms.Label();
        this.cmbChargeType = new System.Windows.Forms.ComboBox();
        this.txtDescription = new System.Windows.Forms.TextBox();
        this.txtAmount = new System.Windows.Forms.TextBox();
        this.txtQuantity = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblChargeType
        // 
        this.lblChargeType.AutoSize = true;
        this.lblChargeType.Location = new System.Drawing.Point(12, 20);
        this.lblChargeType.Name = "lblChargeType";
        this.lblChargeType.Size = new System.Drawing.Size(81, 15);
        this.lblChargeType.TabIndex = 0;
        this.lblChargeType.Text = "Harcama Türü:";
        // 
        // lblDescription
        // 
        this.lblDescription.AutoSize = true;
        this.lblDescription.Location = new System.Drawing.Point(12, 60);
        this.lblDescription.Name = "lblDescription";
        this.lblDescription.Size = new System.Drawing.Size(58, 15);
        this.lblDescription.TabIndex = 1;
        this.lblDescription.Text = "Açıklama:";
        // 
        // lblAmount
        // 
        this.lblAmount.AutoSize = true;
        this.lblAmount.Location = new System.Drawing.Point(12, 100);
        this.lblAmount.Name = "lblAmount";
        this.lblAmount.Size = new System.Drawing.Size(42, 15);
        this.lblAmount.TabIndex = 2;
        this.lblAmount.Text = "Tutar:";
        // 
        // lblQuantity
        // 
        this.lblQuantity.AutoSize = true;
        this.lblQuantity.Location = new System.Drawing.Point(12, 140);
        this.lblQuantity.Name = "lblQuantity";
        this.lblQuantity.Size = new System.Drawing.Size(50, 15);
        this.lblQuantity.TabIndex = 3;
        this.lblQuantity.Text = "Miktar:";
        // 
        // cmbChargeType
        // 
        this.cmbChargeType.FormattingEnabled = true;
        this.cmbChargeType.Location = new System.Drawing.Point(100, 17);
        this.cmbChargeType.Name = "cmbChargeType";
        this.cmbChargeType.Size = new System.Drawing.Size(200, 23);
        this.cmbChargeType.TabIndex = 4;
        // 
        // txtDescription
        // 
        this.txtDescription.Location = new System.Drawing.Point(100, 57);
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(200, 23);
        this.txtDescription.TabIndex = 5;
        // 
        // txtAmount
        // 
        this.txtAmount.Location = new System.Drawing.Point(100, 97);
        this.txtAmount.Name = "txtAmount";
        this.txtAmount.Size = new System.Drawing.Size(200, 23);
        this.txtAmount.TabIndex = 6;
        // 
        // txtQuantity
        // 
        this.txtQuantity.Location = new System.Drawing.Point(100, 137);
        this.txtQuantity.Name = "txtQuantity";
        this.txtQuantity.Size = new System.Drawing.Size(200, 23);
        this.txtQuantity.TabIndex = 7;
        this.txtQuantity.Text = "1";
        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(100, 180);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(80, 30);
        this.btnSave.TabIndex = 8;
        this.btnSave.Text = "Ekle";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // btnCancel
        // 
        this.btnCancel.Location = new System.Drawing.Point(190, 180);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(80, 30);
        this.btnCancel.TabIndex = 9;
        this.btnCancel.Text = "İptal";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // ExtraChargeForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(320, 220);
        this.Controls.Add(this.lblChargeType);
        this.Controls.Add(this.lblDescription);
        this.Controls.Add(this.lblAmount);
        this.Controls.Add(this.lblQuantity);
        this.Controls.Add(this.cmbChargeType);
        this.Controls.Add(this.txtDescription);
        this.Controls.Add(this.txtAmount);
        this.Controls.Add(this.txtQuantity);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnCancel);
        this.Name = "ExtraChargeForm";
        this.Text = "Ekstra Harcama Ekle";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblChargeType;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.ComboBox cmbChargeType;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
}
