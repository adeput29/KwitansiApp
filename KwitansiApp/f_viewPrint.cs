using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwitansiApp
{
    public partial class f_viewPrint : Form
    {
        public f_viewPrint()
        {
            InitializeComponent();
        }
        f_db db = new f_db();
        String querystr;
        public String s_pk;

        private void refresh()
        {
            db.connectdb();
            db.con.Close();
            MySqlDataAdapter adapter = new MySqlDataAdapter(querystr, db.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Command");
            db.con.Open();
            try
            {
                printKwitansi cr = new printKwitansi();
                cr.SetDataSource(ds);
                cr.VerifyDatabase();
                cr.Refresh();
                this.cr_viewer.ReportSource = cr;
                this.cr_viewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f_viewPrint_Layout(object sender, LayoutEventArgs e)
        {
            querystr = "Select * From dataawal where pk = '"+ s_pk + "'";
            refresh();
        }
    }
}
