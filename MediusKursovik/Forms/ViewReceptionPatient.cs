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
    public partial class ViewReceptionPatient : Form
    {
        public static int Id_recep { get; set; }
        public static bool flag = false;
        public static bool flag1 = true;
        int column,row;
        public ViewReceptionPatient()
        {
            InitializeComponent();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
            }
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            Close();
        }
        void ViewReceptionPatientt()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC ViewReceptionPatient";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6].ToString().Substring(0, 10), reader[7]);
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
        void ViewReceptionPatienttOnSpec()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT *FROM ViewReceptionPatientOnSpec(@id_specialist)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_specialist",Authorization.UserId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6].ToString().Substring(0, 10), reader[7]);
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

        private void ViewReceptionPatient_Load(object sender, EventArgs e)
        {
            if (Authorization.Role == "S")
            {
                ViewReceptionPatienttOnSpec();
                buttonAddDiagnosis.Visible = true;
            }
            else
            {
                buttonAddDiagnosis.Visible = false;
                ViewReceptionPatientt();
            }
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
            }
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            Close();
        }
        void DelRecep()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC DelRecep @id_reception";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_reception", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false; 
            }
            if (column > 0)
                MessageBox.Show("Выберите номер записи в таблице");
            else
            {
                DelRecep();
                MessageBox.Show("Запись удалена");
                dataGridView1.Rows.Clear();
                ViewReceptionPatientt();
            }

        }

        private void buttonAddDiagnosis_Click(object sender, EventArgs e)
        {
            if (flag == true && Authorization.Role == "S")
            {
                AddDiagnosis addDiagnosis = new AddDiagnosis((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                addDiagnosis.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Добавить можно лишь у пациентов у которых не поставлен диагноз");
            }
        }
        void ViewPatientOnSpecialistNotDiagnosiss()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT *FROM ViewPatientOnSpecialistNotDiagnosis(@id_specialist)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_specialist", Authorization.UserId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6].ToString().Substring(0, 10), reader[7]);
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
        void PatientNotDiagnosiss()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC PatientNotDiagnosis";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6].ToString().Substring(0, 10), reader[7]);
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
        private void buttonNotDiagnosis_Click(object sender, EventArgs e)
        {
            flag1 = true;
            flag = true;
            if (Authorization.Role == "S")
            {
                dataGridView1.Rows.Clear();
                ViewPatientOnSpecialistNotDiagnosiss();
            }
            else
            {
                dataGridView1.Rows.Clear();
                PatientNotDiagnosiss();
            }
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            flag1 = false;
            flag = false;
            if (Authorization.Role == "S")
            {
                ViewReceptionPatienttOnSpec();
            }
            else
            {
                ViewReceptionPatientt();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            column = e.ColumnIndex;
            row = e.RowIndex;
        }
    }
}
