using InterfacesTutorial.Compare;
using InterfacesTutorial.Equality;
using InterfacesTutorial.Iterator;
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
            Customer customer11 = new Customer()
            {
                Id = 101,
                FirstName = "Mark",
                LastName = "Abi",
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
                LastName = "Neny",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);
            listCutomers.Add(customer11);

            Console.WriteLine("Before Sorting : ");
            foreach (var item in listCutomers)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine();
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


            // Delegate Version
            Console.WriteLine();
            Console.WriteLine("List by Last Name with delegate:");
            listCutomers.Sort((x, y) => x.LastName.CompareTo(y.LastName));

            foreach (var item in listCutomers)
            {
                Console.WriteLine(item.LastName);
            }


            Console.WriteLine();
            var getCustomerById = listCutomers.Find(x => x.Id == 102);
            Console.WriteLine("Customer by id : "+ getCustomerById.FullName);



            //Iterator pattern

            /**
             * The pattern is astonishingly useful when attempting to retrieve objects from collections that you'd 
             * rather not expose to outside usage (because that's, like, the pattern's entire purpose). If you primarily
             * work in the ASP.NET world and you use LINQ, you are already using the Iterator pattern 
             * extensively (e.g. collection.First()(Reset) or collection.Count()).
            */
            var infiniteEnumerable = new MyInfiniteEnumerable();
            var enumerator = infiniteEnumerable.GetEnumerator();


            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }



            // Equality
            Student s1 = new Student()
            {
                Name = "Skerdi",
                Age = 15
            };
            Student s2 = new Student()
            {
                Name = "Skerdi",
                Age = 15
            };

            Console.WriteLine(s1.Equals(s2));

        }
    }
}
