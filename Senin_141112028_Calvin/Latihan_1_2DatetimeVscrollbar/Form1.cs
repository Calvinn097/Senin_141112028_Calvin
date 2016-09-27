using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2DatetimeVscrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = vScrollBar1.Value.ToString();
            label2.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime sekarang = new DateTime();
            sekarang = DateTime.Now;
            DateTime minn = new DateTime();
            minn = sekarang.AddYears(-vScrollBar1.Value);
            dateTimePicker1.MinDate = minn;
            label1.Text = vScrollBar1.Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime sekarang = new DateTime();
            sekarang = DateTime.Now;
            DateTime maxx = new DateTime();
            maxx = sekarang.AddYears(vScrollBar2.Value);
            dateTimePicker1.MaxDate = maxx;
            label2.Text = vScrollBar2.Value.ToString();
        }
    }
}
