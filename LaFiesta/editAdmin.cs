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
    public partial class editAdmin : Form
    {
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
        public editAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void editAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void editAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT * FROM admins WHERE ID = " + id;
                SqlDataReader r = myCommand.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        textBox1.Text = r.GetValue(1).ToString();
                        textBox2.Text = r.GetValue(2).ToString();
                        textBox3.Text = r.GetValue(3).ToString();
                        textBox4.Text = r.GetValue(4).ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(textBox2.Text);
                string query = "UPDATE admins SET";
                query += " Code = " + code + ",";
                query += " Name = '" + textBox1.Text + "',";
                query += " Password = '" + textBox3.Text + "',";
                query += " Rank = '" + textBox4.Text + "'";
                query += " WHERE ID = " + id;

                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = query;
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Данные успешно сохранены. Закройте это окно для обновления информации");
            }
            catch(Exception er) {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
