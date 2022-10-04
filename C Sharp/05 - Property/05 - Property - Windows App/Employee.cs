using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Property
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public Date birthDate;
        public Date hireDate;
        public Employee(string firstName, string lastName, int birthDay, int birthMonth, int birthYear, 
                        int hireDay, int hireMonth, int hireYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            birthDate = new Date(birthMonth, birthDay, birthYear);
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }
        public string ToEmployeeString()
        {
            return lastName + " " + firstName + " Hired: " + hireDate.ToDateString() + " Birthday: " + birthDate.ToDateString();
        }
    }
}
