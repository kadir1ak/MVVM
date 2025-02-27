using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Helpers;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class PhoneViewModel : BindableBase
    {
        private PhoneModel[] _phones;
        public PhoneModel[] Phones
        {
            get => _phones;
            private set => SetProperty(ref _phones, value);
        }

        public PhoneViewModel()
        {
            Phones = new PhoneModel[]
            {
                new PhoneModel("Xiaomi Redmi Note 13 Pro", "Xiaomi", 299),
                new PhoneModel("Samsung Galaxy S22", "Samsung", 799),
                new PhoneModel("Apple iPhone 14 Pro Max", "Apple", 1199),
                new PhoneModel("OnePlus 11", "OnePlus", 699),
                new PhoneModel("Google Pixel 7 Pro", "Google", 899),
                new PhoneModel("Huawei P50 Pro", "Huawei", 999),
                new PhoneModel("Sony Xperia 1 IV", "Sony", 1299),
                new PhoneModel("Oppo Find X5 Pro", "Oppo", 1099),
                new PhoneModel("Realme GT 2 Pro", "Realme", 599),
                new PhoneModel("Asus ROG Phone 6", "Asus", 999)
            };
        }
    }
}
