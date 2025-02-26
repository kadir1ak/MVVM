using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Models;
using MVVM.Helpers;

namespace MVVM.ViewModels
{
    public class PeopleViewModel : BindableBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => SetProperty(ref _name, value);
        }

        private string _age;
        public string Age
        {
            get => _age;
            private set => SetProperty(ref _age, value);
        }

        public ICommand Previous { get; init; }
        public ICommand Next { get; init; }

        private PersonModel[] people = new PersonModel[]
        {
            new PersonModel("Alice", 20),
            new PersonModel("Bob", 25),
            new PersonModel("Charlie", 30)
        };

        private int index = 0;

        public PeopleViewModel()
        {
            Name = people[index].Name;
            Age = people[index].Age.ToString();

            Previous = new RelayCommand(() =>
            {
                if (index > 0)
                {
                    index--;
                    Name = people[index].Name;
                    Age = people[index].Age.ToString();
                }
            });

            Next = new RelayCommand(() =>
            {
                if (index < people.Length - 1)
                {
                    index++;
                    Name = people[index].Name;
                    Age = people[index].Age.ToString();
                }
            });
        }
    }
}
