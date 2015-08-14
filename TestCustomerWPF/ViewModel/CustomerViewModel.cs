using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AmitCustomerWPF.Model;
using AmitCustomerWPF.DataAccess;

namespace AmitCustomerWPF.ViewModel
{
    class CustomerViewModel
    {
        public Customer MyCustomer { get; set; }
        public CustomerRepository _cRepository;

        public CustomerViewModel()
        {
            _cRepository = new CustomerRepository();
            this.MyCustomer = _cRepository._customerList.FirstOrDefault();
        }
    }
}
