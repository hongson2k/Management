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
    public partial class GDBanThuoc : Form
    {
        public GDBanThuoc()
        {
            InitializeComponent();
        }
        public string username;
        public string password;
        public void displayData_In4()
        {

            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.NHANVIEN ", conn);
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

                lbVaiTro.Text = dtbl.Rows[0][8].ToString();
                lbDonVi.Text = dtbl.Rows[0][9].ToString();
                lbName.Text = dtbl.Rows[0][1].ToString();
                conn.Close();
            }
        }

        private void GDBanThuoc_Load(object sender, EventArgs e)
        {
            displayData_In4();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logout = new Login();
            logout.ShowDialog();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBConnection.GetConnection(username, password);
            try
            {
                conn.Open();
                string sql = "UPDATE ADMINBV.NHANVIEN SET HoTen = '" + txt_TenNhanVien.Text + "', DiaChi = '" + txt_DiaChi.Text + "', GioiTinh = '" + txt_GioiTinh.Text + "', CMND = '" + txt_CMND.Text + "' WHERE MANHANVIEN = '" + lb_manv.Text + "'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully !!!");
                //this.Alert_GDBacSi("Updated successfully !!!", Form_Alert.enmType.Success);
                displayData_In4();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
