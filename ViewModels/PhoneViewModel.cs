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
        private PhoneModel _phone;
        public PhoneModel Phone
        {
            get => _phone;
            private set => SetProperty(ref _phone, value);
        }

        public PhoneViewModel()
        {
            Phone = new PhoneModel("Samsung Galaxy S21 Ultra 5G", "Samsung", 999);
        }
    }
}
