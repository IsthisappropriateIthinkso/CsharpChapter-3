using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKiloGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcMilesKilo_Click(object sender, EventArgs e)
        {
            double miles;
            
            double conversionMilesKilos;
            const double CONVERSIONRATE = 1.6;


            miles =Convert.ToInt32(tbMiles.Text);
            


            conversionMilesKilos = miles * CONVERSIONRATE;

           lblMilesToKilos.Text = "Miles to kilometers: "+conversionMilesKilos;



        }
    }
}
