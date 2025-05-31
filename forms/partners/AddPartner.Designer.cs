using System.Windows.Forms;

namespace application.forms.partners
{
    partial class AddPartner
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 181);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 186, 128);
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(856, 39);
            button1.Name = "button1";
            button1.Size = new Size(123, 74);
            button1.TabIndex = 2;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(366, 54);
            label1.Name = "label1";
            label1.Size = new Size(256, 59);
            label1.TabIndex = 1;
            label1.Text = "Мастер пол";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 232, 211);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 500);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 186, 128);
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(407, 443);
            button2.Name = "button2";
            button2.Size = new Size(188, 45);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(517, 378);
            label9.Name = "label9";
            label9.Size = new Size(139, 25);
            label9.TabIndex = 15;
            label9.Text = "Место продаж";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(517, 406);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(132, 23);
            comboBox2.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(343, 378);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 13;
            label8.Text = "Тип партнера";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(343, 406);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(343, 310);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 11;
            label6.Text = "Рейтинг";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(343, 338);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(306, 31);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(343, 248);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 9;
            label7.Text = "Почта";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(343, 276);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(306, 31);
            textBox6.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(343, 188);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 7;
            label4.Text = "Телефон";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 216);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 31);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(343, 126);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 5;
            label5.Text = "ИНН";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(343, 154);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(306, 31);
            textBox4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(343, 63);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 3;
            label3.Text = "Адрес";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 91);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(343, 1);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Имя директора";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 31);
            textBox1.TabIndex = 0;
            // 
            // AddPartner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddPartner";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox comboBox2;
        private Button button2;
    }
}