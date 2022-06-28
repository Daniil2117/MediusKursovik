using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediusKursovik.Forms
{
    public partial class MenuNavigation : Form
    {
        public MenuNavigation()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            YourPage yourPage = new YourPage();
            yourPage.Show();
            this.Close();
        }

        private void buttonViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Close();
        }

        private void buttonRecordClient_Click(object sender, EventArgs e)
        {
            if (Authorization.Role == "S" || Authorization.Role == "H")
            {
                buttonRecordClient.Enabled = false;
                MessageBox.Show("Данное действие выполняет администратор,обратитесь к нему");
            }
            else
            {
                ViewClieentRecord viewClieentRecord = new ViewClieentRecord();
                viewClieentRecord.Show();
                this.Close();
            }
        }

        private void buttonViewWorkShed_Click(object sender, EventArgs e)
        {
            ViewWorkShedule viewWorkShedule = new ViewWorkShedule();
            viewWorkShedule.Show();
            this.Close();
        }

        private void buttonViewReception_Click(object sender, EventArgs e)
        {
            ViewReceptionPatient viewReceptionPatient = new ViewReceptionPatient(); 
            viewReceptionPatient.Show();
            this.Close();
        }
        private void buttonViewSpecialist_Click(object sender, EventArgs e)
        {
            ViewListSpecialists viewListSpecialists = new ViewListSpecialists(); 
            viewListSpecialists.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void MenuNavigation_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
    }
}
