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
    public partial class AddReceptionOnPation : Form
    {
        string time;
        int id_shedule;
        string lastname;
        string firstname;
        string patronymic;
        public AddReceptionOnPation(int Id_shed, string Lastname, string Firstname, string Patronymic)
        {
            InitializeComponent();
            id_shedule = Id_shed;
            lastname = Lastname;
            firstname = Firstname;
            patronymic = Patronymic;
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
                    //comboBoxSpecialization.SelectedIndex = -1;
                    //comboBoxVrach.SelectedIndex = -1;
                    //comboBoxDirection.SelectedIndex = -1; 
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        void ComboxLoadSpecialisation()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM [dbo].[LoadComboBoxSpecialization](@comboBoxDirection)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@comboBoxDirection", comboBoxDirection.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxSpecialization.Items.Add(reader[0]);
                    }
                    //comboBoxDirection.SelectedIndex = -1;
                    //comboBoxVrach.SelectedIndex = -1;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        void ComboxLoadVrach()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM LoadComboBoxVrach(@comboBoxSpec)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@comboBoxSpec", comboBoxSpecialization.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxVrach.Items.Add(reader[0]);
                    }
                    //comboBoxSpecialization.SelectedIndex = -1;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void AddReceptionOnPation_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            LoadWorkShedule();
            ComboxLoadDirection();
            //ComboxLoadSpecialisation();
            //ComboxLoadVrach();
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDirection.SelectedIndex != -1)
            {
                comboBoxSpecialization.Items.Clear();
                ComboxLoadSpecialisation();
            }
        }

        private void comboBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpecialization.SelectedIndex != -1)
            {
                comboBoxVrach.Items.Clear();
                ComboxLoadVrach();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            Close();
        }

        void LoadWorkShedule()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM LoadPatientOnId(@id_shedule)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_shedule", id_shedule);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelNumPatient.Text = reader[0].ToString();
                        labelLastNamePatient.Text = reader[1].ToString();
                        labelNamePatient.Text = reader[2].ToString();
                        labelPatronymic.Text = reader[3].ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
        void InsertReceptionPatient()
        {
            DateTime dateTime = DateTime.Parse(dateTimePickerDate.Value.ToShortDateString());
            time = $"{textBoxChasov.Text}" + $"{labelRazdelenie.Text}" + $"{textBoxMinute.Text}";
            //Convert.ToDateTime(time);
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC InsertReceptionPatient @lastname,@name_specialization,@date,@time,@id_pat";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@lastname", comboBoxVrach.SelectedItem);
                cmd.Parameters.AddWithValue("@name_specialization", comboBoxSpecialization.SelectedItem);
                cmd.Parameters.AddWithValue("@date", dateTime);
                cmd.Parameters.AddWithValue("@time", Convert.ToDateTime(time));
                cmd.Parameters.AddWithValue("@id_pat", int.Parse(labelNumPatient.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void buttonAddReception_Click(object sender, EventArgs e)
        {
            if(comboBoxVrach.SelectedIndex == -1 || comboBoxDirection.SelectedIndex == -1 || comboBoxSpecialization.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                MessageBox.Show("Пациент на прием добавлен");
                InsertReceptionPatient();
            }
        }
    }
}
