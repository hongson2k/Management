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
    public partial class RevokeRole : Form
    {
        public RevokeRole()
        {
            InitializeComponent();

        }
        string strTemp;
        string connectionString = "USER ID = ADMINBV;Password=123;DATA SOURCE = localhost:1521/xe;";

        public string Message
        {
            get
            {
                return strTemp;
            }
            set
            {
                strTemp = value;

            }
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData1 = new OracleDataAdapter("select GRANTED_ROLE from DBA_ROLE_PRIVS WHERE GRANTEE = '" + strTemp + "'", orcCont);
                DataTable dtbl = new DataTable();
                orcData1.Fill(dtbl);
                dgvRole.DataSource = dtbl;
                dgvRole.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke1 = new DataGridViewCheckBoxColumn();
                revoke1.HeaderText = "Revoke";
                dgvRole.Columns.Add(revoke1);
                //


                OracleDataAdapter orcData2 = new OracleDataAdapter("select PRIVILEGE from DBA_SYS_PRIVS WHERE GRANTEE = '" + strTemp + "'", orcCont);
                DataTable dtb2 = new DataTable();
                orcData2.Fill(dtb2);
                dgvSys.DataSource = dtb2;
                dgvSys.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke2 = new DataGridViewCheckBoxColumn();
                revoke2.HeaderText = "Revoke";
                dgvSys.Columns.Add(revoke2);
                //

                OracleDataAdapter orcData3 = new OracleDataAdapter("select TABLE_NAME, PRIVILEGE from USER_TAB_PRIVS WHERE GRANTEE = '" + strTemp + "' ORDER BY TABLE_NAME ASC", orcCont);
                DataTable dtb3 = new DataTable();
                orcData3.Fill(dtb3);
                dgvTbl.DataSource = dtb3;
                dgvTbl.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke3 = new DataGridViewCheckBoxColumn();
                revoke3.HeaderText = "Revoke";
                dgvTbl.Columns.Add(revoke3);
                //

                OracleDataAdapter orcData4 = new OracleDataAdapter("select TABLE_NAME, COLUMN_NAME, PRIVILEGE from USER_COL_PRIVS WHERE GRANTEE = '" + strTemp + "'", orcCont);
                DataTable dtb4 = new DataTable();
                orcData4.Fill(dtb4);
                dgvCol.DataSource = dtb4;
                dgvCol.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke4 = new DataGridViewCheckBoxColumn();
                revoke4.HeaderText = "Revoke";
                dgvCol.Columns.Add(revoke4);
                //

                orcCont.Close();
            }
        }
        public void Alert_GrantUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                OracleConnection con = new OracleConnection("USER ID = ADMINBV;Password=123;DATA SOURCE = localhost:1521/xe;");//Kết nối chuỗi dữ liệu
                con.Open();//Mở chuỗi kết nối
                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                command.ExecuteNonQuery();

                // revoke role
                foreach (DataGridViewRow r in dgvRole.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[1].Value) == true)
                    {
                        sql = "REVOKE " + r.Cells[0].Value.ToString() + " FROM " + strTemp;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
                // revoke system privilege
                foreach (DataGridViewRow r in dgvSys.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[0].Value) == true) // sửa đổi giữa 2 cái cell 0 và 1
                    {
                        sql = "REVOKE " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }

                // revoke level table
                foreach (DataGridViewRow r in dgvTbl.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[0].Value) == true)
                    {
                        sql = "REVOKE " + r.Cells[2].Value.ToString() + " ON " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }

                }
                //revoke level column
                foreach (DataGridViewRow r in dgvCol.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[0].Value) == true)
                    {
                        sql = "REVOKE " + r.Cells[3].Value.ToString() + " ON " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
                // NOTE: Không thể revoke quyền trên cột. Ví dụ ta grant update(ten,sdt) on NHANVIEN, nếu muốn 
                // revoke quyền update trên cột ten, thì phải revoke update on NhanVien rồi grant (sdt) on Nhanvien

                //grant lại các quyền trên cột mà không bị revoke
                foreach (DataGridViewRow r in dgvCol.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[0].Value) == true && Convert.ToBoolean(r.Cells[1].Value) == true)
                    {
                        sql = "GRANT " + r.Cells[3].Value.ToString() + " (" + r.Cells[2].Value.ToString() + ") ON " + r.Cells[1].Value.ToString() + " TO " + strTemp;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
                this.Alert_GrantUser("Revoked successfully", Form_Alert.enmType.Success);
            }
            catch
            {
                this.Alert_GrantUser("Revoked successfully", Form_Alert.enmType.Success);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Revoke_User_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
