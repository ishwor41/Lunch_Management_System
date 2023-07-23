namespace Database_Applcation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            userNameTextBox = new TextBox();
            passTextBox = new TextBox();
            confirmPassTextBox = new TextBox();
            registerButton = new Button();
            passValidation = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 46);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 155);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 219);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(279, 43);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 4;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(279, 96);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(125, 27);
            userNameTextBox.TabIndex = 5;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(279, 152);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(125, 27);
            passTextBox.TabIndex = 6;
            passTextBox.TextChanged += passTextBox_TextChanged;
            // 
            // confirmPassTextBox
            // 
            confirmPassTextBox.Location = new Point(279, 216);
            confirmPassTextBox.Name = "confirmPassTextBox";
            confirmPassTextBox.Size = new Size(125, 27);
            confirmPassTextBox.TabIndex = 7;
            confirmPassTextBox.TextChanged += confirmPassTextBox_TextChanged;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(261, 284);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passValidation
            // 
            passValidation.AutoSize = true;
            passValidation.Location = new Point(279, 189);
            passValidation.Name = "passValidation";
            passValidation.Size = new Size(0, 20);
            passValidation.TabIndex = 9;
            passValidation.Click += passValidation_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passValidation);
            Controls.Add(registerButton);
            Controls.Add(confirmPassTextBox);
            Controls.Add(passTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox userNameTextBox;
        private TextBox passTextBox;
        private TextBox confirmPassTextBox;
        private Button registerButton;
        private Label passValidation;
    }
}