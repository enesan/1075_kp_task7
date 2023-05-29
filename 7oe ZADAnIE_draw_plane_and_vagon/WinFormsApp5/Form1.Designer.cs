namespace WinFormsApp5
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            timer6 = new System.Windows.Forms.Timer(components);
            timer7 = new System.Windows.Forms.Timer(components);
            timer8 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 318);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 0;
            button1.Text = "Vagon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(48, 368);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 1;
            button2.Text = "стоп Vagon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(278, 318);
            button3.Name = "button3";
            button3.Size = new Size(205, 44);
            button3.TabIndex = 2;
            button3.Text = "Очистить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(610, 318);
            button4.Name = "button4";
            button4.Size = new Size(113, 44);
            button4.TabIndex = 3;
            button4.Text = "Самолёт";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timer6
            // 
            timer6.Tick += timer6_Tick;
            // 
            // timer7
            // 
            timer7.Tick += timer7_Tick;
            // 
            // timer8
            // 
            timer8.Tick += timer8_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
    }
}