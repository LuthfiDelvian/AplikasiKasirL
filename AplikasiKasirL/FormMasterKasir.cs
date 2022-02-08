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
    public partial class FormMasterKasir : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        void muncullevel()
        {
            cmbLevelKasir.Items.Add("Admin");
            cmbLevelKasir.Items.Add("User");
        }

        void munculDataKasir()
        {
            SqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("select * from Kasirtbl", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Kasirtbl");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Kasirtbl";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void kondisiAwal()
        {
            txtKodeKasir.Text = "";
            txtNamaKasir.Text = "";
            txtPasswordKasir.Text = "";
            cmbLevelKasir.Text = "";
            muncullevel();
            munculDataKasir();
        }
        public FormMasterKasir()
        {
            InitializeComponent();
        }

        private void FormMasterKasir_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtKodeKasir.Text.Trim() == "" || txtNamaKasir.Text.Trim() == "" || txtPasswordKasir.Text.Trim() == "" || cmbLevelKasir.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua form terisi");
            }
            else
            {
                SqlConnection conn = konn.Getconn();
                cmd = new SqlCommand("insert into Kasirtbl values('" + txtKodeKasir.Text + "','"+ txtNamaKasir.Text + "','" + txtPasswordKasir.Text + "','" + cmbLevelKasir.Text + "')",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di input");
                kondisiAwal();
            }
        }

        private void FormMasterKasir_Load(object sender, EventArgs e)
        {
            kondisiAwal();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtKodeKasir.Text.Trim() == "" || txtNamaKasir.Text.Trim() == "" || txtPasswordKasir.Text.Trim() == "" || cmbLevelKasir.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua form terisi !");
            }
            else
            {
                SqlConnection conn = konn.Getconn();
                cmd = new SqlCommand("update Kasirtbl set NamaKasir='" + txtNamaKasir.Text + "','" + txtPasswordKasir.Text + "',LevelKasir ='" + cmbLevelKasir.Text + "'where KodeAdmin='" + cmbLevelKasir.Text + "'", conn);
                conn.Open();
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKodeKasir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKodeKasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conn = konn.Getconn();
                cmd = new SqlCommand("select * from KasirTbl where KodeKasir = '"+txtKodeKasir.Text+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtKodeKasir.Text = dr[0].ToString();
                    txtNamaKasir.Text = dr[1].ToString();
                    txtPasswordKasir.Text = dr[2].ToString();
                    cmbLevelKasir.Text = dr[3].ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ada !");
                }

                kondisiAwal();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtKodeKasir.Text.Trim() == "" || txtNamaKasir.Text.Trim() == "" || txtPasswordKasir.Text.Trim() == "" || cmbLevelKasir.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua form terisi !");
            }
            else
            {
                SqlConnection conn = konn.Getconn();
                cmd = new SqlCommand("delete KasirTbl where KodeKasir ='" + txtKodeKasir.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di Hapus");
                kondisiAwal();
            }
        }
    }
}
