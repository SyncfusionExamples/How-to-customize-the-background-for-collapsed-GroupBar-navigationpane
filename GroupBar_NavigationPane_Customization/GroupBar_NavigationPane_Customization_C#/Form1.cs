using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupbartest
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBar1_MouseClick(object sender, MouseEventArgs e)
        {
            Office2007BlueColors.Default.FloatHighlightButtonColor = Color.Pink;
        }
    }
}
