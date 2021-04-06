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
    public partial class Grant : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Grant()
        {
            InitializeComponent();
            display_user();
        }
        public void display_user()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select username from all_users order by Created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_User.DataSource = dtbl;
                orcCont.Close();
            }
        }
        public void display_pri()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select username from all_users order by Created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_Privileges.DataSource = dtbl;
                orcCont.Close();
            }
        }
    }
}
