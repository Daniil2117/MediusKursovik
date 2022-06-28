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
    public partial class UpdateinWorkShedule : Form
    {
        int id_shed;
        public UpdateinWorkShedule(int Id_shedule)
        {
            InitializeComponent();
            id_shed = Id_shedule;
        }
        void LoadWorkShedule()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM LoadWorkShedulePerson(@id_shedule)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_shedule", id_shed);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelNum.Text = reader[0].ToString();
                        labelLastName.Text = reader[1].ToString();
                        dateTimePickerDateStart.Text = reader[2].ToString();
                        dateTimePickerDateEnd.Text = reader[3].ToString();
                        textBoxTimeStart.Text = reader[4].ToString();
                        textBoxTimeEnd.Text = reader[5].ToString();
                        textBoxCub.Text = reader[6].ToString();
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

        private void UpdateinWorkShedule_Load(object sender, EventArgs e)
        {
            LoadWorkShedule();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        void UpdateWorkShedule()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC UpdateWorkShedule @id_shedule,@date_shedule_start, " +
                    "@date_shedule_end,@time_start,@time_end,@num_cab";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@id_shedule", id_shed);
                cmd.Parameters.AddWithValue("@date_shedule_start", dateTimePickerDateStart.Value);
                cmd.Parameters.AddWithValue("@date_shedule_end", dateTimePickerDateEnd.Value);
                cmd.Parameters.AddWithValue("@time_start", textBoxTimeStart.Text);
                cmd.Parameters.AddWithValue("@time_end", textBoxTimeEnd.Text);
                cmd.Parameters.AddWithValue("@num_cab", textBoxCub.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void buttonUpdateShedule_Click(object sender, EventArgs e)
        {
            if(textBoxCub.Text == "")
            {
                MessageBox.Show("Есть пустые поля");
            }
            else
            {
                UpdateWorkShedule();
                MessageBox.Show("Расписание обновлено");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ViewWorkShedule viewWorkShedule = new ViewWorkShedule();
            viewWorkShedule.Show();
            Close();
        }
    }
}
