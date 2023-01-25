using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ntp2final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmlakciBL ebl = new EmlakciBL();
            try
            {
                MessageBox.Show(ebl.semtEkle(new Semtler { SemtAdi = txtSemtAdi.Text.Trim(), Ilce = txtIlce.Text.Trim() }) ? "ekleme başarılı" : "ekleme başarısız");
            }
            catch (SqlException)
            {
                MessageBox.Show("veritabanı hatası");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("bilinmeyen hata" + ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection cn = null;
            if (cn != null)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand($"Select Semtid, SemtAdi from Semtler", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                var lst = new List<Semtler>();
                while (dr.Read())
                {
                    var smt = new Semtler();
                    smt.Semtid = Convert.ToInt32(dr["Semtid"]);
                    smt.SemtAdi = (string)dr["SemtAdi"];
                    lst.Add(smt);
                }
                Form1 frm1 = new Form1();
                frm1.cmbSemtler.DisplayMember = "Semtid";
                frm1.cmbSemtler.ValueMember = "SemtAdi";
                frm1.cmbSemtler.DataSource = lst;
                dr.Close();
                //frm1.Show();
            }
        }
    }
}
