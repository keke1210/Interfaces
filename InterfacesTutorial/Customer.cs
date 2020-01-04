using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfacesTutorial
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }


        public string FullName => this.FirstName + " " + LastName;

        public int CompareTo([AllowNull] Customer other)
        {
            int result =  this.FirstName.CompareTo(other.FirstName);
            if(result == 0)
                result = this.LastName.CompareTo(other.LastName);

            return result;
        }
    }
}
