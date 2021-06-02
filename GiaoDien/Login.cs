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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsname.Text;
            string password = txtPsw.Text;
            OracleConnection conn = DBConnection.GetConnection(username, password);
            try
            {
                conn.Open();
                if (username == "BS1" || username == "BS2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: BACSI . \n", "Thông báo", MessageBoxButtons.OK);
                    
                    GDBacSi gd = new GDBacSi();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }


                if (username == "ADQLBV")
                {
                    this.Hide();
                    PhanHe1 phanhe1 = new PhanHe1();
                    phanhe1.ShowDialog();
                    this.Close();
                }
                
               
                    //this.Alert("Login Failed", Form_Alert.enmType.Failed);
                
            }
            catch
            {
                this.Alert("Login Failed", Form_Alert.enmType.Failed);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
