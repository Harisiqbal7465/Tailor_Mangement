using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace GraceTailor
{
    class Main
    {
        //static string query = "Data Source=haseeb\\sqlexpress;Initial Catalog=Grace;Integrated Security=True";
        //public static SqlConnection con = new SqlConnection(query);
        private static string query= "Data Source=GraceDB.db; Version=3; new=False; Compress=True";
        public static SQLiteConnection con = new SQLiteConnection(query);
        public static void show(Form open, Form close, Form MDI)
        {
            close.Close();
            open.MdiParent = MDI;
            open.WindowState = FormWindowState.Maximized;
            open.Show();
        }
        public static void show(Form open, Form MDI)
        {
            open.MdiParent = MDI;
            open.WindowState = FormWindowState.Maximized;
            open.Show();
        }
    }
}
