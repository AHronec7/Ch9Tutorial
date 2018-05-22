using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneInventory
{
    class CellPhoneInventory
    {
        //Fields 

        private string _brand;
        private string _model;
        private decimal _price;

        // constructor

        public CellPhoneInventory()
        {
            _brand = "";
            _model = "";
            _price = 0;
        }

        // brand properties

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // model properties

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // price property 

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
