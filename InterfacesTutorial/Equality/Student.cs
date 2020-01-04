using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfacesTutorial.Equality
{
    public class Student : IEquatable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool Equals(Student other)
        {
            return this.Name.Equals(other.Name) && this.Age.Equals(other.Age);
        }
     
    }
}
