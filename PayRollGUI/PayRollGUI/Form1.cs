using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcMoneyStuff_Click(object sender, EventArgs e)
        {
            double grossPay;
            double federalWithHoldingTax=0.15;
            double stateWithHoldingTax=0.05;
            double netPay;
            double hourlyPay;
            double totalStateTax;
            double totalFederalTax;
            string name;
            int socialSecurity;
            int hoursWorked;
            

            hourlyPay = Convert.ToDouble(tbHourlyPay.Text);
            socialSecurity = Convert.ToInt32(tbSocialSecurity.Text);
            hoursWorked = Convert.ToInt32(tbHoursWorked.Text);
            name = Convert.ToString(tbName.Text);



            grossPay =hourlyPay*hoursWorked;
            totalFederalTax= grossPay*federalWithHoldingTax;
            totalStateTax=grossPay*stateWithHoldingTax;
            netPay=grossPay-(totalFederalTax+totalStateTax);

         
            lblPayroll.Text = String.Format("Name:{0}    |     S.S.NUMBER : {1}   |   Hourly Pay: {2}  |   Hours Worked: {3}  |   Net Pay: {4}  ",name,socialSecurity,hourlyPay,hoursWorked,netPay );



        }
    }
}
