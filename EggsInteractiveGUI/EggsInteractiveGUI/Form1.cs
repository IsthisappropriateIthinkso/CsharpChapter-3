using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcEggs_Click(object sender, EventArgs e)
        {
            const int DOZEN=12;
            int eggsChicken1;
            int eggsChicken2;
            int eggsChicken3;
            int eggsChicken4;
            int eggsChicken5;
            int dozenEggs;
            int leftOverEggs;
            int totalEggs;

            eggsChicken1 = Convert.ToInt32(tbEggProduced1.Text);
            eggsChicken2 = Convert.ToInt32(tbEggProduced2.Text);
            eggsChicken3 = Convert.ToInt32(tbEggProduced3.Text);
            eggsChicken4 = Convert.ToInt32(tbEggProduced4.Text);
            eggsChicken5 = Convert.ToInt32(tbEggProduced5.Text);

            totalEggs = eggsChicken1 + eggsChicken2 + eggsChicken3 + eggsChicken4 + eggsChicken5;
            dozenEggs = totalEggs / DOZEN;

            leftOverEggs = totalEggs % DOZEN;

            lblTotDozLeft.Text = "total eggs:      " + totalEggs + " dozens: " + dozenEggs+ " Left over "+ leftOverEggs ;

        }
    }
}
