using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Latihan_POS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Staff staff= new Staff();
            bool loginStatus;
            string staffname, password;
            staffname = username_tb.Text;
            password = password_tb.Text;
            loginStatus=staff.login(staffname,password);
            if (loginStatus)
            {
                loginForm loginForm = new loginForm();
                loginForm.Close();

                this.Hide();
                Form1 form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah");
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
