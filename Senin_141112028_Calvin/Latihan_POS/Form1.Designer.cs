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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel_lht_brg = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdaftar = new System.Windows.Forms.DataGridView();
            this.pnlEditBrg = new System.Windows.Forms.Panel();
            this.hpsBrg_btn = new System.Windows.Forms.Button();
            this.editReset_btn = new System.Windows.Forms.Button();
            this.editBrg_btn = new System.Windows.Forms.Button();
            this.editJumlahBrg_tb = new System.Windows.Forms.TextBox();
            this.editHargaHPPBrg_tb = new System.Windows.Forms.TextBox();
            this.editHargaJualBrg_tb = new System.Windows.Forms.TextBox();
            this.editNamaBrg_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_brg_row = new System.Windows.Forms.DataGridView();
            this.edit_cek_brg_btn = new System.Windows.Forms.Button();
            this.edit_brg_id_label = new System.Windows.Forms.Label();
            this.editIdBrg_tb = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel_register_barang.SuspendLayout();
            this.panel_lht_brg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaftar)).BeginInit();
            this.pnlEditBrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brg_row)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasiToolStripMenuItem,
            this.lihatToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
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
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 6);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // lihatToolStripMenuItem
            // 
            this.lihatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem1});
            this.lihatToolStripMenuItem.Name = "lihatToolStripMenuItem";
            this.lihatToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.lihatToolStripMenuItem.Text = "Lihat";
            // 
            // barangToolStripMenuItem1
            // 
            this.barangToolStripMenuItem1.Name = "barangToolStripMenuItem1";
            this.barangToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.barangToolStripMenuItem1.Text = "Barang";
            this.barangToolStripMenuItem1.Click += new System.EventHandler(this.barangToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem2});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // barangToolStripMenuItem2
            // 
            this.barangToolStripMenuItem2.Name = "barangToolStripMenuItem2";
            this.barangToolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.barangToolStripMenuItem2.Text = "Barang";
            this.barangToolStripMenuItem2.Click += new System.EventHandler(this.barangToolStripMenuItem2_Click);
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
            this.panel_register_barang.Location = new System.Drawing.Point(12, 36);
            this.panel_register_barang.Name = "panel_register_barang";
            this.panel_register_barang.Size = new System.Drawing.Size(198, 47);
            this.panel_register_barang.TabIndex = 1;
            this.panel_register_barang.Visible = false;
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
            // panel_lht_brg
            // 
            this.panel_lht_brg.Controls.Add(this.label6);
            this.panel_lht_brg.Controls.Add(this.dgvdaftar);
            this.panel_lht_brg.Location = new System.Drawing.Point(216, 42);
            this.panel_lht_brg.Name = "panel_lht_brg";
            this.panel_lht_brg.Size = new System.Drawing.Size(153, 41);
            this.panel_lht_brg.TabIndex = 16;
            this.panel_lht_brg.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lihat Barang";
            // 
            // dgvdaftar
            // 
            this.dgvdaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdaftar.Location = new System.Drawing.Point(3, 27);
            this.dgvdaftar.Name = "dgvdaftar";
            this.dgvdaftar.Size = new System.Drawing.Size(818, 472);
            this.dgvdaftar.TabIndex = 0;
            // 
            // pnlEditBrg
            // 
            this.pnlEditBrg.Controls.Add(this.hpsBrg_btn);
            this.pnlEditBrg.Controls.Add(this.editReset_btn);
            this.pnlEditBrg.Controls.Add(this.editBrg_btn);
            this.pnlEditBrg.Controls.Add(this.editJumlahBrg_tb);
            this.pnlEditBrg.Controls.Add(this.editHargaHPPBrg_tb);
            this.pnlEditBrg.Controls.Add(this.editHargaJualBrg_tb);
            this.pnlEditBrg.Controls.Add(this.editNamaBrg_tb);
            this.pnlEditBrg.Controls.Add(this.label5);
            this.pnlEditBrg.Controls.Add(this.label4);
            this.pnlEditBrg.Controls.Add(this.label3);
            this.pnlEditBrg.Controls.Add(this.label2);
            this.pnlEditBrg.Controls.Add(this.label1);
            this.pnlEditBrg.Controls.Add(this.dgv_brg_row);
            this.pnlEditBrg.Controls.Add(this.edit_cek_brg_btn);
            this.pnlEditBrg.Controls.Add(this.edit_brg_id_label);
            this.pnlEditBrg.Controls.Add(this.editIdBrg_tb);
            this.pnlEditBrg.Location = new System.Drawing.Point(442, 42);
            this.pnlEditBrg.Name = "pnlEditBrg";
            this.pnlEditBrg.Size = new System.Drawing.Size(96, 37);
            this.pnlEditBrg.TabIndex = 17;
            this.pnlEditBrg.Visible = false;
            this.pnlEditBrg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditBrg_Paint);
            // 
            // hpsBrg_btn
            // 
            this.hpsBrg_btn.Location = new System.Drawing.Point(73, 294);
            this.hpsBrg_btn.Name = "hpsBrg_btn";
            this.hpsBrg_btn.Size = new System.Drawing.Size(75, 23);
            this.hpsBrg_btn.TabIndex = 9;
            this.hpsBrg_btn.Text = "Hapus";
            this.hpsBrg_btn.UseVisualStyleBackColor = true;
            this.hpsBrg_btn.Click += new System.EventHandler(this.hpsBrg_btn_Click);
            // 
            // editReset_btn
            // 
            this.editReset_btn.Location = new System.Drawing.Point(12, 294);
            this.editReset_btn.Name = "editReset_btn";
            this.editReset_btn.Size = new System.Drawing.Size(55, 23);
            this.editReset_btn.TabIndex = 8;
            this.editReset_btn.Text = "Cancel";
            this.editReset_btn.UseVisualStyleBackColor = true;
            this.editReset_btn.Click += new System.EventHandler(this.editBrg_btn_Click);
            // 
            // editBrg_btn
            // 
            this.editBrg_btn.Location = new System.Drawing.Point(155, 294);
            this.editBrg_btn.Name = "editBrg_btn";
            this.editBrg_btn.Size = new System.Drawing.Size(71, 23);
            this.editBrg_btn.TabIndex = 8;
            this.editBrg_btn.Text = "Save Edit";
            this.editBrg_btn.UseVisualStyleBackColor = true;
            this.editBrg_btn.Click += new System.EventHandler(this.editBrg_btn_Click);
            // 
            // editJumlahBrg_tb
            // 
            this.editJumlahBrg_tb.Location = new System.Drawing.Point(126, 258);
            this.editJumlahBrg_tb.Name = "editJumlahBrg_tb";
            this.editJumlahBrg_tb.Size = new System.Drawing.Size(100, 20);
            this.editJumlahBrg_tb.TabIndex = 7;
            // 
            // editHargaHPPBrg_tb
            // 
            this.editHargaHPPBrg_tb.Location = new System.Drawing.Point(126, 202);
            this.editHargaHPPBrg_tb.Name = "editHargaHPPBrg_tb";
            this.editHargaHPPBrg_tb.Size = new System.Drawing.Size(100, 20);
            this.editHargaHPPBrg_tb.TabIndex = 7;
            // 
            // editHargaJualBrg_tb
            // 
            this.editHargaJualBrg_tb.Location = new System.Drawing.Point(126, 231);
            this.editHargaJualBrg_tb.Name = "editHargaJualBrg_tb";
            this.editHargaJualBrg_tb.Size = new System.Drawing.Size(100, 20);
            this.editHargaJualBrg_tb.TabIndex = 7;
            // 
            // editNamaBrg_tb
            // 
            this.editNamaBrg_tb.Location = new System.Drawing.Point(126, 175);
            this.editNamaBrg_tb.Name = "editNamaBrg_tb";
            this.editNamaBrg_tb.Size = new System.Drawing.Size(100, 20);
            this.editNamaBrg_tb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harga Jual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga HPP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Barang";
            // 
            // dgv_brg_row
            // 
            this.dgv_brg_row.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brg_row.Location = new System.Drawing.Point(12, 85);
            this.dgv_brg_row.Name = "dgv_brg_row";
            this.dgv_brg_row.Size = new System.Drawing.Size(848, 77);
            this.dgv_brg_row.TabIndex = 3;
            // 
            // edit_cek_brg_btn
            // 
            this.edit_cek_brg_btn.Location = new System.Drawing.Point(377, 56);
            this.edit_cek_brg_btn.Name = "edit_cek_brg_btn";
            this.edit_cek_brg_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_cek_brg_btn.TabIndex = 2;
            this.edit_cek_brg_btn.Text = "Cek Barang";
            this.edit_cek_brg_btn.UseVisualStyleBackColor = true;
            this.edit_cek_brg_btn.Click += new System.EventHandler(this.edit_cek_brg_btn_Click);
            // 
            // edit_brg_id_label
            // 
            this.edit_brg_id_label.AutoSize = true;
            this.edit_brg_id_label.Location = new System.Drawing.Point(389, 10);
            this.edit_brg_id_label.Name = "edit_brg_id_label";
            this.edit_brg_id_label.Size = new System.Drawing.Size(55, 13);
            this.edit_brg_id_label.TabIndex = 1;
            this.edit_brg_id_label.Text = "ID Barang";
            // 
            // editIdBrg_tb
            // 
            this.editIdBrg_tb.Location = new System.Drawing.Point(366, 26);
            this.editIdBrg_tb.Name = "editIdBrg_tb";
            this.editIdBrg_tb.Size = new System.Drawing.Size(100, 20);
            this.editIdBrg_tb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 523);
            this.Controls.Add(this.pnlEditBrg);
            this.Controls.Add(this.panel_register_barang);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_lht_brg);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_register_barang.ResumeLayout(false);
            this.panel_register_barang.PerformLayout();
            this.panel_lht_brg.ResumeLayout(false);
            this.panel_lht_brg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaftar)).EndInit();
            this.pnlEditBrg.ResumeLayout(false);
            this.pnlEditBrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brg_row)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem lihatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem1;
        private System.Windows.Forms.Panel panel_lht_brg;
        private System.Windows.Forms.DataGridView dgvdaftar;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem2;
        private System.Windows.Forms.Panel pnlEditBrg;
        private System.Windows.Forms.Button editBrg_btn;
        private System.Windows.Forms.TextBox editJumlahBrg_tb;
        private System.Windows.Forms.TextBox editHargaHPPBrg_tb;
        private System.Windows.Forms.TextBox editHargaJualBrg_tb;
        private System.Windows.Forms.TextBox editNamaBrg_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_brg_row;
        private System.Windows.Forms.Button edit_cek_brg_btn;
        private System.Windows.Forms.Label edit_brg_id_label;
        private System.Windows.Forms.TextBox editIdBrg_tb;
        private System.Windows.Forms.Button editReset_btn;
        private System.Windows.Forms.Button hpsBrg_btn;
        private System.Windows.Forms.Label label6;
    }
}

