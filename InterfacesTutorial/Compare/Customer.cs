using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfacesTutorial.Compare
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }


        public string FullName => this.FirstName + " " + LastName;

        // Sorts elements by FirstName and then by LastName
        public int CompareTo([AllowNull] Customer other)
        {
            int result =  this.FirstName.CompareTo(other.FirstName);
            if(result == 0)
                result = this.LastName.CompareTo(other.LastName);

            return result;
        }
         
        public override string ToString()
        {
            return this.FullName;
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;

            if (!(obj is Customer)) return false;

            return this.FullName == ((Customer)obj).FullName;
        }
    }
}
