using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;


namespace Latihan_5_1
{
    
    public partial class Form2 : Form
    {
        public string form_color;
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    comboBox1.Items.Add(color.Name);
                }
            }
            this.comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            this.comboBox1.DrawItem += new DrawItemEventHandler(comboBox1_DrawItem);
            this.comboBox1.Text = frm.rtbcolor();
            form_color = frm.rtbcolor();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.comboBox1.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background")
            {
                panel1.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.setrtbcolor(comboBox1.Text);
            frm.showrtb();
            Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.setrtbcolor(comboBox1.SelectedIndex.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.setrtbcolor(form_color);
            frm.showrtb();
            Close();
        }

        
    }
}
