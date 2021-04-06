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
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users order by created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_EditUser.DataSource = dtbl;
                orcCont.Close();
            }
        }
        public void Alert_EditUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnReturn_InDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grant_User grant_User = new Grant_User();
            grant_User.ShowDialog();
            this.Close();
        }

        private void dgv_in_EditUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgv_in_EditUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEdit_username.Text = v;
        }

        private void btnEdit_Save_Click(object sender, EventArgs e)
        {
            string username = txtEdit_username.Text;
            string password = txt_EditPsw.Text;
            string confirm = txtEditConPsw.Text;
            if (username == "")
            {
                this.Alert_EditUser("Please input the username", Form_Alert.enmType.Failed);
                return;
            }
            else
            {
                if (password == confirm)
                {
                    using (OracleConnection connect = new OracleConnection(connectionString))
                    {
                        connect.Open();
                        string queryNeed = "alter session set\"_ORACLE_SCRIPT\"=true";
                        OracleCommand cmd = new OracleCommand(queryNeed, connect);
                        cmd.ExecuteNonQuery();
                        string queryMain = "ALTER USER " + username + " IDENTIFIED BY " + password;
                        OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                        try
                        {
                            cmdMain.ExecuteNonQuery();
                            connect.Close();
                            this.Alert_EditUser("Password has been \n changed successfully", Form_Alert.enmType.Success);
                        }
                        catch
                        {
                            this.Alert_EditUser("The Username already exists\n in the system", Form_Alert.enmType.Failed);
                        }


                    }
                    //CREATE USER son IDENTIFIED BY "123"
                }
                else
                {
                    this.Alert_EditUser("Confirm password \n does not match", Form_Alert.enmType.Failed);
                }
            }
        }
    }
}
