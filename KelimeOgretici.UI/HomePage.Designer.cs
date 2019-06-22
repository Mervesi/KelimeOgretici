namespace KelimeOgretici.UI
{
    partial class HomePage
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
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.txtBoxIng = new System.Windows.Forms.TextBox();
            this.txtBoxTurk = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstIng = new System.Windows.Forms.ListBox();
            this.lstTurk = new System.Windows.Forms.ListBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(87, 124);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTip.TabIndex = 0;
            // 
            // txtBoxIng
            // 
            this.txtBoxIng.Location = new System.Drawing.Point(87, 43);
            this.txtBoxIng.Name = "txtBoxIng";
            this.txtBoxIng.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIng.TabIndex = 1;
            // 
            // txtBoxTurk
            // 
            this.txtBoxTurk.Location = new System.Drawing.Point(87, 84);
            this.txtBoxTurk.Name = "txtBoxTurk";
            this.txtBoxTurk.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTurk.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(87, 167);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İngilizce :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Türkçe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxTurk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxIng);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Location = new System.Drawing.Point(435, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstIng);
            this.groupBox2.Controls.Add(this.lstTurk);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 348);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelimeler";
            // 
            // lstIng
            // 
            this.lstIng.FormattingEnabled = true;
            this.lstIng.Location = new System.Drawing.Point(18, 25);
            this.lstIng.Name = "lstIng";
            this.lstIng.Size = new System.Drawing.Size(138, 303);
            this.lstIng.TabIndex = 0;
            // 
            // lstTurk
            // 
            this.lstTurk.FormattingEnabled = true;
            this.lstTurk.Location = new System.Drawing.Point(178, 25);
            this.lstTurk.Name = "lstTurk";
            this.lstTurk.Size = new System.Drawing.Size(138, 303);
            this.lstTurk.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(381, 30);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(381, 70);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(147, 80);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(80, 33);
            this.btnBasla.TabIndex = 9;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar);
            this.groupBox3.Controls.Add(this.btnBasla);
            this.groupBox3.Location = new System.Drawing.Point(473, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 119);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(23, 29);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(204, 45);
            this.trackBar.TabIndex = 10;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(718, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.TextBox txtBoxIng;
        private System.Windows.Forms.TextBox txtBoxTurk;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstIng;
        private System.Windows.Forms.ListBox lstTurk;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBar;
    }
}