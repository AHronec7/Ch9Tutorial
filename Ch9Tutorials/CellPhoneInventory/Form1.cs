using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhoneInventory
{
    public partial class Form1 : Form
    {
        List<CellPhoneInventory> phoneList = new List<CellPhoneInventory>();
        public Form1()

        {
            InitializeComponent();
        }

        private void getdata(CellPhoneInventory phone)
        {
            // declare a decimal

            decimal price;

            // get the phones brand

            phone.Brand = BrandTextBox.Text;

            // get the phones model

            phone.Model = ModelTextBox.Text;

            // get the phones price 


            if (decimal.TryParse(PriceTextBox.Text, out price))
            {
                phone.Price = price;
            }

            else
            {
                MessageBox.Show("Invalid Price");
            }






        }

        private void AddPhoneButton_Click(object sender, EventArgs e)
        {
            // create a cellphone object

            CellPhoneInventory myphone = new CellPhoneInventory();

            // get the phone data

            getdata(myphone);

            //Add the cell phone object to the list

            phoneList.Add(myphone);

            // add the entry to the list box

            PhoneListBox.Items.Add(myphone.Brand + " " + myphone.Model);

            // clear the contents of the textbox

            BrandTextBox.Clear();
            ModelTextBox.Clear();
            PriceTextBox.Clear();

            BrandTextBox.Focus();
        }

        private void PhoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ge the index of the selected item

            int index = PhoneListBox.SelectedIndex;

            // display the selected items price

            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }


    }
}
    




