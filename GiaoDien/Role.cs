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
    public partial class Role : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Role()
        {
            InitializeComponent();
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users order by created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_Role.DataSource = dtbl;
                orcCont.Close();
            }
        }
    }
}
