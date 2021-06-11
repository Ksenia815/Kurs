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
    public partial class allClients : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public allClients()
        {
            InitializeComponent();
        }

        private void allClients_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                loadClients();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                this.Close();
                return;
            }
        }
        private void loadClients()
        {
            try
            {
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT * FROM Clients ORDER BY Client ASC";
                SqlDataReader r = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                if (r.HasRows)
                {
                    int index = 0;
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add();

                        dataGridView1["cID", index].Value = int.Parse(r.GetValue(0).ToString());
                        dataGridView1["cName", index].Value = r.GetValue(1).ToString();
                        dataGridView1["Birthday", index].Value = r.GetValue(2).ToString();
                        dataGridView1["Place", index].Value = r.GetValue(3).ToString();
                        dataGridView1["Pasport", index].Value = r.GetValue(4).ToString();
                        dataGridView1["PasportDate", index].Value = r.GetValue(5).ToString();
                        dataGridView1["Given", index].Value = r.GetValue(6).ToString();
                        dataGridView1["Objective", index].Value = r.GetValue(7).ToString();
                        dataGridView1["LastDate", index].Value = r.GetValue(8).ToString();
                        index++;
                    }
                }

                r.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                MessageBox.Show("Произошла ошибка при выполнении запроса и чтении ответа..");
            }
        }
        private void allClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadClients();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newClient nC = new newClient();
            nC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Clients WHERE Client = " + int.Parse(dataGridView1[0, ids].Value.ToString());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно удалён.");
            }
            catch
            {
                MessageBox.Show("Для удаления выделите строку в заполненной таблице");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                editClient eC = new editClient();
                eC.id = int.Parse(dataGridView1[0, ids].Value.ToString());
                eC.Show();
            }
            catch
            {
                MessageBox.Show("Для просмотра информации выделите строку в заполненной таблице");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                aboutClient aC = new aboutClient();
                aC.id = int.Parse(dataGridView1[0, ids].Value.ToString());
                aC.Show();
            }
            catch
            {
                MessageBox.Show("Для просмотра информации выделите строку в заполненной таблице");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
