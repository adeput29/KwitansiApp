using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KwitansiApp
{
    public partial class f_db : Form
    {
        public f_db()
        {
            InitializeComponent();
        }
        public String server, namadb, constr, constrfb, pass, user, Dsn, Pwd, Uid, ClientLibrary;
        public MySqlConnection con;
        public String constrfb2, pass2, user2, Dsn2, Pwd2, Uid2;

        private void b_Save_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true);

            key.CreateSubKey("scanbarcode");
            key = key.OpenSubKey("scanbarcode", true);

            key.SetValue("DataSource", t_server.Text);
            key.SetValue("DataCatalog", t_dbsql.Text);
            MessageBox.Show("Berhasil Write Registry");
        }

        private void b_App_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);

            //close the current application process
            Process.GetCurrentProcess().Kill();
        }

        private void b_Test_Click(object sender, EventArgs e)
        {
            connectdb();
        }

        public void bacaregistry()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\scanbarcode"))
                {
                    if (key != null)
                    {
                        Object DataSource = key.GetValue("DataSource");
                        Object DataCatalog = key.GetValue("DataCatalog");
                        if (DataSource != null)
                        {
                            t_server.Text = DataSource as String;
                            server = DataSource as String;
                        }
                        if (DataCatalog != null)
                        {
                            t_dbsql.Text = DataCatalog as String;
                        }
                    }
                }
            }
            catch (Exception ex)  //just for demonstration...it's always best to handle specific exceptions
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Gagal Mengambil Data Registry");
            }
        }

        public void connectdb()
        {
            bacaregistry();
            try
            {
                server = t_server.Text;
                namadb = t_dbsql.Text;
                user = "root";
                pass = "admin";
                constr = "Server='" + server + "';Uid='" + user + "';Pwd='" + pass + "';Database='" + namadb + "'";
                con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand("Select Count(1) from dataawal", con);
                MySqlDataReader dr;
                con.Open();
                try
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.GetInt32(0) > 0)
                        {
                            labelcon.Text = "Database Terkoneksi! Server '" + server + "' -> Database '" + namadb + "'";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
