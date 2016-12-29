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
    class Supplier
    {
        public int id { private set; get; }
        public string nama { private set; get; }
        public string alamat { private set; get; }
        public string nohp { private set; get; }
        public string gender { private set; get; }
        public string str_created_at { private set; get; }
        public string str_updated_at { private set; get; }

        public void setCreated_at(DateTime created_at) { this.str_created_at = created_at.ToString("yyyy-MM-dd HH:mm:ss"); }
        public void setUpdated_at(DateTime updated_at) { this.str_updated_at = updated_at.ToString("yyyy-MM-dd HH:mm:ss"); }
        public void setId(int id) { this.id = id; }
        public void setNama(string nama) { this.nama = nama; }
        public void setAlamat(string alamat) { this.alamat = alamat; }
        public void setNoHp(string nohp) { this.nohp = nohp; }
        public void setGender(string gender) { this.gender = gender; }

        public string insert()
        {
            Dbconn db = new Dbconn();
            db.initialize_conn();
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "INSERT INTO supplier( Nama, Alamat, NoHP, Gender, Created_at, Updated_at) VALUES(@Nama,@Alamat,@NoHP,@Gender,@Created_at,@Updated_at)";
            da.InsertCommand = new MySqlCommand(sql, db.conn);
            da.InsertCommand.Prepare();
            //da.InsertCommand.Parameters.AddWithValue("@ID", this.id);
            da.InsertCommand.Parameters.AddWithValue("@Nama", this.nama);
            da.InsertCommand.Parameters.AddWithValue("@Alamat", this.alamat);
            da.InsertCommand.Parameters.AddWithValue("@NoHP", this.nohp);
            da.InsertCommand.Parameters.AddWithValue("@Gender", this.gender);
            da.InsertCommand.Parameters.AddWithValue("@Created_at", this.str_created_at);
            da.InsertCommand.Parameters.AddWithValue("@Updated_at", this.str_updated_at);
            string res;
            try { res = da.InsertCommand.ExecuteNonQuery().ToString(); }
            catch (MySqlException ex) { return ex.ToString(); }
            db.close_conn();
            return "Berhasil insert :" + res + "Data";
        }

        public DataSet lihat()
        {
            Dbconn db = new Dbconn();
            db.initialize_conn();
            DataSet ds = new DataSet();
            string where = "";
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (this.id != 0)
            {
                string sql = "select * from supplier where ID=@id";
                da.SelectCommand = new MySqlCommand(sql, db.conn);
                da.SelectCommand.Prepare();
                da.SelectCommand.Parameters.AddWithValue("@id", this.id);
            }
            else
            {
                string sql = "select * from supplier";
                da.SelectCommand = new MySqlCommand(sql, db.conn);
            }
            da.Fill(ds, "supplier");
            da.Dispose();
            db.close_conn();
            return ds;
        }

        public string edit()
        {
            Dbconn db = new Dbconn();
            string sql = "update supplier set nama=@Nama,Alamat=@Alamat,NoHP=@NoHP,Gender=@Gender,Updated_at=@s_dateUpdated where ID=@ID";
            MySqlDataAdapter da = new MySqlDataAdapter();
            db.initialize_conn();
            da.UpdateCommand = new MySqlCommand(sql, db.conn);
            da.UpdateCommand.Prepare();
            da.UpdateCommand.Parameters.AddWithValue("@Nama", this.nama);
            da.UpdateCommand.Parameters.AddWithValue("@Alamat", this.alamat);
            da.UpdateCommand.Parameters.AddWithValue("@NoHP", this.nohp);
            da.UpdateCommand.Parameters.AddWithValue("@s_dateUpdated", this.str_updated_at);
            da.UpdateCommand.Parameters.AddWithValue("@ID", this.id);
            da.UpdateCommand.Parameters.AddWithValue("@Gender", this.gender);
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
            string sql = "delete from supplier where ID=@id";
            MySqlDataAdapter da = new MySqlDataAdapter();
            db.initialize_conn();
            da.DeleteCommand = new MySqlCommand(sql, db.conn);
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
