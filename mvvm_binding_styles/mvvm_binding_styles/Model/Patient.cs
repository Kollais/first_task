using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_binding_styles.Model
{
    public class Patient
    {
        string _firstname;
        string _lastname;
        DateTime _dateOfBirth;

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (value == _firstname)
                    return;
                _firstname = value;
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value == _lastname)
                    return;
                _lastname = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (value == _dateOfBirth)
                    return;
                _dateOfBirth = value;
            }
        }

        public Patient(string fn, string ln, DateTime dob)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.DateOfBirth = dob;
        }
    }
}
