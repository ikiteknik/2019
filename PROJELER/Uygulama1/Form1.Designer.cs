namespace Uygulama1
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
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbyirmi = new System.Windows.Forms.RadioButton();
            this.rbotuz = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbindirim = new System.Windows.Forms.CheckBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(75, 16);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(146, 20);
            this.txtfiyat.TabIndex = 0;
            this.txtfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiyat_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // rbyirmi
            // 
            this.rbyirmi.AutoSize = true;
            this.rbyirmi.Location = new System.Drawing.Point(24, 92);
            this.rbyirmi.Name = "rbyirmi";
            this.rbyirmi.Size = new System.Drawing.Size(45, 17);
            this.rbyirmi.TabIndex = 2;
            this.rbyirmi.TabStop = true;
            this.rbyirmi.Text = "%20";
            this.rbyirmi.UseVisualStyleBackColor = true;
            // 
            // rbotuz
            // 
            this.rbotuz.AutoSize = true;
            this.rbotuz.Location = new System.Drawing.Point(84, 92);
            this.rbotuz.Name = "rbotuz";
            this.rbotuz.Size = new System.Drawing.Size(45, 17);
            this.rbotuz.TabIndex = 3;
            this.rbotuz.TabStop = true;
            this.rbotuz.Text = "%30";
            this.rbotuz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İndirim Oranları";
            // 
            // cbindirim
            // 
            this.cbindirim.AutoSize = true;
            this.cbindirim.Location = new System.Drawing.Point(24, 115);
            this.cbindirim.Name = "cbindirim";
            this.cbindirim.Size = new System.Drawing.Size(92, 17);
            this.cbindirim.TabIndex = 5;
            this.cbindirim.Text = "İndirim Uygula";
            this.cbindirim.UseVisualStyleBackColor = true;
            this.cbindirim.CheckedChanged += new System.EventHandler(this.cbindirim_CheckedChanged);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(24, 157);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(105, 23);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Ürün Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(227, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 160);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 253);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cbindirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbotuz);
            this.Controls.Add(this.rbyirmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbyirmi;
        private System.Windows.Forms.RadioButton rbotuz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbindirim;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ListBox listBox1;
    }
}

