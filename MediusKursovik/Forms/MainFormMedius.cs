using MaterialSkin;
using MaterialSkin.Controls;
using MediusKursovik.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using License = MediusKursovik.Forms.License;

namespace MediusKursovik
{
    public partial class MainFormMedius : MaterialForm
    {
        public MainFormMedius()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.Show();
            this.Hide();
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            About_Us us = new About_Us();
            us.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRewsQust_Click(object sender, EventArgs e)
        {
            WriteReviews reviews = new WriteReviews();
            reviews.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (Authorization.Role == "S" || Authorization.Role == "A" || Authorization.Role == "H")
            {
                YourPage yourPage = new YourPage();
                yourPage.Show();
                this.Close();
            }
            else
            {
                Warning warning = new Warning();
                warning.Show();
                this.Hide();
            }
        }

        private void buttonLicense_Click(object sender, EventArgs e)
        {
            License license = new License();
            license.Show();
            this.Hide();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            ViewServices view = new ViewServices();
            view.Show();
            this.Hide();
        }

        private void buttonMakeAnApp_Click(object sender, EventArgs e)
        {
            MakeAnAppointment makeAnAppointment = new MakeAnAppointment();
            makeAnAppointment.Show();
            this.Hide();
        }

        private void MainFormMedius_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
    }
}
