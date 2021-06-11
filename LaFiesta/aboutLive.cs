using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaFiesta
{
    public partial class aboutLive : Form
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
        public aboutLive()
        {
            InitializeComponent();
        }

        private void aboutLive_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(connectionPath);
                myConnection.Open();

                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "SELECT Live.*, cName.Name, fName.Class, fName.Num FROM Live JOIN Clients as cName on cName.Client = clientID JOIN Flats as fName on fName.Flat = flatID WHERE ID = " + id + " ORDER BY Live.ID ASC";
                SqlDataReader r = myCommand.ExecuteReader();
                
                if (r.HasRows)
                {
                    int index = 0;
                    while (r.Read())
                    {
                        textBox1.Text = r.GetValue(5).ToString();
                        textBox2.Text = r.GetValue(7).ToString();
                        textBox3.Text = r.GetValue(3).ToString(); 
                        textBox4.Text = r.GetValue(4).ToString();
                        textBox5.Text = r.GetValue(6).ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
