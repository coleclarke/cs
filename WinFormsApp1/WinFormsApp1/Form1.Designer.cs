namespace WinFormsApp1
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
            LogBtn = new Button();
            UserBox = new TextBox();
            PassBox = new TextBox();
            lblSucsess = new Label();
            SuspendLayout();
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(307, 228);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(172, 33);
            LogBtn.TabIndex = 0;
            LogBtn.Text = "Log In";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click_1;
            // 
            // UserBox
            // 
            UserBox.BackColor = SystemColors.Window;
            UserBox.ForeColor = SystemColors.WindowText;
            UserBox.Location = new Point(307, 111);
            UserBox.Name = "UserBox";
            UserBox.PlaceholderText = "Username";
            UserBox.Size = new Size(172, 23);
            UserBox.TabIndex = 1;
            UserBox.TabStop = false;
            UserBox.TextChanged += UserBox_TextChanged;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(307, 155);
            PassBox.Name = "PassBox";
            PassBox.PlaceholderText = "Password";
            PassBox.Size = new Size(172, 23);
            PassBox.TabIndex = 2;
            // 
            // lblSucsess
            // 
            lblSucsess.AutoSize = true;
            lblSucsess.Font = new Font("Segoe UI", 30F);
            lblSucsess.ForeColor = Color.DarkSeaGreen;
            lblSucsess.Location = new Point(236, 24);
            lblSucsess.Name = "lblSucsess";
            lblSucsess.Size = new Size(0, 54);
            lblSucsess.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSucsess);
            Controls.Add(PassBox);
            Controls.Add(UserBox);
            Controls.Add(LogBtn);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogBtn;
        private TextBox UserBox;
        private TextBox PassBox;
        private Label lblSucsess;
    }
}
