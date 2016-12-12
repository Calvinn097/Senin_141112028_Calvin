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
    class Staff
    {
        public string staffID { private set; get; }
        public string staffname { private set; get; }
        public bool isLoggedIn { private set; get; }

        public Staff()
        {
            staffname = "";
            isLoggedIn = false;
        }

        public bool login(string staffname, string password)
        {
            this.staffname = staffname;
            string cs = "server=localhost;userid=root;password=;database=pos;";
            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "Select * from staff where Staffname = @staffname";
            da.SelectCommand = new MySqlCommand(sql, conn);
            da.SelectCommand.Prepare();
            da.SelectCommand.Parameters.AddWithValue("@staffname", staffname);
            DataSet ds=new DataSet();
            da.Fill(ds, "staff");
            string passwordHash="";
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables["staff"].Rows.Count != 0)
                {
                    
                    passwordHash = ds.Tables["staff"].Rows[0]["Password"].ToString();
                    if (BCrypt.CheckPassword(password,passwordHash))
                    {
                        this.staffID = ds.Tables["staff"].Rows[0]["StaffID"].ToString();
                        this.staffname = ds.Tables["staff"].Rows[0]["Staffname"].ToString();
                        this.isLoggedIn = true;
                    }
                }
            }

            conn.Close();

            return this.isLoggedIn;
            /**
            Dictionary<string, string> staffInfo = new Dictionary<string, string>();
            staffInfo.Add("staffname", this.staffname);
            staffInfo.Add("staffid", this.staffID);
            staffInfo.Add("password", passwordHash);
             **/
        }
    }
}
