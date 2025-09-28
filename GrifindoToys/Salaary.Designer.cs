
namespace GrifindoToys

{
    partial class Salaary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaary));
            label9 = new Label();
            button6 = new Button();
            groupBox1 = new GroupBox();
            txttaxrate = new TextBox();
            label6 = new Label();
            txtempID = new TextBox();
            txtEmpName = new TextBox();
            txtSalary = new TextBox();
            txtAllowances = new TextBox();
            txtOTRate = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label19 = new Label();
            button1 = new Button();
            Settings = new GroupBox();
            Validate = new Button();
            dtpED = new DateTimePicker();
            dtpSD = new DateTimePicker();
            txtNOL = new TextBox();
            txtDR = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtOA = new TextBox();
            label1 = new Label();
            viewreport = new Button();
            Update = new Button();
            Calculate = new Button();
            txtGrossP = new TextBox();
            label18 = new Label();
            txtOvertime = new TextBox();
            txtBasep = new TextBox();
            txtOT = new TextBox();
            txtNopay = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label7 = new Label();
            txtLT = new TextBox();
            txtabsentD = new TextBox();
            txtHoldiays = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            Settings.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cooper Black", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(276, 42);
            label9.TabIndex = 23;
            label9.Text = "Grifindo Toys";
            label9.Click += label9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(832, 25);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 102;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(txttaxrate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtempID);
            groupBox1.Controls.Add(txtEmpName);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(txtAllowances);
            groupBox1.Controls.Add(txtOTRate);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(29, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(923, 174);
            groupBox1.TabIndex = 103;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txttaxrate
            // 
            txttaxrate.Location = new Point(180, 117);
            txttaxrate.Name = "txttaxrate";
            txttaxrate.Size = new Size(249, 27);
            txttaxrate.TabIndex = 128;
            txttaxrate.TextChanged += txttaxrate_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 120);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 127;
            label6.Text = "Tax Rate";
            // 
            // txtempID
            // 
            txtempID.Location = new Point(180, 42);
            txtempID.Name = "txtempID";
            txtempID.Size = new Size(148, 27);
            txtempID.TabIndex = 80;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(180, 80);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(250, 27);
            txtEmpName.TabIndex = 79;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(660, 35);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(250, 27);
            txtSalary.TabIndex = 78;
            // 
            // txtAllowances
            // 
            txtAllowances.Location = new Point(660, 72);
            txtAllowances.Name = "txtAllowances";
            txtAllowances.Size = new Size(250, 27);
            txtAllowances.TabIndex = 77;
            // 
            // txtOTRate
            // 
            txtOTRate.Location = new Point(660, 109);
            txtOTRate.Name = "txtOTRate";
            txtOTRate.Size = new Size(250, 27);
            txtOTRate.TabIndex = 76;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(492, 116);
            label12.Name = "label12";
            label12.Size = new Size(152, 20);
            label12.TabIndex = 75;
            label12.Text = "Overtime Hourly Rate";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(492, 79);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 74;
            label13.Text = "Allowances";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(492, 42);
            label14.Name = "label14";
            label14.Size = new Size(107, 20);
            label14.TabIndex = 73;
            label14.Text = "Monthly Salary";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 86);
            label16.Name = "label16";
            label16.Size = new Size(119, 20);
            label16.TabIndex = 72;
            label16.Text = "Employee Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 49);
            label19.Name = "label19";
            label19.Size = new Size(94, 20);
            label19.TabIndex = 70;
            label19.Text = "Employee ID";
            // 
            // button1
            // 
            button1.Location = new Point(337, 40);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 69;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Settings
            // 
            Settings.BackColor = Color.LightBlue;
            Settings.Controls.Add(Validate);
            Settings.Controls.Add(dtpED);
            Settings.Controls.Add(dtpSD);
            Settings.Controls.Add(txtNOL);
            Settings.Controls.Add(txtDR);
            Settings.Controls.Add(label5);
            Settings.Controls.Add(label4);
            Settings.Controls.Add(label3);
            Settings.Controls.Add(label2);
            Settings.Location = new Point(27, 253);
            Settings.Name = "Settings";
            Settings.Size = new Size(925, 114);
            Settings.TabIndex = 104;
            Settings.TabStop = false;
            Settings.Text = "Settings";
            Settings.Enter += Settings_Enter;
            // 
            // Validate
            // 
            Validate.Location = new Point(817, 68);
            Validate.Name = "Validate";
            Validate.Size = new Size(94, 29);
            Validate.TabIndex = 81;
            Validate.Text = "Validate";
            Validate.UseVisualStyleBackColor = true;
            Validate.Click += Validate_Click;
            // 
            // dtpED
            // 
            dtpED.Location = new Point(182, 71);
            dtpED.Name = "dtpED";
            dtpED.Size = new Size(250, 27);
            dtpED.TabIndex = 80;
            // 
            // dtpSD
            // 
            dtpSD.Location = new Point(182, 27);
            dtpSD.Name = "dtpSD";
            dtpSD.Size = new Size(250, 27);
            dtpSD.TabIndex = 79;
            // 
            // txtNOL
            // 
            txtNOL.Location = new Point(661, 69);
            txtNOL.Name = "txtNOL";
            txtNOL.Size = new Size(150, 27);
            txtNOL.TabIndex = 78;
            // 
            // txtDR
            // 
            txtDR.Location = new Point(661, 26);
            txtDR.Name = "txtDR";
            txtDR.Size = new Size(250, 27);
            txtDR.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 75);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 76;
            label5.Text = "No. Of Leaves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 33);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 75;
            label4.Text = "Date Range";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 76);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 74;
            label3.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 34);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 73;
            label2.Text = "Start Date";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightBlue;
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(txtOA);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(viewreport);
            groupBox3.Controls.Add(Update);
            groupBox3.Controls.Add(Calculate);
            groupBox3.Controls.Add(txtGrossP);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtOvertime);
            groupBox3.Controls.Add(txtBasep);
            groupBox3.Controls.Add(txtOT);
            groupBox3.Controls.Add(txtNopay);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtLT);
            groupBox3.Controls.Add(txtabsentD);
            groupBox3.Controls.Add(txtHoldiays);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(29, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(923, 235);
            groupBox3.TabIndex = 105;
            groupBox3.TabStop = false;
            groupBox3.Text = "Salary";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtOA
            // 
            txtOA.Location = new Point(189, 169);
            txtOA.Name = "txtOA";
            txtOA.Size = new Size(162, 27);
            txtOA.TabIndex = 126;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 176);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 125;
            label1.Text = "Overall Attendance";
            // 
            // viewreport
            // 
            viewreport.Location = new Point(659, 176);
            viewreport.Name = "viewreport";
            viewreport.Size = new Size(150, 29);
            viewreport.TabIndex = 124;
            viewreport.Text = "View Report";
            viewreport.UseVisualStyleBackColor = true;
            viewreport.Click += viewreport_Click;
            // 
            // Update
            // 
            Update.Location = new Point(492, 176);
            Update.Name = "Update";
            Update.Size = new Size(152, 29);
            Update.TabIndex = 123;
            Update.Text = "Insert to Salary";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click_1;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(359, 84);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(107, 57);
            Calculate.TabIndex = 122;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // txtGrossP
            // 
            txtGrossP.Location = new Point(660, 139);
            txtGrossP.Name = "txtGrossP";
            txtGrossP.Size = new Size(150, 27);
            txtGrossP.TabIndex = 119;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(492, 146);
            label18.Name = "label18";
            label18.Size = new Size(71, 20);
            label18.TabIndex = 118;
            label18.Text = "Gross Pay";
            // 
            // txtOvertime
            // 
            txtOvertime.Location = new Point(659, 64);
            txtOvertime.Name = "txtOvertime";
            txtOvertime.Size = new Size(150, 27);
            txtOvertime.TabIndex = 111;
            // 
            // txtBasep
            // 
            txtBasep.Location = new Point(660, 28);
            txtBasep.Name = "txtBasep";
            txtBasep.Size = new Size(150, 27);
            txtBasep.TabIndex = 117;
            // 
            // txtOT
            // 
            txtOT.Location = new Point(189, 132);
            txtOT.Name = "txtOT";
            txtOT.Size = new Size(162, 27);
            txtOT.TabIndex = 116;
            // 
            // txtNopay
            // 
            txtNopay.Location = new Point(660, 99);
            txtNopay.Name = "txtNopay";
            txtNopay.Size = new Size(150, 27);
            txtNopay.TabIndex = 115;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(492, 106);
            label20.Name = "label20";
            label20.Size = new Size(55, 20);
            label20.TabIndex = 114;
            label20.Text = "No Pay";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(492, 67);
            label21.Name = "label21";
            label21.Size = new Size(74, 20);
            label21.TabIndex = 113;
            label21.Text = "Overtime ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(492, 35);
            label22.Name = "label22";
            label22.Size = new Size(66, 20);
            label22.TabIndex = 112;
            label22.Text = "Base Pay";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 139);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 108;
            label7.Text = "Overtime Hours";
            // 
            // txtLT
            // 
            txtLT.Location = new Point(189, 28);
            txtLT.Name = "txtLT";
            txtLT.Size = new Size(162, 27);
            txtLT.TabIndex = 107;
            // 
            // txtabsentD
            // 
            txtabsentD.Location = new Point(189, 61);
            txtabsentD.Name = "txtabsentD";
            txtabsentD.Size = new Size(162, 27);
            txtabsentD.TabIndex = 106;
            // 
            // txtHoldiays
            // 
            txtHoldiays.Location = new Point(189, 99);
            txtHoldiays.Name = "txtHoldiays";
            txtHoldiays.Size = new Size(162, 27);
            txtHoldiays.TabIndex = 105;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 102);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 104;
            label8.Text = "Holidays Taken";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 64);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 103;
            label10.Text = "Days Absent";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 35);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 102;
            label11.Text = "Leaves Taken";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 127;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Salaary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 620);
            Controls.Add(groupBox3);
            Controls.Add(Settings);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(label9);
            Name = "Salaary";
            Text = "Form1";
            Load += Salaary_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button button6;
        private GroupBox groupBox1;
        private TextBox txtempID;
        private TextBox txtEmpName;
        private TextBox txtSalary;
        private TextBox txtAllowances;
        private TextBox txtOTRate;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label19;
        private Button button1;
        private GroupBox Settings;
        private Button Validate;
        private DateTimePicker dtpED;
        private DateTimePicker dtpSD;
        private TextBox txtNOL;
        private TextBox txtDR;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox txtOvertime;
        private Label label7;
        private TextBox txtLT;
        private TextBox txtabsentD;
        private TextBox txtHoldiays;
        private Label label8;
        private Label label10;
        private Label label11;
        private Button viewreport;
        private Button Update;
        private Button Calculate;
        private TextBox txtGrossP;
        private Label label18;
        private TextBox txtBasep;
        private TextBox txtOT;
        private TextBox txtNopay;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txttaxrate;
        private Label label6;
        private TextBox txtOA;
        private Label label1;
        private RadioButton radioButton1;
    }
}