using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasirL
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        FormLogin frmLogin;
        MenuStrip mnstrip;
        void frmLogin_fromClosed(object sender, FormClosingEventArgs e)
        {
            frmLogin = null;
        }
        void MenuTerkunci()
        {
            MenuLogin.Enabled = true;
            MenuLogout.Enabled = false;
            MenuMaster.Enabled = false;
            MenuLaporan.Enabled = false;
            MenuTransaksi.Enabled = false;
            MenuUtility.Enabled = false;
            menu = this;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuFile_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void MenuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new FormLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_fromClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
            frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void frmLogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void MenuMaster_Click(object sender, EventArgs e)
        {

        }

        FormMasterKasir frmKasir;

        void frmKasir_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        private void MenuKasir_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_fromClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        DataMasterBarang frmBarang;

        void frmBarang_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }

        private void MenuBarang_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new DataMasterBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_fromClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

    }
}
