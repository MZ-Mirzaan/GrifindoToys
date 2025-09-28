namespace GrifindoToys
{
    partial class Login
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
            label1 = new Label();
            txtuser = new TextBox();
            label2 = new Label();
            txtpass = new TextBox();
            btnlogin = new Button();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(80, 144);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(213, 133);
            txtuser.Margin = new Padding(3, 4, 3, 4);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(114, 27);
            txtuser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(80, 204);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(213, 200);
            txtpass.Margin = new Padding(3, 4, 3, 4);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(114, 27);
            txtpass.TabIndex = 3;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(153, 312);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 104;
            btnlogin.Text = "Log in";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cooper Black", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(66, 28);
            label9.Name = "label9";
            label9.Size = new Size(276, 42);
            label9.TabIndex = 103;
            label9.Text = "Grifindo Toys";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(174, 75);
            label10.Name = "label10";
            label10.Size = new Size(63, 28);
            label10.TabIndex = 105;
            label10.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7f117cd8aad06dabf86ae57ddfadc6ce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 447);
            Controls.Add(label10);
            Controls.Add(btnlogin);
            Controls.Add(label9);
            Controls.Add(txtpass);
            Controls.Add(label2);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Label label2;
        private TextBox txtpass;
        private Button btnlogin;
        private Label label9;
        private Label label10;
    }
}