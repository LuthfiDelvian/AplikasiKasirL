namespace AplikasiKasirL
{
    partial class FormMenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLaporanData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLaporanPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGantiPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuMaster,
            this.MenuTransaksi,
            this.MenuLaporan,
            this.MenuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLogin,
            this.MenuLogout,
            this.toolStripSeparator1,
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            this.MenuFile.Click += new System.EventHandler(this.MenuFile_Click);
            // 
            // MenuLogin
            // 
            this.MenuLogin.Name = "MenuLogin";
            this.MenuLogin.Size = new System.Drawing.Size(112, 22);
            this.MenuLogin.Text = "Login";
            this.MenuLogin.Click += new System.EventHandler(this.MenuLogin_Click);
            // 
            // MenuLogout
            // 
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(112, 22);
            this.MenuLogout.Text = "Logout";
            this.MenuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(112, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuMaster
            // 
            this.MenuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuKasir,
            this.MenuBarang});
            this.MenuMaster.Name = "MenuMaster";
            this.MenuMaster.Size = new System.Drawing.Size(55, 20);
            this.MenuMaster.Text = "Master";
            this.MenuMaster.Click += new System.EventHandler(this.MenuMaster_Click);
            // 
            // MenuKasir
            // 
            this.MenuKasir.Name = "MenuKasir";
            this.MenuKasir.Size = new System.Drawing.Size(111, 22);
            this.MenuKasir.Text = "Kasir";
            this.MenuKasir.Click += new System.EventHandler(this.MenuKasir_Click);
            // 
            // MenuBarang
            // 
            this.MenuBarang.Name = "MenuBarang";
            this.MenuBarang.Size = new System.Drawing.Size(152, 22);
            this.MenuBarang.Text = "Barang";
            this.MenuBarang.Click += new System.EventHandler(this.MenuBarang_Click);
            // 
            // MenuTransaksi
            // 
            this.MenuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPenjualan});
            this.MenuTransaksi.Name = "MenuTransaksi";
            this.MenuTransaksi.Size = new System.Drawing.Size(66, 20);
            this.MenuTransaksi.Text = "Transaksi";
            // 
            // MenuPenjualan
            // 
            this.MenuPenjualan.Name = "MenuPenjualan";
            this.MenuPenjualan.Size = new System.Drawing.Size(126, 22);
            this.MenuPenjualan.Text = "Penjualan";
            // 
            // MenuLaporan
            // 
            this.MenuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLaporanData,
            this.MenuLaporanPenjualan});
            this.MenuLaporan.Name = "MenuLaporan";
            this.MenuLaporan.Size = new System.Drawing.Size(62, 20);
            this.MenuLaporan.Text = "Laporan";
            // 
            // MenuLaporanData
            // 
            this.MenuLaporanData.Name = "MenuLaporanData";
            this.MenuLaporanData.Size = new System.Drawing.Size(183, 22);
            this.MenuLaporanData.Text = "Laporan Data Master";
            // 
            // MenuLaporanPenjualan
            // 
            this.MenuLaporanPenjualan.Name = "MenuLaporanPenjualan";
            this.MenuLaporanPenjualan.Size = new System.Drawing.Size(183, 22);
            this.MenuLaporanPenjualan.Text = "Laporan Penjualan";
            // 
            // MenuUtility
            // 
            this.MenuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGantiPassword,
            this.MenuAbout});
            this.MenuUtility.Name = "MenuUtility";
            this.MenuUtility.Size = new System.Drawing.Size(50, 20);
            this.MenuUtility.Text = "Utility";
            // 
            // MenuGantiPassword
            // 
            this.MenuGantiPassword.Name = "MenuGantiPassword";
            this.MenuGantiPassword.Size = new System.Drawing.Size(155, 22);
            this.MenuGantiPassword.Text = "Ganti Password";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(155, 22);
            this.MenuAbout.Text = "About";
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 313);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuUtama";
            this.Text = "FormMenuUtama";
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem MenuFile;
        public System.Windows.Forms.ToolStripMenuItem MenuLogin;
        public System.Windows.Forms.ToolStripMenuItem MenuLogout;
        public System.Windows.Forms.ToolStripMenuItem MenuMaster;
        public System.Windows.Forms.ToolStripMenuItem MenuKasir;
        public System.Windows.Forms.ToolStripMenuItem MenuBarang;
        public System.Windows.Forms.ToolStripMenuItem MenuTransaksi;
        public System.Windows.Forms.ToolStripMenuItem MenuPenjualan;
        public System.Windows.Forms.ToolStripMenuItem MenuLaporan;
        public System.Windows.Forms.ToolStripMenuItem MenuLaporanData;
        public System.Windows.Forms.ToolStripMenuItem MenuLaporanPenjualan;
        public System.Windows.Forms.ToolStripMenuItem MenuUtility;
        public System.Windows.Forms.ToolStripMenuItem MenuGantiPassword;
        public System.Windows.Forms.ToolStripMenuItem MenuAbout;
        public System.Windows.Forms.ToolStripMenuItem MenuExit;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}