using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharpBasicRevision
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello c Sharp");

            List<int> myList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7,
            };
            foreach (int number in myList)
            {
                Console.WriteLine($"The number: {number}");
            }

            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "Jawid", LastName = "Forotan" },
                new Student { Id = 2, Name = "Mustafa", LastName = "Andeshwar" }
            };

            // Select list elements with linq in s sharp
            var result = from x in students where x.Name == "Jawid" select x;
            foreach (var student in result)
            {
                Console.WriteLine(student.Id);
            }


            Console.ReadKey();
        }
    }
}
