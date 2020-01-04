using InterfacesTutorial.Compare;
using System;
using System.Collections.Generic;

namespace InterfacesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                FirstName = "Mark",
                LastName = "Miller",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                Id = 102,
                FirstName = "John",
                LastName = "Doe",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                Id = 103,
                FirstName = "Ken",
                LastName = "Kuy",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);



            Console.WriteLine("List by First name then last name with IComparable:");
            listCutomers.Sort();
            foreach(var item in listCutomers)
            {
                Console.WriteLine(item.FullName);
            }

            SortBySalary sortBySal = new SortBySalary();

            Console.WriteLine();
            Console.WriteLine("List by greater Salary with IComparer:");

            listCutomers.Sort(sortBySal);
            listCutomers.Reverse();

            foreach (var item in listCutomers)
            {
                Console.WriteLine(item.Salary);
            }

        }
    }
}
