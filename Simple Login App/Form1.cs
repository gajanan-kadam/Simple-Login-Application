using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Login_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pointer += 2;
            progress.Value = pointer;
            if (pointer == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                LoginPage login = new LoginPage();
                login.Show();

                this.Hide();
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int pointer = 0;
        private void gunaProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
