using System.Drawing.Text;

namespace BOOSEapp
{
    partial class BooseApp
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(267, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = false;
            button1.Click += RunButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 332);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Location = new Point(339, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 332);
            panel1.TabIndex = 2;
            // 
            // BooseApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "BooseApp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
    }
}
