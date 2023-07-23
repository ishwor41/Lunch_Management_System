namespace Database_Applcation
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
            label1 = new Label();
            label2 = new Label();
            usernameTxtBox = new TextBox();
            passwordTextBox = new TextBox();
            label3 = new Label();
            loginBtn = new Button();
            registerBtn = new Button();
            connectBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 62);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 117);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(224, 59);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(125, 27);
            usernameTxtBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(224, 110);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(255, 193);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(255, 255);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 29);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(12, 22);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(94, 29);
            connectBtn.TabIndex = 7;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connectBtn);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxtBox;
        private TextBox passwordTextBox;
        private Label label3;
        private Button loginBtn;
        private Button registerBtn;
        private Button connectBtn;
    }
}