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

namespace AmitCustomerWPF.View
{
    /// <summary>
    /// Interaction logic for ucCustomerView.xaml
    /// </summary>
    public partial class ucCustomerView : UserControl
    {
        CustomerViewModel _customerViewModel;
        public ucCustomerView()
        {
            InitializeComponent();
            _customerViewModel = new CustomerViewModel();
            this.DataContext = _customerViewModel.MyCustomer;
        }
    }
}
