using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GraceTailor
{
    class Insertion
    {
        public void insert_customer(Int32 code,string name,Int32 phoneno,int suit,DateTime order,DateTime delivery,decimal amount,decimal advance,decimal balance)
        {
            try
            {
                string query = "insert into CustomerDetails(Code,Name) values('" + code + "','" + name + "','" + phoneno + "','" + suit + "','" + order + "','" + delivery +"','"+amount+"','"+advance+"','"+balance+"')";
                SQLiteCommand cmd = new SQLiteCommand(query, Main.con);
                Main.con.Open();
                cmd.ExecuteNonQuery();
                Main.con.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
