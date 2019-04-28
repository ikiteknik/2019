namespace Uygulama2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txthobi = new System.Windows.Forms.TextBox();
            this.btnhobiekle = new System.Windows.Forms.Button();
            this.chlistbox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkisikaydet = new System.Windows.Forms.Button();
            this.listboxhobiler = new System.Windows.Forms.ListBox();
            this.btnfiltre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bntyas = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOBİ";
            // 
            // txthobi
            // 
            this.txthobi.Location = new System.Drawing.Point(46, 38);
            this.txthobi.Name = "txthobi";
            this.txthobi.Size = new System.Drawing.Size(100, 20);
            this.txthobi.TabIndex = 1;
            // 
            // btnhobiekle
            // 
            this.btnhobiekle.Location = new System.Drawing.Point(10, 65);
            this.btnhobiekle.Name = "btnhobiekle";
            this.btnhobiekle.Size = new System.Drawing.Size(136, 23);
            this.btnhobiekle.TabIndex = 2;
            this.btnhobiekle.Text = "Hobi Ekle";
            this.btnhobiekle.UseVisualStyleBackColor = true;
            this.btnhobiekle.Click += new System.EventHandler(this.btnhobiekle_Click);
            // 
            // chlistbox
            // 
            this.chlistbox.FormattingEnabled = true;
            this.chlistbox.Location = new System.Drawing.Point(10, 94);
            this.chlistbox.Name = "chlistbox";
            this.chlistbox.Size = new System.Drawing.Size(136, 199);
            this.chlistbox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthobi);
            this.groupBox1.Controls.Add(this.chlistbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnhobiekle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HOBİ LİSTEM";
            // 
            // txtkisi
            // 
            this.txtkisi.Location = new System.Drawing.Point(178, 28);
            this.txtkisi.Name = "txtkisi";
            this.txtkisi.Size = new System.Drawing.Size(121, 20);
            this.txtkisi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AD-SOYAD";
            // 
            // btnkisikaydet
            // 
            this.btnkisikaydet.Location = new System.Drawing.Point(178, 50);
            this.btnkisikaydet.Name = "btnkisikaydet";
            this.btnkisikaydet.Size = new System.Drawing.Size(120, 68);
            this.btnkisikaydet.TabIndex = 7;
            this.btnkisikaydet.Text = "SOLDAN HOBİ SEÇ ve KİŞİYE EKLE";
            this.btnkisikaydet.UseVisualStyleBackColor = true;
            this.btnkisikaydet.Click += new System.EventHandler(this.btnkisikaydet_Click);
            // 
            // listboxhobiler
            // 
            this.listboxhobiler.FormattingEnabled = true;
            this.listboxhobiler.Location = new System.Drawing.Point(331, 28);
            this.listboxhobiler.Name = "listboxhobiler";
            this.listboxhobiler.Size = new System.Drawing.Size(230, 251);
            this.listboxhobiler.TabIndex = 8;
            // 
            // btnfiltre
            // 
            this.btnfiltre.Location = new System.Drawing.Point(331, 285);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(230, 23);
            this.btnfiltre.TabIndex = 9;
            this.btnfiltre.Text = "LİSTEDEN HOBİYE GÖRE FİLTRE YAP";
            this.btnfiltre.UseVisualStyleBackColor = true;
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesap Makinesi Çalıştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntyas);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(581, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yaş";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(19, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // bntyas
            // 
            this.bntyas.Location = new System.Drawing.Point(144, 77);
            this.bntyas.Name = "bntyas";
            this.bntyas.Size = new System.Drawing.Size(75, 23);
            this.bntyas.TabIndex = 2;
            this.bntyas.Text = "Yaş Hesapla";
            this.bntyas.UseVisualStyleBackColor = true;
            this.bntyas.Click += new System.EventHandler(this.bntyas_Click);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltimer.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltimer.Location = new System.Drawing.Point(597, 162);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 31);
            this.lbltimer.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(777, 162);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rb1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(777, 185);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rb2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(777, 208);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Rb3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 430);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.btnfiltre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listboxhobiler);
            this.Controls.Add(this.btnkisikaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkisi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthobi;
        private System.Windows.Forms.Button btnhobiekle;
        private System.Windows.Forms.CheckedListBox chlistbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkisikaydet;
        private System.Windows.Forms.ListBox listboxhobiler;
        private System.Windows.Forms.Button btnfiltre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntyas;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

