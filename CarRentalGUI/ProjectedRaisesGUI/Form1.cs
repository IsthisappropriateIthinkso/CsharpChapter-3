using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRentFee_Click(object sender, EventArgs e)
        {
            int days;
            double miles;
            const int BucksPerDays = 20;
            const double DrivenCentsPerMile=.25;

            double totalRentalFee;
            


            days = Convert.ToInt32(tbDays.Text);
            miles = Convert.ToInt32(tbMiles.Text);

           

            totalRentalFee = (days*BucksPerDays)+(DrivenCentsPerMile *miles);

            lblTotalRentFee.Text = String.Format("{0}", totalRentalFee.ToString("C2"));

        }
    }
}
