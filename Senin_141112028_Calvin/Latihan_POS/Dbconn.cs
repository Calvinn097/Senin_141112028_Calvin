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
    
    class Dbconn
    {
        public string cs = "server=localhost;userid=root;password=;database=pos;";
        public MySqlConnection conn = null;
        public void initialize_conn()
        {
            this.conn = null;
            try
            {
                conn = new MySqlConnection(this.cs);
                conn.Open();
            }
            catch (MySqlException ex)
            {
            }
        }

        public void close_conn()
        {
            conn.Close();
        }
    }
}
