namespace KP_7
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
            knopka_mashinka = new Button();
            timer_mashinka = new System.Windows.Forms.Timer(components);
            knopka_samoletik_odin = new Button();
            timer_odin_samoletik = new System.Windows.Forms.Timer(components);
            knopka_dva_samoletika = new Button();
            timer_dva_samoletika = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // knopka_mashinka
            // 
            knopka_mashinka.Location = new Point(34, 12);
            knopka_mashinka.Name = "knopka_mashinka";
            knopka_mashinka.Size = new Size(118, 59);
            knopka_mashinka.TabIndex = 0;
            knopka_mashinka.Text = "Машинка";
            knopka_mashinka.UseVisualStyleBackColor = true;
            knopka_mashinka.Click += knopka_mashinka_Click;
            // 
            // timer_mashinka
            // 
            timer_mashinka.Interval = 50;
            timer_mashinka.Tick += timer_mashinka_Tick;
            // 
            // knopka_samoletik_odin
            // 
            knopka_samoletik_odin.Location = new Point(182, 12);
            knopka_samoletik_odin.Name = "knopka_samoletik_odin";
            knopka_samoletik_odin.Size = new Size(118, 59);
            knopka_samoletik_odin.TabIndex = 1;
            knopka_samoletik_odin.Text = "Самолётик";
            knopka_samoletik_odin.UseVisualStyleBackColor = true;
            knopka_samoletik_odin.Click += knopka_samoletik_odin_Click;
            // 
            // timer_odin_samoletik
            // 
            timer_odin_samoletik.Tick += timer_odin_samoletik_Tick;
            // 
            // knopka_dva_samoletika
            // 
            knopka_dva_samoletika.Location = new Point(332, 12);
            knopka_dva_samoletika.Name = "knopka_dva_samoletika";
            knopka_dva_samoletika.Size = new Size(118, 59);
            knopka_dva_samoletika.TabIndex = 2;
            knopka_dva_samoletika.Text = "Два самолётика";
            knopka_dva_samoletika.UseVisualStyleBackColor = true;
            knopka_dva_samoletika.Click += knopka_dva_samoletika_Click;
            // 
            // timer_dva_samoletika
            // 
            timer_dva_samoletika.Tick += timer_dva_samoletika_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(knopka_dva_samoletika);
            Controls.Add(knopka_samoletik_odin);
            Controls.Add(knopka_mashinka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button knopka_mashinka;
        private System.Windows.Forms.Timer timer_mashinka;
        private Button knopka_samoletik_odin;
        private System.Windows.Forms.Timer timer_odin_samoletik;
        private Button knopka_dva_samoletika;
        private System.Windows.Forms.Timer timer_dva_samoletika;
    }
}