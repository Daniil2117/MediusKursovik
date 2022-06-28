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
    public partial class MakeAnAppointment : MaterialForm
    {
        public MakeAnAppointment() 
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            StartPosition = FormStartPosition.CenterScreen;
            MaximumSize = new Size(1151, 757);
            MinimumSize = new Size(1151, 757);

            FormBorderStyle = FormBorderStyle.Fixed3D;
            ControlBox = false;

            logotip.Location = new Point(12, 68);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void MakeAnAppointment_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
        void InsertMakeAnAppointment()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC InsertClientRecord @lastname, @firstname, @patronymic, " +
                    "@phone";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@lastname", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@patronymic", textBoxPatronymic.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPnone.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Спасибо за вашy запись, администратор с вами свяжется для уточнения записи");
            connection.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked == true)
            {
                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" || 
                    textBoxPatronymic.Text == "" || textBoxPnone.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                }

                else
                {
                    InsertMakeAnAppointment();
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxPnone.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Чтобы отправить запись нужно подтвердить согласие");
            }
        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            this.Close();
        }
    }
}
