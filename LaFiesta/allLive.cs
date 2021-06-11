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
    public partial class allLive : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public allLive()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadLive();
        }
        private void loadLive()
        {
            try
            {
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT Live.*, cName.Name, fName.Class, fName.Num FROM Live JOIN Clients as cName on cName.Client = clientID JOIN Flats as fName on fName.Flat = flatID ORDER BY Live.ID ASC";
                SqlDataReader r = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                if (r.HasRows)
                {
                    int index = 0;
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add();

                        dataGridView1["lID", index].Value = int.Parse(r.GetValue(0).ToString());
                        //dataGridView1["lName", index].Value = r.GetValue(2).ToString();
                        dataGridView1["lNum", index].Value = r.GetValue(1).ToString();
                        dataGridView1["lStart", index].Value = r.GetValue(3).ToString();
                        dataGridView1["lStop", index].Value = r.GetValue(4).ToString();
                        dataGridView1["lName", index].Value = r.GetValue(5).ToString();
                        dataGridView1["lClass", index].Value = r.GetValue(6).ToString();
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

        private void allLive_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                loadLive();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                this.Close();
                return;
            }
        }

        private void allLive_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Live WHERE ID = " + int.Parse(dataGridView1[0, ids].Value.ToString());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно удалён.");
            }
            catch
            {
                MessageBox.Show("Для удаления выделите строку в заполненной таблице");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newLive nL = new newLive();
            nL.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                aboutLive aL = new aboutLive();
                aL.id = int.Parse(dataGridView1[0, ids].Value.ToString());
                aL.Show();
            }
            catch
            {
                MessageBox.Show("Для просмотра информации выделите строку в заполненной таблице");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
