using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessingControls
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void FoodFactsButton_Click(object sender, EventArgs e)
        {

            NutritionFacts nutriform = new NutritionFacts();


            if (BananaRadioButton.Checked)
            {
                nutriform.Labelone.Text = "1 Banana";
                nutriform.labeltwo.Text = "100";
                nutriform.labelthree.Text = "0.4";
                nutriform.labelfour.Text = "27";
            }

            else if (PopcornRadioButton.Checked)
            {
                nutriform.Labelone.Text = "1 cup air-popped popcorn";
                nutriform.labeltwo.Text = "31";
                nutriform.labelthree.Text = "0.4";
                nutriform.labelfour.Text = "6";
            }


            else if (MuffinRadioButton.Checked)
            {
                nutriform.Labelone.Text = "1 large blueberry muffin";
                nutriform.labeltwo.Text = "385";
                nutriform.labelthree.Text = "9";
                nutriform.labelfour.Text = "67";
            }


            // display the nutrition facts and info

            nutriform.ShowDialog();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
