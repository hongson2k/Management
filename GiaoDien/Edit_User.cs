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
    public partial class Edit_User : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Edit_User()
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
                dgv_in_EditUser.DataSource = dtbl;
                orcCont.Close();
            }
        }
        private void btnReturn_InDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grant_User grant_User = new Grant_User();
            grant_User.ShowDialog();
            this.Close();
        }
    }
}
