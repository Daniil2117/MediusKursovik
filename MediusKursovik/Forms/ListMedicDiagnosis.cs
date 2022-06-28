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
    public partial class ListMedicDiagnosis : Form
    {
        Bitmap b;
        int id_shedule;
        public ListMedicDiagnosis(int Id_shed)
        {
            id_shedule = Id_shed;
            InitializeComponent();
            b = new Bitmap(panel2.ClientRectangle.Width, panel2.ClientRectangle.Height);
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            MenuNavigation menuNavigation = new MenuNavigation();
            menuNavigation.Show();
            Close();
        }
        void LoadCard()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM CardPatientVrach(@idpat)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@idpat", id_shedule);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelNum.Text = reader[0].ToString();
                        labelLastName.Text = reader[1].ToString();
                        labelName.Text = reader[2].ToString();
                        labelPatronymic.Text = reader[3].ToString();
                        labelBirth.Text = reader[4].ToString().Substring(0, 10);
                        labelPassport.Text = reader[5].ToString();
                        labelGender.Text = reader[6].ToString();
                        labelAdress.Text = reader[7].ToString();
                        labelDiagnosis.Text = reader[8].ToString();
                        labelLek.Text = reader[9].ToString();
                        labelManuf.Text = reader[10].ToString();
                        labelServ.Text = reader[11].ToString();
                        labelCoast.Text = reader[12].ToString();
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
        void LoadCardRole()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM CardPatient(@idpat)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@idpat", id_shedule);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelNum.Text = reader[0].ToString();
                        labelLastName.Text = reader[1].ToString();
                        labelName.Text = reader[2].ToString();
                        labelPatronymic.Text = reader[3].ToString();
                        labelBirth.Text = reader[4].ToString().Substring(0, 10);
                        labelPassport.Text = reader[5].ToString();
                        labelGender.Text = reader[6].ToString();
                        labelAdress.Text = reader[7].ToString();
                        labelDiagnosis.Text = reader[8].ToString();
                        labelLek.Text = reader[9].ToString();
                        labelManuf.Text = reader[10].ToString();
                        labelServ.Text = reader[11].ToString();
                        labelCoast.Text = reader[12].ToString();
                        labelVrach.Text = reader[13].ToString()+ " " + reader[14].ToString() + " " + reader[15].ToString();
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

        private void ListMedicDiagnosis_Load(object sender, EventArgs e)
        {
            panel1.DrawToBitmap(b, panel2.ClientRectangle);
            if (Authorization.Role == "S")
            {
                labelVrach.Text = Authorization.Fio;
                LoadCard();
            }
            else
            {
                LoadCardRole();
            }
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
             printDocument1.Print();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect;
            int pbWidth = e.MarginBounds.Width;
            int pbHeight = e.MarginBounds.Height;
            int ImageWidth = b.Width; int ImageHeight = b.Height;

            SizeF sizef = new SizeF(ImageWidth / b.HorizontalResolution, ImageHeight / b.VerticalResolution);
            float fSeale = Math.Min(pbWidth / sizef.Width, pbHeight / sizef.Height);
            sizef.Width *= fSeale;
            sizef.Height *= fSeale;
            Size size = Size.Ceiling(sizef);
            rect = new Rectangle(e.MarginBounds.Location.X, e.MarginBounds.Location.Y, size.Width, size.Height);
            g.DrawImage(b, rect);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
