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
    public partial class ViewWorkShedule : Form
    {
        public static int Id_shedule { get; set; }

        int row;
        int count = 0;
        public ViewWorkShedule()
        {
            InitializeComponent();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            this.Close();
        }
        void LoadWorkShedule()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC LoadWorkShedule";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Id_shedule = (int)reader["id_shedule"];
                        //count++;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3].ToString().Substring(0, 10), reader[4], reader[5], reader[6]);
                    }
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            //labelCount.Text = count.ToString();
        }
        void SearchSpecialist()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM SearchSpeciliast(@textSearch)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@textSearch", "%" + textBoxSearchClient.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //count++;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3].ToString().Substring(0, 10), reader[4], reader[5], reader[6]);
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            //labelCount.Text = count.ToString();
        }
        void SearchSpeciliastOnDate()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM SearchSpeciliastOnDate(@date)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@date", dateTimePickerSearchDate.Value);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //count++;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3].ToString().Substring(0, 10), reader[4], reader[5], reader[6]);
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            //labelCount.Text = count.ToString();
        }

        private void ViewWorkShedule_Load(object sender, EventArgs e)
        {
            if (Authorization.Role == "S" || Authorization.Role == "H")
            {
                buttonUpdateShedule.Visible = false;
            }
                LoadWorkShedule();
                if (dataGridView1.RowCount > 0)
                {
                    count = dataGridView1.RowCount - 1;
                    labelCount.Text = count.ToString();
                }
                else
                {
                    labelCount.Text = "0";
                }
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void textBoxSearchClient_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchSpecialist();
            if (dataGridView1.RowCount > 0)
            {
                count = dataGridView1.RowCount-1;
                labelCount.Text = count.ToString();
            }

        }

        private void buttonSearchDate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchSpeciliastOnDate();
            if (dataGridView1.RowCount > 0)
            {
                count = dataGridView1.RowCount - 1;
                labelCount.Text = count.ToString();
            }
            else
            {
                labelCount.Text = "0";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadWorkShedule();
            if (dataGridView1.RowCount > 0)
            {
                count = dataGridView1.RowCount - 1;
                labelCount.Text = count.ToString();
            }
            else
            {
                labelCount.Text = "0";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdateShedule_Click(object sender, EventArgs e)
        {
            if(Authorization.Role == "S")
            {
                buttonUpdateShedule.Visible = false;
            }
            else
            {
                buttonUpdateShedule.Visible = true;
                UpdateinWorkShedule updateinWorkShedule = new UpdateinWorkShedule((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                updateinWorkShedule.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = e.RowIndex;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
    }
}
