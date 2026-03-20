using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Text.Json;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int nurseID;
        public Form1(int nurseID)
        {
            InitializeComponent();
            this.nurseID = nurseID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {

            // التحقق من تعبئة جميع الحقول
            if (string.IsNullOrEmpty(cmbGroup.Text) || string.IsNullOrEmpty(cmbSex.Text) ||
                string.IsNullOrEmpty(cmbArrivalMode.Text) || string.IsNullOrEmpty(cmbInjury.Text) ||
                string.IsNullOrEmpty(cmbMental.Text) || string.IsNullOrEmpty(cmbPain.Text) ||
                string.IsNullOrEmpty(cmbDisposition.Text) || string.IsNullOrEmpty(cmbAge.Text) ||
                string.IsNullOrEmpty(cmbSBP.Text) || string.IsNullOrEmpty(cmbDBP.Text) ||
                string.IsNullOrEmpty(cmbHR.Text) || string.IsNullOrEmpty(cmbRR.Text) ||
                string.IsNullOrEmpty(cmbBT.Text) || string.IsNullOrEmpty(cmbNRS.Text))
            {
                MessageBox.Show("Please fill in all fields before predicting.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = RunPythonScript();
            MessageBox.Show(
                $"Predicted KTAS: {result}\n\nNote: This is an AI prediction.",
                "Prediction Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private string RunPythonScript()
        {
            ProcessStartInfo start = new ProcessStartInfo();

            start.FileName = @"C:\Users\ahmad\AppData\Local\Programs\Python\Python311\python.exe";

            start.Arguments =
                $"predict.py " +
                $"\"{cmbGroup.Text}\" " +
                $"\"{cmbSex.Text}\" " +
                $"{Patientsnumber.Value} " +
                $"\"{cmbArrivalMode.Text}\" " +
                $"\"{cmbInjury.Text}\" " +
                $"\"{cmbMental.Text}\" " +
                $"\"{cmbPain.Text}\" " +
                $"{Saturation.Value} " +
                $"\"{cmbDisposition.Text}\" " +
                $"{stay_min.Value} " +
                $"\"{cmbAge.Text}\" " +
                $"\"{cmbSBP.Text}\" " +
                $"\"{cmbDBP.Text}\" " +
                $"\"{cmbHR.Text}\" " +
                $"\"{cmbRR.Text}\" " +
                $"\"{cmbBT.Text}\" " +
                $"\"{cmbNRS.Text}\"";

            start.WorkingDirectory =
                @"C:\Users\ahmad\source\repos\WinFormsApp2\bin\Debug\net10.0-windows\ML";

            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;
            start.StandardOutputEncoding = System.Text.Encoding.UTF8;
            start.StandardErrorEncoding = System.Text.Encoding.UTF8;

            using (Process process = Process.Start(start))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                    return $"Python Error: {error}";

                return output.Trim();
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSavePationt_Click(object sender, EventArgs e)
        {
            // التحقق من أن جميع الحقول مملوءة قبل الحفظ
            if (string.IsNullOrEmpty(pname.Text) || string.IsNullOrEmpty(cmbGroup.Text) ||
                string.IsNullOrEmpty(cmbSex.Text) || string.IsNullOrEmpty(cmbArrivalMode.Text) ||
                string.IsNullOrEmpty(cmbInjury.Text) || string.IsNullOrEmpty(cmbMental.Text) ||
                string.IsNullOrEmpty(cmbPain.Text) || string.IsNullOrEmpty(cmbDisposition.Text) ||
                string.IsNullOrEmpty(cmbAge.Text) || string.IsNullOrEmpty(cmbSBP.Text) ||
                string.IsNullOrEmpty(cmbDBP.Text) || string.IsNullOrEmpty(cmbHR.Text) ||
                string.IsNullOrEmpty(cmbRR.Text) || string.IsNullOrEmpty(cmbBT.Text) ||
                string.IsNullOrEmpty(cmbNRS.Text) || string.IsNullOrEmpty(cmbLOS.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Emergency;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO Patients
                 ([Name], [Group], [Sex], [Patients_number_per_hour], [ArrivalMode], [Injury], [Mental], 
                  [Pain], [Saturation], [Disposition], [stay_min], [New_Age], [New_SBP], [New_DBP], 
                  [New_HR], [New_RR], [New_BT], [New_NRS_pain], [New_KTAS_duration_min], 
                  [New_Length_of_stay_min], [CreatedAt], [NurseID])
                 VALUES
                 (@Name, @Group, @Sex, @Patients_number_per_hour, @ArrivalMode, @Injury, @Mental, 
                  @Pain, @Saturation, @Disposition, @stay_min, @New_Age, @New_SBP, @New_DBP, 
                  @New_HR, @New_RR, @New_BT, @New_NRS_pain, @New_KTAS_duration_min, 
                  @New_Length_of_stay_min, @CreatedAt, @NurseID)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // استبدل القيم بالـ TextBoxes الموجودة على الفورم
                        cmd.Parameters.AddWithValue("@Name", pname.Text);
                        cmd.Parameters.AddWithValue("@Group", cmbGroup.Text);
                        cmd.Parameters.AddWithValue("@Sex", cmbSex.Text);
                        cmd.Parameters.AddWithValue("@Patients_number_per_hour", Patientsnumber.Value);
                        cmd.Parameters.AddWithValue("@Saturation", Saturation.Value);
                        cmd.Parameters.AddWithValue("@stay_min", stay_min.Value);
                        cmd.Parameters.AddWithValue("@ArrivalMode", cmbArrivalMode.Text);
                        cmd.Parameters.AddWithValue("@Injury", cmbInjury.Text);
                        cmd.Parameters.AddWithValue("@Mental", cmbMental.Text);
                        cmd.Parameters.AddWithValue("@Pain", cmbPain.Text);
                        cmd.Parameters.AddWithValue("@Disposition", cmbDisposition.Text);
                        cmd.Parameters.AddWithValue("@New_Age", cmbAge.Text);
                        cmd.Parameters.AddWithValue("@New_SBP", cmbSBP.Text);
                        cmd.Parameters.AddWithValue("@New_DBP", cmbDBP.Text);
                        cmd.Parameters.AddWithValue("@New_HR", cmbHR.Text);
                        cmd.Parameters.AddWithValue("@New_RR", cmbRR.Text);
                        cmd.Parameters.AddWithValue("@New_BT", cmbBT.Text);
                        cmd.Parameters.AddWithValue("@New_NRS_pain", cmbNRS.Text);
                        cmd.Parameters.AddWithValue("@New_KTAS_duration_min", cmbLOS.Text);  // استخدم cmbLOS للمدة
                        cmd.Parameters.AddWithValue("@New_Length_of_stay_min", cmbLOS.Text);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NurseID", nurseID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success!", "The patient has been successfully added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Patient addition error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home mainForm = new home(nurseID);
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
    }
}