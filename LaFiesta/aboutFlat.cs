using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaFiesta
{
    public partial class aboutFlat : Form
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
        public aboutFlat()
        {
            InitializeComponent();
        }

        private void aboutFlat_Load(object sender, EventArgs e)
        {

            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT * FROM Flats WHERE Flat = " + id;
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

                        if (File.Exists(dir + "/nums/" + Convert.ToInt32(textBox1.Text) + ".jpeg"))
                        {
                            pictureBox1.Load(dir + "/nums/" + Convert.ToInt32(textBox1.Text) + ".jpeg");
                        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
