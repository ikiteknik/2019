namespace ClasslarTekrar
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.lblogrsayi = new System.Windows.Forms.Label();
            this.btnbul = new System.Windows.Forms.Button();
            this.btnsirala = new System.Windows.Forms.Button();
            this.btncarpim = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(89, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMARA";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(89, 61);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 290);
            this.listBox1.TabIndex = 5;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(327, 324);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // lblogrsayi
            // 
            this.lblogrsayi.AutoSize = true;
            this.lblogrsayi.Location = new System.Drawing.Point(154, 253);
            this.lblogrsayi.Name = "lblogrsayi";
            this.lblogrsayi.Size = new System.Drawing.Size(35, 13);
            this.lblogrsayi.TabIndex = 7;
            this.lblogrsayi.Text = "label3";
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(23, 130);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(166, 23);
            this.btnbul.TabIndex = 0;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // btnsirala
            // 
            this.btnsirala.Location = new System.Drawing.Point(23, 160);
            this.btnsirala.Name = "btnsirala";
            this.btnsirala.Size = new System.Drawing.Size(166, 23);
            this.btnsirala.TabIndex = 0;
            this.btnsirala.Text = "SIRALA";
            this.btnsirala.UseVisualStyleBackColor = true;
            this.btnsirala.Click += new System.EventHandler(this.btnsirala_Click);
            // 
            // btncarpim
            // 
            this.btncarpim.Location = new System.Drawing.Point(23, 189);
            this.btncarpim.Name = "btncarpim";
            this.btncarpim.Size = new System.Drawing.Size(166, 23);
            this.btncarpim.TabIndex = 0;
            this.btncarpim.Text = "ÇARPIM TABLO";
            this.btncarpim.UseVisualStyleBackColor = true;
            this.btncarpim.Click += new System.EventHandler(this.btncarpim_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ÇARPMA",
            "BÖLME",
            "TOPLAMA",
            "ÇIKARMA"});
            this.comboBox1.Location = new System.Drawing.Point(506, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(506, 31);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 9;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(506, 58);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 10;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(506, 148);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(121, 23);
            this.btnhesapla.TabIndex = 11;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.Color.Maroon;
            this.lblsonuc.Location = new System.Drawing.Point(539, 112);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 25);
            this.lblsonuc.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 407);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblogrsayi);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btncarpim);
            this.Controls.Add(this.btnsirala);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label lblogrsayi;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.Button btnsirala;
        private System.Windows.Forms.Button btncarpim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lblsonuc;
    }
}

