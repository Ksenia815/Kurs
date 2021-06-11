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
    public partial class newFlat : Form
    {
        public static string dir = Environment.CurrentDirectory;
        public SqlConnection myConnection = null;
        public string connectionPath = Properties.Resources.connection;
        Bitmap image = null;
        public newFlat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(image == null)
            {
                MessageBox.Show("Перед созданием нового номера, необходимо выбрать его фотографию.", "Предупреждение");
                return;
            }
            int number, floor, beds, rooms; 
            try
            {
                number = Convert.ToInt32(textBox1.Text);
                floor = Convert.ToInt32(textBox2.Text);
                beds = Convert.ToInt32(textBox3.Text);
                rooms = Convert.ToInt32(textBox4.Text);
                string room_class = textBox5.Text;

                string query = "INSERT INTO Flats (Num, Floor, Beds, Rooms, Class) VALUES ";
                query += "(" + number + ", " + floor + ", " + beds + ", " + rooms + ", '" + room_class + "')";
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = query;
                myCommand.ExecuteNonQuery();

                image.Save(dir + "/nums/" + number + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Данные успешно сохранены. Закройте это окно для обновления информации");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString(), "Ошибка!");
            }
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

        private void newFlat_Load(object sender, EventArgs e)
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

        private void newFlat_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
