using System;
using System.Collections.Generic;
using System.Text;
using AmitCustomerWPF.Model;
using System.Timers;

namespace AmitCustomerWPF.DataAccess
{
    class CustomerRepository
    {

        public readonly List<Customer> _customerList = new List<Customer>();
        private Timer SimulatorTimer = new Timer();
        private int _count = 0;

        public CustomerRepository()
        {   
            _customerList = LoadCustomers();
            //SimulatorTimer.Elapsed += new ElapsedEventHandler(RunSimulatorEvent);
            //SimulatorTimer.Interval = 1000;
            //SimulatorTimer.Start();
        }

        private List<Customer> LoadCustomers()
        {
            try
            {
                // Get it from XML File or DB. Currently hardcoded.
                _customerList.Add(new Customer { FirstName = "Amit", LastName = "Vasant", Age = 28 });
                _customerList.Add(new Customer { FirstName = "John", LastName = "Smith", Age = 60 });
                _customerList.Add(new Customer { FirstName = "Bill", LastName = "Gates", Age = 35 });
            }
            catch (Exception ex)
            { 
            
            }
            return _customerList;

        }

        // ignore it
        public void RunSimulatorEvent(object source, ElapsedEventArgs e)
        {            
            _customerList[0].FirstName = "AmitNew" + _count;
            _customerList[0].LastName = "VasantNew" + _count;
            _customerList[0].Age = new Random().Next(20, 50);
            //SimulatorTimer.Stop();           
            _count++;
        }
    }
}

