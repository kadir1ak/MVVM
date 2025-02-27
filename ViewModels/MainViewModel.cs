using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class MainViewModel
    {
        public PeopleViewModel PeopleVM { get; set; }
        public PhoneViewModel PhoneVM { get; set; }

        public MainViewModel()
        {
            PeopleVM = new PeopleViewModel();
            PhoneVM = new PhoneViewModel();
        }
    }
}
