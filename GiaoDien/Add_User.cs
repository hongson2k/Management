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
    public partial class Add_User : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public Add_User()
        {
            InitializeComponent();
        }

        private void pn_add_user_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Alert_CreateUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string username = txtUsname.Text;
            string password = txtPsw.Text;
            string confirm = txtConPsw.Text;
            if(username == "" && password=="")
            {
                this.Alert_CreateUser("Please input the username\n and password !!!", Form_Alert.enmType.Failed);
                return;
            }    
            if(password =="")
            {
                this.Alert_CreateUser("Please input the password !!!", Form_Alert.enmType.Failed);
                return;
            }    
            if (username == "")
            {
                this.Alert_CreateUser("Please input the username !!!", Form_Alert.enmType.Failed);
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
                         string queryMain = "CREATE USER " + username + " IDENTIFIED BY " + password;
                         OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                        try
                        {
                            cmdMain.ExecuteNonQuery();
                            connect.Close();
                            this.Alert_CreateUser("The User has been created\n successfully", Form_Alert.enmType.Success);
                        }
                        catch
                        {
                            this.Alert_CreateUser("The Username already exists\n successfully", Form_Alert.enmType.Failed);
                        }

                        
                    }
                    //CREATE USER son IDENTIFIED BY "123"
                }
                else
                {
                    this.Alert_CreateUser("Confirm password \n does not match", Form_Alert.enmType.Failed);
                }
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            //User usera = new User();
            //usera.ShowDialog();
            //bool Isopen = false;
            //foreach(Form f in Application.OpenForms)
            //{
            //    if(f.Text == "User")
            //    {
            //        Isopen = true;
            //        f.BringToFront();
            //        break;
            //    }    
            //}
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();

        }

        private void txt_psw_add_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }
    }
}
