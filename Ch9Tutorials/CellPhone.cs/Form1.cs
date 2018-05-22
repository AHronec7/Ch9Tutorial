using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Getcellphonedata(CellPhoneData phone)
        {
            // temporary decimal to hold the price
            
            decimal price;

            // get the phone brand

            phone.Brand = BrandTextBox.Text;

            // get the phone model

            phone.Model = ModelTextBox.Text;

            // get the phone price

            if (decimal.TryParse(PriceTextBox.Text, out price))
            {
                phone.Price = price;
            }

            else
            {
                MessageBox.Show("Not the right price");
            }



        }

        private void CreateDataButton_Click(object sender, EventArgs e)
        {
            // create the cell phone object

            CellPhoneData myphone = new CellPhoneData();

            // get the phone data

            Getcellphonedata(myphone);


            // display the phone data

            OutputBrandBox.Text = myphone.Brand;
            OutputModelBox.Text = myphone.Model;
            OutputPriceBox.Text = myphone.Price.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

