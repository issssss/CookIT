using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorInjection.DataProcessing
{
    public class Person
    {
        private string _oib;
        private string _name;
        private string _surname;
        private DateTime _dateOfBirth;
        private string _adress;
        private string _eMail;


        public string Oib
        {
            get { return _oib; }
            set { _oib = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        public Person(string inOib, string inName, string inSurname, DateTime inDateOfBirth,
            string inAdress, string inEMail)
        {
            _oib = inOib;
            _name = inName;
            _surname = inSurname;
            _dateOfBirth = inDateOfBirth;
            _adress = inAdress;
            _eMail = inEMail;
        }
    }
}

