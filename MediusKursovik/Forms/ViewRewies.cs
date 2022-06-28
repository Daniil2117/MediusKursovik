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
    public partial class ViewRewies : MaterialForm
    {
        int column, row;
        public ViewRewies()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            StartPosition = FormStartPosition.CenterScreen;
            //MaximumSize = new Size(1151, 757);
            //MinimumSize = new Size(1151, 757);

            FormBorderStyle = FormBorderStyle.Fixed3D;
            ControlBox = false;

            logotip.Location = new Point(12, 68);
            LoadReviews();
        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            this.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (Authorization.Role == "S" || Authorization.Role == "A" || Authorization.Role == "H")
            {
                YourPage yourPage = new YourPage();
                yourPage.Show();
                this.Close();
            }
            else
            {
                WriteReviews reviews = new WriteReviews();
                reviews.Show();
                this.Close();
            }
        }
        void LoadReviews()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC RewiesR";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Column5.Visible = false;
                        Column6.Visible = false;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3]);
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
        void ReviewQ()
        {
            dataGridView1.Rows.Clear();
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC RewiesQ";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Column5.Visible = true;
                        Column6.Visible = true;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3], reader[4],reader[5]);
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
        void ReviewQRole()
        {
            dataGridView1.Rows.Clear();
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC RewiesQRole";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Column5.Visible = true;
                        Column6.Visible = true;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3], reader[4], reader[5]);
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
        private void buttonQuest_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Authorization.Role == "S" || Authorization.Role == "A" || Authorization.Role == "H")
            {
                ReviewQRole();
            }
            else
            {
                ReviewQ();
            }
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadReviews();
        }
        void FiltrDataUsers(DateTime dt1, DateTime dt2)
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM FiltrDataUsers(@dataFrom,@dataTo)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@dataFrom", dt1);
                cmd.Parameters.AddWithValue("@dataTo", dt2);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Column5.Visible = false;
                        Column6.Visible = false;
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2].ToString().Substring(0, 10), reader[3], reader[4]);
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

        private void buttonFiltrDate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
                FiltrDataUsers(dateTimeDateFrom.Value, dateTimePickerTo.Value);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            column = 0;
            row = e.RowIndex;
        }
        void AnswerQuest()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC AnswerQuest @message_rew, @id_rwsqst, @email_us, @id_user";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@message_rew", textBoxAnswer.Text);
                cmd.Parameters.AddWithValue("@id_rwsqst", int.Parse(dataGridView1[column, row].Value.ToString()));
                cmd.Parameters.AddWithValue("@email_us", Authorization.Role);
                cmd.Parameters.AddWithValue("@id_user", Authorization.UserId);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void buttonAnswerQuestion_Click(object sender, EventArgs e)
        {
            if(column > 0 )
            {
                MessageBox.Show("Чтобы отправить ответ выберить по номеру вопроса ");
            }
            else
            {
                if (textBoxAnswer.Text != "")
                {
                    AnswerQuest();
                    MessageBox.Show("Ответ отправлен");
                    dataGridView1.Rows.Clear();
                    ReviewQRole();
                }
                else
                {
                    MessageBox.Show("Чтобы отправить ответ выберите раздел вопрос, либо у вас пустое поле");
                }
            }
        }

        private void ViewRewies_Load(object sender, EventArgs e)
        {
            
            if (Authorization.Role == "S" || Authorization.Role == "A" || Authorization.Role == "H")
            {
                labelID.Text = Authorization.UserId;
                label5.Visible = true;
                textBoxAnswer.Visible = true;
                buttonAnswerQuestion.Visible = true;
            }
            else
            {
                labelID.Visible = false;
                label5.Visible=false;
                textBoxAnswer.Visible = false;
                buttonAnswerQuestion.Visible = false;
            }
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

    }
}
