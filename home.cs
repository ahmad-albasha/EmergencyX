using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WinFormsApp2
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        int nurseID;

        public home(int nurseID)
        {
            InitializeComponent();
            this.nurseID = nurseID;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {

            string connectionString =
            @"Data Source=localhost\SQLEXPRESS;
  Initial Catalog=Emergency;
  Integrated Security=True;";

            string query = "SELECT * FROM Patients";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void LoadData2()
        {

            string connectionString =
            @"Data Source=localhost\SQLEXPRESS;
  Initial Catalog=Emergency;
  Integrated Security=True;";

            string query = "SELECT * FROM PatientsHaert";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(nurseID);
            this.Hide();
            mainForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2(nurseID);
            this.Hide();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(nurseID);
            this.Hide();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2(nurseID);
            this.Hide();
            mainForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Load(object sender, EventArgs e)
        {
            
            LoadData();
            LoadData2();
        }
    }
}
