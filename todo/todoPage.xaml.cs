using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace todo
{
    public partial class todoPage : ContentPage
    {
        public todoPage()
        {
            InitializeComponent();

            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }
    }
}
