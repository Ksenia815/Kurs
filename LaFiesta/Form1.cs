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
    public partial class Form1 : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                Application.Exit();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string code = textBox1.Text;
            string pass = textBox2.Text;


            string query = "SELECT * FROM admins WHERE Code = '" + code + "' AND Password = '" + pass + "'";
            SqlDataReader count = null;
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.CommandText = query;
                count = myCommand.ExecuteReader();
                if (!count.HasRows)
                {
                    MessageBox.Show("Администратор с такими данными не найден!");
                    return;
                }
                mainForm f = new mainForm();
                f.Show();
                this.Hide();
                count.Close();
            }
            catch(Exception er)
            {
                if(count != null) count.Close();
                MessageBox.Show(er.ToString());
                MessageBox.Show("Произошла ошибка при выполнении запроса и чтении ответа..");
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
