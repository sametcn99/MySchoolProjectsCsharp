using DAL;
using MODEL;
using System;
using System.Data.SqlClient;

namespace BLL
{
    public class EmlakciBL
    {
        public bool semtEkle(Semtler smt)
        {
            if (smt == null)
            {
                throw new NullReferenceException("Semt Eklerken Nesne Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Insert into Semtler (SemtAdi, Ilce) values ('{smt.SemtAdi}', '{smt.Ilce}')");
                return sonuc > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Ilanlar ilanBul(string ilanno)
        {
            Ilanlar iln = new Ilanlar();
            if (iln == null)
            {
                throw new NullReferenceException("Semt Eklerken Nesne Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                SqlDataReader dr = hlp.ExecuteReader($"Select * from Ilanlar where IlanNo = '{iln.IlanNo}'");
                if (dr.Read())
                {
                    iln.IlanId = (int)dr["IlanId"];
                    iln.IlanNo = (string)dr["IlanNo"];
                    iln.OdaSayisi = (string)dr["OdaSayisi"];
                    iln.KatNo = (string)dr["KatNo"];
                    iln.Alan = (string)dr["Alan"];
                }
                dr.Close();

                return iln;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
