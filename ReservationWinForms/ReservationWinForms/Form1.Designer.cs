namespace ReservationWinForms;

partial class Form1
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
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabReservations = new System.Windows.Forms.TabPage();
        this.tabRooms = new System.Windows.Forms.TabPage();
        this.tabCurrency = new System.Windows.Forms.TabPage();
        this.dgvReservations = new System.Windows.Forms.DataGridView();
        this.dgvRooms = new System.Windows.Forms.DataGridView();
        this.dgvCurrencyRates = new System.Windows.Forms.DataGridView();
        this.btnNewReservation = new System.Windows.Forms.Button();
        this.btnCheckIn = new System.Windows.Forms.Button();
        this.btnCheckOut = new System.Windows.Forms.Button();
        this.btnRefreshRates = new System.Windows.Forms.Button();
        this.tabControl1.SuspendLayout();
        this.tabReservations.SuspendLayout();
        this.tabRooms.SuspendLayout();
        this.tabCurrency.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyRates)).BeginInit();
        this.SuspendLayout();
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabReservations);
        this.tabControl1.Controls.Add(this.tabRooms);
        this.tabControl1.Controls.Add(this.tabCurrency);
        this.tabControl1.Location = new System.Drawing.Point(12, 12);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(776, 426);
        this.tabControl1.TabIndex = 0;
        // 
        // tabReservations
        // 
        this.tabReservations.Controls.Add(this.dgvReservations);
        this.tabReservations.Controls.Add(this.btnNewReservation);
        this.tabReservations.Controls.Add(this.btnCheckIn);
        this.tabReservations.Controls.Add(this.btnCheckOut);
        this.tabReservations.Location = new System.Drawing.Point(4, 24);
        this.tabReservations.Name = "tabReservations";
        this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
        this.tabReservations.Size = new System.Drawing.Size(768, 398);
        this.tabReservations.TabIndex = 0;
        this.tabReservations.Text = "Rezervasyonlar";
        this.tabReservations.UseVisualStyleBackColor = true;
        // 
        // tabRooms
        // 
        this.tabRooms.Controls.Add(this.dgvRooms);
        this.tabRooms.Location = new System.Drawing.Point(4, 24);
        this.tabRooms.Name = "tabRooms";
        this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
        this.tabRooms.Size = new System.Drawing.Size(768, 398);
        this.tabRooms.TabIndex = 1;
        this.tabRooms.Text = "Odalar";
        this.tabRooms.UseVisualStyleBackColor = true;
        // 
        // tabCurrency
        // 
        this.tabCurrency.Controls.Add(this.dgvCurrencyRates);
        this.tabCurrency.Controls.Add(this.btnRefreshRates);
        this.tabCurrency.Location = new System.Drawing.Point(4, 24);
        this.tabCurrency.Name = "tabCurrency";
        this.tabCurrency.Padding = new System.Windows.Forms.Padding(3);
        this.tabCurrency.Size = new System.Drawing.Size(768, 398);
        this.tabCurrency.TabIndex = 2;
        this.tabCurrency.Text = "Döviz Kurları";
        this.tabCurrency.UseVisualStyleBackColor = true;
        // 
        // dgvReservations
        // 
        this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvReservations.Location = new System.Drawing.Point(6, 6);
        this.dgvReservations.Name = "dgvReservations";
        this.dgvReservations.RowTemplate.Height = 25;
        this.dgvReservations.Size = new System.Drawing.Size(756, 300);
        this.dgvReservations.TabIndex = 0;
        // 
        // dgvRooms
        // 
        this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRooms.Location = new System.Drawing.Point(6, 6);
        this.dgvRooms.Name = "dgvRooms";
        this.dgvRooms.RowTemplate.Height = 25;
        this.dgvRooms.Size = new System.Drawing.Size(756, 386);
        this.dgvRooms.TabIndex = 0;
        // 
        // dgvCurrencyRates
        // 
        this.dgvCurrencyRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvCurrencyRates.Location = new System.Drawing.Point(6, 6);
        this.dgvCurrencyRates.Name = "dgvCurrencyRates";
        this.dgvCurrencyRates.RowTemplate.Height = 25;
        this.dgvCurrencyRates.Size = new System.Drawing.Size(756, 350);
        this.dgvCurrencyRates.TabIndex = 0;
        // 
        // btnNewReservation
        // 
        this.btnNewReservation.Location = new System.Drawing.Point(6, 320);
        this.btnNewReservation.Name = "btnNewReservation";
        this.btnNewReservation.Size = new System.Drawing.Size(100, 30);
        this.btnNewReservation.TabIndex = 1;
        this.btnNewReservation.Text = "Yeni Rezervasyon";
        this.btnNewReservation.UseVisualStyleBackColor = true;
        this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
        // 
        // btnCheckIn
        // 
        this.btnCheckIn.Location = new System.Drawing.Point(112, 320);
        this.btnCheckIn.Name = "btnCheckIn";
        this.btnCheckIn.Size = new System.Drawing.Size(100, 30);
        this.btnCheckIn.TabIndex = 2;
        this.btnCheckIn.Text = "Check-in";
        this.btnCheckIn.UseVisualStyleBackColor = true;
        this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
        // 
        // btnCheckOut
        // 
        this.btnCheckOut.Location = new System.Drawing.Point(218, 320);
        this.btnCheckOut.Name = "btnCheckOut";
        this.btnCheckOut.Size = new System.Drawing.Size(100, 30);
        this.btnCheckOut.TabIndex = 3;
        this.btnCheckOut.Text = "Check-out";
        this.btnCheckOut.UseVisualStyleBackColor = true;
        this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
        // 
        // btnRefreshRates
        // 
        this.btnRefreshRates.Location = new System.Drawing.Point(6, 370);
        this.btnRefreshRates.Name = "btnRefreshRates";
        this.btnRefreshRates.Size = new System.Drawing.Size(120, 30);
        this.btnRefreshRates.TabIndex = 1;
        this.btnRefreshRates.Text = "Kurları Yenile";
        this.btnRefreshRates.UseVisualStyleBackColor = true;
        this.btnRefreshRates.Click += new System.EventHandler(this.btnRefreshRates_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.tabControl1);
        this.Name = "Form1";
        this.Text = "Bilge Hotel - Rezervasyon Yönetimi";
        this.tabControl1.ResumeLayout(false);
        this.tabReservations.ResumeLayout(false);
        this.tabRooms.ResumeLayout(false);
        this.tabCurrency.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyRates)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabReservations;
    private System.Windows.Forms.TabPage tabRooms;
    private System.Windows.Forms.TabPage tabCurrency;
    private System.Windows.Forms.DataGridView dgvReservations;
    private System.Windows.Forms.DataGridView dgvRooms;
    private System.Windows.Forms.DataGridView dgvCurrencyRates;
    private System.Windows.Forms.Button btnNewReservation;
    private System.Windows.Forms.Button btnCheckIn;
    private System.Windows.Forms.Button btnCheckOut;
    private System.Windows.Forms.Button btnRefreshRates;
}
