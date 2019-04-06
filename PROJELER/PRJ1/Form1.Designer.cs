namespace PRJ1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandomUret1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsirasayi1 = new System.Windows.Forms.TextBox();
            this.btnEkle1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.btnkucuktobuyuk = new System.Windows.Forms.Button();
            this.btnbuyuktokucuk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(16, 19);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(145, 20);
            this.txtsayi1.TabIndex = 0;
            this.txtsayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsayi1_KeyPress);
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(16, 45);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(145, 20);
            this.txtsayi2.TabIndex = 1;
            this.txtsayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsayi2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(1, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Girilen 2 sayı için\r\n        \"T\" basılınca Toplam\r\n        \"Ç\"  basılınca Çarpı" +
    "m vermesi   \r\n\r\n- Sadece nümerik sayı girilmesi validasyonu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsayi1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsayi2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Kontrol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRandomUret1);
            this.groupBox2.Location = new System.Drawing.Point(229, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Sayı Üret";
            // 
            // btnRandomUret1
            // 
            this.btnRandomUret1.Location = new System.Drawing.Point(21, 20);
            this.btnRandomUret1.Name = "btnRandomUret1";
            this.btnRandomUret1.Size = new System.Drawing.Size(132, 23);
            this.btnRandomUret1.TabIndex = 0;
            this.btnRandomUret1.Text = "TIKLA";
            this.btnRandomUret1.UseVisualStyleBackColor = true;
            this.btnRandomUret1.Click += new System.EventHandler(this.btnRandomUret1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.List2);
            this.groupBox3.Controls.Add(this.List1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnbuyuktokucuk);
            this.groupBox3.Controls.Add(this.btnkucuktobuyuk);
            this.groupBox3.Controls.Add(this.btnEkle1);
            this.groupBox3.Controls.Add(this.txtsirasayi1);
            this.groupBox3.Location = new System.Drawing.Point(402, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 352);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sıralama";
            // 
            // txtsirasayi1
            // 
            this.txtsirasayi1.Location = new System.Drawing.Point(6, 22);
            this.txtsirasayi1.Name = "txtsirasayi1";
            this.txtsirasayi1.Size = new System.Drawing.Size(127, 20);
            this.txtsirasayi1.TabIndex = 0;
            // 
            // btnEkle1
            // 
            this.btnEkle1.Location = new System.Drawing.Point(139, 20);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(75, 23);
            this.btnEkle1.TabIndex = 1;
            this.btnEkle1.Text = "EKLE";
            this.btnEkle1.UseVisualStyleBackColor = true;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "POZİTİFLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NEGATİFLER";
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(10, 83);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(96, 173);
            this.List1.TabIndex = 3;
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.Location = new System.Drawing.Point(117, 83);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(98, 173);
            this.List2.TabIndex = 3;
            // 
            // btnkucuktobuyuk
            // 
            this.btnkucuktobuyuk.Location = new System.Drawing.Point(10, 265);
            this.btnkucuktobuyuk.Name = "btnkucuktobuyuk";
            this.btnkucuktobuyuk.Size = new System.Drawing.Size(204, 23);
            this.btnkucuktobuyuk.TabIndex = 1;
            this.btnkucuktobuyuk.Text = "SIRALA KUCUKTEN BUYUGE";
            this.btnkucuktobuyuk.UseVisualStyleBackColor = true;
            this.btnkucuktobuyuk.Click += new System.EventHandler(this.btnkucuktobuyuk_Click);
            // 
            // btnbuyuktokucuk
            // 
            this.btnbuyuktokucuk.Location = new System.Drawing.Point(6, 294);
            this.btnbuyuktokucuk.Name = "btnbuyuktokucuk";
            this.btnbuyuktokucuk.Size = new System.Drawing.Size(204, 23);
            this.btnbuyuktokucuk.TabIndex = 1;
            this.btnbuyuktokucuk.Text = "SIRALA BUYUKTEN KUCUGE";
            this.btnbuyuktokucuk.UseVisualStyleBackColor = true;
            this.btnbuyuktokucuk.Click += new System.EventHandler(this.btnbuyuktokucuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 576);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandomUret1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkucuktobuyuk;
        private System.Windows.Forms.Button btnEkle1;
        private System.Windows.Forms.TextBox txtsirasayi1;
        private System.Windows.Forms.Button btnbuyuktokucuk;
    }
}

