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
    public partial class Add_Role : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Add_Role()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role rolea = new Role();
            rolea.ShowDialog();
            this.Close();
        }
        public void Alert_Add_Role(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            string username = txtUsname_Role.Text;
            string password = txtPsw_Role.Text;
            string confirm = txtConPsw_Role.Text;
            if (username == "")
            {
                this.Alert_Add_Role("Please input the username !!!", Form_Alert.enmType.Failed);
                return;
            }
            else
            {
                if (password == "" && confirm == "")
                {
                    using (OracleConnection connect = new OracleConnection(connectionString))
                    {
                        connect.Open();
                        string queryNeed = "alter session set\"_ORACLE_SCRIPT\"=true";
                        OracleCommand cmd = new OracleCommand(queryNeed, connect);
                        cmd.ExecuteNonQuery();
                        string queryMain = "CREATE ROLE " + username;
                        OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                        try
                        {
                            cmdMain.ExecuteNonQuery();
                            connect.Close();
                            this.Alert_Add_Role("The Role has been created\n successfully", Form_Alert.enmType.Success);
                        }
                        catch
                        {
                            this.Alert_Add_Role("The Role already exists\n in the system", Form_Alert.enmType.Failed);
                        }
                    }
                }
                if(password != "")
                {
                    if(password == confirm)
                    {
                        using (OracleConnection connect = new OracleConnection(connectionString))
                        {
                            connect.Open();
                            string queryNeed = "alter session set\"_ORACLE_SCRIPT\"=true";
                            OracleCommand cmd = new OracleCommand(queryNeed, connect);
                            cmd.ExecuteNonQuery();
                            string queryMain = "CREATE ROLE " + username + " IDENTIFIED BY "+ password;
                            OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                            try
                            {
                                cmdMain.ExecuteNonQuery();
                                connect.Close();
                                this.Alert_Add_Role("The Role has been created\n successfully", Form_Alert.enmType.Success);
                            }
                            catch
                            {
                                this.Alert_Add_Role("The Role already exists\n in the system", Form_Alert.enmType.Failed);
                            }
                        }
                    }   
                    else
                    {
                        this.Alert_Add_Role("Confirm password \n does not match", Form_Alert.enmType.Failed);
                    }                        
                }    
            }
        }
    }
}
