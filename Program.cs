using System.Collections.Generic;

namespace Day12_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Abhinav", "123-456-7890", "123 Main St", 15, 85.5),
                new Student(2, "Anuj", "987-654-3210", "456 Elm St", 16, 92.0),
                new Student(3, "Stuti", "555-123-4567", "789 Oak St", 14, 77.5),
                new Student(4, "Reshma", "777-888-9999", "123 Main St", 18, 88.5),
                new Student(5, "Arbab", "444-555-6666", "456 Elm St", 12, 95.0)
            };

            foreach (Student student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            var ageFilteredStudents = students.Where(student => student.Age >= 12 && student.Age <= 18).ToList();
            Console.WriteLine("\nStudents with Age between 12 and 18:");
            foreach (var student in ageFilteredStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\nStudents sorted by Age in descending order:");
            var sortedStudents = students.OrderByDescending(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nStudents by Address:");
            var groupedStudents = students.GroupBy(s => s.Address);
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Address: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }

            Console.WriteLine("\nFirst Three Students:");
            var firstThreeStudents = students.Take(3);
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nEnter a name to search for a student:");
            string searchName = Console.ReadLine();
            var searchedStudent = students.FirstOrDefault(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (searchedStudent != null)
            {
                Console.WriteLine($"Found Student: {searchedStudent}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}