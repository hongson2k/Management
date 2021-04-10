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
                OracleDataAdapter orcData = new OracleDataAdapter("SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES ORDER BY role ASC", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_Role.DataSource = dtbl;
                orcCont.Close();
            }
        }
        public void Alert_DropUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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

            CreateRoles createR = new CreateRoles();
            createR.ShowDialog();

        }

        private void btn_Drop_Role_Click(object sender, EventArgs e)
        {
            string username = txtRolename.Text;
            if (username == "")
            {
                this.Alert_DropUser("Please input the username", Form_Alert.enmType.Failed);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this role", "Drop Role", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    using (OracleConnection connect = new OracleConnection(connectionString))
                    {
                        connect.Open();
                        string queryNeed = "alter session set\"_ORACLE_SCRIPT\"=true";
                        OracleCommand cmd = new OracleCommand(queryNeed, connect);
                        cmd.ExecuteNonQuery();
                        string queryMain = "Drop ROLE " + username;
                        OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                        try
                        {
                            cmdMain.ExecuteNonQuery();
                            connect.Close();
                            this.Alert_DropUser("The Role has been DROPPED\n successfully", Form_Alert.enmType.Success);
                            displayData();
                        }
                        catch
                        {
                            this.Alert_DropUser("Role does not exist in the system.", Form_Alert.enmType.Failed);
                        }


                    }
                }
                else return;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Detail_Role vdr = new View_Detail_Role();
            vdr.Message = txtRolename.Text;
            vdr.ShowDialog();
            this.Close();
            
        }

        private void dgv_in_Role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgv_in_Role.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRolename.Text = v;
        }
    }
}
