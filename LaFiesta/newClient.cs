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
    public partial class newClient : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public newClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string room_class = textBox5.Text;

                string query = "INSERT INTO Clients (Name, Birthday, PlaceBorn, Pasport, PasportDate, PasportGiven, Objective) VALUES ";
                query += "('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "',";
                query += " '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = query;
                myCommand.ExecuteNonQuery();
                
                MessageBox.Show("Данные успешно сохранены. Закройте это окно для обновления информации");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString(), "Ошибка!");
            }
        }

        private void newClient_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                this.Close();
                return;
            }
        }

        private void newClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
