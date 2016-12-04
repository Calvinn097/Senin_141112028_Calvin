namespace Latihan_POS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_register_barang = new System.Windows.Forms.Panel();
            this.jumlah_reg_brg_label = new System.Windows.Forms.Label();
            this.jumlah_reg_tb = new System.Windows.Forms.TextBox();
            this.keluar_reg_btn = new System.Windows.Forms.Button();
            this.batal_reg_btn = new System.Windows.Forms.Button();
            this.simpan_reg_btn = new System.Windows.Forms.Button();
            this.reg_brg_hargajual_tb = new System.Windows.Forms.TextBox();
            this.reg_brg_hargahpp_tb = new System.Windows.Forms.TextBox();
            this.reg_brg_nama_tb = new System.Windows.Forms.TextBox();
            this.reg_brg_kode_tb = new System.Windows.Forms.TextBox();
            this.reg_brg_id_tb = new System.Windows.Forms.TextBox();
            this.reg_barang_hargajual_label = new System.Windows.Forms.Label();
            this.reg_barang_hargahpp_label = new System.Windows.Forms.Label();
            this.reg_barang_nama_label = new System.Windows.Forms.Label();
            this.reg_barang_kode_label = new System.Windows.Forms.Label();
            this.reg_barang_id_label = new System.Windows.Forms.Label();
            this.register_barang_label = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel_register_barang.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registrasiToolStripMenuItem
            // 
            this.registrasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.toolStripMenuItem1,
            this.keluarToolStripMenuItem});
            this.registrasiToolStripMenuItem.Name = "registrasiToolStripMenuItem";
            this.registrasiToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.registrasiToolStripMenuItem.Text = "Registrasi";
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // panel_register_barang
            // 
            this.panel_register_barang.Controls.Add(this.jumlah_reg_brg_label);
            this.panel_register_barang.Controls.Add(this.jumlah_reg_tb);
            this.panel_register_barang.Controls.Add(this.keluar_reg_btn);
            this.panel_register_barang.Controls.Add(this.batal_reg_btn);
            this.panel_register_barang.Controls.Add(this.simpan_reg_btn);
            this.panel_register_barang.Controls.Add(this.reg_brg_hargajual_tb);
            this.panel_register_barang.Controls.Add(this.reg_brg_hargahpp_tb);
            this.panel_register_barang.Controls.Add(this.reg_brg_nama_tb);
            this.panel_register_barang.Controls.Add(this.reg_brg_kode_tb);
            this.panel_register_barang.Controls.Add(this.reg_brg_id_tb);
            this.panel_register_barang.Controls.Add(this.reg_barang_hargajual_label);
            this.panel_register_barang.Controls.Add(this.reg_barang_hargahpp_label);
            this.panel_register_barang.Controls.Add(this.reg_barang_nama_label);
            this.panel_register_barang.Controls.Add(this.reg_barang_kode_label);
            this.panel_register_barang.Controls.Add(this.reg_barang_id_label);
            this.panel_register_barang.Controls.Add(this.register_barang_label);
            this.panel_register_barang.Location = new System.Drawing.Point(37, 45);
            this.panel_register_barang.Name = "panel_register_barang";
            this.panel_register_barang.Size = new System.Drawing.Size(520, 340);
            this.panel_register_barang.TabIndex = 1;
            // 
            // jumlah_reg_brg_label
            // 
            this.jumlah_reg_brg_label.AutoSize = true;
            this.jumlah_reg_brg_label.Location = new System.Drawing.Point(23, 255);
            this.jumlah_reg_brg_label.Name = "jumlah_reg_brg_label";
            this.jumlah_reg_brg_label.Size = new System.Drawing.Size(40, 13);
            this.jumlah_reg_brg_label.TabIndex = 15;
            this.jumlah_reg_brg_label.Text = "Jumlah";
            // 
            // jumlah_reg_tb
            // 
            this.jumlah_reg_tb.Location = new System.Drawing.Point(114, 252);
            this.jumlah_reg_tb.Name = "jumlah_reg_tb";
            this.jumlah_reg_tb.Size = new System.Drawing.Size(100, 20);
            this.jumlah_reg_tb.TabIndex = 11;
            // 
            // keluar_reg_btn
            // 
            this.keluar_reg_btn.Location = new System.Drawing.Point(311, 163);
            this.keluar_reg_btn.Name = "keluar_reg_btn";
            this.keluar_reg_btn.Size = new System.Drawing.Size(75, 23);
            this.keluar_reg_btn.TabIndex = 14;
            this.keluar_reg_btn.Text = "Keluar";
            this.keluar_reg_btn.UseVisualStyleBackColor = true;
            this.keluar_reg_btn.Click += new System.EventHandler(this.keluar_reg_btn_Click);
            // 
            // batal_reg_btn
            // 
            this.batal_reg_btn.Location = new System.Drawing.Point(311, 120);
            this.batal_reg_btn.Name = "batal_reg_btn";
            this.batal_reg_btn.Size = new System.Drawing.Size(75, 23);
            this.batal_reg_btn.TabIndex = 13;
            this.batal_reg_btn.Text = "Batal";
            this.batal_reg_btn.UseVisualStyleBackColor = true;
            this.batal_reg_btn.Click += new System.EventHandler(this.batal_reg_btn_Click);
            // 
            // simpan_reg_btn
            // 
            this.simpan_reg_btn.Location = new System.Drawing.Point(311, 73);
            this.simpan_reg_btn.Name = "simpan_reg_btn";
            this.simpan_reg_btn.Size = new System.Drawing.Size(75, 23);
            this.simpan_reg_btn.TabIndex = 12;
            this.simpan_reg_btn.Text = "Simpan";
            this.simpan_reg_btn.UseVisualStyleBackColor = true;
            this.simpan_reg_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reg_brg_hargajual_tb
            // 
            this.reg_brg_hargajual_tb.Location = new System.Drawing.Point(114, 211);
            this.reg_brg_hargajual_tb.Name = "reg_brg_hargajual_tb";
            this.reg_brg_hargajual_tb.Size = new System.Drawing.Size(100, 20);
            this.reg_brg_hargajual_tb.TabIndex = 10;
            // 
            // reg_brg_hargahpp_tb
            // 
            this.reg_brg_hargahpp_tb.Location = new System.Drawing.Point(114, 174);
            this.reg_brg_hargahpp_tb.Name = "reg_brg_hargahpp_tb";
            this.reg_brg_hargahpp_tb.Size = new System.Drawing.Size(100, 20);
            this.reg_brg_hargahpp_tb.TabIndex = 9;
            // 
            // reg_brg_nama_tb
            // 
            this.reg_brg_nama_tb.Location = new System.Drawing.Point(114, 137);
            this.reg_brg_nama_tb.Name = "reg_brg_nama_tb";
            this.reg_brg_nama_tb.Size = new System.Drawing.Size(100, 20);
            this.reg_brg_nama_tb.TabIndex = 8;
            this.reg_brg_nama_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // reg_brg_kode_tb
            // 
            this.reg_brg_kode_tb.Location = new System.Drawing.Point(114, 106);
            this.reg_brg_kode_tb.Name = "reg_brg_kode_tb";
            this.reg_brg_kode_tb.Size = new System.Drawing.Size(100, 20);
            this.reg_brg_kode_tb.TabIndex = 7;
            // 
            // reg_brg_id_tb
            // 
            this.reg_brg_id_tb.Location = new System.Drawing.Point(114, 70);
            this.reg_brg_id_tb.Name = "reg_brg_id_tb";
            this.reg_brg_id_tb.Size = new System.Drawing.Size(100, 20);
            this.reg_brg_id_tb.TabIndex = 6;
            this.reg_brg_id_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reg_barang_hargajual_label
            // 
            this.reg_barang_hargajual_label.AutoSize = true;
            this.reg_barang_hargajual_label.Location = new System.Drawing.Point(23, 214);
            this.reg_barang_hargajual_label.Name = "reg_barang_hargajual_label";
            this.reg_barang_hargajual_label.Size = new System.Drawing.Size(58, 13);
            this.reg_barang_hargajual_label.TabIndex = 5;
            this.reg_barang_hargajual_label.Text = "Harga Jual";
            // 
            // reg_barang_hargahpp_label
            // 
            this.reg_barang_hargahpp_label.AutoSize = true;
            this.reg_barang_hargahpp_label.Location = new System.Drawing.Point(23, 174);
            this.reg_barang_hargahpp_label.Name = "reg_barang_hargahpp_label";
            this.reg_barang_hargahpp_label.Size = new System.Drawing.Size(61, 13);
            this.reg_barang_hargahpp_label.TabIndex = 4;
            this.reg_barang_hargahpp_label.Text = "Harga HPP";
            // 
            // reg_barang_nama_label
            // 
            this.reg_barang_nama_label.AutoSize = true;
            this.reg_barang_nama_label.Location = new System.Drawing.Point(23, 137);
            this.reg_barang_nama_label.Name = "reg_barang_nama_label";
            this.reg_barang_nama_label.Size = new System.Drawing.Size(35, 13);
            this.reg_barang_nama_label.TabIndex = 3;
            this.reg_barang_nama_label.Text = "Nama";
            // 
            // reg_barang_kode_label
            // 
            this.reg_barang_kode_label.AutoSize = true;
            this.reg_barang_kode_label.Location = new System.Drawing.Point(23, 106);
            this.reg_barang_kode_label.Name = "reg_barang_kode_label";
            this.reg_barang_kode_label.Size = new System.Drawing.Size(32, 13);
            this.reg_barang_kode_label.TabIndex = 2;
            this.reg_barang_kode_label.Text = "Kode";
            // 
            // reg_barang_id_label
            // 
            this.reg_barang_id_label.AutoSize = true;
            this.reg_barang_id_label.Location = new System.Drawing.Point(23, 73);
            this.reg_barang_id_label.Name = "reg_barang_id_label";
            this.reg_barang_id_label.Size = new System.Drawing.Size(18, 13);
            this.reg_barang_id_label.TabIndex = 1;
            this.reg_barang_id_label.Text = "ID";
            // 
            // register_barang_label
            // 
            this.register_barang_label.AutoSize = true;
            this.register_barang_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_barang_label.Location = new System.Drawing.Point(18, 12);
            this.register_barang_label.Name = "register_barang_label";
            this.register_barang_label.Size = new System.Drawing.Size(167, 25);
            this.register_barang_label.TabIndex = 0;
            this.register_barang_label.Text = "Register Barang";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 442);
            this.Controls.Add(this.panel_register_barang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_register_barang.ResumeLayout(false);
            this.panel_register_barang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.Panel panel_register_barang;
        private System.Windows.Forms.TextBox reg_brg_id_tb;
        private System.Windows.Forms.Label reg_barang_hargajual_label;
        private System.Windows.Forms.Label reg_barang_hargahpp_label;
        private System.Windows.Forms.Label reg_barang_nama_label;
        private System.Windows.Forms.Label reg_barang_kode_label;
        private System.Windows.Forms.Label reg_barang_id_label;
        private System.Windows.Forms.Label register_barang_label;
        private System.Windows.Forms.TextBox reg_brg_nama_tb;
        private System.Windows.Forms.TextBox reg_brg_kode_tb;
        private System.Windows.Forms.TextBox reg_brg_hargajual_tb;
        private System.Windows.Forms.TextBox reg_brg_hargahpp_tb;
        private System.Windows.Forms.Button simpan_reg_btn;
        private System.Windows.Forms.Button keluar_reg_btn;
        private System.Windows.Forms.Button batal_reg_btn;
        private System.Windows.Forms.Label jumlah_reg_brg_label;
        private System.Windows.Forms.TextBox jumlah_reg_tb;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}

