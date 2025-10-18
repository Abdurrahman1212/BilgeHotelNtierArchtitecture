namespace ReservationWinForms;

partial class ReservationForm
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
        this.lblCustomer = new System.Windows.Forms.Label();
        this.lblRoom = new System.Windows.Forms.Label();
        this.lblCheckIn = new System.Windows.Forms.Label();
        this.lblCheckOut = new System.Windows.Forms.Label();
        this.lblPackageType = new System.Windows.Forms.Label();
        this.lblRoomType = new System.Windows.Forms.Label();
        this.lblRoomCapacity = new System.Windows.Forms.Label();
        this.lblRoomFeatures = new System.Windows.Forms.Label();
        this.lblTotal = new System.Windows.Forms.Label();
        this.cmbCustomers = new System.Windows.Forms.ComboBox();
        this.cmbRooms = new System.Windows.Forms.ComboBox();
        this.cmbPackageType = new System.Windows.Forms.ComboBox();
        this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
        this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
        this.txtTotalAmount = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnCheckAvailability = new System.Windows.Forms.Button();
        this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
        this.txtCustomerLastName = new System.Windows.Forms.TextBox();
        this.txtBirthYear = new System.Windows.Forms.TextBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblCustomer
        // 
        this.lblCustomer.AutoSize = true;
        this.lblCustomer.Location = new System.Drawing.Point(6, 20);
        this.lblCustomer.Name = "lblCustomer";
        this.lblCustomer.Size = new System.Drawing.Size(58, 15);
        this.lblCustomer.TabIndex = 0;
        this.lblCustomer.Text = "Müşteri:";
        // 
        // lblRoom
        // 
        this.lblRoom.AutoSize = true;
        this.lblRoom.Location = new System.Drawing.Point(6, 50);
        this.lblRoom.Name = "lblRoom";
        this.lblRoom.Size = new System.Drawing.Size(35, 15);
        this.lblRoom.TabIndex = 1;
        this.lblRoom.Text = "Oda:";
        // 
        // lblCheckIn
        // 
        this.lblCheckIn.AutoSize = true;
        this.lblCheckIn.Location = new System.Drawing.Point(6, 80);
        this.lblCheckIn.Name = "lblCheckIn";
        this.lblCheckIn.Size = new System.Drawing.Size(73, 15);
        this.lblCheckIn.TabIndex = 2;
        this.lblCheckIn.Text = "Giriş Tarihi:";
        // 
        // lblCheckOut
        // 
        this.lblCheckOut.AutoSize = true;
        this.lblCheckOut.Location = new System.Drawing.Point(6, 110);
        this.lblCheckOut.Name = "lblCheckOut";
        this.lblCheckOut.Size = new System.Drawing.Size(84, 15);
        this.lblCheckOut.TabIndex = 3;
        this.lblCheckOut.Text = "Çıkış Tarihi:";
        // 
        // lblPackageType
        // 
        this.lblPackageType.AutoSize = true;
        this.lblPackageType.Location = new System.Drawing.Point(6, 140);
        this.lblPackageType.Name = "lblPackageType";
        this.lblPackageType.Size = new System.Drawing.Size(70, 15);
        this.lblPackageType.TabIndex = 4;
        this.lblPackageType.Text = "Paket Tipi:";
        // 
        // lblRoomType
        // 
        this.lblRoomType.AutoSize = true;
        this.lblRoomType.Location = new System.Drawing.Point(6, 20);
        this.lblRoomType.Name = "lblRoomType";
        this.lblRoomType.Size = new System.Drawing.Size(67, 15);
        this.lblRoomType.TabIndex = 10;
        this.lblRoomType.Text = "Oda Tipi:";
        // 
        // lblRoomCapacity
        // 
        this.lblRoomCapacity.AutoSize = true;
        this.lblRoomCapacity.Location = new System.Drawing.Point(6, 45);
        this.lblRoomCapacity.Name = "lblRoomCapacity";
        this.lblRoomCapacity.Size = new System.Drawing.Size(59, 15);
        this.lblRoomCapacity.TabIndex = 11;
        this.lblRoomCapacity.Text = "Kapasite:";
        // 
        // lblRoomFeatures
        // 
        this.lblRoomFeatures.AutoSize = true;
        this.lblRoomFeatures.Location = new System.Drawing.Point(6, 70);
        this.lblRoomFeatures.Name = "lblRoomFeatures";
        this.lblRoomFeatures.Size = new System.Drawing.Size(65, 15);
        this.lblRoomFeatures.TabIndex = 12;
        this.lblRoomFeatures.Text = "Özellikler:";
        // 
        // lblTotal
        // 
        this.lblTotal.AutoSize = true;
        this.lblTotal.Location = new System.Drawing.Point(6, 200);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Size = new System.Drawing.Size(42, 15);
        this.lblTotal.TabIndex = 5;
        this.lblTotal.Text = "Toplam:";
        // 
        // cmbCustomers
        // 
        this.cmbCustomers.FormattingEnabled = true;
        this.cmbCustomers.Location = new System.Drawing.Point(90, 17);
        this.cmbCustomers.Name = "cmbCustomers";
        this.cmbCustomers.Size = new System.Drawing.Size(200, 23);
        this.cmbCustomers.TabIndex = 6;
        // 
        // cmbRooms
        // 
        this.cmbRooms.FormattingEnabled = true;
        this.cmbRooms.Location = new System.Drawing.Point(90, 47);
        this.cmbRooms.Name = "cmbRooms";
        this.cmbRooms.Size = new System.Drawing.Size(200, 23);
        this.cmbRooms.TabIndex = 7;
        // 
        // cmbPackageType
        // 
        this.cmbPackageType.FormattingEnabled = true;
        this.cmbPackageType.Items.AddRange(new object[] {
            "Tam Pansiyon",
            "Herşey Dahil"});
        this.cmbPackageType.Location = new System.Drawing.Point(90, 137);
        this.cmbPackageType.Name = "cmbPackageType";
        this.cmbPackageType.Size = new System.Drawing.Size(200, 23);
        this.cmbPackageType.TabIndex = 8;
        // 
        // dtpCheckIn
        // 
        this.dtpCheckIn.Location = new System.Drawing.Point(90, 77);
        this.dtpCheckIn.Name = "dtpCheckIn";
        this.dtpCheckIn.Size = new System.Drawing.Size(200, 23);
        this.dtpCheckIn.TabIndex = 9;
        // 
        // dtpCheckOut
        // 
        this.dtpCheckOut.Location = new System.Drawing.Point(90, 107);
        this.dtpCheckOut.Name = "dtpCheckOut";
        this.dtpCheckOut.Size = new System.Drawing.Size(200, 23);
        this.dtpCheckOut.TabIndex = 10;
        // 
        // txtTotalAmount
        // 
        this.txtTotalAmount.Location = new System.Drawing.Point(90, 197);
        this.txtTotalAmount.Name = "txtTotalAmount";
        this.txtTotalAmount.ReadOnly = true;
        this.txtTotalAmount.Size = new System.Drawing.Size(200, 23);
        this.txtTotalAmount.TabIndex = 11;
        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(90, 240);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(80, 30);
        this.btnSave.TabIndex = 12;
        this.btnSave.Text = "Kaydet";
        this.btnSave.UseVisualStyleBackColor = true;
        // 
        // btnCheckAvailability
        // 
        this.btnCheckAvailability.Location = new System.Drawing.Point(90, 170);
        this.btnCheckAvailability.Name = "btnCheckAvailability";
        this.btnCheckAvailability.Size = new System.Drawing.Size(120, 25);
        this.btnCheckAvailability.TabIndex = 14;
        this.btnCheckAvailability.Text = "Müsaitliği Kontrol Et";
        this.btnCheckAvailability.UseVisualStyleBackColor = true;
        // 
        // txtCustomerFirstName
        // 
        this.txtCustomerFirstName.Location = new System.Drawing.Point(90, 230);
        this.txtCustomerFirstName.Name = "txtCustomerFirstName";
        this.txtCustomerFirstName.Size = new System.Drawing.Size(200, 23);
        this.txtCustomerFirstName.TabIndex = 18;
        // 
        // txtCustomerLastName
        // 
        this.txtCustomerLastName.Location = new System.Drawing.Point(90, 260);
        this.txtCustomerLastName.Name = "txtCustomerLastName";
        this.txtCustomerLastName.Size = new System.Drawing.Size(200, 23);
        this.txtCustomerLastName.TabIndex = 19;
        // 
        // txtBirthYear
        // 
        this.txtBirthYear.Location = new System.Drawing.Point(90, 290);
        this.txtBirthYear.Name = "txtBirthYear";
        this.txtBirthYear.Size = new System.Drawing.Size(100, 23);
        this.txtBirthYear.TabIndex = 20;
        // 
        // txtIdentityNumber
        // 
        this.txtIdentityNumber.Location = new System.Drawing.Point(90, 320);
        this.txtIdentityNumber.Name = "txtIdentityNumber";
        this.txtIdentityNumber.Size = new System.Drawing.Size(150, 23);
        this.txtIdentityNumber.TabIndex = 21;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.lblRoomType);
        this.groupBox1.Controls.Add(this.lblRoomCapacity);
        this.groupBox1.Controls.Add(this.lblRoomFeatures);
        this.groupBox1.Location = new System.Drawing.Point(310, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(300, 100);
        this.groupBox1.TabIndex = 15;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Oda Bilgileri";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.lblCustomer);
        this.groupBox2.Controls.Add(this.lblRoom);
        this.groupBox2.Controls.Add(this.lblCheckIn);
        this.groupBox2.Controls.Add(this.lblCheckOut);
        this.groupBox2.Controls.Add(this.lblPackageType);
        this.groupBox2.Controls.Add(this.lblTotal);
        this.groupBox2.Controls.Add(this.cmbCustomers);
        this.groupBox2.Controls.Add(this.cmbRooms);
        this.groupBox2.Controls.Add(this.cmbPackageType);
        this.groupBox2.Controls.Add(this.dtpCheckIn);
        this.groupBox2.Controls.Add(this.dtpCheckOut);
        this.groupBox2.Controls.Add(this.txtTotalAmount);
        this.groupBox2.Controls.Add(this.btnCheckAvailability);
        this.groupBox2.Location = new System.Drawing.Point(12, 12);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(290, 280);
        this.groupBox2.TabIndex = 16;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Rezervasyon Bilgileri";
        // 
        // ReservationForm
        // 
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblCustomer;
    private System.Windows.Forms.Label lblRoom;
    private System.Windows.Forms.Label lblCheckIn;
    private System.Windows.Forms.Label lblCheckOut;
    private System.Windows.Forms.Label lblPackageType;
    private System.Windows.Forms.Label lblRoomType;
    private System.Windows.Forms.Label lblRoomCapacity;
    private System.Windows.Forms.Label lblRoomFeatures;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.ComboBox cmbCustomers;
    private System.Windows.Forms.ComboBox cmbRooms;
    private System.Windows.Forms.ComboBox cmbPackageType;
    private System.Windows.Forms.DateTimePicker dtpCheckIn;
    private System.Windows.Forms.DateTimePicker dtpCheckOut;
    private System.Windows.Forms.TextBox txtTotalAmount;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCheckAvailability;
    private System.Windows.Forms.DataGridView dgvExtraCharges;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtCustomerFirstName;
    private System.Windows.Forms.TextBox txtCustomerLastName;
    private System.Windows.Forms.TextBox txtBirthYear;
    private System.Windows.Forms.TextBox txtIdentityNumber;
}
