using AutomobileDealer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public static string connectString = "Server=DESKTOP-2DRPGMC\\SQLEXPRESS;Database=student;Integrated Security=SSPI;";
        public static DateTime startA = new DateTime();
        public static string user;
        public static string usercheck = "admin";

        public Login()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string d = "select login, password from users where login = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
            using (SqlDataAdapter sda = new SqlDataAdapter(d, new SqlConnection(connectString)))
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    StreamWriter lr = new StreamWriter(@"C:\Users\Egor\source\repos\Tlab3\AutomobileDealer\Resources\LogFile.txt", true);
                    lr.WriteLine("Date = " + DateTime.Now.ToString() + " username = " + textBox1.Text + " logged in");
                    lr.Close();
                    if (textBox1.Text == "user")
                    {
                        usercheck = "user";
                    }
                    else
                        usercheck = "admin";
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        MainForm newForm = new MainForm();
                        newForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}