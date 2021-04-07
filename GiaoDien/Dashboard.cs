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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_user_btn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("e9c46a");

        }
    }
}
