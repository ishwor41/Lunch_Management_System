namespace Database_Applcation
{
    partial class Form3
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
            employeeBtn = new Button();
            lunchBtn = new Button();
            setLunch = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // employeeBtn
            // 
            employeeBtn.Location = new Point(98, 90);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(177, 177);
            employeeBtn.TabIndex = 0;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += button1_Click;
            // 
            // lunchBtn
            // 
            lunchBtn.Location = new Point(353, 121);
            lunchBtn.Name = "lunchBtn";
            lunchBtn.Size = new Size(177, 177);
            lunchBtn.TabIndex = 0;
            lunchBtn.Text = "Lunch";
            lunchBtn.UseVisualStyleBackColor = true;
            lunchBtn.Click += button1_Click;
            // 
            // setLunch
            // 
            setLunch.Location = new Point(602, 90);
            setLunch.Name = "setLunch";
            setLunch.Size = new Size(177, 177);
            setLunch.TabIndex = 0;
            setLunch.Text = "Set Lunch";
            setLunch.UseVisualStyleBackColor = true;
            setLunch.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(employeeBtn);
            panel1.Controls.Add(setLunch);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 396);
            panel1.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 450);
            Controls.Add(lunchBtn);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button employeeBtn;
        private Button lunchBtn;
        private Button setLunch;
        private Panel panel1;
    }
}