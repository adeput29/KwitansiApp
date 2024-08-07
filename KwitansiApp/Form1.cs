﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KwitansiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        f_db db = new f_db();
        public int generatePK;
        int harga1, harga2, harga3;

        private void b_print_Click(object sender, EventArgs e)
        {
            f_viewPrint viewPrint = new f_viewPrint();
            viewPrint.s_pk = t_pk.Text;
            viewPrint.ShowDialog();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (t_no.Text.Equals("") || t_terimaDari.Text.Equals("") || t_total.Text.Equals("") || t_uangSejumlah.Text.Equals("") || t_untukBayar.Text.Equals(""))
            {
                MessageBox.Show("Ada data yang belum diisi!");
            }
            else
            {
                newPKFunc();
                simpan_baru();
            }
        }


        private void newPKFunc()
        {
            generatePK = 0;
            db.connectdb();
            db.con.Close();
            MySqlCommand cmdNewPK = new MySqlCommand("SELECT pk FROM `kwitansiapp`.`dataawal` order by pk DESC LIMIT 1 ", db.con);
            MySqlDataReader drPK;
            db.con.Open();

            try
            {
                drPK = cmdNewPK.ExecuteReader();
                while (drPK.Read())
                {
                    int read = drPK.GetInt32(0);
                    generatePK = read + 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void simpan_baru()
        {
            db.connectdb();
            db.con.Close();
            
            MySqlCommand cmdinsert1 = new MySqlCommand("INSERT INTO dataawal (PK,noSurat,telahTerima,uangSejumlah,item1,hargaitem1,item2,hargaitem2,item3,hargaitem3,totalBayar,stampnew, stampDate) " +
                "VALUES ( '"+ generatePK + "', '"+t_no.Text+"', '" + t_terimaDari.Text + "', '" + t_uangSejumlah.Text + "',  '" + t_untukBayar.Text + "','"+hargabayar1.Text+"', " +
                "'"+untukbayar2.Text+"', '"+hargabayar2.Text+"', '"+untukbayar3.Text+"', '"+hargabayar3.Text+"', '" + t_total.Text + "', " +
                "'"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + t_date.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')", db.con);
            MySqlDataReader drPK;
            db.con.Open();
            try
            {
                
                int countinsert1 = cmdinsert1.ExecuteNonQuery();
                if (countinsert1 > 0)
                {
                    MessageBox.Show("Berhasil Insert Data Stock!");
                    t_pk.Text = generatePK.ToString();
                    clearData();
                    isiData();
                }
                else
                {
                    MessageBox.Show("Gagal Insert Data Stock!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Belum ada fitur Edit Data yang sudah disimpan, jika ingin membuat data baru silahkan Klik Tambah Baru!");
            }
        }

        private void t_setDB_Click(object sender, EventArgs e)
        {
            f_db db = new f_db();
            db.ShowDialog();
        }

        private void t_passAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (t_passAdmin.Text.Equals("paperline"))
            {
                t_setDB.Visible = true;
                t_passAdmin.Text = "";
            } else if (t_passAdmin.Text.Equals(""))
            {
                t_setDB.Visible = false;
            }
        }

        private void b_baru_Click(object sender, EventArgs e)
        {
            newData();
            b_print.Enabled = false;
            b_print.BackColor = SystemColors.ScrollBar;
        }

        private void newData()
        {
            b_simpan.Enabled = true;
            b_simpan.BackColor = Color.White;
            t_terimaDari.Enabled = true;
            t_terimaDari.Text = "";
            t_terimaDari.BackColor = Color.White;

            t_uangSejumlah.Enabled = true;
            t_uangSejumlah.Text = "";
            t_uangSejumlah.BackColor = Color.White;

            t_untukBayar.Enabled = true;
            t_untukBayar.Text = "";
            t_untukBayar.BackColor = Color.White;

            untukbayar2.Enabled = true;
            untukbayar2.Text = "";
            untukbayar2.BackColor = Color.White;

            untukbayar3.Enabled = true;
            untukbayar3.Text = "";
            untukbayar3.BackColor = Color.White;

            hargabayar1.Enabled = true;
            hargabayar1.Text = "";
            hargabayar1.BackColor = Color.White;

            hargabayar2.Enabled = true;
            hargabayar2.Text = "";
            hargabayar2.BackColor = Color.White;

            hargabayar3.Enabled = true;
            hargabayar3.Text = "";
            hargabayar3.BackColor = Color.White;

            

        }

        private void t_pk_TextChanged(object sender, EventArgs e)
        {
            if (t_pk.Text.Equals(""))
            {
                b_print.Enabled = false;
                b_print.BackColor = SystemColors.ScrollBar;
            } else if (t_pk.Text.Equals("") == false)
            {
                b_print.Enabled = true;
                b_print.BackColor = Color.White;
            }
        }

        private void isiData()
        {
            db.connectdb();
            db.con.Close();
            MySqlCommand cmdNewPK = new MySqlCommand("SELECT noSurat, telahTerima,uangSejumlah,item1,hargaitem1," +
                "item2, hargaitem2,item3, hargaitem3,totalbayar,stampDate FROM `kwitansiapp`.`dataawal` where pk = '"+t_pk.Text+"' ", db.con);
            MySqlDataReader drPK;
            db.con.Open();

            try
            {
                drPK = cmdNewPK.ExecuteReader();
                while (drPK.Read())
                {
                    t_no.Text = drPK.GetString(0);
                    t_terimaDari.Text = drPK.GetString(1);
                    t_uangSejumlah.Text = drPK.GetString(2);
                    t_untukBayar.Text = drPK.GetString(3);
                    hargabayar1.Text = drPK.GetString(4);
                    untukbayar2.Text = drPK.GetString(5);
                    hargabayar2.Text = drPK.GetString(6);
                    untukbayar3.Text = drPK.GetString(7);
                    hargabayar3.Text = drPK.GetString(8);
                    t_total.Text = drPK.GetString(9);
                    t_date.Value = drPK.GetDateTime(10);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void b_gantittl_Click(object sender, EventArgs e)
        {
            t_total.Enabled = true;
            t_total.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t_total.Enabled = false;
            t_total.BackColor = SystemColors.ScrollBar;
            

            if (hargabayar1.Text == "" || hargabayar1.Text == "0") return;
            decimal price;
            price = decimal.Parse(hargabayar1.Text, System.Globalization.NumberStyles.Currency);
            hargabayar1.Text = price.ToString("#,#");
            hargabayar1.SelectionStart = hargabayar1.Text.Length;

            if (hargabayar1.Text == "")
            {
                harga1 = 0;
            } else
            {
                int ans = int.Parse(hargabayar1.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga1 = ans;
            }
            
            if (hargabayar2.Text == "")
            {
                harga2 = 0;
            } else
            {
                int ans = int.Parse(hargabayar2.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga2 = ans;
            }
            if (hargabayar3.Text == "")
            {
                harga3 = 0;
            } else
            {
                int ans = int.Parse(hargabayar3.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga3 = ans;
            }

            int hitung = harga1 + harga2 + harga3;
            t_total.Text = hitung.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            t_total.Enabled = false;
            t_total.BackColor = SystemColors.ScrollBar;

            if (hargabayar2.Text == "" || hargabayar2.Text == "0") return;
            decimal price;
            price = decimal.Parse(hargabayar2.Text, System.Globalization.NumberStyles.Currency);
            hargabayar2.Text = price.ToString("#,#");
            hargabayar2.SelectionStart = hargabayar2.Text.Length;

            if (hargabayar1.Text == "")
            {
                harga1 = 0;
            }
            else
            {
                int ans = int.Parse(hargabayar1.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga1 = ans;
            }

            if (hargabayar2.Text == "")
            {
                harga2 = 0;
            }
            else
            {
                int ans = int.Parse(hargabayar2.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga2 = ans;
            }
            if (hargabayar3.Text == "")
            {
                harga3 = 0;
            }
            else
            {
                int ans = int.Parse(hargabayar3.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga3 = ans;
            }

            int hitung = harga1 + harga2 + harga3;
            t_total.Text = hitung.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            t_total.Enabled = false;
            t_total.BackColor = SystemColors.ScrollBar;

            if (hargabayar3.Text == "" || hargabayar3.Text == "0") return;
            decimal price;
            price = decimal.Parse(hargabayar3.Text, System.Globalization.NumberStyles.Currency);
            hargabayar3.Text = price.ToString("#,#");
            hargabayar3.SelectionStart = hargabayar3.Text.Length;

            if (hargabayar1.Text == "")
            {
                harga1 = 0;
            }
            else
            {
                int ans = int.Parse(hargabayar1.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga1 = ans;
            }

            if (hargabayar2.Text == "")
            {
                harga2 = 0;
            }
            else
            {
                int ans = int.Parse(hargabayar2.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga2 = ans;
            }
            if (hargabayar3.Text == "")
            {
                harga3 = 0;
            }
            else
            {
                int ans = int.Parse(hargabayar3.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
                harga3 = ans;
            }

            int hitung = harga1 + harga2 + harga3;
            t_total.Text = hitung.ToString();
        }

        private void b_cari_Click(object sender, EventArgs e)
        {
            f_cari cari = new f_cari();
            cari.ShowDialog();
            if (cari.pk.Equals("") == false)
            {
                t_pk.Text = cari.pk;
                b_print.Enabled = true;
                b_print.BackColor = Color.White;

                clearData();
                isiData();
                
            }
        }

        private void clearData()
        {
            b_simpan.Enabled = false;
            b_simpan.BackColor = SystemColors.ScrollBar;

            t_terimaDari.Enabled = false;
            t_terimaDari.Text = "";
            t_terimaDari.BackColor = SystemColors.ScrollBar;

            t_uangSejumlah.Enabled = false;
            t_uangSejumlah.Text = "";
            t_uangSejumlah.BackColor = SystemColors.ScrollBar;

            t_untukBayar.Enabled = false;
            t_untukBayar.Text = "";
            t_untukBayar.BackColor = SystemColors.ScrollBar;

            untukbayar2.Enabled = false;
            untukbayar2.Text = "";
            untukbayar2.BackColor = SystemColors.ScrollBar;

            untukbayar3.Enabled = false;
            untukbayar3.Text = "";
            untukbayar3.BackColor = SystemColors.ScrollBar;

            hargabayar1.Enabled = false;
            hargabayar1.Text = "";
            hargabayar1.BackColor = SystemColors.ScrollBar;

            hargabayar2.Enabled = false;
            hargabayar2.Text = "";
            hargabayar2.BackColor = SystemColors.ScrollBar;

            hargabayar3.Enabled = false;
            hargabayar3.Text = "";
            hargabayar3.BackColor = SystemColors.ScrollBar;


        }

        private void hargabayar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void hargabayar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void hargabayar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void t_uangSejumlah_TextChanged(object sender, EventArgs e)
        {
            if (t_uangSejumlah.Text == "" || t_uangSejumlah.Text == "0") return;
            decimal price;
            price = decimal.Parse(t_uangSejumlah.Text, System.Globalization.NumberStyles.Currency);
            t_uangSejumlah.Text = price.ToString("#,#");
            t_uangSejumlah.SelectionStart = t_uangSejumlah.Text.Length;
        }

        private void t_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void t_total_TextChanged(object sender, EventArgs e)
        {
            if (t_total.Text == "" || t_total.Text == "0") return;
            decimal price;
            price = decimal.Parse(t_total.Text, System.Globalization.NumberStyles.Currency);
            t_total.Text = price.ToString("#,#");
            t_total.SelectionStart = t_total.Text.Length;
        }
    }
}
