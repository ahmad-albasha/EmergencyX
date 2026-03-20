namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnPredict = new Button();
            txtAge = new TextBox();
            txtSex = new TextBox();
            txtCp = new TextBox();
            txtCaa = new TextBox();
            txtFbs = new TextBox();
            txtRestecg = new TextBox();
            txtExng = new TextBox();
            txtThalachh = new TextBox();
            txtOldpeak = new TextBox();
            txtTrtbps = new TextBox();
            txtChol = new TextBox();
            txtSlp = new TextBox();
            txtThall = new TextBox();
            lblResult = new TextBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            txtName = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            CP = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSavePationt = new Button();
            panel2 = new Panel();
            label6 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button3 = new Button();
            button5 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPredict
            // 
            btnPredict.BackColor = SystemColors.ControlLight;
            btnPredict.FlatAppearance.BorderSize = 0;
            btnPredict.FlatStyle = FlatStyle.Flat;
            btnPredict.Location = new Point(1430, 840);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(157, 44);
            btnPredict.TabIndex = 0;
            btnPredict.Text = "Predict";
            btnPredict.UseVisualStyleBackColor = false;
            btnPredict.Click += btnPredict_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(310, 202);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(196, 34);
            txtAge.TabIndex = 1;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(310, 310);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(196, 34);
            txtSex.TabIndex = 2;
            // 
            // txtCp
            // 
            txtCp.Location = new Point(310, 418);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(196, 34);
            txtCp.TabIndex = 3;
            // 
            // txtCaa
            // 
            txtCaa.Location = new Point(813, 524);
            txtCaa.Name = "txtCaa";
            txtCaa.Size = new Size(240, 34);
            txtCaa.TabIndex = 4;
            // 
            // txtFbs
            // 
            txtFbs.Location = new Point(310, 729);
            txtFbs.Name = "txtFbs";
            txtFbs.Size = new Size(196, 34);
            txtFbs.TabIndex = 5;
            // 
            // txtRestecg
            // 
            txtRestecg.Location = new Point(813, 723);
            txtRestecg.Name = "txtRestecg";
            txtRestecg.Size = new Size(240, 34);
            txtRestecg.TabIndex = 6;
            // 
            // txtExng
            // 
            txtExng.Location = new Point(813, 205);
            txtExng.Name = "txtExng";
            txtExng.Size = new Size(240, 34);
            txtExng.TabIndex = 7;
            // 
            // txtThalachh
            // 
            txtThalachh.Location = new Point(813, 107);
            txtThalachh.Name = "txtThalachh";
            txtThalachh.Size = new Size(240, 34);
            txtThalachh.TabIndex = 8;
            // 
            // txtOldpeak
            // 
            txtOldpeak.Location = new Point(813, 307);
            txtOldpeak.Name = "txtOldpeak";
            txtOldpeak.Size = new Size(240, 34);
            txtOldpeak.TabIndex = 9;
            // 
            // txtTrtbps
            // 
            txtTrtbps.Location = new Point(310, 524);
            txtTrtbps.Name = "txtTrtbps";
            txtTrtbps.Size = new Size(196, 34);
            txtTrtbps.TabIndex = 10;
            // 
            // txtChol
            // 
            txtChol.Location = new Point(310, 621);
            txtChol.Name = "txtChol";
            txtChol.Size = new Size(196, 34);
            txtChol.TabIndex = 11;
            // 
            // txtSlp
            // 
            txtSlp.Location = new Point(813, 418);
            txtSlp.Name = "txtSlp";
            txtSlp.Size = new Size(240, 34);
            txtSlp.TabIndex = 12;
            // 
            // txtThall
            // 
            txtThall.Location = new Point(813, 618);
            txtThall.Name = "txtThall";
            txtThall.Size = new Size(240, 34);
            txtThall.TabIndex = 13;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(1228, 736);
            lblResult.Multiline = true;
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(359, 71);
            lblResult.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(CP);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtThall);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(txtCaa);
            groupBox1.Controls.Add(txtSlp);
            groupBox1.Controls.Add(txtOldpeak);
            groupBox1.Controls.Add(txtTrtbps);
            groupBox1.Controls.Add(txtExng);
            groupBox1.Controls.Add(txtThalachh);
            groupBox1.Controls.Add(txtChol);
            groupBox1.Controls.Add(txtRestecg);
            groupBox1.Controls.Add(txtFbs);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtSex);
            groupBox1.Controls.Add(txtCp);
            groupBox1.Controls.Add(btnSavePationt);
            groupBox1.Controls.Add(btnPredict);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(275, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1615, 960);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Data";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(111, 107);
            label11.Name = "label11";
            label11.Size = new Size(68, 28);
            label11.TabIndex = 37;
            label11.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(310, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 34);
            txtName.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(676, 624);
            label17.Name = "label17";
            label17.Size = new Size(60, 28);
            label17.TabIndex = 35;
            label17.Text = "Thall";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(676, 530);
            label16.Name = "label16";
            label16.Size = new Size(49, 28);
            label16.TabIndex = 34;
            label16.Text = "Caa";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(676, 310);
            label15.Name = "label15";
            label15.Size = new Size(90, 28);
            label15.TabIndex = 33;
            label15.Text = "Oldpeak";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(676, 201);
            label14.Name = "label14";
            label14.Size = new Size(58, 28);
            label14.TabIndex = 32;
            label14.Text = "Exng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(676, 107);
            label13.Name = "label13";
            label13.Size = new Size(99, 28);
            label13.TabIndex = 31;
            label13.Text = "Thalachh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(111, 310);
            label12.Name = "label12";
            label12.Size = new Size(44, 28);
            label12.TabIndex = 30;
            label12.Text = "Sex";
            // 
            // CP
            // 
            CP.AutoSize = true;
            CP.Location = new Point(111, 418);
            CP.Name = "CP";
            CP.Size = new Size(38, 28);
            CP.TabIndex = 29;
            CP.Text = "CP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(111, 513);
            label10.Name = "label10";
            label10.Size = new Size(73, 28);
            label10.TabIndex = 28;
            label10.Text = "Trtbps";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(111, 624);
            label9.Name = "label9";
            label9.Size = new Size(55, 28);
            label9.TabIndex = 27;
            label9.Text = "Chol";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 729);
            label8.Name = "label8";
            label8.Size = new Size(43, 28);
            label8.TabIndex = 26;
            label8.Text = "Fbs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(676, 735);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 25;
            label7.Text = "Restecg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(676, 424);
            label5.Name = "label5";
            label5.Size = new Size(41, 28);
            label5.TabIndex = 23;
            label5.Text = "Slp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 208);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 22;
            label4.Text = "Age";
            // 
            // btnSavePationt
            // 
            btnSavePationt.BackColor = SystemColors.ControlLight;
            btnSavePationt.FlatAppearance.BorderColor = Color.Blue;
            btnSavePationt.FlatAppearance.BorderSize = 0;
            btnSavePationt.FlatStyle = FlatStyle.Flat;
            btnSavePationt.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSavePationt.ForeColor = SystemColors.ControlDarkDark;
            btnSavePationt.Location = new Point(1228, 840);
            btnSavePationt.Name = "btnSavePationt";
            btnSavePationt.Size = new Size(161, 44);
            btnSavePationt.TabIndex = 21;
            btnSavePationt.Text = "Save";
            btnSavePationt.UseVisualStyleBackColor = false;
            btnSavePationt.Click += btnSavePationt_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(256, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1653, 56);
            panel2.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(2, 4, 41);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(417, 46);
            label6.TabIndex = 36;
            label6.Text = "Predicting a heart attack";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderColor = SystemColors.ControlLight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1569, 0);
            button2.Name = "button2";
            button2.Size = new Size(84, 56);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 4, 41);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Cornsilk;
            panel1.Location = new Point(-7, -34);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 1100);
            panel1.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderColor = Color.DarkGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = SystemColors.ButtonShadow;
            button4.Location = new Point(40, 499);
            button4.Name = "button4";
            button4.Size = new Size(177, 103);
            button4.TabIndex = 15;
            button4.Text = "Emergency prediction\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(10, 1017);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 6;
            label3.Text = "© HeurisTech Company";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.DarkGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonShadow;
            button3.Location = new Point(49, 713);
            button3.Name = "button3";
            button3.Size = new Size(158, 48);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.DarkGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonShadow;
            button5.Location = new Point(49, 299);
            button5.Name = "button5";
            button5.Size = new Size(158, 48);
            button5.TabIndex = 3;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 973);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "_____________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 158);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "_____________________";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Predicting a heart attack";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPredict;
        private TextBox txtAge;
        private TextBox txtSex;
        private TextBox txtCp;
        private TextBox txtCaa;
        private TextBox txtFbs;
        private TextBox txtRestecg;
        private TextBox txtExng;
        private TextBox txtThalachh;
        private TextBox txtOldpeak;
        private TextBox txtTrtbps;
        private TextBox txtChol;
        private TextBox txtSlp;
        private TextBox txtThall;
        private TextBox lblResult;
        private GroupBox groupBox1;
        private Button btnSavePationt;
        private Panel panel2;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button3;
        private Button button5;
        private Label label2;
        private Label label1;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label CP;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label11;
        private TextBox txtName;
        private Button button4;
    }
}