using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AmitCustomerWPF.ViewModel;
using System.Timers;
using System.Threading;


namespace AmitCustomerWPF.View
{
    /// <summary>
    /// Interaction logic for ucAllCustomerView.xaml
    /// </summary>
    public partial class ucAllCustomerView : UserControl
    {
        AllCustomerViewModel _allCustomerViewModel;

        public ucAllCustomerView()
        {
            InitializeComponent();
            _allCustomerViewModel = new AllCustomerViewModel();
            this.DataContext = _allCustomerViewModel;            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(dosomething));
            t.Start();
            

        }
        private void dosomething() 
        {
            this.Dispatcher.Invoke((Action)(() => { MessageBox.Show("Hi"); }));
           

        }
    }
}
