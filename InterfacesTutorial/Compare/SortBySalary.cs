using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfacesTutorial.Compare
{
    public class SortBySalary : IComparer<Customer>
    {
        public int Compare([AllowNull] Customer x, [AllowNull] Customer y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
