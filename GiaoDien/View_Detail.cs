﻿using System;
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
    public partial class View_Detail : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        string strTemp;
        
        public View_Detail()
        {
            InitializeComponent();
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData1 = new OracleDataAdapter("select GRANTED_ROLE from DBA_ROLE_PRIVS WHERE GRANTEE = '" + txtEdit_username.Text + "'", orcCont);
                DataTable dtbl = new DataTable();
                orcData1.Fill(dtbl);
                dgvRole.DataSource = dtbl;
                dgvRole.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                OracleDataAdapter orcData2 = new OracleDataAdapter("select PRIVILEGE from DBA_SYS_PRIVS WHERE GRANTEE = '" + txtEdit_username.Text + "'", orcCont);
                DataTable dtb2 = new DataTable();
                orcData2.Fill(dtb2);
                dgvSys.DataSource = dtb2;
                dgvSys.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;




                OracleDataAdapter orcData3 = new OracleDataAdapter("select TABLE_NAME, PRIVILEGE from USER_TAB_PRIVS WHERE GRANTEE = '" + txtEdit_username.Text + "'", orcCont);
                DataTable dtb3 = new DataTable();
                orcData3.Fill(dtb3);
                dgvTbl.DataSource = dtb3;
                dgvTbl.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                OracleDataAdapter orcData4 = new OracleDataAdapter("select TABLE_NAME, COLUMN_NAME, PRIVILEGE from USER_COL_PRIVS WHERE GRANTEE = '" + txtEdit_username.Text + "'", orcCont);
                DataTable dtb4 = new DataTable();
                orcData4.Fill(dtb4);
                dgvCol.DataSource = dtb4;
                dgvCol.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                orcCont.Close();
            }
        }
        public void Alert_ViewDetail(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public string Message
        {
            get { return strTemp; }
            set
            {
                strTemp = value;
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
         
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
          
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

        private void btnGrant_Click(object sender, EventArgs e)
        {

            GrantUser grantuser = new GrantUser();
            grantuser.Message = txtEdit_username.Text;
            grantuser.ShowDialog();

        }

        private void txt_edit_nameuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_Detail_Load(object sender, EventArgs e)
        {
            txtEdit_username.Text = strTemp;
            displayData();
        }

        private void btnEdit_Save_Click(object sender, EventArgs e)
        {
            string username = txtEdit_username.Text;
            string password = txt_EditPsw.Text;
            string confirm = txtEditConPsw.Text;


            if (username == "")
            {
                this.Alert_ViewDetail("Please input the username", Form_Alert.enmType.Failed);
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
                            this.Alert_ViewDetail("Password has been \n changed successfully", Form_Alert.enmType.Success);
                        }
                        catch
                        {
                            this.Alert_ViewDetail("The Username already exists\n in the system", Form_Alert.enmType.Failed);
                        }


                    }
                    //CREATE USER son IDENTIFIED BY "123"
                }
                else
                {
                    this.Alert_ViewDetail("Confirm password \n does not match", Form_Alert.enmType.Failed);
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void btn_Revoke_Click(object sender, EventArgs e)
        {
            Revoke_User revokeuser = new Revoke_User();
            revokeuser.Message = txtEdit_username.Text;
            revokeuser.ShowDialog();
        }
    }
}
