using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AutomobileDealer
{
    public partial class I_Employee_3 : Form
    {
        public I_Employee_3()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void I_Employee_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string d = "SELECT * From Employee_3 WHERE ID_Emp = '" + textBox1.Text + "'";
            using (SqlDataAdapter sda = new SqlDataAdapter(d, new SqlConnection(Login.connectString)))
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Необходимо заполнить ключевое поле *");
                }
                else
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        string query = "INSERT INTO Employee_3 VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        SqlConnection sql_conn = new SqlConnection(Login.connectString);
                        SqlCommand sql_comm = new SqlCommand(query, sql_conn);
                        sql_conn.Open();
                        sql_comm.ExecuteNonQuery();
                        sql_conn.Close();

                        MessageBox.Show("Запись добавленна");
                    }
                    else
                    {
                        MessageBox.Show("Такое ключевое значение уже существует");
                    }
                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void I_Employee_Load_1(object sender, EventArgs e)
        {
        }
    }
}