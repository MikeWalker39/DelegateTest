using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();            
        }

        public delegate void TurnMommyGreenDelegate(object sender, EventArgs e);

        public event TurnMommyGreenDelegate Greening;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Greening != null)
            {
                Greening(this, e);
            }
        }
    }
}
