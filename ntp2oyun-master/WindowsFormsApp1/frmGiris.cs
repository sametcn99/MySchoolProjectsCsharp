using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tboxAd.Text != "" && tboxSyd.Text != "")
            {
                MessageBox.Show("Giriş Başarılı");

                frmOyun frmoyn = new frmOyun();
                frmoyn.adSoyad = tboxAd.Text + " " + tboxSyd.Text;
                if (radioKolay.Checked)
                {
                    frmoyn.btnInterval = 70;
                    frmoyn.sure = 50;
                }
                else if (radioOrta.Checked)
                {
                    frmoyn.btnInterval = 100;
                    frmoyn.sure = 30;
                }
                else if (radioZor.Checked)
                {
                    frmoyn.btnInterval = 1000;
                    frmoyn.sure = 10;                    
                }
                frmoyn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad Girin.");
            }
        }
    }
}