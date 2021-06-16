using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AutomobileDealer
{
    public partial class Load_Backup : Form
    {
        public Load_Backup()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string query = "USE master RESTORE DATABASE student FROM DISK = '" + comboBox1.Text + "' WITH REPLACE";
                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);
                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();

                MessageBox.Show("БД загружена");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Load_Backup_Load(object sender, EventArgs e)
        {
            string[] second = Directory.GetFiles("D:\\sql"); // путь к папке

            for (int i = 0; i < second.Length; i++)
            {
                comboBox1.Items.Add(second[i]);
            }
        }
    }
}