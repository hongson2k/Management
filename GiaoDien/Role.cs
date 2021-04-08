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
            displayData();
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("SELECT * FROM DBA_ROLES ORDER BY role ASC", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_Role.DataSource = dtbl;
                orcCont.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanHe1 p = new PhanHe1();
            p.ShowDialog();
            this.Close();
        }

        private void add_role_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Role addR = new Add_Role();
            addR.ShowDialog();
            this.Close();
        }

        private void btn_Drop_Role_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drop_Role dropR = new Drop_Role();
            dropR.ShowDialog();
            this.Close();
        }
    }
}
