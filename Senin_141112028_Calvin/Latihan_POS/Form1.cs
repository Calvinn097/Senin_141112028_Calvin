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

            Barang brg = new Barang();
            brg.setId(id);
            brg.setNama(nama);
            brg.setKode(kode);
            brg.setJumlah(jumlah);
            brg.setHargahpp(hargahpp);
            brg.setHargajual(hargajual);
            brg.setCreated_at(DateTime.Now);
            brg.setUpdated_at(DateTime.Now);
            brg.insert_barang();
            
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
            DataSet ds = new DataSet();
            Barang brg = new Barang();
            ds = brg.lihat();
            dgvdaftar.ReadOnly = true;
            dgvdaftar.AllowUserToAddRows = false;
            dgvdaftar.AllowUserToDeleteRows = false;
            dgvdaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdaftar.DataSource = ds.Tables["barang"];
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

            Barang brg = new Barang();
            brg.setNama(nama);
            brg.setsHargahpp(hargaHPP);
            brg.setsHargajual(hargaJual);
            brg.setUpdated_at(dateUpdated);
            brg.setId(id);
            brg.setJumlah(Convert.ToInt32(jumlah));
            MessageBox.Show(brg.edit());
            
        }

        private void edit_cek_brg_btn_Click(object sender, EventArgs e)
        {
            if (editIdBrg_tb.Text != "")
            {
                int idBrg = Convert.ToInt32(editIdBrg_tb.Text);
                Barang brg = new Barang();
                brg.setId(idBrg);
                DataSet ds = brg.lihat();
                dgv_brg_row.ReadOnly = true;
                dgv_brg_row.AllowUserToAddRows = false;
                dgv_brg_row.AllowUserToDeleteRows = false;
                dgv_brg_row.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_brg_row.DataSource = ds.Tables["barang"];
                if (ds.Tables.Count != 0)
                {
                    if (ds.Tables["barang"].Rows.Count != 0)
                    {
                        editNamaBrg_tb.Text = Convert.ToString(ds.Tables["barang"].Rows[0]["nama"]);
                        editHargaHPPBrg_tb.Text = Convert.ToString(ds.Tables["barang"].Rows[0]["HargaHPP"]);
                        editHargaJualBrg_tb.Text = Convert.ToString(ds.Tables["barang"].Rows[0]["HargaJual"]);
                        editJumlahBrg_tb.Text = Convert.ToString(ds.Tables["barang"].Rows[0]["JumlahAwal"]);
                    }
                }
            }
        }

        private void hpsBrg_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda akan menghapus barang ini?", "Hapus Barang?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                string id = editIdBrg_tb.Text;
                Barang brg = new Barang();
                brg.setId(Convert.ToInt32(id));
                MessageBox.Show(brg.delete());
            }
        }

        private void barangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hidePanel();
            pnlEditBrg.Show();
            pnlEditBrg.Dock = DockStyle.Fill;
            
        }

        private void pnlEditBrg_Paint(object sender, PaintEventArgs e)
        {
              
        }
    }
}
