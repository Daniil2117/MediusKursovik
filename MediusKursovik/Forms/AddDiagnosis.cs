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
    public partial class AddDiagnosis : Form
    {
        int id_recep;
        public AddDiagnosis(int Id_recep)
        {
            InitializeComponent();
            id_recep = Id_recep;
        }
        void ViewPatientOnSpecialistAddDiagnoss()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM ViewPatientOnSpecialistAddDiagnos(@id_shedule)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_shedule", id_recep);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelNum.Text = reader[0].ToString();
                        labelLastName.Text = reader[1].ToString();
                        labelName.Text = reader[2].ToString();
                        labelPatronymic.Text = reader[3].ToString();
                        labelBirth.Text = reader[4].ToString().Substring(0, 10);
                        labelGender.Text = reader[5].ToString();
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

        private void AddDiagnosis_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            labelVrach.Text = Authorization.Fio;
            LoadDiagnosis();
            ViewPatientOnSpecialistAddDiagnoss();
            LoadServices();
        }
        void LoadDiagnosis()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT name_diagnos FROM Diagnosis";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxDiagnosis.Items.Add(reader[0]);
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
        void ComboxLoadMedical()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT name_medicines FROM Medicines " +
                    "JOIN Medicines_diagnosis ON Medicines_diagnosis.id_medicines = Medicines.id_medicines " +
                    "JOIN Diagnosis ON Medicines_diagnosis.id_diagnos = Diagnosis.id_diagnos " +
                    "WHERE name_diagnos = @name_diagnos";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@name_diagnos", comboBoxDiagnosis.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxMedic.Items.Add(reader[0]);
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

        private void comboBoxDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiagnosis.SelectedIndex != -1)
            {
                comboBoxMedic.Items.Clear();
                ComboxLoadMedical();
            }
        }

        void ManuftLek()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT name_manufacterer FROM Medicines " +
                    "WHERE name_medicines = @name_medicines";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@name_medicines", comboBoxMedic.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelManuf.Text = reader[0].ToString();
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

        void LoadServices()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT name_service FROM Service_coast ";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxServices.Items.Add(reader[0]);
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
        void CoastServices()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT coast FROM Service_coast " +
                    "WHERE name_service = @name_service";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@name_service", comboBoxServices.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelCost.Text = reader[0].ToString();
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

        private void comboBoxMedic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManuftLek();
        }

        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoastServices();
        }
        void AddDiagnos()
        { 
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC InsertDiagnozReception @name_diagnos,@id_reception,@name_service";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@name_diagnos", comboBoxDiagnosis.SelectedItem);
                cmd.Parameters.AddWithValue("@id_reception", id_recep);
                cmd.Parameters.AddWithValue("@name_service", comboBoxServices.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
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
            MessageBox.Show("Данные добавлены");
            AddDiagnos();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            ViewReceptionPatient viewReceptionPatient = new ViewReceptionPatient();
            viewReceptionPatient.Show();
            Close();
        }
    }
}
