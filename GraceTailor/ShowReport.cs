using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SQLite;
namespace GraceTailor
{
    public partial class ShowReport : Form
    {
        private int check;
        public ShowReport()
        {
            InitializeComponent();
        }
        ReportDocument rd;
        private void ShowReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (Detail.condition == 1)
                {
                    check = Detail.a;
                    string qu = "select * from show_shalwarkameez where code='" + check + "'";
                    SQLiteCommand cmd = new SQLiteCommand(qu, Main.con);
                    SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\Reports\\ShowShalwarKameez.rpt");
                    rd.SetDataSource(dt);
                    crv.ReportSource = rd;
                    crv.Refresh();
                }
                else if (Detail.condition == 2)
                {
                    check = Detail.a;
                    string qu = "select * from show_Wcoat where code='" + check + "'";
                    SQLiteCommand cmd = new SQLiteCommand(qu, Main.con);
                    SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\Reports\\ShowWestCoat.rpt");
                    rd.SetDataSource(dt);
                    crv.ReportSource = rd;
                    crv.Refresh();
                }
                else if (Detail.condition == 3) {
                    check = Detail.a;
                    string qu = "select * from show_coat where code='" + check + "'";
                    SQLiteCommand cmd = new SQLiteCommand(qu, Main.con);
                    SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\Reports\\ShowCoat.rpt");
                    rd.SetDataSource(dt);
                    crv.ReportSource = rd;
                    crv.Refresh();
                }
                else if (Detail.condition == 4) {
                    check = Detail.a;
                    string qu = "select * from show_shirt where code='" + check + "'";
                    SQLiteCommand cmd = new SQLiteCommand(qu, Main.con);
                    SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\Reports\\showShirt.rpt");
                    rd.SetDataSource(dt);
                    crv.ReportSource = rd;
                    crv.Refresh();
                }
                else if (Detail.condition == 5) {
                    check = Detail.a;
                    string qu = "select * from show_pant where code='" + check + "'";
                    SQLiteCommand cmd = new SQLiteCommand(qu, Main.con);
                    SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\Reports\\ShowPant.rpt");
                    rd.SetDataSource(dt);
                    crv.ReportSource = rd;
                    crv.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
