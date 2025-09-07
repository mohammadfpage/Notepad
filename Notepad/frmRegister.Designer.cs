namespace Notepad
{
    partial class frmRegister
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(113, 321);
            button1.Name = "button1";
            button1.Size = new Size(117, 40);
            button1.TabIndex = 9;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 192);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 8;
            label2.Text = "رمز عبور";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 46);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 7;
            label1.Text = "نام کاربری";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 225);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 51);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 51);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(81, 400);
            label3.Name = "label3";
            label3.Size = new Size(193, 20);
            label3.TabIndex = 10;
            label3.Text = "قبلا ثبت نام کردید؟ کلیک کنید";
            label3.Click += label3_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 449);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
    }
}