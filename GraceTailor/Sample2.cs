using System;
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
    public partial class Sample2 : Sample
    {
        
        public Sample2()
        {
            InitializeComponent();
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            Main.show(hm, this, MDI.ActiveForm);
        }
    }
}
