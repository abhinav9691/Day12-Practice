using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Practice
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public double TotalMarks { get; set; }

        public Student(int id, string name, string phoneNumber, string address, int age, double totalMarks)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
            TotalMarks = totalMarks;
        }


    }
}
