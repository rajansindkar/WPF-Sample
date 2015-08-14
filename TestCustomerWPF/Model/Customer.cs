using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AmitCustomerWPF.Model
{
    /*
    class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstname;
        public string FirstName 
        {
            get 
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _lastname;
        public string LastName 
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                OnPropertyChanged("LastName");
            }
        }

        private int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
                OnPropertyChanged("IsOld");
            }
        }

        //private bool _isold;
        public bool IsOld 
        {

            get
            {
                if (this.Age < 31)
                    return false;
                else
                    return true;
            }
            set
            { 
                //_isold = value;
                //OnPropertyChanged("IsOld");                    
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        
    }
    */

    
    class Customer 
    {
        private string _firstname;
        public string FirstName 
        {
            get 
            {
                return _firstname;
            }
            set
            {
                _firstname = value;               
            }
        }

        private string _lastname;
        public string LastName 
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;               
            }
        }

        private int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;                
            }
        }

        //private bool _isold;
        public bool IsOld 
        {

            get
            {
                if (this.Age < 31)
                    return false;
                else
                    return true;
            }
            set
            { 
                                   
            }
        }

        
        
    }
    
    
}
