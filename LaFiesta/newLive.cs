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
    public partial class newLive : Form
    {
        public int[] clients = new int[200];
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public newLive()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < clients.Length; i++) { clients[i] = 0; }
            string name = textBox1.Text;
            try
            {
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT Name, Client FROM Clients WHERE Name LIKE '%" + name + "%' ORDER BY Client ASC";
                SqlDataReader r = myCommand.ExecuteReader();

                comboBox1.Items.Clear();
                if (r.HasRows)
                {
                    int index = 0;
                    while (r.Read())
                    {
                        clients[index] = int.Parse(r.GetValue(1).ToString());
                        comboBox1.Items.Add(r.GetValue(0).ToString());
                        index++;
                    }
                }

                r.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                MessageBox.Show("Произошла ошибка при выполнении запроса и чтении ответа..");
            }
        }

        private void newLive_Load(object sender, EventArgs e)
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

        private void newLive_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int flat = Convert.ToInt32(textBox4.Text);
                int clientID = clients[comboBox1.SelectedIndex];
                String start = Convert.ToString(dateTimePicker1.Value);
                String finish = Convert.ToString(dateTimePicker2.Value);
                start = start.Substring(0, 10);
                finish = finish.Substring(0, 10);

                SqlCommand mCMD = myConnection.CreateCommand();
                mCMD.CommandText = "SELECT * FROM Flats WHERE Flat = " + flat;
                SqlDataReader r = mCMD.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Данный номер не найден в таблице!");
                    r.Close();
                    return;
                }
                r.Close();

                mCMD = myConnection.CreateCommand();
                mCMD.CommandText = "SELECT * FROM Live WHERE startDate BETWEEN '" + start + "' AND '" + finish + "' OR  finishDate BETWEEN '" + start + "' AND '" + finish + "'";
                r = mCMD.ExecuteReader();

                if (r.HasRows)
                {
                    MessageBox.Show("В этом промежутке уже заказан данный номер.");
                    r.Close();
                    return;
                }
                r.Close();

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбран клиент в списке.");
                    return;
                }
                if(clients[comboBox1.SelectedIndex] == 0)
                {
                    MessageBox.Show("Не выбран клиент в списке.");
                    return;
                }
                
                string query = "INSERT INTO Live (flatID, clientID, startDate, finishDate) VALUES ";
                query += "('" + flat + "', '" + clientID + "', '" + start + "', '" + finish + "')";
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
    }
}
