using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clash_of_Clans_Calculator
{
    public partial class Form1 : Form
    {
        private static Calculations calc = new Calculations();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_berechnen_Click(object sender, EventArgs e)
        {
            calc.Start();
        }

    }
}
