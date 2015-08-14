using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AmitCustomerWPF.Model;
using AmitCustomerWPF.DataAccess;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Timers;
using System.Windows.Input;
using System.Windows.Threading;
using System.Threading;

namespace AmitCustomerWPF.ViewModel
{
    class AllCustomerViewModel 
    {
        private System.Timers.Timer SimulatorTimer = new System.Timers.Timer();
        private int _count = 0;

        delegate void DoSomethingDelegate();

        ObservableCollection<Customer> _list = new ObservableCollection<Customer>();
        public ObservableCollection<Customer> AllCustomerList
        {
            get { return _list; }
        }
        
        public AllCustomerViewModel()
        {
            _list = new ObservableCollection<Customer>();
            List<Customer> _cList = new CustomerRepository()._customerList;

            foreach (Customer item in _cList)
            {
                this.AllCustomerList.Add(item);
            }

            // Initialize Commands of the View
            this.SetStart = new AllCustomerViewModelCommand(ExecuteSetStart, CanExecuteSetStart);
            this.SetStop = new AllCustomerViewModelCommand(ExecuteSetStop, CanExecuteSetStop);
            
            // Setting up the timer for updating data on recurring basis
            SimulatorTimer.Elapsed += new ElapsedEventHandler(RunSimulatorEvent);
            SimulatorTimer.Interval = 5000;
            SimulatorTimer.Start();
            
        }

        public void RunSimulatorEvent(object source, ElapsedEventArgs e)
        {
            for (int i = 0; i < AllCustomerList.Count; i++)
            {
                //this.AllCustomerList[0].FirstName = this.AllCustomerList[0].FirstName + _count;
                //this.AllCustomerList[0].LastName = this.AllCustomerList[0].LastName + _count;
                //this.AllCustomerList[0].Age = new Random().Next(20, 50);                
            }
            //DoSomethingDelegate del = Update;
            //Dispatcher.CurrentDispatcher.BeginInvoke( del, DispatcherPriority.Render);

            
            if (Dispatcher.CurrentDispatcher.Thread != Thread.CurrentThread)
            {
                Dispatcher.CurrentDispatcher.BeginInvoke(
                    new Action(delegate() 
                    {
                        this.AllCustomerList[1] = new Customer() { FirstName = "test", Age = DateTime.Now.Millisecond, LastName = "LNamne" };            
                    }));
            }
            else
                ///this.AllCustomerList[1] = new Customer() { FirstName = "test", Age = DateTime.Now.Millisecond, LastName = "LNamne" };            
            _count++;
        }

        void Update()
        {
            
            //AllCustomerList.Add(new Customer() { FirstName = "test", Age = DateTime.Now.Millisecond, LastName = "LNamne" });
        }

        #region Commands

        public ICommand SetStart { get; set; }
        public ICommand SetStop { get; set; }

        private bool CanExecuteSetStart(object parameter)
        {
            return true;//!(CanExecuteSetStop(parameter));
        }

        private void ExecuteSetStart(object parameter)
        {
            // when button is enabled and clicked
            SimulatorTimer.Start();
        }

        private bool CanExecuteSetStop(object parameter)
        {
            return !(CanExecuteSetStart(parameter));
        }

        private void ExecuteSetStop(object parameter)
        {
            // when button is enabled and clicked
            SimulatorTimer.Stop();
        }

        #endregion

    }

    internal class AllCustomerViewModelCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute _execute;
        private ICommandOnCanExecute _canExecute;

        public AllCustomerViewModelCommand(ICommandOnExecute onExecuteMethod, ICommandOnCanExecute onCanExecuteMethod)
        {
            _execute = onExecuteMethod;
            _canExecute = onCanExecuteMethod;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
        #endregion
    }

}

