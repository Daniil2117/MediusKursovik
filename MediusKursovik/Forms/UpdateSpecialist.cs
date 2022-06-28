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
    public partial class UpdateSpecialist : Form
    {
        int id_specialist;
        public UpdateSpecialist(int Id_specialist)
        {
            id_specialist = Id_specialist;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void UpdateSpecialist_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            LoadSpecialist();
            ComboxLoadSpecialisation();
            ComboxLoadDirection();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ViewListSpecialists viewListSpecialists = new ViewListSpecialists();
            viewListSpecialists.Show();
            Close();
        }
        void UpdateSpecialistt()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC UpdateSpecialist @id_spec,@email,@date_of_birth,@telephone, " +
                    "@employment_date, @stavka_in_day, @name_direction,@name_specialization,@password, " +
                    "@lastname,@firstname,@patronymic";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_spec", id_specialist);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", dateTimePickerBirth.Value);
                cmd.Parameters.AddWithValue("@telephone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@employment_date", dateTimePickerDate.Value);
                cmd.Parameters.AddWithValue("@stavka_in_day", textBoxStavkaInDay.Text);
                cmd.Parameters.AddWithValue("@name_direction", comboBoxDirection.Text);
                cmd.Parameters.AddWithValue("@name_specialization", comboBoxSpecialization.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@lastname", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@patronymic", textBoxPatronymic.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        void LoadSpecialist()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM LoadSpecialistOnId(@id_specialist)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_specialist", id_specialist);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelNum.Text = reader[0].ToString();
                        textBoxLastName.Text = reader[1].ToString();
                        textBoxFirstName.Text = reader[2].ToString();
                        textBoxPatronymic.Text = reader[3].ToString();
                        textBoxPhone.Text = reader[4].ToString();
                        dateTimePickerDate.Text = reader[5].ToString();
                        textBoxStavkaInDay.Text = reader[6].ToString();
                        comboBoxSpecialization.Text = reader[7].ToString();
                        textBoxEmail.Text = reader[8].ToString();
                        dateTimePickerBirth.Text = reader[9].ToString();
                        comboBoxDirection.Text = reader[10].ToString();
                        textBoxPassword.Text = reader[11].ToString();
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

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(textBoxFirstName.Text ==""|| textBoxLastName.Text == "" || textBoxPatronymic.Text == ""
                || textBoxPhone.Text ==""||textBoxStavkaInDay.Text == "" ||textBoxPassword.Text ==""||textBoxEmail.Text=="")
            {
                MessageBox.Show("Есть пустые значения");
            }
            else
            {
                UpdateSpecialistt();
                MessageBox.Show("Данные обновлены");
            }
        }
        void ComboxLoadSpecialisation()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT name_specialization FROM Specialization";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxSpecialization.Items.Add(reader[0]);
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
        void ComboxLoadDirection()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC LoadDirection";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxDirection.Items.Add(reader[0]);
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
    }
}
