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
    public partial class Grant_User : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Grant_User()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("SELECT * FROM DBA_ROLE_PRIVS  ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_EditUser.DataSource = dtbl;
                orcCont.Close();
            }
        }
        private void btnReturn_InGrant_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void dgv_in_EditUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgv_in_EditUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_edit_nameuser.Text = v;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_User EditU = new Edit_User();
            EditU.ShowDialog();
            this.Close();
        }

        private void dgv_in_EditUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }
    }
}
