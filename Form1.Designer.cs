namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPredict = new Button();
            cmbGroup = new ComboBox();
            cmbSex = new ComboBox();
            cmbArrivalMode = new ComboBox();
            cmbInjury = new ComboBox();
            cmbMental = new ComboBox();
            cmbPain = new ComboBox();
            cmbDisposition = new ComboBox();
            cmbAge = new ComboBox();
            cmbSBP = new ComboBox();
            cmbHR = new ComboBox();
            cmbDBP = new ComboBox();
            cmbRR = new ComboBox();
            cmbBT = new ComboBox();
            cmbLOS = new ComboBox();
            cmbNRS = new ComboBox();
            Patientsnumber = new NumericUpDown();
            Saturation = new NumericUpDown();
            stay_min = new NumericUpDown();
            NRS_pain = new ComboBox();
            pname = new TextBox();
            btnSavePationt = new Button();
            panel1 = new Panel();
            button6 = new Button();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label41 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            ((System.ComponentModel.ISupportInitialize)Patientsnumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Saturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stay_min).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPredict
            // 
            btnPredict.BackColor = SystemColors.ControlLight;
            btnPredict.FlatAppearance.BorderColor = Color.Blue;
            btnPredict.FlatAppearance.BorderSize = 0;
            btnPredict.FlatStyle = FlatStyle.Flat;
            btnPredict.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnPredict.ForeColor = SystemColors.ControlDarkDark;
            btnPredict.Location = new Point(1440, 925);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(147, 44);
            btnPredict.TabIndex = 0;
            btnPredict.Text = "Predict";
            btnPredict.UseVisualStyleBackColor = false;
            btnPredict.Click += btnPredict_Click;
            // 
            // cmbGroup
            // 
            cmbGroup.Items.AddRange(new object[] { "'Local ED (3th Degree)'", "'Regional ED (4th Degree)'" });
            cmbGroup.Location = new Point(300, 139);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new Size(244, 36);
            cmbGroup.TabIndex = 1;
            // 
            // cmbSex
            // 
            cmbSex.Items.AddRange(new object[] { "'Male'", "'Female'" });
            cmbSex.Location = new Point(300, 315);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(244, 36);
            cmbSex.TabIndex = 2;
            // 
            // cmbArrivalMode
            // 
            cmbArrivalMode.Items.AddRange(new object[] { "'Walking'", "'Public Ambulance'", "'Private Vehicle'", "'Private Ambulance'", "'Other'" });
            cmbArrivalMode.Location = new Point(300, 499);
            cmbArrivalMode.Name = "cmbArrivalMode";
            cmbArrivalMode.Size = new Size(244, 36);
            cmbArrivalMode.TabIndex = 3;
            // 
            // cmbInjury
            // 
            cmbInjury.Items.AddRange(new object[] { "'Yes'", "'No'" });
            cmbInjury.Location = new Point(300, 600);
            cmbInjury.Name = "cmbInjury";
            cmbInjury.Size = new Size(244, 36);
            cmbInjury.TabIndex = 4;
            // 
            // cmbMental
            // 
            cmbMental.Items.AddRange(new object[] { "'Alert'", "'Verbose Response'", "'Pain Response'", "'Unresponsive'" });
            cmbMental.Location = new Point(300, 684);
            cmbMental.Name = "cmbMental";
            cmbMental.Size = new Size(244, 36);
            cmbMental.TabIndex = 5;
            // 
            // cmbPain
            // 
            cmbPain.Items.AddRange(new object[] { "'Yes'", "'No'" });
            cmbPain.Location = new Point(300, 762);
            cmbPain.Name = "cmbPain";
            cmbPain.Size = new Size(244, 36);
            cmbPain.TabIndex = 6;
            // 
            // cmbDisposition
            // 
            cmbDisposition.Items.AddRange(new object[] { "'Discharge'", "'Admission to Ward'", "'Admission to ICU'", "'Transfer'", "'Death'", "'Surgery'" });
            cmbDisposition.Location = new Point(1134, 41);
            cmbDisposition.Name = "cmbDisposition";
            cmbDisposition.Size = new Size(229, 36);
            cmbDisposition.TabIndex = 7;
            // 
            // cmbAge
            // 
            cmbAge.Items.AddRange(new object[] { "'Young'", "'Adult'", "'Mid_Age'", "'Old'" });
            cmbAge.Location = new Point(300, 222);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(244, 36);
            cmbAge.TabIndex = 8;
            // 
            // cmbSBP
            // 
            cmbSBP.Items.AddRange(new object[] { "'Low'", "'Normal'", "'High'" });
            cmbSBP.Location = new Point(1134, 193);
            cmbSBP.Name = "cmbSBP";
            cmbSBP.Size = new Size(229, 36);
            cmbSBP.TabIndex = 9;
            // 
            // cmbHR
            // 
            cmbHR.Items.AddRange(new object[] { "'Low'", "'Normal'", "'High'" });
            cmbHR.Location = new Point(1134, 346);
            cmbHR.Name = "cmbHR";
            cmbHR.Size = new Size(229, 36);
            cmbHR.TabIndex = 11;
            // 
            // cmbDBP
            // 
            cmbDBP.Items.AddRange(new object[] { "'Low'", "'Normal'", "'High'" });
            cmbDBP.Location = new Point(1134, 266);
            cmbDBP.Name = "cmbDBP";
            cmbDBP.Size = new Size(229, 36);
            cmbDBP.TabIndex = 10;
            // 
            // cmbRR
            // 
            cmbRR.Items.AddRange(new object[] { "'Low'", "'Normal'", "'High'" });
            cmbRR.Location = new Point(1134, 420);
            cmbRR.Name = "cmbRR";
            cmbRR.Size = new Size(229, 36);
            cmbRR.TabIndex = 12;
            // 
            // cmbBT
            // 
            cmbBT.Items.AddRange(new object[] { "'Low'", "'Normal'", "'High'" });
            cmbBT.Location = new Point(1134, 506);
            cmbBT.Name = "cmbBT";
            cmbBT.Size = new Size(229, 36);
            cmbBT.TabIndex = 13;
            // 
            // cmbLOS
            // 
            cmbLOS.Items.AddRange(new object[] { "'Immediate'", "'Very Urgent'", "'Urgent'", "'Standart'", "'Non-Urgent'" });
            cmbLOS.Location = new Point(1134, 803);
            cmbLOS.Name = "cmbLOS";
            cmbLOS.Size = new Size(229, 36);
            cmbLOS.TabIndex = 14;
            // 
            // cmbNRS
            // 
            cmbNRS.Items.AddRange(new object[] { "'Immediate'", "'Very Urgent'", "'Urgent'", "'Standart'", "'Non-Urgent'" });
            cmbNRS.Location = new Point(1134, 695);
            cmbNRS.Name = "cmbNRS";
            cmbNRS.Size = new Size(229, 36);
            cmbNRS.TabIndex = 15;
            // 
            // Patientsnumber
            // 
            Patientsnumber.Location = new Point(300, 419);
            Patientsnumber.Name = "Patientsnumber";
            Patientsnumber.Size = new Size(244, 34);
            Patientsnumber.TabIndex = 16;
            // 
            // Saturation
            // 
            Saturation.Location = new Point(300, 856);
            Saturation.Name = "Saturation";
            Saturation.Size = new Size(244, 34);
            Saturation.TabIndex = 17;
            // 
            // stay_min
            // 
            stay_min.Location = new Point(1134, 116);
            stay_min.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            stay_min.Name = "stay_min";
            stay_min.Size = new Size(229, 34);
            stay_min.TabIndex = 18;
            // 
            // NRS_pain
            // 
            NRS_pain.Items.AddRange(new object[] { "'Low Pain'", "'Pain'", "'High Pain'" });
            NRS_pain.Location = new Point(1134, 592);
            NRS_pain.Name = "NRS_pain";
            NRS_pain.Size = new Size(229, 36);
            NRS_pain.TabIndex = 19;
            // 
            // pname
            // 
            pname.Location = new Point(300, 60);
            pname.Name = "pname";
            pname.Size = new Size(244, 34);
            pname.TabIndex = 20;
            // 
            // btnSavePationt
            // 
            btnSavePationt.BackColor = SystemColors.ControlLight;
            btnSavePationt.FlatAppearance.BorderColor = Color.Blue;
            btnSavePationt.FlatAppearance.BorderSize = 0;
            btnSavePationt.FlatStyle = FlatStyle.Flat;
            btnSavePationt.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSavePationt.ForeColor = SystemColors.ControlDarkDark;
            btnSavePationt.Location = new Point(1252, 925);
            btnSavePationt.Name = "btnSavePationt";
            btnSavePationt.Size = new Size(161, 44);
            btnSavePationt.TabIndex = 21;
            btnSavePationt.Text = "Save";
            btnSavePationt.UseVisualStyleBackColor = false;
            btnSavePationt.Click += btnSavePationt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 5, 50);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Cornsilk;
            panel1.Location = new Point(2, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 1100);
            panel1.TabIndex = 22;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderColor = Color.DarkGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic);
            button6.ForeColor = SystemColors.ButtonShadow;
            button6.Location = new Point(28, 442);
            button6.Name = "button6";
            button6.Size = new Size(209, 61);
            button6.TabIndex = 14;
            button6.Text = "Heart attack\r\n";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            button3.Location = new Point(49, 657);
            button3.Name = "button3";
            button3.Size = new Size(158, 48);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.DarkGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Location = new Point(49, 249);
            button2.Name = "button2";
            button2.Size = new Size(158, 48);
            button2.TabIndex = 3;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            label1.Location = new Point(61, 118);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "_____________________";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(262, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1653, 65);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(2, 4, 41);
            label11.Location = new Point(3, 6);
            label11.Name = "label11";
            label11.Size = new Size(387, 38);
            label11.TabIndex = 43;
            label11.Text = "Emergency level prediction";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1567, 0);
            button1.Name = "button1";
            button1.Size = new Size(84, 63);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label39);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(label37);
            groupBox1.Controls.Add(label36);
            groupBox1.Controls.Add(label35);
            groupBox1.Controls.Add(label34);
            groupBox1.Controls.Add(label41);
            groupBox1.Controls.Add(label33);
            groupBox1.Controls.Add(label32);
            groupBox1.Controls.Add(label31);
            groupBox1.Controls.Add(label30);
            groupBox1.Controls.Add(label29);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pname);
            groupBox1.Controls.Add(btnSavePationt);
            groupBox1.Controls.Add(btnPredict);
            groupBox1.Controls.Add(NRS_pain);
            groupBox1.Controls.Add(cmbArrivalMode);
            groupBox1.Controls.Add(cmbPain);
            groupBox1.Controls.Add(cmbGroup);
            groupBox1.Controls.Add(cmbDisposition);
            groupBox1.Controls.Add(Patientsnumber);
            groupBox1.Controls.Add(cmbAge);
            groupBox1.Controls.Add(cmbSex);
            groupBox1.Controls.Add(cmbSBP);
            groupBox1.Controls.Add(cmbMental);
            groupBox1.Controls.Add(cmbDBP);
            groupBox1.Controls.Add(cmbInjury);
            groupBox1.Controls.Add(cmbHR);
            groupBox1.Controls.Add(cmbBT);
            groupBox1.Controls.Add(cmbRR);
            groupBox1.Controls.Add(stay_min);
            groupBox1.Controls.Add(Saturation);
            groupBox1.Controls.Add(cmbLOS);
            groupBox1.Controls.Add(cmbNRS);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(285, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1615, 986);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ControlDarkDark;
            label24.Location = new Point(880, 346);
            label24.Name = "label24";
            label24.Size = new Size(39, 28);
            label24.TabIndex = 42;
            label24.Text = "HR";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ControlDarkDark;
            label23.Location = new Point(880, 420);
            label23.Name = "label23";
            label23.Size = new Size(36, 28);
            label23.TabIndex = 41;
            label23.Text = "RR";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ControlDarkDark;
            label22.Location = new Point(880, 506);
            label22.Name = "label22";
            label22.Size = new Size(35, 28);
            label22.TabIndex = 40;
            label22.Text = "BT";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ControlDarkDark;
            label21.Location = new Point(880, 592);
            label21.Name = "label21";
            label21.Size = new Size(100, 28);
            label21.TabIndex = 39;
            label21.Text = "Pain level";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(880, 698);
            label20.Name = "label20";
            label20.Size = new Size(49, 28);
            label20.TabIndex = 38;
            label20.Text = "NSR";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ControlDarkDark;
            label19.Location = new Point(880, 803);
            label19.Name = "label19";
            label19.Size = new Size(51, 28);
            label19.TabIndex = 37;
            label19.Text = "LOG";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(34, 222);
            label18.Name = "label18";
            label18.Size = new Size(134, 28);
            label18.TabIndex = 36;
            label18.Text = "Patient's Age ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(34, 600);
            label17.Name = "label17";
            label17.Size = new Size(65, 28);
            label17.TabIndex = 35;
            label17.Text = "Injury";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(34, 684);
            label16.Name = "label16";
            label16.Size = new Size(75, 28);
            label16.TabIndex = 34;
            label16.Text = "Mental";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(34, 762);
            label15.Name = "label15";
            label15.Size = new Size(53, 28);
            label15.TabIndex = 33;
            label15.Text = "Pain";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(34, 855);
            label14.Name = "label14";
            label14.Size = new Size(107, 28);
            label14.TabIndex = 32;
            label14.Text = "Saturation";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(880, 44);
            label13.Name = "label13";
            label13.Size = new Size(113, 28);
            label13.TabIndex = 31;
            label13.Text = "Disposition";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(880, 116);
            label12.Name = "label12";
            label12.Size = new Size(159, 28);
            label12.TabIndex = 30;
            label12.Text = "Patient stay min";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(34, 315);
            label10.Name = "label10";
            label10.Size = new Size(125, 28);
            label10.TabIndex = 28;
            label10.Text = "Patient's Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(880, 193);
            label9.Name = "label9";
            label9.Size = new Size(46, 28);
            label9.TabIndex = 27;
            label9.Text = "SBP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(880, 266);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 26;
            label8.Text = "DBP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(34, 499);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 25;
            label7.Text = "Arrival Mode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(34, 418);
            label6.Name = "label6";
            label6.Size = new Size(232, 28);
            label6.TabIndex = 24;
            label6.Text = "Patients number in hour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(34, 139);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 23;
            label5.Text = "Group";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(34, 59);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 22;
            label4.Text = "Patient Name";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(561, 225);
            label25.Name = "label25";
            label25.Size = new Size(167, 80);
            label25.TabIndex = 43;
            label25.Text = "Young: 0 – < 25 years\r\nAdult: 25 – < 45 years\r\nMid Age: 45 – < 60 years\r\nOld: ≥ 60 years";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label26.ForeColor = SystemColors.ActiveCaptionText;
            label26.Location = new Point(1412, 161);
            label26.Name = "label26";
            label26.Size = new Size(121, 60);
            label26.TabIndex = 44;
            label26.Text = "Low: < 80\r\nNormal: 80 – 120\r\nHigh: > 120\r\n";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label27.ForeColor = SystemColors.ActiveCaptionText;
            label27.Location = new Point(1412, 242);
            label27.Name = "label27";
            label27.Size = new Size(113, 60);
            label27.TabIndex = 45;
            label27.Text = "Low: < 60\r\nNormal: 60 – 80\r\nHigh: > 80";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label28.ForeColor = SystemColors.ActiveCaptionText;
            label28.Location = new Point(1412, 332);
            label28.Name = "label28";
            label28.Size = new Size(121, 60);
            label28.TabIndex = 46;
            label28.Text = "Low: < 45\r\nNormal: 45 – 100\r\nHigh: > 100";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label29.ForeColor = SystemColors.ActiveCaptionText;
            label29.Location = new Point(1412, 409);
            label29.Name = "label29";
            label29.Size = new Size(113, 60);
            label29.TabIndex = 47;
            label29.Text = "Low: < 12\r\nNormal: 12 – 25\r\nHigh: > 25";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label30.ForeColor = SystemColors.ActiveCaptionText;
            label30.Location = new Point(1412, 486);
            label30.Name = "label30";
            label30.Size = new Size(135, 60);
            label30.TabIndex = 48;
            label30.Text = "Low: < 36.4\r\nNormal: 36.4 – 37.6\r\nHigh: > 37.6";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label31.ForeColor = SystemColors.ActiveCaptionText;
            label31.Location = new Point(1412, 565);
            label31.Name = "label31";
            label31.Size = new Size(141, 80);
            label31.TabIndex = 49;
            label31.Text = "Scale: 0 – 10\r\nLow Pain: < 3\r\nModerate Pain: 3 – 7\r\nSevere Pain: > 7";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label32.ForeColor = SystemColors.ActiveCaptionText;
            label32.Location = new Point(1415, 663);
            label32.Name = "label32";
            label32.Size = new Size(194, 100);
            label32.TabIndex = 50;
            label32.Text = "Immediate: < 10 minutes\r\nVery Urgent: 10 – 60 minutes\r\nUrgent: 61 – 120 minutes\r\nStandard: 121 – 240 minutes\r\nNon-Urgent: > 240 minutes";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label33.ForeColor = SystemColors.ActiveCaptionText;
            label33.Location = new Point(1412, 783);
            label33.Name = "label33";
            label33.Size = new Size(194, 100);
            label33.TabIndex = 51;
            label33.Text = "Immediate: < 10 minutes\r\nVery Urgent: 10 – 60 minutes\r\nUrgent: 61 – 120 minutes\r\nStandard: 121 – 240 minutes\r\nNon-Urgent: > 240 minutes";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label41.Location = new Point(1412, 392);
            label41.Name = "label41";
            label41.Size = new Size(113, 17);
            label41.TabIndex = 58;
            label41.Text = "_____________________";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label34.Location = new Point(1412, 221);
            label34.Name = "label34";
            label34.Size = new Size(113, 17);
            label34.TabIndex = 59;
            label34.Text = "_____________________";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label35.Location = new Point(1412, 305);
            label35.Name = "label35";
            label35.Size = new Size(113, 17);
            label35.TabIndex = 60;
            label35.Text = "_____________________";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label36.Location = new Point(1412, 469);
            label36.Name = "label36";
            label36.Size = new Size(113, 17);
            label36.TabIndex = 61;
            label36.Text = "_____________________";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label37.Location = new Point(1412, 546);
            label37.Name = "label37";
            label37.Size = new Size(113, 17);
            label37.TabIndex = 62;
            label37.Text = "_____________________";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label38.Location = new Point(1412, 763);
            label38.Name = "label38";
            label38.Size = new Size(113, 17);
            label38.TabIndex = 63;
            label38.Text = "_____________________";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label39.Location = new Point(1412, 645);
            label39.Name = "label39";
            label39.Size = new Size(113, 17);
            label39.TabIndex = 64;
            label39.Text = "_____________________";
            // 
            // Form1
            // 
            ClientSize = new Size(1920, 1080);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimizeBox = false;
            MinimumSize = new Size(1918, 1018);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Patientsnumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)Saturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)stay_min).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPredict;
        private ComboBox cmbGroup;
        private ComboBox cmbSex;
        private ComboBox cmbArrivalMode;
        private ComboBox cmbInjury;
        private ComboBox cmbMental;
        private ComboBox cmbPain;
        private ComboBox cmbDisposition;
        private ComboBox cmbAge;
        private ComboBox cmbSBP;
        private ComboBox cmbHR;
        private ComboBox cmbDBP;
        private ComboBox cmbRR;
        private ComboBox cmbBT;
        private ComboBox cmbLOS;
        private ComboBox cmbNRS;

        private NumericUpDown Patientsnumber;
        private NumericUpDown Saturation;
        private NumericUpDown stay_min;
        private ComboBox NRS_pain;
        private TextBox pname;
        private Button btnSavePationt;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Button button6;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label41;
        private Label label39;
        private Label label38;
    }
}
