using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaFiesta
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allFlats aF = new allFlats();
            aF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allClients aC = new allClients();
            aC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            allStuff aS = new allStuff();
            aS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            allLive aL = new allLive();
            aL.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того, чтобы распечатать информацию, перейдите в любую таблицу и нажмите Печать");
        }
    }
}
