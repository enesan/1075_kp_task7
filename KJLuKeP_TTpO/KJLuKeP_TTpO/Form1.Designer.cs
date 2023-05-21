namespace KJLuKeP_TTpO
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(477, 248);
            button1.Name = "button1";
            button1.Size = new Size(210, 109);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(892, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 45);
            label1.TabIndex = 1;
            label1.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1010, 24);
            label2.Name = "label2";
            label2.Size = new Size(38, 45);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(692, 69);
            label3.Name = "label3";
            label3.Size = new Size(312, 45);
            label3.TabIndex = 3;
            label3.Text = "Пассивный доход:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1010, 69);
            label4.Name = "label4";
            label4.Size = new Size(38, 45);
            label4.TabIndex = 4;
            label4.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(948, 165);
            button2.Name = "button2";
            button2.Size = new Size(93, 57);
            button2.TabIndex = 5;
            button2.Text = "Купить бабушку 20";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1047, 165);
            button3.Name = "button3";
            button3.Size = new Size(93, 57);
            button3.TabIndex = 6;
            button3.Text = "Купить ферму 100";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(948, 228);
            button4.Name = "button4";
            button4.Size = new Size(93, 57);
            button4.TabIndex = 7;
            button4.Text = "Купить завод 500";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1047, 228);
            button5.Name = "button5";
            button5.Size = new Size(93, 57);
            button5.TabIndex = 8;
            button5.Text = "Купить офис 2500";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(993, 291);
            button6.Name = "button6";
            button6.Size = new Size(110, 72);
            button6.TabIndex = 9;
            button6.Text = "Увеличить доход с кликов      250*сила клика";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(830, 388);
            label5.Name = "label5";
            label5.Size = new Size(227, 25);
            label5.TabIndex = 10;
            label5.Text = "Текущий доход с кликов:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1063, 388);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 11;
            label6.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 535);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label5;
        private Label label6;
    }
}