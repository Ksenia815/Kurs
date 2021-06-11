using System;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace LaFiesta
{
    public partial class editFlat : Form
    {
        public Bitmap image = null;
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
        public editFlat()
        {
            InitializeComponent();
        }

        private void editFlat_Load(object sender, EventArgs e)
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

                        if (!File.Exists(dir + "/nums/" + Convert.ToInt32(textBox1.Text) + ".jpeg")) {
                            button3.Text = "Фотография не установлена.";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Flats SET";
            query += " Num = " + Convert.ToInt32(textBox1.Text) + ",";
            query += " Floor = " + Convert.ToInt32(textBox2.Text) + ",";
            query += " Beds = " + Convert.ToInt32(textBox3.Text) + ",";
            query += " Rooms = " + Convert.ToInt32(textBox4.Text) + ",";
            query += " Class = '" + textBox5.Text + "'";
            query += " WHERE Flat = " + id;

            SqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = query;
            myCommand.ExecuteNonQuery();
            
            if (image != null) image.Save(dir + "/nums/" + Convert.ToInt32(textBox1.Text) + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Данные успешно сохранены. Закройте это окно для обновления информации");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    button3.Text = "Фотография выбрана.";
                }
                catch
                {
                    button3.Text = "Выбрать фотографию";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
