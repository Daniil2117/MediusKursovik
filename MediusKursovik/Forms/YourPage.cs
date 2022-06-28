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
    public partial class YourPage : Form
    {
        public YourPage()
        {
            InitializeComponent();
        }

        private void YourPage_Load(object sender, EventArgs e)
        {
            labelID.Text = Authorization.UserId;
            labelFIO.Text = Authorization.Fio;
            if (Authorization.Role == "S")
            {
                labelRole.Text = "Врач";
            }
            if (Authorization.Role == "A")
            {
                labelRole.Text = "Администратор";
            }
            if (Authorization.Role == "H")
            {
                labelRole.Text = "Главный врач";
            }
            buttonRegUsers.Visible= false;
            if(Authorization.Role == "A")
            {
                buttonRegUsers.Visible = true;
            }
            VivodPicture();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegUsers_Click(object sender, EventArgs e)
        {
            RegistrationUsers registration = new RegistrationUsers();
            registration.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
        private void buttonViewReviews_Click(object sender, EventArgs e)
        {
            ViewRewies viewRewies = new ViewRewies();
            viewRewies.Show();
            this.Close();
        }

        private void buttonMenuNavig_Click(object sender, EventArgs e)
        {
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            this.Close();
        }
        public void VivodPicture()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connection))
                {
                    connect.Open();
                    string sqlExp = "Select [photo] from [dbo].[Users]" +
                                    $"where email = @id";
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    command.Parameters.AddWithValue("@id", labelID.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    try
                    {
                        pictureBox1.Image = (Bitmap)Image.FromFile($@"../../{reader[0]}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Фотография отсутсвует");
                    }
                    reader.Close();
                }
            }
            catch (SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }
    }
}
