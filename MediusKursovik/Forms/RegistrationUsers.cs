using MediusKursovik.Classes;
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
    public partial class RegistrationUsers : Form
    {
        public RegistrationUsers()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void RegistrationUsers_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            ComboxLoadDirection();
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
        void ComboxLoadSpecialisation()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM [dbo].[LoadComboBoxSpecialization](@comboBoxDirection)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@comboBoxDirection", comboBoxDirection.SelectedItem.ToString());
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


        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDirection.SelectedIndex != -1)
            {
                comboBoxSpecialization.Items.Clear();
                ComboxLoadSpecialisation();
            }

        }

        void CreateNewSpecialist()
        {
            DateTime dateTime2 = DateTime.Parse(dateTimeDateBirth.Value.ToShortDateString());
            DateTime dateTime3 = DateTime.Parse(dateTimePickerEmpDate.Value.ToShortDateString());
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC CreateNewSpecialist @email, @password, @lastname, @firstname, @patronymic, " +
                    "@date_of_birth,@phone,@employment_date,@stavka_in_day,@specialization,@name_direction";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@email", textBoxLogin.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@lastname", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@patronymic", textBoxPatronymic.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", dateTime2);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@employment_date", dateTime3);
                cmd.Parameters.AddWithValue("@stavka_in_day", textBoxStavkaDay.Text);
                cmd.Parameters.AddWithValue("@specialization", comboBoxSpecialization.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@name_direction", comboBoxDirection.SelectedItem.ToString());

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Регистрация прошла успешно");
            connection.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" || textBoxPatronymic.Text == "" || textBoxPhone.Text == "" ||
                    comboBoxDirection.SelectedItem.ToString() == "" || textBoxPassword.Text == "" || textBoxTwoPassword.Text == ""
                    || comboBoxSpecialization.SelectedItem.ToString() == "" || dateTimeDateBirth.Value.ToString() == ""
                    || dateTimePickerEmpDate.Value.ToString() == "" || textBoxStavkaDay.Text == "" || textBoxLogin.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                }

                else
                {
                bool rez = CheckPassword(textBoxPassword.Text, textBoxTwoPassword.Text);
                if (!rez) return;
                else
                    if (UserCheck()) CreateNewSpecialist();
                else return;
                    textBoxStavkaDay.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxPhone.Text = "";
                    textBoxTwoPassword.Text = "";
                    textBoxPassword.Text = "";
                    comboBoxSpecialization.SelectedIndex = -1;
                    comboBoxDirection.SelectedIndex = -1;
                    textBoxLogin.Text = "";
                    dateTimeDateBirth.Value = DateTime.Today;
                    dateTimePickerEmpDate.Value = DateTime.Today;
                }
        }
        public bool CheckPassword(string q, string w)
        {
            bool f, f1, f2;
            f = f1 = f2 = false;
            for (int i = 0; i < q.Length; i++)
            {
                if (Char.IsDigit(q[i])) f1 = true;
                if (Char.IsUpper(q[i])) f2 = true;
                if (f1 && f2) break;
            }
            if (!(f1 && f2))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру и одну заглавную букву!");
                return f1 && f2;
            }
            else
            {
                string simbol = "!@#$%^";
                for (int i = 0; i < q.Length; i++)
                {
                    for (int j = 0; j < simbol.Length; j++)
                    {
                        if (q[i] == simbol[j])
                        {
                            f = true;
                            break;
                        }
                    }
                }
                if (!f) MessageBox.Show("Пароль должен содержать один из символов !@#$%^");
                if ((q == w) && f) return true; else { MessageBox.Show("Неверное подтвержден пароль"); return false; }
            }
        }
        bool UserCheck()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connection))
                {
                    connect.Open();

                    string sqlExp = "SELECT email FROM Users WHERE email = @email";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@email", textBoxLogin.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже есть");
                        return false;
                    }
                    else
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            YourPage yourPage = new YourPage();
            yourPage.Show();
            this.Close();
        }

        private void comboBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

