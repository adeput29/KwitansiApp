
namespace KwitansiApp
{
    partial class f_cari
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
            this.dgcari = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nosurat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_telahterima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_uangsejumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_totalbayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_tgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgcari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcari
            // 
            this.dgcari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_pk,
            this.c_nosurat,
            this.c_telahterima,
            this.c_uangsejumlah,
            this.c_totalbayar,
            this.c_tgl});
            this.dgcari.Location = new System.Drawing.Point(12, 26);
            this.dgcari.Name = "dgcari";
            this.dgcari.ReadOnly = true;
            this.dgcari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcari.Size = new System.Drawing.Size(710, 347);
            this.dgcari.TabIndex = 0;
            this.dgcari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcari_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // c_pk
            // 
            this.c_pk.DataPropertyName = "pk";
            this.c_pk.HeaderText = "pk";
            this.c_pk.Name = "c_pk";
            this.c_pk.Width = 10;
            // 
            // c_nosurat
            // 
            this.c_nosurat.DataPropertyName = "noSurat";
            this.c_nosurat.HeaderText = "No ";
            this.c_nosurat.Name = "c_nosurat";
            this.c_nosurat.Width = 150;
            // 
            // c_telahterima
            // 
            this.c_telahterima.DataPropertyName = "telahTerima";
            this.c_telahterima.HeaderText = "Sudah Terima Dari";
            this.c_telahterima.Name = "c_telahterima";
            this.c_telahterima.Width = 150;
            // 
            // c_uangsejumlah
            // 
            this.c_uangsejumlah.DataPropertyName = "uangSejumlah";
            this.c_uangsejumlah.HeaderText = "Uang Sejumlah";
            this.c_uangsejumlah.Name = "c_uangsejumlah";
            // 
            // c_totalbayar
            // 
            this.c_totalbayar.DataPropertyName = "totalBayar";
            this.c_totalbayar.HeaderText = "Total";
            this.c_totalbayar.Name = "c_totalbayar";
            // 
            // c_tgl
            // 
            this.c_tgl.DataPropertyName = "stampDate";
            this.c_tgl.HeaderText = "Tanggal";
            this.c_tgl.Name = "c_tgl";
            this.c_tgl.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Orang";
            // 
            // f_cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgcari);
            this.Name = "f_cari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_cari";
            this.Load += new System.EventHandler(this.f_cari_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.f_cari_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.dgcari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcari;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nosurat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_telahterima;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_uangsejumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_totalbayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_tgl;
        private System.Windows.Forms.Label label1;
    }
}