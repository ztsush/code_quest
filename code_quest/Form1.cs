using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code_quest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_header.BackColor = Color.FromArgb(109, 110, 106);
            BackColor = Color.FromArgb(40, 41, 35);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_question_Click(object sender, EventArgs e)
        {

        }
    }
}
