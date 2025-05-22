using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Marks (out of 100): ");
                string input = Console.ReadLine();
                int marks;

                if (!int.TryParse(input, out marks) || marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid input. Please enter numeric marks between 0 and 100.");
                }
                else
                {
                    string grade;

                    if (marks > 75)
                        grade = "A";
                    else if (marks > 65)
                        grade = "B";
                    else if (marks > 55)
                        grade = "C";
                    else if (marks > 45)
                        grade = "S";
                    else
                        grade = "F";

                    Console.WriteLine("Student: " + name + ", Grade: " + grade);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
