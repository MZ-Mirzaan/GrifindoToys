namespace GrifindoToys
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnemp = new Button();
            btnsal = new Button();
            btnset = new Button();
            label3 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(82, 106);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(289, 106);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(499, 106);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnemp
            // 
            btnemp.Location = new Point(107, 217);
            btnemp.Margin = new Padding(3, 2, 3, 2);
            btnemp.Name = "btnemp";
            btnemp.Size = new Size(82, 22);
            btnemp.TabIndex = 3;
            btnemp.Text = "Employees";
            btnemp.UseVisualStyleBackColor = true;
            btnemp.Click += button1_Click;
            // 
            // btnsal
            // 
            btnsal.Location = new Point(300, 217);
            btnsal.Margin = new Padding(3, 2, 3, 2);
            btnsal.Name = "btnsal";
            btnsal.Size = new Size(82, 22);
            btnsal.TabIndex = 4;
            btnsal.Text = "Salary";
            btnsal.UseVisualStyleBackColor = true;
            btnsal.Click += button2_Click;
            // 
            // btnset
            // 
            btnset.Location = new Point(512, 217);
            btnset.Margin = new Padding(3, 2, 3, 2);
            btnset.Name = "btnset";
            btnset.Size = new Size(82, 22);
            btnset.TabIndex = 5;
            btnset.Text = "Settings";
            btnset.UseVisualStyleBackColor = true;
            btnset.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 64);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 9;
            label3.Text = "Menu";
            label3.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cooper Black", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(220, 21);
            label9.Name = "label9";
            label9.Size = new Size(228, 35);
            label9.TabIndex = 28;
            label9.Text = "Grifindo Toys";
            label9.Click += label9_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7f117cd8aad06dabf86ae57ddfadc6ce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(btnset);
            Controls.Add(btnsal);
            Controls.Add(btnemp);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnemp;
        private Button btnsal;
        private Button btnset;
        private Label label3;
        private Label label9;
    }
}