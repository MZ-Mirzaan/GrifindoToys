namespace GrifindoToys
{
    partial class reportveiwer
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
            dgv = new DataGridView();
            Backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 50);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(785, 356);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Backbtn
            // 
            Backbtn.Location = new Point(338, 412);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(94, 29);
            Backbtn.TabIndex = 1;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // reportveiwer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7f117cd8aad06dabf86ae57ddfadc6ce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbtn);
            Controls.Add(dgv);
            Name = "reportveiwer";
            Text = "Form2";
            Load += reportveiwer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Button Backbtn;
    }
}