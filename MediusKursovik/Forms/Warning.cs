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
    public partial class Warning : MaterialForm
    {
        public Warning()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            this.Close();
        }
        void CheckPassword()
        {
            if (!(textBoxCheckPass.Text != "") || textBoxCheckPass.Text != "2121")
            {
                MessageBox.Show("Данные не введены или неверный пароль"); return;
            }
            else
            {
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
        }
        private void buttonCheckPass_Click(object sender, EventArgs e)
        {
             CheckPassword(); 
        }
    }
}
