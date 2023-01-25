using System;
using System.Windows.Forms;

namespace ntp2final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.buttonsEnable();
            frm1.Show();
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
