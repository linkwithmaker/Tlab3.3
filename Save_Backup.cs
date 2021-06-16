using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AutomobileDealer
{
    public partial class Save_Backup : Form
    {
        public Save_Backup()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "BACKUP DATABASE student TO DISK = 'D:\\sql\\" + textBox1.Text + "' ";
                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);
                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();

                MessageBox.Show("БД сохранена");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Backup_Load(object sender, EventArgs e)
        {
        }
    }
}