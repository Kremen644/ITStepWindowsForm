using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Goods
    {
        private string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value == String.Empty ? throw new ArgumentNullException(nameof(Name)) 
                    : value;
            }
        }

        private string _country;
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value == String.Empty ? throw new ArgumentNullException(nameof(Country))
                    : value;
            }
        }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value <= 0 ? throw new ArgumentNullException(nameof(Price))
                    : value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} / Country: {Country} /Price: {Price}";
        }

    }
}
