using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9Tutorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TossCoinButton_Click(object sender, EventArgs e)
        {
            // create an object

            Coin mycoin = new Coin();

            // clear the listbox

            CoinListBox.Items.Clear();

            // toss the coin 5 times

            for(int count = 0; count < 5; count++)
            {
                // toss the coin 

                mycoin.Toss();

                // display the side that is up

                CoinListBox.Items.Add(mycoin.getsideup());
            }
        }
    }
}
