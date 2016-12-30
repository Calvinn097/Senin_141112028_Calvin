using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace Latihan_POS
{
    class Barang
    {
        
        
        public int id {private set; get; }
        public int jumlah{private set;get;}
        public string kode { private set; get; }
        public string nama { private set; get; }
        public float hargahpp { private set; get; }
        public float hargajual { private set; get; }
        public string shargahpp { private set; get; }
        public string shargajual { private set; get; }
        public string str_created_at {private set;get;}
        public string str_updated_at { private set; get; }
        public void setId(int id){this.id = id;}
        public void setJumlah(int jlh) { this.jumlah = jlh; }
        public void setKode(string kode) { this.kode = kode; }
        public void setNama(string nama) { this.nama = nama; }
        public void setHargahpp(float hargahpp) { this.hargahpp = hargahpp; }
        public void setHargajual(float hargajual) { this.hargajual = hargajual; }
        public void setsHargahpp(string hargahpp) { this.shargahpp = hargahpp; }
        public void setsHargajual(string hargajual) { this.shargajual = hargajual; }
        public void setCreated_at(DateTime created_at) { this.str_created_at = created_at.ToString("yyyy-MM-dd HH:mm:ss"); }
        public void setUpdated_at(DateTime updated_at) { this.str_updated_at = updated_at.ToString("yyyy-MM-dd HH:mm:ss"); }

        public string insert_barang(){
            Dbconn db = new Dbconn();
            db.initialize_conn();
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "INSERT INTO barang(ID, Kode, Nama, JumlahAwal, HargaHPP, HargaJual, Created_at, Updated_at) VALUES(@Id,@Kode,@Nama,@JumlahAwal,@HargaHPP,@HargaJual,@Created_at,@Updated_at)";
            da.InsertCommand = new MySqlCommand(sql, db.conn);
            da.InsertCommand.Prepare();
            da.InsertCommand.Parameters.AddWithValue("@ID", this.id);
            da.InsertCommand.Parameters.AddWithValue("@Kode", this.kode);
            da.InsertCommand.Parameters.AddWithValue("@Nama", this.nama);
            da.InsertCommand.Parameters.AddWithValue("@JumlahAwal", this.jumlah);
            da.InsertCommand.Parameters.AddWithValue("@HargaHPP", this.hargahpp);
            da.InsertCommand.Parameters.AddWithValue("@HargaJual", this.hargajual);
            da.InsertCommand.Parameters.AddWithValue("@Created_at", this.str_created_at);
            da.InsertCommand.Parameters.AddWithValue("@Updated_at", this.str_updated_at);

            try { da.InsertCommand.ExecuteNonQuery();  }
            catch (MySqlException ex) { return ex.ToString(); }
            db.close_conn();
            return "berhasil";
        }

        public DataSet lihat()
        {
            Dbconn db = new Dbconn();
            db.initialize_conn();
            DataSet ds = new DataSet();
            string where="";
            MySqlDataAdapter da=new MySqlDataAdapter();
            if(this.id!=0){
                string sql = "select * from barang where ID=@id";
                da.SelectCommand=new MySqlCommand(sql,db.conn);
                da.SelectCommand.Prepare();
                da.SelectCommand.Parameters.AddWithValue("@id",this.id);
            }else{
                string sql = "select * from barang";
                da.SelectCommand = new MySqlCommand(sql, db.conn);
            }
            da.Fill(ds, "barang");
            da.Dispose();
            db.close_conn();
            return ds;
        }

        public int getPrice(int id)
        {
            this.id = id;
            DataSet ds = new DataSet();
            ds = this.lihat();
            int price=Convert.ToInt32(ds.Tables["barang"].Rows[0]["HargaHPP"]);
            return price;
        }

        public int getPriceSell(int id)
        {
            this.id = id;
            DataSet ds = new DataSet();
            ds = this.lihat();
            int price = Convert.ToInt32(ds.Tables["barang"].Rows[0]["HargaJual"]);
            return price;
        }

        public string edit()
        {
            Dbconn db = new Dbconn();
            string sql = "update barang set nama=@Nama,HargaHPP=@hargaHPP,HargaJual=@hargaJual,JumlahAwal=@jumlah,Updated_at=@s_dateUpdated where ID=@ID";
            MySqlDataAdapter da = new MySqlDataAdapter();
            db.initialize_conn();
            da.UpdateCommand = new MySqlCommand(sql, db.conn);
            da.UpdateCommand.Prepare();
            da.UpdateCommand.Parameters.AddWithValue("@Nama", this.nama);
            da.UpdateCommand.Parameters.AddWithValue("@HargaHPP", this.shargahpp);
            da.UpdateCommand.Parameters.AddWithValue("@hargaJual", this.shargajual);
            da.UpdateCommand.Parameters.AddWithValue("@s_dateUpdated", this.str_updated_at);
            da.UpdateCommand.Parameters.AddWithValue("@ID", this.id);
            da.UpdateCommand.Parameters.AddWithValue("@jumlah", this.jumlah);
            string res;
            try
            {
                res = da.UpdateCommand.ExecuteNonQuery().ToString();
            }
            catch (MySqlException ex)
            {
                res = ex.ToString();
            }
            db.close_conn();
            da.Dispose();
            return res;
        }

        public string delete()
        {
            Dbconn db = new Dbconn();
            string sql = "delete from barang where ID=@id";
            MySqlDataAdapter da = new MySqlDataAdapter();
            db.initialize_conn();
            da.DeleteCommand=new MySqlCommand(sql, db.conn);
            da.DeleteCommand.Prepare();
            if (this.id != 0)
            {
                da.DeleteCommand.Parameters.AddWithValue("@id", this.id);
                return da.DeleteCommand.ExecuteNonQuery().ToString();
            }
            else
            {
                return "gagal karena tidak ada id";
            }
            da.Dispose();
            db.close_conn();
            
        }
    }
}
