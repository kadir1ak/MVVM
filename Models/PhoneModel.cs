using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace MVVM.Models
{
    public class PhoneModel
    {
        public string Title { get; set; }

        public string Company { get; set; }

        public double Price { get; set; }

        public PhoneModel(string title, string company, double price)
        {
            Title = title;
            Company = company;
            Price = price;
        }
    }
}
