﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AutomobileDealer
{
    public partial class U_Employee_1 : Form
    {
        public U_Employee_1()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string d = "SELECT ID_Emp From Equipment WHERE ID_Emp = '" + textBox1.Text + "'";
            string d1 = "SELECT ID_Emp From Equipment WHERE ID_Emp = '" + textBox2.Text + "'";
            using (SqlDataAdapter sda = new SqlDataAdapter(d, new SqlConnection(Login.connectString)))
            using (SqlDataAdapter sda1 = new SqlDataAdapter(d1, new SqlConnection(Login.connectString)))
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Необходимо заполнить ключевое поле *");
                }
                else
                {
                    if (textBox1.Text == textBox2.Text)
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            string query = "UPDATE Equipment SET ID_Emp = '" + textBox2.Text + "', Emp_name = '" + textBox3.Text + "', SNLS = '" + textBox4.Text + "', INN = '" + textBox5.Text + "', WHERE ID_Emp = '" + textBox1.Text + "'";
                            SqlConnection sql_conn = new SqlConnection(Login.connectString);
                            SqlCommand sql_comm = new SqlCommand(query, sql_conn);
                            sql_conn.Open();
                            sql_comm.ExecuteNonQuery();
                            sql_conn.Close();

                            MessageBox.Show("Запись изменена");
                        }
                        else
                        {
                            MessageBox.Show("Запись не изменена");
                        }
                    }
                    else
                    {
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        if (dt1.Rows.Count == 0)
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows.Count != 0)
                            {
                                string query = "UPDATE Equipment SET Equ = '" + textBox2.Text + "', Emp_name = '" + textBox3.Text + "', SNLS = '" + textBox4.Text + "', INN = '" + textBox5.Text + "'";
                                SqlConnection sql_conn = new SqlConnection(Login.connectString);
                                SqlCommand sql_comm = new SqlCommand(query, sql_conn);
                                sql_conn.Open();
                                sql_comm.ExecuteNonQuery();
                                sql_conn.Close();

                                MessageBox.Show("Запись изменена");
                            }
                            else
                            {
                                MessageBox.Show("Запись не изменена");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Запись на которую вы хотите изменить уже существует");
                        }
                    }
                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void U_Equipment_Load_1(object sender, EventArgs e)
        {
            textBox1.Select();

            textBox1.Text = MainForm.a[0];
            textBox2.Text = MainForm.a[0];
            textBox3.Text = MainForm.a[1];
            textBox4.Text = MainForm.a[2];
            textBox5.Text = MainForm.a[3];
        }

        private void U_Equipment_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            MainForm.a[0] = "";
            MainForm.a[1] = "";
            MainForm.a[2] = "";
            MainForm.a[3] = "";
            MainForm.a[4] = "";
            MainForm.a[5] = "";
        }
    }
}