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
            rdr.Close();

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
            
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql= "INSERT INTO barang(ID, Kode, Nama, JumlahAwal, HargaHPP, HargaJual, Created_at, Updated_at) VALUES(@Id,@Kode,@Nama,@JumlahAwal,@HargaHPP,@HargaJual,@Created_at,@Updated_at)";
            da.InsertCommand= new MySqlCommand(sql,conn);
            da.InsertCommand.Prepare();
            da.InsertCommand.Parameters.AddWithValue("@ID", id);
            da.InsertCommand.Parameters.AddWithValue("@Kode", kode);
            da.InsertCommand.Parameters.AddWithValue("@Nama", nama);
            da.InsertCommand.Parameters.AddWithValue("@JumlahAwal", jumlah);
            da.InsertCommand.Parameters.AddWithValue("@HargaHPP", hargahpp);
            da.InsertCommand.Parameters.AddWithValue("@HargaJual", hargajual);
            da.InsertCommand.Parameters.AddWithValue("@Created_at", str_created_at);
            da.InsertCommand.Parameters.AddWithValue("@Updated_at", str_updated_at);
            try { da.InsertCommand.ExecuteNonQuery(); }
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

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanel();
            panel_register_barang.Show();
            panel_register_barang.Dock= DockStyle.Fill;
        }

        void hidePanel()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hidePanel();
            panel_lht_brg.Show();
            panel_lht_brg.Dock = DockStyle.Fill;
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
            DataSet ds = new DataSet();
            string sql = "select * from barang";
            MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
            da.Fill(ds, "barang");
            dgvdaftar.ReadOnly = true;
            dgvdaftar.AllowUserToAddRows = false;
            dgvdaftar.AllowUserToDeleteRows = false;
            dgvdaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdaftar.DataSource = ds.Tables["barang"];
            da.Dispose();
            conn.Close();
            

        }

        private void editBrg_btn_Click(object sender, EventArgs e)
        {
            string nama = editNamaBrg_tb.Text;
            int id = Convert.ToInt32(editIdBrg_tb.Text);
            string hargaHPP, hargaJual, jumlah;
            hargaHPP = editHargaHPPBrg_tb.Text;
            hargaJual = editHargaJualBrg_tb.Text;
            DateTime dateUpdated = new DateTime();
            dateUpdated = DateTime.Now;
            jumlah = editJumlahBrg_tb.Text;
            string s_dateUpdated = dateUpdated.ToString("yyyy-MM-dd HH:mm:ss");
            string cs = "server=localhost;userid=root;password=;database=pos";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "update barang set nama = @Nama,HargaHPP=@hargaHPP, HargaJual=@hargaJual,JumlahAwal=@jumlah,Updated_at=@s_dateUpdated where ID = @ID";
            //string sql = "update barang set nama = '"+nama+"',HargaHPP='"+hargaHPP+"', HargaJual='"+hargaJual+"',JumlahAwal='"+jumlah+"',Updated_at='"+s_dateUpdated+"' Where Kode = '"+id.ToString()+"'";
            //string sql = "update barang set nama = 'calvin' Where Kode = '" + (4).ToString() + "'";
            da.UpdateCommand = new MySqlCommand(sql,conn);
            
            da.UpdateCommand.Prepare();
            da.UpdateCommand.Parameters.AddWithValue("@Nama", nama);
            da.UpdateCommand.Parameters.AddWithValue("@HargaHPP", hargaHPP);
            da.UpdateCommand.Parameters.AddWithValue("@hargaJual", hargaJual);
            da.UpdateCommand.Parameters.AddWithValue("@s_dateUpdated", s_dateUpdated);
            da.UpdateCommand.Parameters.AddWithValue("@ID", id);
            da.UpdateCommand.Parameters.AddWithValue("@jumlah", jumlah);
             
            try
            {
                MessageBox.Show(da.UpdateCommand.ExecuteNonQuery().ToString());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void edit_cek_brg_btn_Click(object sender, EventArgs e)
        {
            if (editIdBrg_tb.Text != "")
            {
                int idBrg = Convert.ToInt32(editIdBrg_tb.Text);
                MySqlConnection conn = null;
                string cs = "server=localhost;userid=root;password=;database=pos;";
                try
                {
                    conn = new MySqlConnection(cs);
                    conn.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                DataSet ds = new DataSet();
                string sql = "select * from barang where ID='" + idBrg.ToString() + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                try
                {
                    da.Fill(ds, "brg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                dgv_brg_row.ReadOnly = true;
                dgv_brg_row.AllowUserToAddRows = false;
                dgv_brg_row.AllowUserToDeleteRows = false;
                dgv_brg_row.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_brg_row.DataSource = ds.Tables["brg"];
                if (ds.Tables.Count != 0)
                {
                    if (ds.Tables["brg"].Rows.Count != 0)
                    {
                        editNamaBrg_tb.Text = Convert.ToString(ds.Tables["brg"].Rows[0]["nama"]);
                        editHargaHPPBrg_tb.Text = Convert.ToString(ds.Tables["brg"].Rows[0]["HargaHPP"]);
                        editHargaJualBrg_tb.Text = Convert.ToString(ds.Tables["brg"].Rows[0]["HargaJual"]);
                        editJumlahBrg_tb.Text = Convert.ToString(ds.Tables["brg"].Rows[0]["JumlahAwal"]);
                    }
                }
                da.Dispose();
                conn.Close();
            }
        }

        private void hpsBrg_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda akan menghapus barang ini?", "Hapus Barang?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conn = null;
                string cs = "server=localhost;userid=root;password=;database=pos";
                conn = new MySqlConnection(cs);
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                string sql = "delete from barang where id=@id";
                da.DeleteCommand = new MySqlCommand(sql, conn);
                da.DeleteCommand.Prepare();
                string id = editIdBrg_tb.Text;
                da.DeleteCommand.Parameters.AddWithValue("@id", id);
                da.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                da.Dispose();
            }
        }

        private void barangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hidePanel();
            pnlEditBrg.Show();
            
        }

        private void pnlEditBrg_Paint(object sender, PaintEventArgs e)
        {
              
        }
    }
}
