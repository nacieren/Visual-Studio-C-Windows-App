using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Drawing;

namespace heliotels
{
    partial class oteller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oteller));
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 205);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 6;
            label7.Text = "Hilton Dalaman";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 233);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 7;
            label8.Text = "Konum: Dalaman";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 249);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 8;
            label9.Text = "Kapasite 10000 kişi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(61, 264);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 9;
            label10.Text = "Puan: 4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(61, 279);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 10;
            label11.Text = "Fiyat: 9500 TL";
            // 
            // button1
            // 
            button1.Location = new Point(202, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Kirala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(365, 205);
            label13.Name = "label13";
            label13.Size = new Size(26, 15);
            label13.TabIndex = 13;
            label13.Text = "Jiva";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(365, 233);
            label14.Name = "label14";
            label14.Size = new Size(90, 15);
            label14.TabIndex = 14;
            label14.Text = "Konum: Fethiye";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(365, 249);
            label15.Name = "label15";
            label15.Size = new Size(101, 15);
            label15.TabIndex = 15;
            label15.Text = "Kapasite: 6000 kişi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(365, 264);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 16;
            label16.Text = "Puan: 4.2";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(365, 279);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 17;
            label17.Text = "Fiyat: 6000 TL";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(669, 205);
            label19.Name = "label19";
            label19.Size = new Size(48, 15);
            label19.TabIndex = 19;
            label19.Text = "SunCity";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(669, 233);
            label20.Name = "label20";
            label20.Size = new Size(99, 15);
            label20.TabIndex = 20;
            label20.Text = "Konum: Ölüdeniz";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(669, 249);
            label21.Name = "label21";
            label21.Size = new Size(101, 15);
            label21.TabIndex = 21;
            label21.Text = "Kapasite: 7000 kişi";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(669, 264);
            label22.Name = "label22";
            label22.Size = new Size(55, 15);
            label22.TabIndex = 22;
            label22.Text = "Puan: 4.5";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(669, 279);
            label23.Name = "label23";
            label23.Size = new Size(77, 15);
            label23.TabIndex = 23;
            label23.Text = "Fiyat: 5500 TL";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(61, 532);
            label25.Name = "label25";
            label25.Size = new Size(78, 15);
            label25.TabIndex = 25;
            label25.Text = "Aqua Fantasy";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(61, 560);
            label26.Name = "label26";
            label26.Size = new Size(92, 15);
            label26.TabIndex = 26;
            label26.Text = "Konum: Antalya";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(61, 574);
            label27.Name = "label27";
            label27.Size = new Size(101, 15);
            label27.TabIndex = 27;
            label27.Text = "Kapasite: 5500 kişi";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(61, 589);
            label28.Name = "label28";
            label28.Size = new Size(55, 15);
            label28.TabIndex = 28;
            label28.Text = "Puan: 4.6";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(61, 604);
            label29.Name = "label29";
            label29.Size = new Size(77, 15);
            label29.TabIndex = 29;
            label29.Text = "Fiyat: 8500 TL";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(365, 532);
            label31.Name = "label31";
            label31.Size = new Size(62, 15);
            label31.TabIndex = 31;
            label31.Text = "Richmond";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(365, 560);
            label32.Name = "label32";
            label32.Size = new Size(101, 15);
            label32.TabIndex = 32;
            label32.Text = "Konum: Pamucak";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(365, 574);
            label33.Name = "label33";
            label33.Size = new Size(107, 15);
            label33.TabIndex = 33;
            label33.Text = "Kapasite: 12000 kişi";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(365, 589);
            label34.Name = "label34";
            label34.Size = new Size(55, 15);
            label34.TabIndex = 34;
            label34.Text = "Puan: 3.9";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(365, 604);
            label35.Name = "label35";
            label35.Size = new Size(77, 15);
            label35.TabIndex = 35;
            label35.Text = "Fiyat: 5000 TL";
            // 
            // button2
            // 
            button2.Location = new Point(506, 271);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 37;
            button2.Text = "Kirala";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(809, 275);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 38;
            button3.Text = "Kirala";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(202, 581);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 39;
            button4.Text = "Kirala";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(506, 585);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 40;
            button5.Text = "Kirala";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(809, 585);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 41;
            button6.Text = "Kirala";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(669, 532);
            label37.Name = "label37";
            label37.Size = new Size(28, 15);
            label37.TabIndex = 42;
            label37.Text = "Ilıca";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(669, 559);
            label38.Name = "label38";
            label38.Size = new Size(88, 15);
            label38.TabIndex = 43;
            label38.Text = "Konum: Çeşme";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(669, 574);
            label39.Name = "label39";
            label39.Size = new Size(101, 15);
            label39.TabIndex = 44;
            label39.Text = "Kapasite: 2500 kişi";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(669, 589);
            label40.Name = "label40";
            label40.Size = new Size(55, 15);
            label40.TabIndex = 45;
            label40.Text = "Puan: 4.9";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(669, 604);
            label41.Name = "label41";
            label41.Size = new Size(46, 15);
            label41.TabIndex = 46;
            label41.Text = "5700 TL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(365, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(668, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 145);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(61, 350);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(216, 145);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(365, 350);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(216, 145);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 51;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(669, 350);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(216, 145);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            // 
            // oteller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 653);
            this.BackColor = Color.FromArgb(246, 247, 248);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label41);
            Controls.Add(label40);
            Controls.Add(label39);
            Controls.Add(label38);
            Controls.Add(label37);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "oteller";
            Text = "oteller";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}