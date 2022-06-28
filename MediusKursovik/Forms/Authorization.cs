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
    public partial class Authorization : Form
    {
        public static string Fio { get; set; }
        public static string UserId { get; set; }
        public static string Role { get; set; }

        public Authorization()
        {
            InitializeComponent();
            Fio = "";
            UserId = "";

        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            CheckAutorize();
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
        void CheckAutorize()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connection))
                {
                    connect.Open();

                    if (!(textBoxLogin.Text != "" && textBoxPassword.Text != ""))
                    {
                        MessageBox.Show("Введите данные"); return;
                    }
                    string sqlExp = "SELECT * FROM CheckUsers(@login)";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Fio = reader["lastname"].ToString() + " " + reader["firstname"].ToString() + " " + reader["patronymic"].ToString();
                        UserId = reader["email"].ToString();
                        Role = reader["role_id"].ToString();

                        if (reader[1].ToString() == textBoxPassword.Text)
                            switch (reader["role_id"])
                            {
                                case "S":
                                    YourPage yourPage = new YourPage(); 
                                    yourPage.Show();
                                    Close();
                                    break;
                                case "A":
                                    YourPage yourPageA = new YourPage();
                                    yourPageA.Show();
                                    Close();
                                    break;
                                case "H":
                                    YourPage yourPageH = new YourPage();
                                    yourPageH.Show();
                                    Close();
                                    break;
                                default:
                                    MessageBox.Show("Ошибка роли");
                                    break;
                            }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                            textBoxPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
    }
}
