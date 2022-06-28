using MediusKursovik.Models;
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

namespace MediusKursovik.Forms
{
    public partial class ViewClieentRecord : Form
    {
        int column, row;
        public ViewClieentRecord()
        {
            InitializeComponent();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            this.Close();
        }
        void LoadClient()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC ViewClient";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5]);
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        void SearchClient()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM SearchClient(@textSearch)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@textSearch", "%" + textBoxSearchClient.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5]);
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void ViewClieentRecord_Load(object sender, EventArgs e)
        {
            LoadClient();
            LoadGenderComboBox();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void textBoxSearchClient_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchClient();
        }

        private void buttonViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Close();
        }
        void LoadGenderComboBox()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC GenderComboBox";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxGender.Items.Add(reader[0]);
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        void InsertPatient()
        {
            DateTime dateTime2 = DateTime.Parse(dateTimeDateBirth.Value.ToShortDateString());
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC [dbo].[InsertPatient] @id_client,@date_of_birth,@gender,@address,@passport";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_client", int.Parse(dataGridView1[0, row].Value.ToString()));
                cmd.Parameters.AddWithValue("@date_of_birth", dateTime2);
                cmd.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@address", textBoxAdress.Text);
                cmd.Parameters.AddWithValue("@passport", textBoxPassport.Text);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (textBoxAdress.Text == "" || textBoxPassport.Text == "" || comboBoxGender.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Внесите все данные");
            }
            else
            {
                if (column != 0)
                    MessageBox.Show("Выберите номер записи в таблице");
                else
                {
                    MessageBox.Show("Пациент добавлен");
                    InsertPatient();
                    dataGridView1.Rows.Clear();
                    LoadClient();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void buttonСlear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadClient();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            column = 0;
            row = e.RowIndex;
        }
    }
}
