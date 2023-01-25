
namespace WindowsFormsApp1
{
    partial class frmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.tboxSyd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioKolay = new System.Windows.Forms.RadioButton();
            this.radioOrta = new System.Windows.Forms.RadioButton();
            this.radioZor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // tboxAd
            // 
            this.tboxAd.Location = new System.Drawing.Point(329, 117);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(165, 20);
            this.tboxAd.TabIndex = 2;
            // 
            // tboxSyd
            // 
            this.tboxSyd.Location = new System.Drawing.Point(330, 151);
            this.tboxSyd.Name = "tboxSyd";
            this.tboxSyd.Size = new System.Drawing.Size(164, 20);
            this.tboxSyd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oyuna Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioKolay
            // 
            this.radioKolay.AutoSize = true;
            this.radioKolay.Location = new System.Drawing.Point(350, 193);
            this.radioKolay.Name = "radioKolay";
            this.radioKolay.Size = new System.Drawing.Size(50, 17);
            this.radioKolay.TabIndex = 8;
            this.radioKolay.TabStop = true;
            this.radioKolay.Text = "kolay";
            this.radioKolay.UseVisualStyleBackColor = true;
            // 
            // radioOrta
            // 
            this.radioOrta.AutoSize = true;
            this.radioOrta.Location = new System.Drawing.Point(406, 193);
            this.radioOrta.Name = "radioOrta";
            this.radioOrta.Size = new System.Drawing.Size(43, 17);
            this.radioOrta.TabIndex = 9;
            this.radioOrta.TabStop = true;
            this.radioOrta.Text = "orta";
            this.radioOrta.UseVisualStyleBackColor = true;
            // 
            // radioZor
            // 
            this.radioZor.AutoSize = true;
            this.radioZor.Location = new System.Drawing.Point(455, 193);
            this.radioZor.Name = "radioZor";
            this.radioZor.Size = new System.Drawing.Size(39, 17);
            this.radioZor.TabIndex = 10;
            this.radioZor.TabStop = true;
            this.radioZor.Text = "zor";
            this.radioZor.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioZor);
            this.Controls.Add(this.radioOrta);
            this.Controls.Add(this.radioKolay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxSyd);
            this.Controls.Add(this.tboxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.TextBox tboxSyd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioKolay;
        private System.Windows.Forms.RadioButton radioOrta;
        private System.Windows.Forms.RadioButton radioZor;
    }
}