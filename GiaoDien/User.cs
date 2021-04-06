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
    public partial class User : Form
    {
        string connectionString = "USER ID = CARSON;Password=123;DATA SOURCE = localhost:1521/xe;";
        public User()
        {
            InitializeComponent();
            displayData();
        }


        //Nut Show nhưng khỏi cần vì đã có hàm DisplayData rồi
        private void buttom_in_User_Click(object sender, EventArgs e)
        {
            
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users order by created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }
        //Hàm displayData
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users order by created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv1.DataSource = dtbl;
                orcCont.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_User addU = new Add_User();
            addU.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanHe1 p = new PhanHe1();
            p.ShowDialog();
            this.Close();
        }

        private void btn_Drop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drop_User DropU = new Drop_User();
            DropU.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grant_User GrantU = new Grant_User();
            GrantU.ShowDialog();
            this.Close();
        }
    }
}
