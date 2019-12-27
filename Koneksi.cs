using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Aplikasi_Kasir
{
    class Koneksi
    {
        public OleDbConnection con = null;
        public Koneksi()
        {
            inikoneksi();
        }
        public void inikoneksi()
        {
            string kon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ali\Aplikasi Destop\Aplikasi Kasir\bin\Debug\Database\db_penjualan.accdb";
            con = new OleDbConnection(kon);
        }

        public void Op()
        {
            try
            {
                con.Open();
            }
            catch(OleDbException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //close
        public void Cls()
        {
            try
            {
                con.Close();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}
