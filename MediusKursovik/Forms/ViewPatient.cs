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
    public partial class ViewPatient : Form
    {
        int column, row;

        public static int Id_shed { get ; set; }
        public static string Lastname { get; set; }
        public static string Firstname { get; set; }
        public static string Patronymic { get; set; }
        public bool flag = false;

        public ViewPatient()
        {
            InitializeComponent();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            this.Close();
        }
        void LoadPatientOnSpeciakist()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM ViewPatientOnSpecialist(@email)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@email",Authorization.UserId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5], reader[6], reader[7], reader[8]);
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
        void LoadPatient()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC ViewPatient";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5], reader[6], reader[7], reader[8]);
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

        private void ViewPatient_Load(object sender, EventArgs e)
        {
            if(Authorization.Role == "S")
            {
                LoadPatientOnSpeciakist();
                buttonNotExistRec.Visible = false;
            }
            else
            {
                buttonNotExistRec.Visible = true;
                buttonDelPatient.Enabled = true;
                LoadPatient();
            }
                timer1.Enabled = true;
                timer1.Interval = 1000;
        }

        void SearchPatient()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM SearchPatient(@textSearch)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@textSearch", "%" + textBoxSearchPatient.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5], reader[6], reader[7], reader[8]);
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

        void DelPatient()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC [dbo].[DelPatient] @id_patient";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_patient", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void textBoxSearchPatient_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchPatient();
        }

        private void buttonViewZapis_Click(object sender, EventArgs e)
        {
            flag = false;
            if (Authorization.Role == "S" || Authorization.Role == "H")
            {
                buttonViewZapis.Enabled = false;
                MessageBox.Show("Данное действие выполняет администратор,обратитесь к нему");
            }
            else
            {
                buttonViewZapis.Enabled = true;
                ViewClieentRecord clieentRecord = new ViewClieentRecord();
                clieentRecord.Show();
                this.Close();
            }

        }

        private void buttonDelPatient_Click(object sender, EventArgs e)
        {
            flag = false;
            if (Authorization.Role == "S" || Authorization.Role == "H")
            {
                buttonDelPatient.Enabled = false;
                MessageBox.Show("Данное действие выполняет администратор,обратитесь к нему");
            }
            else
            {
                if (column > 0)
                    MessageBox.Show("Выберите номер записи в таблице");
                else
                {
                    DelPatient();
                    MessageBox.Show("Пациент удален");
                    dataGridView1.Rows.Clear();
                    LoadPatient();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void buttonAddReception_Click(object sender, EventArgs e)
        {
            flag = false;
            if (Authorization.Role == "S" || Authorization.Role == "H")
            {
                buttonAddReception.Enabled = false;
                MessageBox.Show("Данное действие может совершать только администратор");
            }
            else
            {
                AddReceptionOnPation addReceptionOnPation = new AddReceptionOnPation((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value,
                (string)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value, (string)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value,
                (string)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
                addReceptionOnPation.Show();
                Close();
            }
        }
        void PatientNotExist()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC PatientNotExist";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5], reader[6], reader[7], reader[8]);
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
        private void buttonNotExistRec_Click(object sender, EventArgs e)
        {
                flag = false;
                dataGridView1.Rows.Clear();
                PatientNotExist();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            flag = false;
            if (Authorization.Role == "S")
            {
                dataGridView1.Rows.Clear();
                LoadPatientOnSpeciakist();
            }
            else
            {
                dataGridView1.Rows.Clear();
                LoadPatient();
            }
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Выберите пациентов с диагнозом");
            }
            else
            {
                    ListMedicDiagnosis listMedicDiagnosis = new ListMedicDiagnosis((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    listMedicDiagnosis.Show();
                    Close();
            }
        }

        void ViewPatientHaveDiagnos()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC ViewPatientHaveDiagnos";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5], reader[6], reader[7], reader[8]);
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
        void ViewPatientHaveDiagnosRole()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM ViewPatientHaveDiagnosRole(@idspec)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@idspec", Authorization.UserId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4].ToString().Substring(0, 10), reader[5], reader[6], reader[7], reader[8]);
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

        private void buttonPatDiagn_Click(object sender, EventArgs e)
        {
            flag = true;
            if (Authorization.Role == "S")
            {
                dataGridView1.Rows.Clear();
                ViewPatientHaveDiagnosRole();
            }
            else
            {
                dataGridView1.Rows.Clear();
                ViewPatientHaveDiagnos();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            column = 0;
            row = e.RowIndex;
        }
    }
}
