using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Python.Runtime;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        int nurseID;

        public Form2(int nurseID)
        {
            InitializeComponent();
            this.nurseID = nurseID;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            // جمع البيانات من TextBox
            var inputData = new
            {
                age = int.Parse(txtAge.Text),
                sex = int.Parse(txtSex.Text),
                cp = int.Parse(txtCp.Text),
                trtbps = int.Parse(txtTrtbps.Text),
                chol = int.Parse(txtChol.Text),
                fbs = int.Parse(txtFbs.Text),
                restecg = int.Parse(txtRestecg.Text),
                thalachh = int.Parse(txtThalachh.Text),
                exng = int.Parse(txtExng.Text),
                oldpeak = double.Parse(txtOldpeak.Text),
                slp = int.Parse(txtSlp.Text),
                caa = int.Parse(txtCaa.Text),
                thall = int.Parse(txtThall.Text)
            };

            // استدعاء Python للتنبؤ (باستخدام Process)
            string result = RunPythonScript(inputData);
            lblResult.Text = result;
        }
        private string RunPythonScript(dynamic inputData)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python.exe";  // أو المسار الكامل لـ Python
            start.Arguments = $"predict_script.py {inputData.age} {inputData.sex} {inputData.cp} {inputData.trtbps} {inputData.chol} {inputData.fbs} {inputData.restecg} {inputData.thalachh} {inputData.exng} {inputData.oldpeak} {inputData.slp} {inputData.caa} {inputData.thall}";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true; // مهم لرؤية الأخطاء
            start.CreateNoWindow = true;
            start.StandardOutputEncoding = System.Text.Encoding.UTF8;
            start.StandardErrorEncoding = System.Text.Encoding.UTF8;

            using (Process process = Process.Start(start))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd(); // قراءة الأخطاء
                    if (!string.IsNullOrEmpty(errors))
                    {
                        return $"خطأ في السكريبت: {errors}";
                    }
                    return result;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            home mainForm = new home(nurseID);
            this.Hide();
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(nurseID);
            this.Hide();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnSavePationt_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // قراءة القيم من الفورم
                    string patientName = txtName.Text.Trim();
                    int age = int.Parse(txtAge.Text);
                    int sex = int.Parse(txtSex.Text);
                    int cp = int.Parse(txtCp.Text);
                    int trtbps = int.Parse(txtTrtbps.Text);
                    int chol = int.Parse(txtChol.Text);
                    int fbs = int.Parse(txtFbs.Text);
                    int restecg = int.Parse(txtRestecg.Text);
                    int thalachh = int.Parse(txtThalachh.Text);
                    int exng = int.Parse(txtExng.Text);
                    double oldpeak = double.Parse(txtOldpeak.Text);
                    int slp = int.Parse(txtSlp.Text);
                    int caa = int.Parse(txtCaa.Text);
                    int thall = int.Parse(txtThall.Text);

                    // سلسلة الاتصال بقاعدة البيانات
                    string connectionString = @"Server=.\SQLEXPRESS;Database=Emergency;Trusted_Connection=True;Encrypt=False;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"
                        INSERT INTO PatientsHaert
                        (PatientName, Age, Sex, Cp, Trtbps, Chol, Fbs, Restecg, Thalachh, Exng, Oldpeak, Slp, Caa, Thall, NurseID)
                        VALUES
                        (@PatientName, @Age, @Sex, @Cp, @Trtbps, @Chol, @Fbs, @Restecg, @Thalachh, @Exng, @Oldpeak, @Slp, @Caa, @Thall, @NurseID);
                    ";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // تمرير القيم كـ parameters لتجنب SQL Injection
                            cmd.Parameters.AddWithValue("@PatientName", patientName);
                            cmd.Parameters.AddWithValue("@Age", age);
                            cmd.Parameters.AddWithValue("@Sex", sex);
                            cmd.Parameters.AddWithValue("@Cp", cp);
                            cmd.Parameters.AddWithValue("@Trtbps", trtbps);
                            cmd.Parameters.AddWithValue("@Chol", chol);
                            cmd.Parameters.AddWithValue("@Fbs", fbs);
                            cmd.Parameters.AddWithValue("@Restecg", restecg);
                            cmd.Parameters.AddWithValue("@Thalachh", thalachh);
                            cmd.Parameters.AddWithValue("@Exng", exng);
                            cmd.Parameters.AddWithValue("@Oldpeak", oldpeak);
                            cmd.Parameters.AddWithValue("@Slp", slp);
                            cmd.Parameters.AddWithValue("@Caa", caa);
                            cmd.Parameters.AddWithValue("@Thall", thall);
                            cmd.Parameters.AddWithValue("@NurseID", nurseID);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("successfully", "Patient data was successfully saved ✅",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtName.Clear();
                    txtAge.Clear();
                    txtSex.Clear();
                    txtCp.Clear();
                    txtTrtbps.Clear();
                    txtChol.Clear();
                    txtFbs.Clear();
                    txtRestecg.Clear();
                    txtThalachh.Clear();
                    txtExng.Clear();
                    txtOldpeak.Clear();
                    txtSlp.Clear();
                    txtCaa.Clear();
                    txtThall.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}

