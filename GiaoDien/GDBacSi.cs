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
    public partial class GDBacSi : Form
    {
        public GDBacSi()
        {
            InitializeComponent();
        }
        public string username;
        public string password;
        //public void displayData()
        //{
            
        //    using (OracleConnection conn = DBConnection.GetConnection(username, password))
        //    {
        //        conn.Open();
        //        OracleDataAdapter orcData = new OracleDataAdapter("select * from ADQLBV.NHANVIEN ", conn);
        //        DataTable dtbl = new DataTable();
        //        orcData.Fill(dtbl);
        //        dgv_bs.DataSource = dtbl;
        //        dgv_bs.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        //        conn.Close();
        //    }
        //}
        public void displayData_In4_Bacsi()
        {

            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADQLBV.NHANVIEN ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                lb_manv.Text = dtbl.Rows[0][0].ToString();
                txt_TenNhanVien.Text = dtbl.Rows[0][1].ToString();
                txt_DiaChi.Text = dtbl.Rows[0][2].ToString();
                txt_NgaySinh.Text = dtbl.Rows[0][3].ToString();
                txt_CMND.Text = dtbl.Rows[0][4].ToString();
                lb_Luong.Text = dtbl.Rows[0][5].ToString();
                txt_GioiTinh.Text = dtbl.Rows[0][6].ToString();
                lb_PhuCap.Text = dtbl.Rows[0][7].ToString();
                lbDonVi.Text = dtbl.Rows[0][8].ToString();
                lbVaiTro.Text = dtbl.Rows[0][9].ToString();

                lbWelcome.Text = dtbl.Rows[0][1].ToString();
                conn.Close();
            }
        }

        private void GDBacSi_Load(object sender, EventArgs e)
        {
            //displayData();
            displayData_In4_Bacsi();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logout = new Login();
            logout.ShowDialog();
            this.Close();
        }

        private void topdashboard_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
