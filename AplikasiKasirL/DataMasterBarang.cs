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
    public partial class DataMasterBarang : Form
    {
        public DataMasterBarang()
        {
            InitializeComponent();
        }

        private void DataMasterBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kasirAppDataSet.BarangTbl' table. You can move, or remove it, as needed.
            this.barangTblTableAdapter.Fill(this.kasirAppDataSet.BarangTbl);

        }

        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;


        void munculDataBarang()
        {
            SqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("select * from BarangTbl",conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "BarangTbl");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "BarangTbl";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        void kondisiAwal()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtHargaBeli.Text = "";
            txtHargaJual.Text = "";
            txtJumlahBarang.Text = "";
            cmbSatuanbarang.Text = "";
            munculDataBarang();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //validasi
            if (txtKodeBarang.Text.Trim() == "" || txtNamaBarang.Text.Trim() == "" || txtHargaBeli.Text.Trim() == "" || txtHargaJual.Text.Trim() == "" || txtJumlahBarang.Text.Trim() == "" || cmbSatuanbarang.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua form terisi !");
            }
            else
            {
                SqlConnection conn = konn.Getconn();
                cmd = new SqlCommand("insert into BarangTbl values('" + txtKodeBarang.Text + "','" + txtNamaBarang.Text + "','" + txtHargaBeli.Text + "','" + txtHargaJual.Text + "','" + txtJumlahBarang.Text + "','" + cmbSatuanbarang.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di input");
                kondisiAwal();
            }
        }
    }
}
