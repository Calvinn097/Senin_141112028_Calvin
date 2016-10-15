using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1_TextboxVerTI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.HideSelection = false;

            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            comboBox1.DataSource = fonts;
            List<string> sizes = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                sizes.Add(i.ToString());
            }
            comboBox2.DataSource = sizes;
            comboBox2.SelectedItem = "12";
            comboBox1.SelectedItem = "Times New Roman";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //richTextBox1.SelectionFont = new Font(comboBox1.SelectedItem.ToString(), Convert.ToInt16(comboBox2.SelectedItem));
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                //MessageBox.Show(richTextBox1.SelectionFont.Bold.ToString());
                if (checkBox1.Checked)
                {
                    //MessageBox.Show("asd");
                    //checkBox1.Checked = false;
                    if (!richTextBox1.SelectionFont.Bold)
                    {
                        bool ubah = true;
                        int start = richTextBox1.SelectionStart;
                        int end = richTextBox1.SelectionLength;
                        if (richTextBox1.SelectionFont == null)
                            return;
                        if (richTextBox1.SelectionFont.Bold)
                        { 
                            //MessageBox.Show("All text is Bold"); 
                        }
                        else if (richTextBox1.SelectedRtf.Replace(@"\\", "").IndexOf(@"\b") > -1)
                        {
                            ubah = false;
                            //MessageBox.Show("Mixed Content");
                        }
                        else
                            //MessageBox.Show("Text doesn't contain Bold");
                        //for (int i = 1; i < end; i++)
                        //{
                        //    richTextBox1.SelectionStart = start+i;
                        //    richTextBox1.SelectionLength = 1;
                        //    if (richTextBox1.SelectionFont.Bold)
                        //    {
                        //        ubah = false;
                        //        richTextBox1.SelectionStart = 0;
                        //        richTextBox1.SelectionLength = 0;
                        //        richTextBox1.SelectionStart = start;
                        //        richTextBox1.SelectionLength = end;
                        //        richTextBox1.Focus();
                        //        break;
                        //    }
                        //}
                        if (ubah)//jika ubah true dikarenakan karakter yang diblock tidak mengandung bold
                        {
                            richTextBox1.SelectionStart = start;
                            richTextBox1.SelectionLength = end;
                            if (richTextBox1.SelectionFont.Italic && richTextBox1.SelectionFont.Underline)
                            {
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                            }
                            else if (richTextBox1.SelectionFont.Italic)
                            {
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                            }
                            else if (richTextBox1.SelectionFont.Underline)
                            {
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline | FontStyle.Bold);
                            }
                            else
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                            //richTextBox1.DeselectAll();
                            //FontFamily rtb_fontfamily = new FontFamily(comboBox1.SelectedItem.ToString());
                            //richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
                            //richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                            //MessageBox.Show(richTextBox1.SelectionFont.Bold.ToString());
                        }
                       
                    }
                }
                else {
                    if (richTextBox1.SelectionFont.Bold)
                    {
                        int start = richTextBox1.SelectionStart;
                        int end = richTextBox1.SelectionLength;
                        if (richTextBox1.SelectionFont.Italic && richTextBox1.SelectionFont.Underline)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Underline);
                        }
                        else if (richTextBox1.SelectionFont.Italic)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                        }
                        else if (richTextBox1.SelectionFont.Underline)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                        }
                        else
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);

                        richTextBox1.SelectionStart = start;
                        richTextBox1.SelectionLength = end;
                    }
                }
            }
            else
            {
                if(checkBox1.Checked){
                    if(checkBox2.Checked&&checkBox3.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold|FontStyle.Italic|FontStyle.Underline);
                    else if(checkBox2.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                    else if(checkBox3.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }
                else
                {
                    if (checkBox2.Checked && checkBox3.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font,  FontStyle.Italic | FontStyle.Underline);
                    else if (checkBox2.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                    else if (checkBox3.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
            richTextBox1.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (checkBox2.Checked)
                {
                    if (!richTextBox1.SelectionFont.Italic)
                    {
                        bool ubah = true;
                        int start = richTextBox1.SelectionStart;
                        int end = richTextBox1.SelectionLength;
                        if (richTextBox1.SelectionFont == null)
                            return;
                        if (richTextBox1.SelectionFont.Italic)
                        {
                            //MessageBox.Show("All text is Bold"); 
                        }
                        else if (richTextBox1.SelectedRtf.Replace(@"\\", "").IndexOf(@"\i") > -1)
                        {
                            ubah = false;
                        }
                        else
                        {
                            if (ubah)
                            {
                                richTextBox1.SelectionStart = start;
                                richTextBox1.SelectionLength = end;
                                if (richTextBox1.SelectionFont.Bold && richTextBox1.SelectionFont.Underline)
                                {
                                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                                }
                                else if (richTextBox1.SelectionFont.Bold)
                                {
                                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                                }
                                else if (richTextBox1.SelectionFont.Underline)
                                {
                                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic);
                                }
                                else
                                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                                richTextBox1.SelectionStart = start;
                                richTextBox1.SelectionLength = end;
                            }
                        }

                    }

                }
                else
                {
                    if (richTextBox1.SelectionFont.Italic)
                    {
                        //checkBox1.Checked = true;
                        int start = richTextBox1.SelectionStart;
                        int end = richTextBox1.SelectionLength;
                        if (richTextBox1.SelectionFont.Bold && richTextBox1.SelectionFont.Underline)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                        }
                        else if (richTextBox1.SelectionFont.Bold)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold );
                        }
                        else if (richTextBox1.SelectionFont.Underline)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                        }
                        else
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                        richTextBox1.SelectionStart = start;
                        richTextBox1.SelectionLength = end;
                        richTextBox1.Focus();
                    }
                }
            }
            else
            {
                if (checkBox2.Checked)
                {
                    if (richTextBox1.SelectionFont.Bold&&richTextBox1.SelectionFont.Underline)
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold|FontStyle.Underline);
                    }
                    else if (richTextBox1.SelectionFont.Bold)
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                    }
                    else if (richTextBox1.SelectionFont.Underline)
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic);
                    }
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        if (checkBox1.Checked && checkBox3.Checked)
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                        else if (checkBox1.Checked)
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold);
                        else if (checkBox3.Checked)
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Underline);
                        else
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                    }
                    else
                    {
                        if (checkBox1.Checked && checkBox3.Checked)
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                        else if (checkBox1.Checked)
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        else if (checkBox3.Checked)
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                        else
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                    }
                }
            }
            richTextBox1.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (checkBox3.Checked)
                {
                    if (!richTextBox1.SelectionFont.Underline)
                    {
                        bool ubah = true;
                        int start = richTextBox1.SelectionStart;
                        int end = richTextBox1.SelectionLength;
                        if (richTextBox1.SelectionFont == null)
                            return;
                        
                        if (richTextBox1.SelectedRtf.Replace(@"\\", "").IndexOf(@"\ul") > -1)
                        {
                            MessageBox.Show("asd");
                            ubah = false;
                        }
                        if (ubah)
                        {
                            richTextBox1.SelectionStart = start;
                            richTextBox1.SelectionLength = end;
                            if (richTextBox1.SelectionFont.Bold && richTextBox1.SelectionFont.Italic)
                            {
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                            }
                            else if (richTextBox1.SelectionFont.Bold)
                            {
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                            }
                            else if (richTextBox1.SelectionFont.Italic)
                            {
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic);
                            }
                            else
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                            richTextBox1.SelectionStart = start;
                            richTextBox1.SelectionLength = end;
                        }

                    }

                }
                else
                {
                    if (richTextBox1.SelectionFont.Underline)
                    {
                        int start = richTextBox1.SelectionStart;
                        int end = richTextBox1.SelectionLength;
                        if (richTextBox1.SelectionFont.Bold && richTextBox1.SelectionFont.Italic)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                        }
                        else if (richTextBox1.SelectionFont.Bold)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold );
                        }
                        else if (richTextBox1.SelectionFont.Italic)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic );
                        }
                        else
                            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);

                        richTextBox1.SelectionStart = start;
                        richTextBox1.SelectionLength = end;
                    }
                }
            }
            else
            {
                if (checkBox3.Checked)
                {
                    if (checkBox2.Checked && checkBox1.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    else if (checkBox1.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                    else if (checkBox2.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Underline);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                }
                else
                {
                    if (checkBox2.Checked && checkBox1.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold);
                    else if (checkBox2.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                    else if (checkBox1.Checked)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
            richTextBox1.Focus();
        }
    }
}
