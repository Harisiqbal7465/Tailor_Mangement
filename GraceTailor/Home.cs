using System;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraceTailor
{
    public partial class Home : Sample
    {
        Order or = new Order();
        Detail d = new Detail();
        public Home()
        {
            InitializeComponent();
        }

        private void btnord_Click(object sender, EventArgs e)
        {
            Main.show(or, this, MDI.ActiveForm);
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            Main.show(d,this,MDI.ActiveForm);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
