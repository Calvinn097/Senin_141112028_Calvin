using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, 3, 17));
            int today = (int)DateTime.Now.DayOfWeek;
            int sabtu_depan = 6 - today;
            int sabtu_lalu = sabtu_depan - 7;
            int minggu_depan = sabtu_depan + 1;
            int minggu_lalu = minggu_depan - 7;
            for (int i = 0; i < 240; i++)
            {
                monthCalendar1.AddBoldedDate(DateTime.Now.AddDays(sabtu_depan));
                monthCalendar1.AddBoldedDate(DateTime.Now.AddDays(minggu_depan));
                monthCalendar1.AddBoldedDate(DateTime.Now.AddDays(minggu_lalu));
                monthCalendar1.AddBoldedDate(DateTime.Now.AddDays(sabtu_lalu));
                sabtu_depan += 7;
                minggu_depan += 7;
                minggu_lalu -= 7;
                sabtu_lalu -= 7;
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (domainUpDown1.SelectedItem.ToString() == "" || domainUpDown2.SelectedItem.ToString() == "")
            {
                MessageBox.Show("empty");
            }
            int day = Convert.ToInt32(domainUpDown1.SelectedItem);
            int month;
            switch (domainUpDown2.SelectedItem.ToString())
            {
                case "Januari":
                    month = 1;
                    break;
                case "Februari":
                    month = 2;
                    break;
                case "Maret":
                    month = 3;
                    break;
                case "April":
                    month = 4;
                    break;
                case "Mei":
                    month = 5;
                    break;
                case "Juni":
                    month = 6;
                    break;
                case "Juli":
                    month = 7;
                    break;
                case "Agustus":
                    month = 8;
                    break;
                case "September":
                    month = 9;
                    break;
                case "Oktober":
                    month = 10;
                    break;
                case "November":
                    month = 11;
                    break;
                default:
                    month = 12;
                    break;
            }
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016,month,day));
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(domainUpDown1.SelectedItem);
            int month;
            switch (domainUpDown2.SelectedItem.ToString())
            {
                case "Januari":
                    month = 1;
                    break;
                case "Februari":
                    month = 2;
                    break;
                case "Maret":
                    month = 3;
                    break;
                case "April":
                    month = 4;
                    break;
                case "Mei":
                    month = 5;
                    break;
                case "Juni":
                    month = 6;
                    break;
                case "Juli":
                    month = 7;
                    break;
                case "Agustus":
                    month = 8;
                    break;
                case "September":
                    month = 9;
                    break;
                case "Oktober":
                    month = 10;
                    break;
                case "November":
                    month = 11;
                    break;
                default:
                    month = 12;
                    break;
            }
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, month, day));
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
