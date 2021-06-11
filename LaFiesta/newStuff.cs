using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaFiesta
{
    public partial class newStuff : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public newStuff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO admins (Name, Code, Password, Rank) VALUES ";
                query += "('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
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

        private void newStuff_Load(object sender, EventArgs e)
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

        private void newStuff_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
