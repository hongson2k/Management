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

namespace GiaoDien.BenhNhan
{
    public partial class BenhNhan : Form
    {
        public BenhNhan()
        {
            InitializeComponent();
        }


        public string username;
        public string password;

        string strTemp;
        public string Message
        {
            get { return strTemp; }
            set
            {
                strTemp = value;
            }
        }

        public void displayData_BenhNhan()
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.BENHNHAN ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_BenhNhan.DataSource = dtbl;
                dgv_BenhNhan.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_mabn.Text = dgv_BenhNhan.Rows[0].Cells[0].Value.ToString();
                lb_TenBN.Text = dgv_BenhNhan.Rows[0].Cells[1].Value.ToString();
                txt_NSinh.Text = dgv_BenhNhan.Rows[0].Cells[2].Value.ToString();
                lbDiaChi.Text = dgv_BenhNhan.Rows[0].Cells[3].Value.ToString();
                lb_SDT.Text = dgv_BenhNhan.Rows[0].Cells[4].Value.ToString();
                lb_CMND.Text = dgv_BenhNhan.Rows[0].Cells[5].Value.ToString();
                lb_BHYT.Text = dgv_BenhNhan.Rows[0].Cells[6].Value.ToString();
                conn.Close();
            }
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            displayData_BenhNhan();
        }

        private void dgv_BenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_BenhNhan.CurrentRow.Index;
            lb_mabn.Text = dgv_BenhNhan.Rows[i].Cells[0].Value.ToString();
            lb_TenBN.Text = dgv_BenhNhan.Rows[i].Cells[1].Value.ToString();
            txt_NSinh.Text = dgv_BenhNhan.Rows[i].Cells[2].Value.ToString();
            lbDiaChi.Text = dgv_BenhNhan.Rows[i].Cells[3].Value.ToString();
            lb_SDT.Text = dgv_BenhNhan.Rows[i].Cells[4].Value.ToString();
            lb_CMND.Text = dgv_BenhNhan.Rows[i].Cells[5].Value.ToString();
            lb_BHYT.Text = dgv_BenhNhan.Rows[i].Cells[6].Value.ToString();
        }
    }
}
