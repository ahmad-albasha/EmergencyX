using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Emergency;Integrated Security=True;Trust Server Certificate=True";

            string nurseName = NurseName.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(nurseName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Attention", "Please fill in all fields.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT NurseID FROM Login1 
                             WHERE NurseName=@NurseName 
                               AND [Password]=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NurseName", nurseName);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar(); // تنفيذ الاستعلام

                        if (result != null)
                        {
                            int nurseID = Convert.ToInt32(result);
                            home mainForm = new home(nurseID);
                            this.Hide();
                            mainForm.Show();
                        }

                        else
                        {
                            MessageBox.Show("Error", "Incorrect nurse name or password.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error connecting to the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // إنشاء نسخة من Form2
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
