using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaFiesta
{
    public partial class aboutClient : Form
    {
        public static string dir = Environment.CurrentDirectory;
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public int id = 0;
        public int setID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public aboutClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void aboutClient_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT * FROM Clients WHERE Client = " + id;
                SqlDataReader r = myCommand.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        textBox1.Text = r.GetValue(1).ToString();
                        textBox2.Text = r.GetValue(2).ToString();
                        textBox3.Text = r.GetValue(3).ToString();
                        textBox4.Text = r.GetValue(4).ToString();
                        textBox5.Text = r.GetValue(5).ToString();
                        textBox6.Text = r.GetValue(6).ToString();
                        textBox7.Text = r.GetValue(7).ToString();

                    }
                }
                r.Close();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                this.Close();
                return;
            }
        }

        private void aboutClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
