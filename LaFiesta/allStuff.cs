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
    public partial class allStuff : Form
    {
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        public allStuff()
        {
            InitializeComponent();
        }

        private void allStuff_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                loadStuff();
            }
            catch
            {
                MessageBox.Show("Не могу подключиться к базе данных, попробуйте перезапустить сервер!");
                this.Close();
                return;
            }
        }
        private void loadStuff()
        {
            try
            {
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT * FROM admins ORDER BY ID ASC";
                SqlDataReader r = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                if (r.HasRows)
                {
                    int index = 0;
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add();

                        dataGridView1["sID", index].Value = int.Parse(r.GetValue(0).ToString());
                        dataGridView1["sName", index].Value = r.GetValue(1).ToString();
                        dataGridView1["sRank", index].Value = r.GetValue(4).ToString();
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

        private void allStuff_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadStuff();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newStuff nS = new newStuff();
            nS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = dataGridView1.CurrentRow.Index;
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "DELETE FROM admins WHERE ID = " + int.Parse(dataGridView1[0, ids].Value.ToString());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно удалён.");
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
                editAdmin eA = new editAdmin();
                eA.id = int.Parse(dataGridView1[0, ids].Value.ToString());
                eA.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
