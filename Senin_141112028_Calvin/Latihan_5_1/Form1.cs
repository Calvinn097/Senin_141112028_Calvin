using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public string save_filepath="";
        public bool edited = false;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.HideSelection = false;

            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            toolStripComboBox2.ComboBox.DataSource = fonts;
            List<string> sizes = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                sizes.Add(i.ToString());
            }
            toolStripComboBox1.ComboBox.DataSource = sizes;
            toolStripComboBox1.ComboBox.SelectedItem = "12";
            toolStripComboBox2.ComboBox.SelectedItem = "Times New Roman";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //richTextBox1.SelectionFont = new Font(comtoolStripComboBox2.ComboBoxboBox1.SelectedItem.ToString(), Convert.ToInt16(comboBox2.SelectedItem));
            if (richTextBox1.SelectedText.ToString() != "") {
                int start = richTextBox1.SelectionStart;
                int length = richTextBox1.SelectionLength;
                Font font = richTextBox1.SelectionFont;
                //FontFamily fam = richTextBox1.SelectionFont.FontFamily;
                FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                for (int i = 0; i < length; i++)
                {
                    richTextBox1.SelectionStart = i + start;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(fam, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                }
            }
            else
            {
                FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                if (Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem) != 0)
                {
                    richTextBox1.SelectionFont = new Font(fam, Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem), richTextBox1.SelectionFont.Style);
                }
            }

            richTextBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.ToString() != "")
            {
                int start = richTextBox1.SelectionStart;
                int length = richTextBox1.SelectionLength;
                Font font = richTextBox1.SelectionFont;
                FontFamily fam = richTextBox1.SelectionFont.FontFamily;
                int size = Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem);
                for (int i = 0; i < length; i++)
                {
                    richTextBox1.SelectionStart = i + start;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style);
                }
            }
            else
            {
                FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                richTextBox1.SelectionFont = new Font(fam, Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem), richTextBox1.SelectionFont.Style);
            }

            richTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.ToString() != "")
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }
            richTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(saveFileDialog1.FileName.ToString());
            //}
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            edited = true;
        }

        private void Load_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edited)
            {
                DialogResult res = MessageBox.Show("Start new?", "New File", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.OK)
                {
                    richTextBox1.Text = "";
                    edited = false;
                }
            }
            else
            {
                richTextBox1.Text = "";
                edited = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            openFileDialog1.RestoreDirectory = true;
            if (save_filepath == "" )
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    save_filepath = saveFileDialog1.FileName;
                    edited = false;
                }
            }
            else if(edited)
            {
                DialogResult res = MessageBox.Show("Do you want to overwrite?", "Overwrite Confirm", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    save_filepath = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(save_filepath);
                    edited = false;
                }
                else if (DialogResult.No == res)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName);
                        save_filepath = saveFileDialog1.FileName;
                        edited = false;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "Rich Text Format (*rtf)|*.rtf";
            openFileDialog1.RestoreDirectory = true;
            if (edited)
            {
                if (MessageBox.Show("Load new file and replace this?", "Load File?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        save_filepath = openFileDialog1.FileName;
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                        edited = false;
                    }
                }
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    save_filepath = openFileDialog1.FileName;
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                    edited = false;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(abc++.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.ToString() != "")
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }
            richTextBox1.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripButton2.Checked)
            {
                toolStripButton2.Checked = false;
            }
            else
            {
                toolStripButton2.Checked = true;
            }
            if (toolStripButton2.Checked)
            {
                if (richTextBox1.SelectedText != "")
                {
                    int length = richTextBox1.SelectionLength;
                    int start = richTextBox1.SelectionStart;
                    FontFamily ffi, ffj;
                    FontStyle fsi, fsj;
                    for (int i = 0; i < length; i++)
                    {
                        richTextBox1.SelectionStart = start + i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    }
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = length;
                    richTextBox1.Focus();
                    //if (length == 1)
                    //{
                    //    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    //}
                    //for (int i = 0; i < length-1; i++)
                    //{
                    //    richTextBox1.SelectionStart=start+i;
                    //    richTextBox1.SelectionLength = 1;
                    //    ffi= richTextBox1.SelectionFont.FontFamily;
                    //    fsi= richTextBox1.SelectionFont.Style;
                    //    for (int j = i + 1; j < length; j++)
                    //    {
                    //        richTextBox1.SelectionStart = start + j;
                    //        richTextBox1.SelectionLength = 1;
                    //        ffj = richTextBox1.SelectionFont.FontFamily;
                    //        fsj = richTextBox1.SelectionFont.Style;
                    //        if (j == length - 1)
                    //        {
                    //            if (fsi.ToString() != fsj.ToString() || ffi.ToString() != ffj.ToString())
                    //            {
                    //                richTextBox1.SelectionStart = start + i;
                    //                richTextBox1.SelectionLength = j - i;
                    //                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    //                //MessageBox.Show(fsi.ToString()+ " " + fsj.ToString());
                    //                i = j - 1;


                    //            }
                    //            richTextBox1.SelectionStart = start + j;
                    //            richTextBox1.SelectionLength = 1;

                    //            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    //            break;

                    //        }
                    //        else if (fsi.ToString() != fsj.ToString() || ffi.ToString() != ffj.ToString())
                    //        {
                    //            richTextBox1.SelectionStart = start + i;
                    //            richTextBox1.SelectionLength = j - i;
                    //            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    //            //MessageBox.Show(fsi.ToString()+ " " + fsj.ToString());
                    //            i = j-1;

                    //            break;
                    //        }
                    //    }
                    //}

                }
                else
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    float size = Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem);
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    richTextBox1.Focus();
                }

            }
            else
            {
                if (richTextBox1.SelectedText != "")
                {
                    int length = richTextBox1.SelectionLength;
                    int start = richTextBox1.SelectionStart;
                    FontFamily ffi, ffj;
                    FontStyle fsi, fsj;
                    for (int i = 0; i < length; i++)
                    {
                        richTextBox1.SelectionStart = start + i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    }
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = length;
                    richTextBox1.Focus();
                    //if (length == 1)
                    //{
                    //    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    //}
                    //for (int i = 0; i < length - 1; i++)
                    //{
                    //    richTextBox1.SelectionStart = start + i;
                    //    richTextBox1.SelectionLength = 1;
                    //    ffi = richTextBox1.SelectionFont.FontFamily;
                    //    fsi = richTextBox1.SelectionFont.Style;
                    //    for (int j = i + 1; j < length; j++)
                    //    {
                    //        richTextBox1.SelectionStart = start + j;
                    //        richTextBox1.SelectionLength = 1;
                    //        ffj = richTextBox1.SelectionFont.FontFamily;
                    //        fsj = richTextBox1.SelectionFont.Style;
                    //        if (j == length - 1)
                    //        {
                    //            if (fsi.ToString() != fsj.ToString() || ffi.ToString() != ffj.ToString())
                    //            {
                    //                richTextBox1.SelectionStart = start + i;
                    //                richTextBox1.SelectionLength = j - i;
                    //                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    //                //MessageBox.Show(fsi.ToString()+ " " + fsj.ToString());
                    //                i = j - 1;

                    //                break;
                    //            }

                    //            richTextBox1.SelectionStart = start + j;
                    //            richTextBox1.SelectionLength = 1;
                    //            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);

                    //        }
                    //        else if (fsi.ToString() != fsj.ToString() || ffi.ToString() != ffj.ToString())
                    //        {
                    //            richTextBox1.SelectionStart = start + i;
                    //            richTextBox1.SelectionLength = j - i;
                    //            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    //            //MessageBox.Show(fsi.ToString()+ " " + fsj.ToString());
                    //            i = j - 1;

                    //            break;
                    //        }
                    //    }
                    //}

                }
                else
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    float size = Convert.ToInt32(toolStripComboBox1.SelectedItem);
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    richTextBox1.Focus();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripButton3.Checked)
            {
                toolStripButton3.Checked = false;
            }
            else
            {
                toolStripButton3.Checked = true;
            }
            if (toolStripButton3.Checked)
            {
                if (richTextBox1.SelectedText != "")
                {
                    int length = richTextBox1.SelectionLength;
                    int start = richTextBox1.SelectionStart;
                    FontFamily ffi, ffj;
                    FontStyle fsi, fsj;
                    for (int i = 0; i < length; i++)
                    {
                        richTextBox1.SelectionStart = start + i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                    }
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = length;
                    richTextBox1.Focus();

                }
                else
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    float size = Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem);
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                    richTextBox1.Focus();
                }

            }
            else
            {
                if (richTextBox1.SelectedText != "")
                {
                    int length = richTextBox1.SelectionLength;
                    int start = richTextBox1.SelectionStart;
                    FontFamily ffi, ffj;
                    FontStyle fsi, fsj;
                    for (int i = 0; i < length; i++)
                    {
                        richTextBox1.SelectionStart = start + i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                    }
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = length;
                    richTextBox1.Focus();

                }
                else
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    float size = Convert.ToInt32(toolStripComboBox1.SelectedItem);
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                    richTextBox1.Focus();
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripButton4.Checked)
            {
                toolStripButton4.Checked = false;
            }
            else
            {
                toolStripButton4.Checked = true;
            }
            if (toolStripButton4.Checked)
            {
                if (richTextBox1.SelectedText != "")
                {
                    int length = richTextBox1.SelectionLength;
                    int start = richTextBox1.SelectionStart;
                    FontFamily ffi, ffj;
                    FontStyle fsi, fsj;
                    for (int i = 0; i < length; i++)
                    {
                        richTextBox1.SelectionStart = start + i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                    }
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = length;
                    richTextBox1.Focus();

                }
                else
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    float size = Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem);
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                    richTextBox1.Focus();
                }

            }
            else
            {
                if (richTextBox1.SelectedText != "")
                {
                    int length = richTextBox1.SelectionLength;
                    int start = richTextBox1.SelectionStart;
                    FontFamily ffi, ffj;
                    FontStyle fsi, fsj;
                    for (int i = 0; i < length; i++)
                    {
                        richTextBox1.SelectionStart = start + i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                    }
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = length;
                    richTextBox1.Focus();

                }
                else
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    float size = Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem);
                    richTextBox1.SelectionFont = new Font(fam, size, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                    richTextBox1.Focus();
                }
            }
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.ToString() != "")
            {
                int start = richTextBox1.SelectionStart;
                int length = richTextBox1.SelectionLength;
                Font font = richTextBox1.SelectionFont;
                //FontFamily fam = richTextBox1.SelectionFont.FontFamily;
                for (int i = 0; i < length; i++)
                {
                    richTextBox1.SelectionStart = i + start;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem), richTextBox1.SelectionFont.Style);
                }
            }
            else
            {
                if (Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem) != 0)
                {
                    FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                    richTextBox1.SelectionFont = new Font(fam, Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem), richTextBox1.SelectionFont.Style);
                }
            }

            richTextBox1.Focus();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.SelectionFont = new Font(toolStripComboBox2.ComboBox.SelectedItem.ToString(), Convert.ToInt16(comboBox2.SelectedItem));
            if (richTextBox1.SelectedText.ToString() != "")
            {
                int start = richTextBox1.SelectionStart;
                int length = richTextBox1.SelectionLength;
                Font font = richTextBox1.SelectionFont;
                //FontFamily fam = richTextBox1.SelectionFont.FontFamily;
                FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                for (int i = 0; i < length; i++)
                {
                    richTextBox1.SelectionStart = i + start;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(fam, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                }
            }
            else
            {
                FontFamily fam = new FontFamily(toolStripComboBox2.ComboBox.SelectedItem.ToString());
                if (Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem) != 0)
                {
                    richTextBox1.SelectionFont = new Font(fam, Convert.ToInt32(toolStripComboBox1.ComboBox.SelectedItem), richTextBox1.SelectionFont.Style);
                }
            }

            richTextBox1.Focus();
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        contextMenuStrip1.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
