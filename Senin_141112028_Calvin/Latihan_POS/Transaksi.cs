using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;
namespace Latihan_POS
{
    class Transaksi
    {

        public int supplierID { set; get; }
        public int customerID { set; get; }
        public string tanggal { set; get; }
        public int totalPrice { set; get; }
        public struct brg
        {
            public int id;
            public int qty;
        }
        public List<brg> cart {  set;  get; }
        public Transaksi()
        {
            cart = new List<brg>();
        }
        public List<brg> add_barang(int idBrg,int qty)
        {
            brg barang = new brg();
            barang.id = idBrg;
            barang.qty = qty;
            int cek = cek_barang(idBrg);
            if (cek == -1)
                cart.Add(barang);
            else
            {
                barang = cart[cek];
                barang.qty += qty;
                cart[cek] = barang;
            }
            return cart;
        }

        public List<brg> min_barang(int idBrg, int qty)
        {
            brg barang = new brg();
            barang.id = idBrg;
            barang.qty = qty;
            int cek = cek_barang(idBrg);
            if (cek != -1)
            {
                barang = cart[cek];
                barang.qty -= qty;
                if (barang.qty < 0)
                {
                    barang.qty = 0;
                }
                cart[cek] = barang;
            }
            return cart;
        }

        public List<brg> remove(int idBrg)
        {
            int cek = cek_barang(idBrg);
            if (cek != -1)
            {
                cart.RemoveAt(cek);
            }
            return cart;
        }

        public int cek_barang(int idBrg)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].id == idBrg)
                {
                    return i;
                }
            }
            return -1;
        }

        public string beli(int supplierID)
        {
            int priceTot = 0;
            this.supplierID = supplierID;
            this.tanggal=(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
            Barang barang = new Barang();
            Dbconn db = new Dbconn();
            db.initialize_conn();
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "INSERT INTO buy(supplier_id,tanggal) VALUES(@supplier_id,@tanggal)";
            da.InsertCommand = new MySqlCommand(sql, db.conn);
            da.InsertCommand.Prepare();
            da.InsertCommand.Parameters.AddWithValue("@supplier_id", this.supplierID);
            da.InsertCommand.Parameters.AddWithValue("@tanggal", this.tanggal);
            da.InsertCommand.ExecuteNonQuery();
            int id_buy =Convert.ToInt32(da.InsertCommand.LastInsertedId);
            sql = "INSERT INTO buy_item( id_buy, id_barang,qty) VALUES(@idBuy,@idBarang,@qty)";
            
            for (int i = 0; i < cart.Count; i++)
            {
                da.InsertCommand = new MySqlCommand(sql, db.conn);
                da.InsertCommand.Prepare();
                //da.InsertCommand.Parameters.AddWithValue("@ID", this.id);
                da.InsertCommand.Parameters.AddWithValue("@idBuy", id_buy);
                da.InsertCommand.Parameters.AddWithValue("@idBarang", cart[i].id);
                da.InsertCommand.Parameters.AddWithValue("@qty", cart[i].qty);
                priceTot+=barang.getPrice(cart[i].id)*cart[i].qty;
                try { da.InsertCommand.ExecuteNonQuery().ToString(); }
                catch (MySqlException ex) { return ex.ToString(); }
            }
            sql = "update buy set total_price=@tot where id_pembelian="+id_buy.ToString();
            da.UpdateCommand = new MySqlCommand(sql, db.conn);
            this.totalPrice = priceTot;
            da.UpdateCommand.Parameters.AddWithValue("@tot", this.totalPrice);
            da.UpdateCommand.ExecuteNonQuery();
            db.close_conn();
            return "success";
        }

        public string jual(int customerID)
        {
            int priceTot = 0;
            this.customerID = customerID;
            this.tanggal = (DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
            Barang barang = new Barang();
            Dbconn db = new Dbconn();
            db.initialize_conn();
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "INSERT INTO sell(customer_id,tanggal) VALUES(@customer_id,@tanggal)";
            da.InsertCommand = new MySqlCommand(sql, db.conn);
            da.InsertCommand.Prepare();
            da.InsertCommand.Parameters.AddWithValue("@customer_id", this.customerID);
            da.InsertCommand.Parameters.AddWithValue("@tanggal", this.tanggal);
            da.InsertCommand.ExecuteNonQuery();
            int id_sell = Convert.ToInt32(da.InsertCommand.LastInsertedId);
            sql = "INSERT INTO sell_item( id_sell, id_barang,qty) VALUES(@idSell,@idBarang,@qty)";

            for (int i = 0; i < cart.Count; i++)
            {
                da.InsertCommand = new MySqlCommand(sql, db.conn);
                da.InsertCommand.Prepare();
                //da.InsertCommand.Parameters.AddWithValue("@ID", this.id);
                da.InsertCommand.Parameters.AddWithValue("@idSell", id_sell);
                da.InsertCommand.Parameters.AddWithValue("@idBarang", cart[i].id);
                da.InsertCommand.Parameters.AddWithValue("@qty", cart[i].qty);
                priceTot += barang.getPriceSell(cart[i].id) * cart[i].qty;
                try { da.InsertCommand.ExecuteNonQuery().ToString(); }
                catch (MySqlException ex) { return ex.ToString(); }
            }
            sql = "update sell set total_price=@tot where id_penjualan=" + id_sell.ToString();
            da.UpdateCommand = new MySqlCommand(sql, db.conn);
            this.totalPrice = priceTot;
            da.UpdateCommand.Parameters.AddWithValue("@tot", this.totalPrice);
            da.UpdateCommand.ExecuteNonQuery();
            db.close_conn();
            return "success";
        }

        public DataSet lihat()
        {
            Dbconn db = new Dbconn();
            db.initialize_conn();
            DataSet ds = new DataSet();
            string where = "";
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select id_pembelian,tanggal,total_price,supplier.Nama as namaSupplier,supplier.Alamat,supplier.NoHP from buy inner join supplier on supplier.ID=buy.supplier_id";
            da.SelectCommand = new MySqlCommand(sql, db.conn);
            da.Fill(ds, "historyPembelian");
            da.Dispose();
            db.close_conn();
            return ds;
        }

        public DataSet lihatJual()
        {
            Dbconn db = new Dbconn();
            db.initialize_conn();
            DataSet ds = new DataSet();
            string where = "";
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select id_penjualan,tanggal,total_price,customer.Nama as namaCustomer,customer.Alamat,customer.NoHP from sell inner join customer on customer.ID=sell.customer_id";
            da.SelectCommand = new MySqlCommand(sql, db.conn);
            da.Fill(ds, "historyPenjualan");
            da.Dispose();
            db.close_conn();
            return ds;
        }
    }
}
