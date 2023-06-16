using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            (this.Owner as pong).pongTimer.Interval = 20;
        }

        private void rbtnHard_CheckedChanged(object sender, EventArgs e)
        {
            (this.Owner as pong).pongTimer.Interval = 5;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            (this.Owner as pong).cpuScoreLabel.Text = "0";
            (this.Owner as pong).playerScoreLabel.Text = "0";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            (this.Owner as pong).pongTimer.Start();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
