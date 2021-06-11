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
    public partial class allFlats : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public allFlats()
        {
            InitializeComponent();
        }

        private void allFlats_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                loadFlats();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                this.Close();
                return;
            }
        }
        public void loadFlats()
        {
            try
            {
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT * FROM Flats ORDER BY Flat ASC";
                SqlDataReader r = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                if (r.HasRows)
                {
                    int index = 0;
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add();

                        dataGridView1["ID", index].Value = int.Parse(r.GetValue(0).ToString());
                        dataGridView1["Number", index].Value = int.Parse(r.GetValue(1).ToString());
                        dataGridView1["Floor", index].Value = int.Parse(r.GetValue(2).ToString());
                        dataGridView1["Beds", index].Value = int.Parse(r.GetValue(3).ToString());
                        dataGridView1["Rooms", index].Value = int.Parse(r.GetValue(4).ToString());
                        dataGridView1["Class", index].Value = r.GetValue(5).ToString();
                        index++;
                    }
                }

                r.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при выполнении запроса и чтении ответа..");
            }
        }

        private void allFlats_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newFlat nF = new newFlat();
            nF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Flats WHERE Flat = " + int.Parse(dataGridView1[0, ids].Value.ToString());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Номер успешно удалён.");
            }
            catch
            {
                MessageBox.Show("Для удаления выделите строку в заполненной таблице");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadFlats();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                editFlat f = new editFlat();
                f.id = int.Parse(dataGridView1[0, ids].Value.ToString());
                f.Show();
            }
            catch
            {
                MessageBox.Show("Для редактирования выделите строку в заполненной таблице");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                aboutFlat aF = new aboutFlat();
                aF.id = int.Parse(dataGridView1[0, ids].Value.ToString());
                aF.Show();
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
