namespace GrifindoToys
{
    partial class Settings
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
            btnUpdate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDR = new TextBox();
            txtNOL = new TextBox();
            dtpSD = new DateTimePicker();
            dtpED = new DateTimePicker();
            btnback = new Button();
            label10 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(75, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(75, 136);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(75, 178);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(75, 220);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 5;
            label4.Text = "Date Range";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(75, 262);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 6;
            label5.Text = "Leaves Per Year";
            // 
            // txtDR
            // 
            txtDR.Location = new Point(194, 214);
            txtDR.Name = "txtDR";
            txtDR.Size = new Size(125, 27);
            txtDR.TabIndex = 9;
            // 
            // txtNOL
            // 
            txtNOL.Location = new Point(194, 255);
            txtNOL.Name = "txtNOL";
            txtNOL.Size = new Size(125, 27);
            txtNOL.TabIndex = 10;
            // 
            // dtpSD
            // 
            dtpSD.Format = DateTimePickerFormat.Short;
            dtpSD.Location = new Point(194, 132);
            dtpSD.Name = "dtpSD";
            dtpSD.Size = new Size(125, 27);
            dtpSD.TabIndex = 11;
            // 
            // dtpED
            // 
            dtpED.Format = DateTimePickerFormat.Short;
            dtpED.Location = new Point(194, 173);
            dtpED.Name = "dtpED";
            dtpED.Size = new Size(125, 27);
            dtpED.TabIndex = 12;
            // 
            // btnback
            // 
            btnback.Location = new Point(213, 306);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 13;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.Location = new Point(131, 64);
            label10.Name = "label10";
            label10.Size = new Size(86, 28);
            label10.TabIndex = 26;
            label10.Text = "Settings";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cooper Black", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(43, 22);
            label9.Name = "label9";
            label9.Size = new Size(276, 42);
            label9.TabIndex = 28;
            label9.Text = "Grifindo Toys";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7f117cd8aad06dabf86ae57ddfadc6ce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 450);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnback);
            Controls.Add(dtpED);
            Controls.Add(dtpSD);
            Controls.Add(txtNOL);
            Controls.Add(txtDR);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Name = "Settings";
            Text = "Form2";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDR;
        private TextBox txtNOL;
        private DateTimePicker dtpSD;
        private DateTimePicker dtpED;
        private Button btnback;
        private Label label10;
        private Label label9;
    }
}