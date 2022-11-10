using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ExtendWindow.xaml
    /// </summary>
    public partial class ExtendWindow : Window
    {
        public ExtendWindow()
        {
            InitializeComponent();
        }
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            CarDependencyProperty dpSample = TryFindResource("CarDependency") as CarDependencyProperty;
            MessageBox.Show(dpSample.MyCar);
        }
    }
    public class CarDependencyProperty : DependencyObject
    {
        //Register Dependency Property  
        public static readonly DependencyProperty CarDependency = DependencyProperty.Register("MyProperty", typeof(string), typeof(CarDependencyProperty));
        public string MyCar
        {
            get
            {
                return (string)GetValue(CarDependency);
            }
            set
            {
                SetValue(CarDependency, value);
            }
        }
    }
}
