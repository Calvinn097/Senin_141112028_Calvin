using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        static int last_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;userid=root;password=;database=pos;";
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}", ex.ToString());
            }
            string stm = "SELECT id FROM barang WHERE id=(SELECT max(id) FROM barang)";
            //string stm = "select * from barang";
            MySqlCommand cmd = new MySqlCommand(stm,conn);
            MySqlDataReader rdr=null;
            rdr=cmd.ExecuteReader();
            string hasil="";
            while (rdr.Read())
            {
                hasil+=rdr.GetString("id");
                //hasil += rdr.ToString();
            }
            //MessageBox.Show(hasil);
            if (hasil == "")
            {
                last_id = 1;
            }
            else
            {
                last_id = Convert.ToInt32(hasil) + 1;
            }
            reg_brg_id_tb.Text = last_id.ToString();
            conn.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id,jumlah;
            string kode,nama;
            float hargahpp,hargajual;
            id = Convert.ToInt32(reg_brg_id_tb.Text);
            nama = reg_brg_nama_tb.Text;
            kode = reg_brg_kode_tb.Text;
            jumlah =Convert.ToInt32(jumlah_reg_tb.Text);
            hargahpp = Convert.ToInt32(reg_brg_hargahpp_tb.Text);
            hargajual = Convert.ToInt32(reg_brg_hargajual_tb.Text);
            DateTime created_at= new DateTime();
            created_at = DateTime.Now;
            string str_created_at,str_updated_at;
            str_created_at = created_at.ToString("yyyy-MM-dd HH:mm:ss");
            str_updated_at = str_created_at;
            string cs = "server=localhost;userid=root;password=;database=pos;";
            MySqlConnection conn = null;
            
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error: {0}", ex.ToString());
            }
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO barang(ID, Kode, Nama, JumlahAwal, HargaHPP, HargaJual, Created_at, Updated_at) VALUES(@Id,@Kode,@Nama,@JumlahAwal,@HargaHPP,@HargaJual,@Created_at,@Updated_at)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Kode", kode);
            cmd.Parameters.AddWithValue("@Nama", nama);
            cmd.Parameters.AddWithValue("@JumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@HargaHPP", hargahpp);
            cmd.Parameters.AddWithValue("@HargaJual", hargajual);
            cmd.Parameters.AddWithValue("@Created_at", str_created_at);
            cmd.Parameters.AddWithValue("@Updated_at", str_updated_at);
            try { cmd.ExecuteNonQuery(); }
            catch (MySqlException ex) { MessageBox.Show(ex.ToString()); }
            conn.Close();


            
        }

        private void keluar_reg_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void batal_reg_btn_Click(object sender, EventArgs e)
        {
            jumlah_reg_tb.Text = "";
            reg_brg_hargahpp_tb.Text = "";
            reg_brg_hargajual_tb.Text = "";
            reg_brg_kode_tb.Text = "";
            reg_brg_nama_tb.Text = "";
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
