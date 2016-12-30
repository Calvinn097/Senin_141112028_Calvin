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
        static Transaksi beli;
        static Transaksi jual;
        public Form1()
        {
            beli = new Transaksi();
            jual = new Transaksi();
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

        private void simpanCusInpBtn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.setNama(namaCusInpTB.Text);
            cust.setAlamat(alamatCusInpTB.Text);
            cust.setNoHp(noHpCusInpTB.Text);
            cust.setGender(genderBoxInpCB.Text);
            cust.setCreated_at(DateTime.Now);
            cust.setUpdated_at(DateTime.Now);
            MessageBox.Show(cust.insert());
        }

        private void batalCusInpBtn_Click(object sender, EventArgs e)
        {
            namaCusInpTB.Text = "";
            alamatCusInpTB.Text = "";
            noHpCusInpTB.Text = "";
            genderBoxInpCB.Text = "";
        }

        private void cusomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanel();
            panelLhtCust.Show();
            panelLhtCust.Dock = DockStyle.Fill;
            DataSet ds = new DataSet();
            Customer cus = new Customer();
            ds = cus.lihat();
            custListDgv.ReadOnly = true;
            custListDgv.AllowUserToAddRows = false;
            custListDgv.AllowUserToDeleteRows = false;
            custListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custListDgv.DataSource = ds.Tables["customer"];
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanel();
            register_user_pnl.Show();
            register_user_pnl.Dock = DockStyle.Fill;
        }

        private void cekCustBTN_Click(object sender, EventArgs e)
        {
            if (idCustEditBTN.Text!= "")
            {
                Customer cus = new Customer();
                cus.setId(Convert.ToInt32(idCustEditBTN.Text));
                DataSet ds = cus.lihat();

                cekCustDGV.ReadOnly = true;
                cekCustDGV.AllowUserToAddRows = false;
                cekCustDGV.AllowUserToDeleteRows = false;
                cekCustDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                cekCustDGV.DataSource = ds.Tables["customer"];
                if (ds.Tables.Count != 0)
                {
                    if (ds.Tables["customer"].Rows.Count != 0)
                    {
                        namaCustEditTB.Text = Convert.ToString(ds.Tables["customer"].Rows[0]["Nama"]);
                        alamatCusEditTB.Text = Convert.ToString(ds.Tables["customer"].Rows[0]["Alamat"]);
                        noHpCusEditTB.Text = Convert.ToString(ds.Tables["customer"].Rows[0]["NoHp"]);
                        genderCustEditTB.Text = Convert.ToString(ds.Tables["customer"].Rows[0]["Gender"]);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpanEditBTN_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.setId(Convert.ToInt32(idCustEditBTN.Text));
            cust.setNama(namaCustEditTB.Text);
            cust.setAlamat(alamatCusEditTB.Text);
            cust.setUpdated_at(DateTime.Now);
            cust.setGender(genderCustEditTB.Text);
            cust.setNoHp(noHpCusEditTB.Text);
            cust.edit();
        }

        private void hpsCustBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda akan menghapus ini?", "Hapus ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Customer cus = new Customer();
                cus.setId(Convert.ToInt32(idCustEditBTN.Text));
                MessageBox.Show(cus.delete());
            }
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hidePanel();
            editCustPanel.Show();
            editCustPanel.Dock = DockStyle.Fill;
        }

        private void simpanSupBTN_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.setNama(namaSupInpTB.Text);
            sup.setAlamat(alamatSupInpTB.Text);
            sup.setNoHp(noHPSupTB.Text);
            sup.setGender(genderSupTB.Text);
            sup.setCreated_at(DateTime.Now);
            sup.setUpdated_at(DateTime.Now);
            sup.insert();
        }

        private void batalSupInpBTN_Click(object sender, EventArgs e)
        {
            namaSupInpTB.Text = "";
            alamatSupInpTB.Text = "";
            noHPSupTB.Text = "";
            genderSupTB.Text = "";
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanel();
            regisSupPanel.Show();
            regisSupPanel.Dock = DockStyle.Fill;
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hidePanel();
            lihatSupPanel.Show();
            lihatSupPanel.Dock = DockStyle.Fill;
            DataSet ds = new DataSet();
            Supplier sup = new Supplier();
            ds = sup.lihat();
            lihatSupDGV.ReadOnly = true;
            lihatSupDGV.AllowUserToAddRows = false;
            lihatSupDGV.AllowUserToDeleteRows = false;
            lihatSupDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lihatSupDGV.DataSource = ds.Tables["supplier"];

        }

        private void cekSupEditBTN_Click(object sender, EventArgs e)
        {

            if (idSupEditTB.Text != "")
            {
                Supplier sup = new Supplier();
                sup.setId(Convert.ToInt32(idSupEditTB.Text));
                DataSet ds = sup.lihat();

                cekSupDGV.ReadOnly = true;
                cekSupDGV.AllowUserToAddRows = false;
                cekSupDGV.AllowUserToDeleteRows = false;
                cekSupDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                cekSupDGV.DataSource = ds.Tables["supplier"];
                if (ds.Tables.Count != 0)
                {
                    if (ds.Tables["supplier"].Rows.Count != 0)
                    {
                        namaSupEditTB.Text = Convert.ToString(ds.Tables["supplier"].Rows[0]["Nama"]);
                        alamatSupEditTB.Text = Convert.ToString(ds.Tables["supplier"].Rows[0]["Alamat"]);
                        noHPSupEditTB.Text = Convert.ToString(ds.Tables["supplier"].Rows[0]["NoHp"]);
                        genderSupCB.Text = Convert.ToString(ds.Tables["supplier"].Rows[0]["Gender"]);
                    }
                }
            }
        }

        private void saveSupEditBTN_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.setNama(namaSupEditTB.Text);
            sup.setId(Convert.ToInt32(idSupEditTB.Text));
            sup.setAlamat(alamatSupEditTB.Text);
            sup.setNoHp(noHPSupEditTB.Text);
            sup.setGender(genderSupCB.Text);
            sup.edit();

        }

        private void delSupEditBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda akan menghapus ini?", "Hapus ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Supplier sup = new Supplier();
                sup.setId(Convert.ToInt32(idSupEditTB.Text));
                MessageBox.Show(sup.delete());
            }
        }

        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hidePanel();
            editSupPanel.Show();
            editSupPanel.Dock = DockStyle.Fill;
        }

        private void addListPembelian_Click(object sender, EventArgs e)
        {
            
            //Latihan_POS.Transaksi.brg brg = new Latihan_POS.Transaksi.brg();
            List<Latihan_POS.Transaksi.brg> listBrg = new List<Transaksi.brg>();
            listBrg = beli.add_barang(Convert.ToInt32(idBrgPembelian.Text), Convert.ToInt32(qtyBrgPembelian.Text));
            Barang clsBrg = new Barang();
            DataSet ds=new DataSet();
            this.keranjangBeli.DataSource = null;
            this.keranjangBeli.Rows.Clear();
            this.keranjangBeli.Columns.Clear();
            this.keranjangBeli.Columns.Add("idBrg", "ID Barang");
            this.keranjangBeli.Columns.Add("namaBrg", "Nama");
            this.keranjangBeli.Columns.Add("qtyBrg", "Qty");
            this.keranjangBeli.Columns.Add("hargaPcs", "@harga");
            this.keranjangBeli.Columns.Add("hargaTot", "Harga Total");
            for(int i=0;i<listBrg.Count;i++){
                clsBrg.setId(listBrg[i].id);
                ds=clsBrg.lihat();
                //ds.Tables["supplier"].Rows[0]["Gender"];
                foreach(DataRow row in ds.Tables["barang"].Rows){
                    this.keranjangBeli.Rows.Add(row["ID"].ToString(),
                            row["Nama"].ToString(),
                            listBrg[i].qty,
                            row["HargaHPP"].ToString(),
                            (Convert.ToInt32(row["HargaHPP"])*Convert.ToInt32(listBrg[i].qty)).ToString()
                        );
                }

            }
            //this.keranjangBeli.Columns.Add("test", "test2");
            //this.keranjangBeli.Rows.Add("HelloHelloo","hllo2");
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanel();
            pembelian_pnl.Show();
            pembelian_pnl.Dock = DockStyle.Fill;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Latihan_POS.Transaksi.brg brg = new Latihan_POS.Transaksi.brg();
            List<Latihan_POS.Transaksi.brg> listBrg = new List<Transaksi.brg>();
            listBrg = beli.min_barang(Convert.ToInt32(idBrgPembelian.Text), Convert.ToInt32(qtyBrgPembelian.Text));
            Barang clsBrg = new Barang();
            DataSet ds = new DataSet();
            this.keranjangBeli.DataSource = null;
            this.keranjangBeli.Rows.Clear();
            this.keranjangBeli.Columns.Clear();
            this.keranjangBeli.Columns.Add("idBrg", "ID Barang");
            this.keranjangBeli.Columns.Add("namaBrg", "Nama");
            this.keranjangBeli.Columns.Add("qtyBrg", "Qty");
            this.keranjangBeli.Columns.Add("hargaPcs", "@harga");
            this.keranjangBeli.Columns.Add("hargaTot", "Harga Total");
            for (int i = 0; i < listBrg.Count; i++)
            {
                clsBrg.setId(listBrg[i].id);
                ds = clsBrg.lihat();
                //ds.Tables["supplier"].Rows[0]["Gender"];
                foreach (DataRow row in ds.Tables["barang"].Rows)
                {
                    this.keranjangBeli.Rows.Add(row["ID"].ToString(),
                            row["Nama"].ToString(),
                            listBrg[i].qty,
                            row["HargaHPP"].ToString(),
                            (Convert.ToInt32(row["HargaHPP"]) * Convert.ToInt32(listBrg[i].qty)).ToString()
                        );
                }

            }
        }

        private void HpsBrgBeliBTN_Click(object sender, EventArgs e)
        {
            List<Latihan_POS.Transaksi.brg> listBrg = new List<Transaksi.brg>();
            listBrg = beli.remove(Convert.ToInt32(idBrgPembelian.Text));
            Barang clsBrg = new Barang();
            DataSet ds = new DataSet();
            this.keranjangBeli.DataSource = null;
            this.keranjangBeli.Rows.Clear();
            this.keranjangBeli.Columns.Clear();
            this.keranjangBeli.Columns.Add("idBrg", "ID Barang");
            this.keranjangBeli.Columns.Add("namaBrg", "Nama");
            this.keranjangBeli.Columns.Add("qtyBrg", "Qty");
            this.keranjangBeli.Columns.Add("hargaPcs", "@harga");
            this.keranjangBeli.Columns.Add("hargaTot", "Harga Total");
            for (int i = 0; i < listBrg.Count; i++)
            {
                clsBrg.setId(listBrg[i].id);
                ds = clsBrg.lihat();
                //ds.Tables["supplier"].Rows[0]["Gender"];
                foreach (DataRow row in ds.Tables["barang"].Rows)
                {
                    this.keranjangBeli.Rows.Add(row["ID"].ToString(),
                            row["Nama"].ToString(),
                            listBrg[i].qty,
                            row["HargaHPP"].ToString(),
                            (Convert.ToInt32(row["HargaHPP"]) * Convert.ToInt32(listBrg[i].qty)).ToString()
                        );
                }

            }
        }

        private void checkoutPembelian_Click(object sender, EventArgs e)
        {
            MessageBox.Show(beli.beli(Convert.ToInt32(suppIDBeliBrgTB.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Latihan_POS.Transaksi.brg brg = new Latihan_POS.Transaksi.brg();
            List<Latihan_POS.Transaksi.brg> listBrg = new List<Transaksi.brg>();

            listBrg = jual.add_barang(Convert.ToInt32(idBrgJualTB.Text), Convert.ToInt32(qtyBrgJualTB.Text));
            Barang clsBrg = new Barang();
            DataSet ds = new DataSet();

            this.JualCart.DataSource = null;
            this.JualCart.Rows.Clear();
            this.JualCart.Columns.Clear();
            this.JualCart.Columns.Add("idBrg", "ID Barang");
            this.JualCart.Columns.Add("namaBrg", "Nama");
            this.JualCart.Columns.Add("qtyBrg", "Qty");
            this.JualCart.Columns.Add("hargaPcs", "@harga");
            this.JualCart.Columns.Add("hargaTot", "Harga Total");
            for (int i = 0; i < listBrg.Count; i++)
            {
                clsBrg.setId(listBrg[i].id);
                ds = clsBrg.lihat();
                //ds.Tables["supplier"].Rows[0]["Gender"];
                foreach (DataRow row in ds.Tables["barang"].Rows)
                {
                    this.JualCart.Rows.Add(row["ID"].ToString(),
                            row["Nama"].ToString(),
                            listBrg[i].qty,
                            row["HargaJual"].ToString(),
                            (Convert.ToInt32(row["HargaJual"]) * Convert.ToInt32(listBrg[i].qty)).ToString()
                        );
                }

            }
        }

        private void minSell_Click(object sender, EventArgs e)
        {
            //Latihan_POS.Transaksi.brg brg = new Latihan_POS.Transaksi.brg();
            List<Latihan_POS.Transaksi.brg> listBrg = new List<Transaksi.brg>();
            listBrg = jual.min_barang(Convert.ToInt32(idBrgJualTB.Text), Convert.ToInt32(qtyBrgJualTB.Text));
            Barang clsBrg = new Barang();
            DataSet ds = new DataSet();
            this.JualCart.DataSource = null;
            this.JualCart.Rows.Clear();
            this.JualCart.Columns.Clear();
            this.JualCart.Columns.Add("idBrg", "ID Barang");
            this.JualCart.Columns.Add("namaBrg", "Nama");
            this.JualCart.Columns.Add("qtyBrg", "Qty");
            this.JualCart.Columns.Add("hargaPcs", "@harga");
            this.JualCart.Columns.Add("hargaTot", "Harga Total");
            for (int i = 0; i < listBrg.Count; i++)
            {
                clsBrg.setId(listBrg[i].id);
                ds = clsBrg.lihat();
                //ds.Tables["supplier"].Rows[0]["Gender"];
                foreach (DataRow row in ds.Tables["barang"].Rows)
                {
                    this.JualCart.Rows.Add(row["ID"].ToString(),
                            row["Nama"].ToString(),
                            listBrg[i].qty,
                            row["HargaJual"].ToString(),
                            (Convert.ToInt32(row["HargaJual"]) * Convert.ToInt32(listBrg[i].qty)).ToString()
                        );
                }

            }
        }

        private void delSell_Click(object sender, EventArgs e)
        {
            List<Latihan_POS.Transaksi.brg> listBrg = new List<Transaksi.brg>();
            listBrg = jual.remove(Convert.ToInt32(idBrgJualTB.Text));
            Barang clsBrg = new Barang();
            DataSet ds = new DataSet();
            this.JualCart.DataSource = null;
            this.JualCart.Rows.Clear();
            this.JualCart.Columns.Clear();
            this.JualCart.Columns.Add("idBrg", "ID Barang");
            this.JualCart.Columns.Add("namaBrg", "Nama");
            this.JualCart.Columns.Add("qtyBrg", "Qty");
            this.JualCart.Columns.Add("hargaPcs", "@harga");
            this.JualCart.Columns.Add("hargaTot", "Harga Total");
            for (int i = 0; i < listBrg.Count; i++)
            {
                clsBrg.setId(listBrg[i].id);
                ds = clsBrg.lihat();
                //ds.Tables["supplier"].Rows[0]["Gender"];
                foreach (DataRow row in ds.Tables["barang"].Rows)
                {
                    this.JualCart.Rows.Add(row["ID"].ToString(),
                            row["Nama"].ToString(),
                            listBrg[i].qty,
                            row["HargaJual"].ToString(),
                            (Convert.ToInt32(row["HargaJual"]) * Convert.ToInt32(listBrg[i].qty)).ToString()
                        );
                }

            }
        }

        private void checkoutCust_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jual.jual(Convert.ToInt32(custIDJualTB.Text)));
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanel();
            panel1.Show();
            panel1.Dock = DockStyle.Fill;
        }
    }
}
