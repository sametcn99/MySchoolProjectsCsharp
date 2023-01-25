namespace WindowsFormsApp1
{
    partial class frmOyun
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
            this.tmr_game = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPuan = new System.Windows.Forms.Panel();
            this.lblAdSyd = new System.Windows.Forms.Label();
            this.tmr_sure = new System.Windows.Forms.Timer(this.components);
            this.pnlPuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_game
            // 
            this.tmr_game.Interval = 10;
            this.tmr_game.Tick += new System.EventHandler(this.tmr_game_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Süre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puan";
            // 
            // pnlPuan
            // 
            this.pnlPuan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlPuan.Controls.Add(this.lblAdSyd);
            this.pnlPuan.Controls.Add(this.label1);
            this.pnlPuan.Controls.Add(this.label2);
            this.pnlPuan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPuan.Location = new System.Drawing.Point(722, 0);
            this.pnlPuan.Name = "pnlPuan";
            this.pnlPuan.Size = new System.Drawing.Size(78, 450);
            this.pnlPuan.TabIndex = 2;
            // 
            // lblAdSyd
            // 
            this.lblAdSyd.AutoSize = true;
            this.lblAdSyd.Location = new System.Drawing.Point(3, 9);
            this.lblAdSyd.Name = "lblAdSyd";
            this.lblAdSyd.Size = new System.Drawing.Size(53, 13);
            this.lblAdSyd.TabIndex = 2;
            this.lblAdSyd.Text = "Ad Soyad";
            // 
            // tmr_sure
            // 
            this.tmr_sure.Interval = 1000;
            this.tmr_sure.Tick += new System.EventHandler(this.tmr_sure_Tick);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPuan);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.pnlPuan.ResumeLayout(false);
            this.pnlPuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_game;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPuan;
        private System.Windows.Forms.Timer tmr_sure;
        private System.Windows.Forms.Label lblAdSyd;
    }
}