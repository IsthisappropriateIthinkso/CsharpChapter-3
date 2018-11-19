using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
    public partial class FrmMadLibs : Form
    {
        public FrmMadLibs()
        {
            InitializeComponent();
        }

        private void btnMakeMadLibsStory_Click(object sender, EventArgs e)
        {
            string color;
            string wordEst;
            string bodyPartMultiple;
            string animal;
            string aNoun;
            string pluralNoun;
            int firstNum;
            int secondNum;
            int integerC;


            color = Convert.ToString(tbColor.Text);
            wordEst = Convert.ToString(tbWordEst.Text);
            firstNum = Convert.ToInt32(tbFirstNum.Text);
            secondNum = Convert.ToInt32(tbSecondNum.Text);

            bodyPartMultiple = Convert.ToString(tbBodyPartPlural.Text);
            animal = Convert.ToString(tbAnimal.Text);
            aNoun = Convert.ToString(tbNoun.Text);
            pluralNoun = Convert.ToString(tbPluralNoun.Text);

            integerC = firstNum - secondNum;

            lblMadLibsNewStory.Text = String.Format("the ({0}) Dragon is the ( {1} ) Dragon of all. It has ({2}) ({3}), and a ({4}) shaped like a  ({5}). It loves to eat({6}), " +
                "although it will feast on nearly anything" + "", color, wordEst, integerC, bodyPartMultiple, animal, aNoun, pluralNoun);
                
        }
    }
}
