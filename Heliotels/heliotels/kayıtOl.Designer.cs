using System.Drawing;
using System.Windows.Forms;

namespace heliotels
{
    partial class kayıtOl
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(82, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(300, 50);
            label1.TabIndex = 2;
            label1.Text = "HELİOTELS";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(173, 422);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 35);
            button1.TabIndex = 1;
            button1.Text = "Kayıt Ol";
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(80, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 21);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı TC'si*:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(142, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Şifre*:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(96, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(98, 21);
            label4.TabIndex = 5;
            label4.Text = "Şifre Tekrar*:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(145, 219);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 21);
            label5.TabIndex = 6;
            label5.Text = "İsim*:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(119, 259);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 21);
            label6.TabIndex = 7;
            label6.Text = "Soyisim*:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(126, 299);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 21);
            label7.TabIndex = 8;
            label7.Text = "Cinsiyet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(104, 334);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 21);
            label8.TabIndex = 9;
            label8.Text = "Doğum Yılı:";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(232, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 29);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(232, 131);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new System.Drawing.Size(150, 29);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(232, 171);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new System.Drawing.Size(150, 29);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox4.Location = new System.Drawing.Point(232, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(150, 29);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox5.Location = new System.Drawing.Point(232, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(150, 29);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox6.Location = new System.Drawing.Point(232, 331);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(150, 29);
            textBox6.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBox1.Location = new System.Drawing.Point(232, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Text = "Erkek";
            comboBox1.Size = new System.Drawing.Size(150, 29);
            comboBox1.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(66, 376);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(128, 21);
            label11.TabIndex = 19;
            label11.Text = "Yaşadığınız şehir:";
            // 
            // textBox7
            // 
            textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox7.Location = new System.Drawing.Point(232, 373);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(150, 29);
            textBox7.TabIndex = 20;
            // 
            // kayıtOl
            // 
            ClientSize = new System.Drawing.Size(511, 496);
            this.BackColor = Color.FromArgb(246, 247, 248);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "kayıtOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Label label11;
        private TextBox textBox7;
    }
}