using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Hello Kids!");
            Console.WriteLine("please enter the Informations one after another!");

            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Person {i}:");

                Thread.Sleep(1000);
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Thread.Sleep(1000);
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();

                Thread.Sleep(1000);
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Thread.Sleep(1000);
                Console.Write("National Code: ");
                int nationalCode = int.Parse(Console.ReadLine());

                students.Add(new Student { firstName = firstName, lastName = lastName, age = age, nationalCode = nationalCode});

            }


            foreach (var student in students)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Name : {student.firstName} {student.lastName} \n Age : {student.age} \n National Code : {student.nationalCode}");
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
