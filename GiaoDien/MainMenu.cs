using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class PhanHe1 : Form
    {
        public PhanHe1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 180)
                MenuVertical.Width = 70;
            else MenuVertical.Width = 180;
        }
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.MenuCenter.Controls.Count > 0)
                this.MenuCenter.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MenuCenter.Controls.Add(fh);
            this.MenuCenter.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role rolea = new Role();
            rolea.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MenuCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PhanHe1_Load(object sender, EventArgs e)
        {

        }

        private void txtRoleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_userAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("e9c46a");
        }
    }
}
