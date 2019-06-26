namespace KelimeOgretici.UI
{
    partial class PopUpWin
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
            this.lblIng = new System.Windows.Forms.Label();
            this.lblTurk = new System.Windows.Forms.Label();
            this.btnCevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIng.Location = new System.Drawing.Point(91, 19);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(41, 31);
            this.lblIng.TabIndex = 0;
            this.lblIng.Text = "lbl";
            // 
            // lblTurk
            // 
            this.lblTurk.AutoSize = true;
            this.lblTurk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurk.Location = new System.Drawing.Point(91, 88);
            this.lblTurk.Name = "lblTurk";
            this.lblTurk.Size = new System.Drawing.Size(41, 31);
            this.lblTurk.TabIndex = 0;
            this.lblTurk.Text = "lbl";
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(57, 139);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(126, 36);
            this.btnCevir.TabIndex = 1;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // PopUpWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(265, 215);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.lblTurk);
            this.Controls.Add(this.lblIng);
            this.Name = "PopUpWin";
            this.Text = "PopUpWin";
            this.Load += new System.EventHandler(this.PopUpWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Label lblTurk;
        private System.Windows.Forms.Button btnCevir;
    }
}