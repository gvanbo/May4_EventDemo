using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May4_EventDemo
{
    class Person
    {
        public string FName { get; set; }

        public string LName { get; set; }
        private DateTime _dob;

        public DateTime DOB {
            get { return _dob; }
            set { 
                _dob = value;
                DOBEvent(this); //Fire the Event
            }
        }


        public delegate void DOBDelegate(Person p);

        public event DOBDelegate DOBEvent;


    }
}
