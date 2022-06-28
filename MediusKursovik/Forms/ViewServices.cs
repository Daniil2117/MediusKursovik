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
    public partial class ViewServices : MaterialForm
    {
        public ViewServices()
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
            LoadServices();
            LoadDirectionCombobox();
        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            MainFormMedius mainForm = new MainFormMedius();
            mainForm.Show();
            Close();
        }
        void LoadServices()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC LoadServices";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
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
        void LoadDirectionCombobox()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "EXEC [dbo].[LoadDirection]";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBoxSearchDirec.Items.Add(reader[0]);
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

        private void comboBoxSearchDirec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FiltrTovars(comboBoxSearchDirec.SelectedItem.ToString());
        }
        void FiltrTovars(string cmbSelectionItem)
        {
            if (cmbSelectionItem == "Все типы")
                LoadServices();

            else
            {
                SqlConnection connect = new SqlConnection(Connect.connection);
                try
                {
                    connect.Open();
                    string sqlExpression = "EXEC LoadServicesOnDirection @name_direction";
                    SqlCommand cmd = new SqlCommand(sqlExpression, connect);
                    cmd.Parameters.AddWithValue("@name_direction", cmbSelectionItem);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                        }
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connect.Close();
            }
        }

        private void textBoxSearchServ_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchServices();
        }
        void SearchServices()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM SearchServices(@textSearch)";
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                cmd.Parameters.AddWithValue("@textSearch", "%" + textBoxSearchServ.Text+"%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
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
        void FiltrDateZakazy()
        {
            SqlConnection connection = new SqlConnection(Connect.connection);
            try
            {
                connection.Open();
                string sqlExpression = "SELECT [id_sevice],[name_service],[coast],[name_direction],[dbo].[Users].[lastname] from Service_coast " +
                    "JOIN[dbo].[Spec_On_Direct] ON Service_coast.id_specializ_direct = [dbo].[Spec_On_Direct].id_specializ_direct " +
                    "JOIN[dbo].[Directions] ON[dbo].[Directions].id_direction = [dbo].[Spec_On_Direct].id_direction " +
                    "JOIN[dbo].[Specialists] ON Service_coast.id_specializ_direct = [dbo].[Specialists].id_specializ_direct " +
                    "JOIN[dbo].[Users] ON[dbo].[Users].email = [dbo].[Specialists].email ";
                if (comboBoxFiltrCoast.SelectedIndex == 0)
                {
                    sqlExpression += " ORDER BY [coast] DESC";
                }
                if(comboBoxFiltrCoast.SelectedIndex == 1)
                {
                    sqlExpression += " ORDER BY [coast] ";
                }
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
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

        private void comboBoxFiltrCoast_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FiltrDateZakazy();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDate.Text = now.ToString("D");
            labelTime.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");

        }

        private void ViewServices_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
    }
}
