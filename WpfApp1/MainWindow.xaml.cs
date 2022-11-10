using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> person;
        public MainWindow()
        {
            InitializeComponent();
            person = new ObservableCollection<Person>()
         {
             new Person(){Name="Prabhat",Address="India"},

             new Person(){Name="Smith",Address="US"}
         };
            lstNames.ItemsSource = person;
        }
        private void btnNames_Click(object sender, RoutedEventArgs e)
        {
            person.Add(new Person() { Name = txtName.Text, Address = txtAddress.Text });
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
        private void btnNamesExt_Click(object sender, RoutedEventArgs e)
        {
            ExtendWindow subWindow = new ExtendWindow();
            subWindow.Show();
        }
        public class Person
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
}
