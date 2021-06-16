using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AutomobileDealer
{
    public partial class D_Employee : Form
    {
        public D_Employee()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void D_Automobiles_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox1.Text = MainForm.a[0];
        }

        private void D_Automobiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.a[0] = "";
            MainForm.a[1] = "";
            MainForm.a[2] = "";
            MainForm.a[3] = "";
            MainForm.a[4] = "";
            MainForm.a[5] = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string d = "SELECT ID_Emp From Employee WHERE ID_Emp = '" + textBox1.Text + "'";
            using (SqlDataAdapter sda = new SqlDataAdapter(d, new SqlConnection(Login.connectString)))
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Необходимо заполнить поле *");
                }
                else
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        string query = "DELETE FROM Employee WHERE ID_Emp = '" + textBox1.Text + "'";
                        SqlConnection sql_conn = new SqlConnection(Login.connectString);
                        SqlCommand sql_comm = new SqlCommand(query, sql_conn);
                        sql_conn.Open();
                        sql_comm.ExecuteNonQuery();
                        sql_conn.Close();

                        MessageBox.Show("Запись удалена");
                    }
                    else
                    {
                        MessageBox.Show("Такой записи не существует");
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}