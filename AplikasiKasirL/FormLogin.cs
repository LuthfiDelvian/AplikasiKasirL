using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplikasiKasirL
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet dt;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        Koneksi Konn = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.Getconn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from KasirTbl where KodeKasir ='"+ kodeTxt.Text +"'and PasswordKasir = '"+ PassTxt.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    FormMenuUtama.menu.MenuLogin.Enabled = false;
                    FormMenuUtama.menu.MenuLogout.Enabled = true;
                    FormMenuUtama.menu.MenuMaster.Enabled = true;
                    FormMenuUtama.menu.MenuTransaksi.Enabled = true;
                    FormMenuUtama.menu.MenuLaporan.Enabled = true;
                    FormMenuUtama.menu.MenuUtility.Enabled = true;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ada Kesalahan");
                }
                conn.Close();
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PassTxt.PasswordChar = 'X';
            kodeTxt.Text = "KSR001";
            PassTxt.Text = "Admin";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
