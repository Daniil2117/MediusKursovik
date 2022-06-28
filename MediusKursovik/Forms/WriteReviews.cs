using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class WriteReviews : Form
    {
        public WriteReviews()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            ComboxLoad();
        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked == true)
            {
                if (textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxMessage.Text == "" || textBoxPhone.Text == "" ||
                    comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Заполните все поля!");
                }
                
                else
                {
                    WriteMessage();
                    textBoxEmail.Text = "";
                    textBoxName.Text = "";
                    textBoxMessage.Text = "";
                    textBoxPhone.Text = "";
                    comboBox1.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Чтобы отправить сообщение нужно подтвердить согласие");
            }
        }

        private void pictureBoxReviews_Click(object sender, EventArgs e)
        {
            ViewRewies viewRewies = new ViewRewies();
            viewRewies.Show();
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label8.Text = "Вы хотите оставить отзыв";
            }
            else
            {
                label8.Text = "Вы хотите оставить вопрос";
            }
        }
        void ComboxLoad()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT TOP (2) [qst/rws] from [dbo].[Rewiews]";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[0]);
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
        void WriteMessage()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC WriteReviews @name_user, @telephone, @email, @rws, @message";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@name_user", textBoxName.Text);
                cmd.Parameters.AddWithValue("@telephone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@rws", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@message", textBoxMessage.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Спасибо за ваш отклик, мы рад, что именно вы наш клиент! Если вы задали вопрос, " +
                "его скоро опубликуют с ответом и позвонят");
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void WriteReviews_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
    }
}
