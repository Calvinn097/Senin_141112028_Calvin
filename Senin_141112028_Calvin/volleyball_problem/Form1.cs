using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

double fakt(double n){
    if (n == 0)
    {
        return 1;
    }
    if (n == 1)
    {
        return 1;
    }
        return n * fakt(n-1);
}

double comb(double n,double k){
    double nilai=0;
    double atas =1;
    for(double i=n;i>max(n-k,k);i--){
        atas*=i;
    }
    nilai=atas/fakt(min(k,n-k));
    return nilai;

}

        double max(double a,double b)
        {
            if(a>b){
                return a;
            }
            return b;
        }

        double min(double a, double b)
        {
            if (a > b)
            {
                return b;
            }
            return a;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            
            double a = Convert.ToInt32( Txt1.Text);
            double b = Convert.ToInt32(Txt2.Text);
            //MessageBox.Show();
            if (a < 25 && b < 25)
            {
                TxtHasil.Text = "0";
            }
            else
            {
                if (max(a, b) == 25 && min(a, b) < 24)
                {
                    TxtHasil.Text = comb(a + b - 1, b).ToString();
                }
                /**else if (max(a, b) > 24 && min(a, b) > 24 && ((a - b) == 2))
                {

                }
                else
                {
                    //cout << 0 << endl;
                }
                 **/
            }
        }
    }
}
