namespace mole
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lable2 = new Label();
            label1 = new Label();
            Scorelb = new Label();
            Timelb = new Label();
            button2 = new Button();
            Miss = new Button();
            Misslb = new Label();
            label3 = new Label();
            Go = new Label();
            Restart = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.New_Piskel_1_png__1_;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(454, 253);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.BackColor = Color.Transparent;
            lable2.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable2.ForeColor = Color.Black;
            lable2.Location = new Point(12, 9);
            lable2.Name = "lable2";
            lable2.Size = new Size(96, 35);
            lable2.TabIndex = 1;
            lable2.Text = "Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 35);
            label1.TabIndex = 2;
            label1.Text = "Time";
            // 
            // Scorelb
            // 
            Scorelb.AutoSize = true;
            Scorelb.BackColor = Color.Transparent;
            Scorelb.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Scorelb.ForeColor = Color.Black;
            Scorelb.Location = new Point(114, 9);
            Scorelb.Name = "Scorelb";
            Scorelb.Size = new Size(33, 35);
            Scorelb.TabIndex = 3;
            Scorelb.Text = "0";
            // 
            // Timelb
            // 
            Timelb.AutoSize = true;
            Timelb.BackColor = Color.Transparent;
            Timelb.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Timelb.ForeColor = Color.Black;
            Timelb.Location = new Point(114, 56);
            Timelb.Name = "Timelb";
            Timelb.Size = new Size(0, 35);
            Timelb.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(413, 113);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(178, 98);
            button2.TabIndex = 5;
            button2.Text = "Start";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Miss
            // 
            Miss.BackColor = Color.Transparent;
            Miss.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Miss.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Miss.FlatStyle = FlatStyle.Flat;
            Miss.ForeColor = Color.Transparent;
            Miss.Location = new Point(1, 28);
            Miss.Name = "Miss";
            Miss.Size = new Size(1014, 621);
            Miss.TabIndex = 6;
            Miss.UseVisualStyleBackColor = false;
            Miss.Click += Miss_Click;
            // 
            // Misslb
            // 
            Misslb.AutoSize = true;
            Misslb.BackColor = Color.Transparent;
            Misslb.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Misslb.ForeColor = Color.Black;
            Misslb.Location = new Point(962, 9);
            Misslb.Name = "Misslb";
            Misslb.Size = new Size(33, 35);
            Misslb.TabIndex = 8;
            Misslb.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(860, 9);
            label3.Name = "label3";
            label3.Size = new Size(112, 35);
            label3.TabIndex = 7;
            label3.Text = "Misses";
            // 
            // Go
            // 
            Go.AutoSize = true;
            Go.BackColor = Color.Transparent;
            Go.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Go.Location = new Point(194, 84);
            Go.Name = "Go";
            Go.Size = new Size(629, 128);
            Go.TabIndex = 9;
            Go.Text = "GAME OVER";
            // 
            // Restart
            // 
            Restart.BackColor = Color.Transparent;
            Restart.FlatAppearance.BorderSize = 0;
            Restart.FlatAppearance.MouseDownBackColor = Color.Black;
            Restart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Restart.FlatStyle = FlatStyle.Flat;
            Restart.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Restart.ForeColor = Color.Black;
            Restart.Location = new Point(396, 224);
            Restart.Margin = new Padding(0);
            Restart.Name = "Restart";
            Restart.Size = new Size(245, 98);
            Restart.TabIndex = 10;
            Restart.Text = "Restart";
            Restart.TextAlign = ContentAlignment.TopLeft;
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += Restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_510762097_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1012, 620);
            Controls.Add(Restart);
            Controls.Add(Go);
            Controls.Add(Misslb);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(Timelb);
            Controls.Add(Scorelb);
            Controls.Add(label1);
            Controls.Add(lable2);
            Controls.Add(button1);
            Controls.Add(Miss);
            MaximizeBox = false;
            MaximumSize = new Size(1029, 659);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1028, 658);
            Name = "Form1";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lable2;
        private Label label1;
        private Label Scorelb;
        private Label Timelb;
        private Button button2;
        private Button Miss;
        private Label Misslb;
        private Label label3;
        private Label Go;
        private Button Restart;
    }
}
