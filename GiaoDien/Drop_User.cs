using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace GiaoDien
{
    public partial class Drop_User : Form
    {
        
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Drop_User()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_DropUser.DataSource = dtbl;
                orcCont.Close();
            }
        }

        private void Drop_User_Load(object sender, EventArgs e)
        {

        }

        private void dgv_in_DropUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string v = dgv_in_DropUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_drop_nameuser.Text = v;
        }

        private void btnReturn_InDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void btnCancelDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }
    }
}
