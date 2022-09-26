using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApplication.Core;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Reflection.Metadata;

namespace TrainingApplication.VIewModel
{
    public class EmployeeViewModel
    {
        private Employee itemSelected;
        public ObservableCollection<Employee> Employees { get; set; }

        public ICommand AddEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Employee ItemSelected
        {
            get { return itemSelected; }
            set { this.itemSelected = value;
                MessageBox.Show(string.Format("The Employee Selected is {0}{1}{2}", this.itemSelected.FirstName, this.itemSelected.LastName, this.itemSelected.Age));
            }
           
        }
        public EmployeeViewModel()
        {
            this.Employees = new ObservableCollection<Employee>();
            //this.AddEmployee = new RelayCommand((par) => {
            //      this.Employees.Add(new Employee(this.FirstName, this.LastName, int.Parse(this.Age)));});
            PopulateStaticData();
        }
         private void PopulateStaticData()
        {
            for(int index =0;index < 1000; index++)
            {
                this.Employees.Add(new Employee("John" + index, "doe" + index, index));
            }

        }
    }
}
