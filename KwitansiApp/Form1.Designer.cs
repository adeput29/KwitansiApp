
namespace KwitansiApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_untukBayar = new System.Windows.Forms.TextBox();
            this.t_no = new System.Windows.Forms.TextBox();
            this.t_terimaDari = new System.Windows.Forms.TextBox();
            this.t_uangSejumlah = new System.Windows.Forms.TextBox();
            this.t_total = new System.Windows.Forms.TextBox();
            this.b_baru = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.b_print = new System.Windows.Forms.Button();
            this.b_cari = new System.Windows.Forms.Button();
            this.t_setDB = new System.Windows.Forms.Button();
            this.t_passAdmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_pk = new System.Windows.Forms.TextBox();
            this.hargabayar1 = new System.Windows.Forms.TextBox();
            this.hargabayar2 = new System.Windows.Forms.TextBox();
            this.untukbayar2 = new System.Windows.Forms.TextBox();
            this.hargabayar3 = new System.Windows.Forms.TextBox();
            this.untukbayar3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t_date = new System.Windows.Forms.DateTimePicker();
            this.b_gantittl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_print);
            this.groupBox1.Controls.Add(this.b_gantittl);
            this.groupBox1.Controls.Add(this.t_date);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.hargabayar3);
            this.groupBox1.Controls.Add(this.untukbayar3);
            this.groupBox1.Controls.Add(this.hargabayar2);
            this.groupBox1.Controls.Add(this.untukbayar2);
            this.groupBox1.Controls.Add(this.hargabayar1);
            this.groupBox1.Controls.Add(this.t_pk);
            this.groupBox1.Controls.Add(this.b_cari);
            this.groupBox1.Controls.Add(this.b_simpan);
            this.groupBox1.Controls.Add(this.b_baru);
            this.groupBox1.Controls.Add(this.t_total);
            this.groupBox1.Controls.Add(this.t_uangSejumlah);
            this.groupBox1.Controls.Add(this.t_terimaDari);
            this.groupBox1.Controls.Add(this.t_no);
            this.groupBox1.Controls.Add(this.t_untukBayar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Kwitansi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telah terima dari : ________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No : _________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uang Sejumlah : _________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Untuk Pembayaran : _______________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total : ________________________";
            // 
            // t_untukBayar
            // 
            this.t_untukBayar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_untukBayar.Location = new System.Drawing.Point(131, 114);
            this.t_untukBayar.Name = "t_untukBayar";
            this.t_untukBayar.Size = new System.Drawing.Size(171, 20);
            this.t_untukBayar.TabIndex = 11;
            // 
            // t_no
            // 
            this.t_no.Location = new System.Drawing.Point(131, 37);
            this.t_no.Name = "t_no";
            this.t_no.Size = new System.Drawing.Size(171, 20);
            this.t_no.TabIndex = 8;
            // 
            // t_terimaDari
            // 
            this.t_terimaDari.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_terimaDari.Location = new System.Drawing.Point(131, 63);
            this.t_terimaDari.Name = "t_terimaDari";
            this.t_terimaDari.Size = new System.Drawing.Size(171, 20);
            this.t_terimaDari.TabIndex = 9;
            // 
            // t_uangSejumlah
            // 
            this.t_uangSejumlah.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_uangSejumlah.Location = new System.Drawing.Point(131, 88);
            this.t_uangSejumlah.Name = "t_uangSejumlah";
            this.t_uangSejumlah.Size = new System.Drawing.Size(171, 20);
            this.t_uangSejumlah.TabIndex = 10;
            // 
            // t_total
            // 
            this.t_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_total.Enabled = false;
            this.t_total.Location = new System.Drawing.Point(131, 193);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(100, 20);
            this.t_total.TabIndex = 12;
            // 
            // b_baru
            // 
            this.b_baru.Location = new System.Drawing.Point(131, 248);
            this.b_baru.Name = "b_baru";
            this.b_baru.Size = new System.Drawing.Size(87, 41);
            this.b_baru.TabIndex = 12;
            this.b_baru.Text = "Tambah Baru";
            this.b_baru.UseVisualStyleBackColor = true;
            this.b_baru.Click += new System.EventHandler(this.b_baru_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b_simpan.Enabled = false;
            this.b_simpan.Location = new System.Drawing.Point(224, 248);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(78, 41);
            this.b_simpan.TabIndex = 13;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = false;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // b_print
            // 
            this.b_print.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.b_print.Enabled = false;
            this.b_print.Location = new System.Drawing.Point(131, 295);
            this.b_print.Name = "b_print";
            this.b_print.Size = new System.Drawing.Size(171, 41);
            this.b_print.TabIndex = 14;
            this.b_print.Text = "Print";
            this.b_print.UseVisualStyleBackColor = false;
            this.b_print.Click += new System.EventHandler(this.b_print_Click);
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(272, 37);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(30, 20);
            this.b_cari.TabIndex = 15;
            this.b_cari.Text = "...";
            this.b_cari.UseVisualStyleBackColor = true;
            this.b_cari.Click += new System.EventHandler(this.b_cari_Click);
            // 
            // t_setDB
            // 
            this.t_setDB.Location = new System.Drawing.Point(284, 375);
            this.t_setDB.Name = "t_setDB";
            this.t_setDB.Size = new System.Drawing.Size(79, 23);
            this.t_setDB.TabIndex = 3;
            this.t_setDB.Text = "setDB";
            this.t_setDB.UseVisualStyleBackColor = true;
            this.t_setDB.Visible = false;
            this.t_setDB.Click += new System.EventHandler(this.t_setDB_Click);
            // 
            // t_passAdmin
            // 
            this.t_passAdmin.Location = new System.Drawing.Point(178, 377);
            this.t_passAdmin.Name = "t_passAdmin";
            this.t_passAdmin.Size = new System.Drawing.Size(100, 20);
            this.t_passAdmin.TabIndex = 4;
            this.t_passAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_passAdmin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PassSetting";
            // 
            // t_pk
            // 
            this.t_pk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_pk.Enabled = false;
            this.t_pk.Location = new System.Drawing.Point(141, 306);
            this.t_pk.Name = "t_pk";
            this.t_pk.Size = new System.Drawing.Size(100, 20);
            this.t_pk.TabIndex = 16;
            this.t_pk.TextChanged += new System.EventHandler(this.t_pk_TextChanged);
            // 
            // hargabayar1
            // 
            this.hargabayar1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hargabayar1.Location = new System.Drawing.Point(324, 114);
            this.hargabayar1.Name = "hargabayar1";
            this.hargabayar1.Size = new System.Drawing.Size(100, 20);
            this.hargabayar1.TabIndex = 17;
            this.hargabayar1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hargabayar2
            // 
            this.hargabayar2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hargabayar2.Location = new System.Drawing.Point(324, 140);
            this.hargabayar2.Name = "hargabayar2";
            this.hargabayar2.Size = new System.Drawing.Size(100, 20);
            this.hargabayar2.TabIndex = 20;
            this.hargabayar2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // untukbayar2
            // 
            this.untukbayar2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.untukbayar2.Location = new System.Drawing.Point(131, 140);
            this.untukbayar2.Name = "untukbayar2";
            this.untukbayar2.Size = new System.Drawing.Size(171, 20);
            this.untukbayar2.TabIndex = 19;
            // 
            // hargabayar3
            // 
            this.hargabayar3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hargabayar3.Location = new System.Drawing.Point(324, 166);
            this.hargabayar3.Name = "hargabayar3";
            this.hargabayar3.Size = new System.Drawing.Size(100, 20);
            this.hargabayar3.TabIndex = 23;
            this.hargabayar3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // untukbayar3
            // 
            this.untukbayar3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.untukbayar3.Location = new System.Drawing.Point(131, 166);
            this.untukbayar3.Name = "untukbayar3";
            this.untukbayar3.Size = new System.Drawing.Size(171, 20);
            this.untukbayar3.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rp.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Rp.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Rp.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tanggal : ________________________";
            // 
            // t_date
            // 
            this.t_date.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.t_date.Enabled = false;
            this.t_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.t_date.Location = new System.Drawing.Point(131, 222);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(171, 20);
            this.t_date.TabIndex = 28;
            // 
            // b_gantittl
            // 
            this.b_gantittl.Location = new System.Drawing.Point(224, 193);
            this.b_gantittl.Name = "b_gantittl";
            this.b_gantittl.Size = new System.Drawing.Size(78, 20);
            this.b_gantittl.TabIndex = 29;
            this.b_gantittl.Text = "Ganti Manual";
            this.b_gantittl.UseVisualStyleBackColor = true;
            this.b_gantittl.Click += new System.EventHandler(this.b_gantittl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_passAdmin);
            this.Controls.Add(this.t_setDB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KwitansiApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.Button b_print;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.Button b_baru;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.TextBox t_uangSejumlah;
        private System.Windows.Forms.TextBox t_terimaDari;
        private System.Windows.Forms.TextBox t_no;
        private System.Windows.Forms.TextBox t_untukBayar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button t_setDB;
        private System.Windows.Forms.TextBox t_passAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_pk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hargabayar3;
        private System.Windows.Forms.TextBox untukbayar3;
        private System.Windows.Forms.TextBox hargabayar2;
        private System.Windows.Forms.TextBox untukbayar2;
        private System.Windows.Forms.TextBox hargabayar1;
        private System.Windows.Forms.DateTimePicker t_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_gantittl;
    }
}

