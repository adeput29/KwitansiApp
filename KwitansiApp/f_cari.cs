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
    public partial class f_cari : Form
    {
        public String pk;

        public f_cari()
        {
            InitializeComponent();
        }
        f_db db = new f_db();

        private void refresh()
        {
            db.connectdb();
            db.con.Close();

            MySqlCommand cmdstock = new MySqlCommand("Select * From dataawal order by PK DESC", db.con);
            MySqlDataReader drstock;
            DataTable dtablemat = new DataTable();
            db.con.Open();
            try
            {
                drstock = cmdstock.ExecuteReader();
                dtablemat.Load(drstock);
                dgcari.AutoGenerateColumns = false;
                dgcari.DataSource = dtablemat;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void f_cari_Load(object sender, EventArgs e)
        {

        }

        private void f_cari_Layout(object sender, LayoutEventArgs e)
        {
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgcari.DataSource;
            bs.Filter =
                "telahTerima like '%" + textBox1.Text + "%'  ";
            dgcari.DataSource = bs;
        }

        private void dgcari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgcari.Rows[rowIndex];
            pk = row.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
