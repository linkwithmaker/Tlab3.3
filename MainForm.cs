using AutomobileDealer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1;

namespace AutomobileDealer
{
    public partial class MainForm : Form
    {
        public static string[] a = { "", "", "", "", "", "", "", "" };

        public MainForm()
        {
/*            this.button4.Visible = true;
            this.button5.Visible = true;*/
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            if (selectedState == "Сотрудники")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID_Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Post", "Должность");
                dataGridView1.Columns.Add("Passport_data", "Паспортные данные");
                dataGridView1.Columns.Add("Phone_number", "Телефон");
                dataGridView1.Columns.Add("Salary", "Зарплата");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Паспортные данные")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee_1";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID_Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("SNLS", "Снилс");
                dataGridView1.Columns.Add("INN", "ИНН");
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Дата рождения")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee_2";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID ");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Age", "Возраст");
                dataGridView1.Columns.Add("WorkStartDate", "Дата вступления в должность");
                dataGridView1.Columns.Add("Office", "Отдел");

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Образование")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee_3";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID Сотрудника");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Degree", "Образование");
                dataGridView1.Columns.Add("BirthDate", "Дата рождения");
                dataGridView1.Columns.Add("Adress", "Адрес");
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            if (selectedState == "Сотрудники")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Post", "Должность");
                dataGridView1.Columns.Add("Passport_data", "Паспортные данные");
                dataGridView1.Columns.Add("Phone_number", "Телефон");
                dataGridView1.Columns.Add("Salary", "Зарплата");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Паспортные данные")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee_1";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID_Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("SNLS", "Снилс");
                dataGridView1.Columns.Add("INN", "ИНН");
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Дата рождения")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee_2";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Age", "Возраст");
                dataGridView1.Columns.Add("WorkStartDate", "Дата вступления в должность");
                dataGridView1.Columns.Add("Office", "Отдел");

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Образование")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                string query = "SELECT * FROM Employee_3";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add("ID_Emp", "ID_Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Degree", "Образование");
                dataGridView1.Columns.Add("BirthDate", "Дата рождения");
                dataGridView1.Columns.Add("Adress", "Адрес");

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            string s = textBox1.Text;

            if (selectedState == "Сотрудники")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                string query = "SELECT * FROM Employee WHERE ID_Emp like '%" + s + "%' or Emp_name like '%" + s + "%' or Post like '%" + s + "%' or Passport_data like '%" + s + "%' or Phone_number like '%" + s + "%' or Salary like '%" + s + "%'";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ID_Emp", "ID Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Post", "Должность");
                dataGridView1.Columns.Add("Passport_data", "Паспортные данные");
                dataGridView1.Columns.Add("Phone_number", "Телефон");
                dataGridView1.Columns.Add("Salary", "Зарплата");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Паспортные данные")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                string query = "SELECT * FROM Employee_1 WHERE ID_Emp like '%" + s + "%' or Emp_name like '%" + s + "%' or SNLS like '%" + s + "%' or INN like '%" + s + "%'";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ID_Emp", "ID_Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("SNLS", "Снилс");
                dataGridView1.Columns.Add("INN", "ИНН");
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Дата рождения")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                string query = "SELECT * FROM Employee_2 Where ID_Emp like '%" + s + "%' or Emp_name like '%" + s + "%' or Age like '%" + s + "%' or WorkStartDate like '%" + s + "%' or Office like '%" + s + "%'";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ID_Emp", "ID Emp");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Age", "Возраст");
                dataGridView1.Columns.Add("WorkStartDate", "Дата вступления в должность");
                dataGridView1.Columns.Add("Office", "Отдел");

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }

            if (selectedState == "Образование")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                string query = "SELECT * FROM Employee_3 Where ID_Emp like '%" + s + "%' or Emp_name like '%" + s + "%' or Degree like '%" + s + "%' or BirthDate like '%" + s + "%' or Adress like '%" + s + "%'";

                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                SqlCommand sql_comm = new SqlCommand(query, sql_conn);

                sql_conn.Open();

                SqlDataReader reader = sql_comm.ExecuteReader();

                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ID_Emp", "ID Сотрудника");
                dataGridView1.Columns.Add("Emp_name", "ФИО");
                dataGridView1.Columns.Add("Degree", "Образование");
                dataGridView1.Columns.Add("BirthDate", "Дата рождения");
                dataGridView1.Columns.Add("Adress", "Адрес");
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                sql_conn.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();

            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 1)
            {
                for (int i = 0; i < selectedCellCount; i++)
                {
                    a[i] = dataGridView1.SelectedCells[i].Value.ToString();
                }
            }

            if (selectedState == "Сотрудники")
            {
                I_Employee newForm = new I_Employee();
                newForm.Show();
            }
            if (selectedState == "Паспортные данные")
            {
                I_Employee_1 newForm = new I_Employee_1();
                newForm.Show();
            }
            if (selectedState == "Дата рождения")
            {
                I_Employee_2 newForm = new I_Employee_2();
                newForm.Show();
            }
            if (selectedState == "Образование")
            {
                I_Employee_3 newForm = new I_Employee_3();
                newForm.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();

            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 1)
            {
                for (int i = 0; i < selectedCellCount; i++)
                {
                    a[i] = dataGridView1.SelectedCells[i].Value.ToString();
                }
            }

            if (selectedState == "Сотрудники")
            {
                D_Employee newForm = new D_Employee();
                newForm.Show();
            }
            if (selectedState == "Паспортные данные")
            {
                D_Employee_1 newForm = new D_Employee_1();
                newForm.Show();
            }
            if (selectedState == "Дата рождения")
            {
                D_Employee_2 newForm = new D_Employee_2();
                newForm.Show();
            }
            if (selectedState == "Образование")
            {
                D_Employee_3 newForm = new D_Employee_3();
                newForm.Show();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();

            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 1)
            {
                for (int i = 0; i < selectedCellCount; i++)
                {
                    a[i] = dataGridView1.SelectedCells[i].Value.ToString();
                }
            }

            if (selectedState == "Сотрудники")
            {
                U_Employee newForm = new U_Employee();
                newForm.Show();
            }
            if (selectedState == "Паспортные данные")
            {
                U_Employee_1 newForm = new U_Employee_1();
                newForm.Show();
            }
            if (selectedState == "Дата рождения")
            {
                U_Employee_2 newForm = new U_Employee_2();
                newForm.Show();
            }
            if (selectedState == "Образование")
            {
                U_Employee_3 newForm = new U_Employee_3();
                newForm.Show();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void CоздатьРезервнуюКопиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_Backup newForm = new Save_Backup();
            newForm.Show();
        }

        private void ЗагрузитьРезервнуюКопиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_Backup newForm = new Load_Backup();
            newForm.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;

                string selectedState = comboBox1.SelectedItem.ToString();

                if (selectedState == "Сотрудники")
                {
                    ExcelApp.Cells[1, 1] = "ID Сотрудника";
                    ExcelApp.Cells[1, 2] = "ФИО";
                    ExcelApp.Cells[1, 3] = "Должность";
                    ExcelApp.Cells[1, 4] = "Паспортные данные";
                    ExcelApp.Cells[1, 5] = "Телефон";
                    ExcelApp.Cells[1, 5] = "Зарплата";
                }

                if (selectedState == "Паспортные данные")
                {
                    ExcelApp.Cells[1, 1] = "ID Сотрудника";
                    ExcelApp.Cells[1, 2] = "ФИО";
                    ExcelApp.Cells[1, 3] = "Снилс";
                    ExcelApp.Cells[1, 4] = "ИНН";
                }

                if (selectedState == "Дата рождения")
                {
                    ExcelApp.Cells[1, 1] = "ID Сотрудника";
                    ExcelApp.Cells[1, 2] = "ФИО";
                    ExcelApp.Cells[1, 3] = "Возраст";
                    ExcelApp.Cells[1, 4] = "Дата вступления в должность";
                    ExcelApp.Cells[1, 5] = "Отдел";
                }

                if (selectedState == "Образование")
                {
                    ExcelApp.Cells[1, 1] = "ID Сотрудника";
                    ExcelApp.Cells[1, 2] = "ФИО";
                    ExcelApp.Cells[1, 3] = "Образование";
                    ExcelApp.Cells[1, 4] = "Дата рождения";
                    ExcelApp.Cells[1, 5] = "Адрес";
                }

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = dataGridView1[i, j].Value;
                    }
                }
                ExcelApp.Visible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Login.usercheck == "user")
            {
                button4.Visible = false;
                button5.Visible = false;
            }
            else
            {
                this.button4.Visible = true;
                this.button5.Visible = true;
            }
        }
    }
}