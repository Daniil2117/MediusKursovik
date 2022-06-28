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
    public partial class ViewListSpecialists : Form
    {
        public static int Id_specialist {get ; set ;}
        public ViewListSpecialists()
        {
            InitializeComponent();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void ViewListSpecialists_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            if (Authorization.Role == "S") 
            { 
                Column6.Visible = false;
                labelSort.Visible = false;
                comboBoxSortStavka.Visible = false;
                Column8.Visible = false;
                Column10.Visible = false;
                buttonDel.Visible = false;
                Column12.Visible = false;
            }
            else
            {
                buttonDel.Visible = true;
                Column6.Visible = true;
                labelSort.Visible = true;
                comboBoxSortStavka.Visible = true;
                Column8.Visible = true;
                Column10.Visible = true;
                Column12.Visible = true;
            }
            LoadSpec();
        }
        void LoadSpec()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC ViewSpecialists";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], 
                            reader[5].ToString().Substring(0, 10), reader[6], reader[7], reader[8], 
                            reader[9].ToString().Substring(0, 10), reader[10], reader[11]);
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
        void SearchSpecialist()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM SearchSpeciliastOnSpisok(@textSearch)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@textSearch", "%" + textBoxSearchSpec.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], 
                            reader[5].ToString().Substring(0, 10), reader[6], reader[7], reader[8], 
                            reader[9].ToString().Substring(0, 10), reader[10], reader[11]);
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

        private void textBoxSearchSpec_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchSpecialist();
        }
        void FiltrDateZakazy()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT [id_specialist],[lastname],[firstname],[patronymic],[telephone],[employment_date],[stavka_in_day],[name_specialization],[dbo].[Specialists].[email]," +
                    " [dbo].[Specialists].date_of_birth, name_direction, [Users].[password] FROM[dbo].[Specialists]" +
                    " JOIN[dbo].[Users] ON[dbo].[Users].email = [dbo].[Specialists].email" +
                    " JOIN[dbo].[Spec_On_Direct] ON[dbo].[Spec_On_Direct].id_specializ_direct = [dbo].[Specialists].id_specializ_direct" +
                    " JOIN[dbo].[Specialization] ON[dbo].[Spec_On_Direct].id_specialization = [dbo].[Specialization].id_specialization" +
                    " JOIN Directions ON Directions.id_direction = Spec_On_Direct.id_direction";
                if (comboBoxSortStavka.SelectedIndex == 0)
                {
                    sqlExpression += " ORDER BY [stavka_in_day] DESC";
                }
                if (comboBoxSortStavka.SelectedIndex == 1)
                {
                    sqlExpression += " ORDER BY [stavka_in_day] ";
                }
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], 
                            reader[5].ToString().Substring(0, 10), reader[6], reader[7], reader[8], 
                            reader[9].ToString().Substring(0, 10), reader[10], reader[11]);
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
        private void comboBoxSortStavka_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FiltrDateZakazy();
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadSpec();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            UpdateSpecialist updateSpecialist = new UpdateSpecialist((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            updateSpecialist.Show();
            Close();
        }
    }
}
