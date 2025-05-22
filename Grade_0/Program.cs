using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = 0;
            Dictionary<string, int> gradeCount = new Dictionary<string, int>
            {
                {"A", 0}, {"B", 0}, {"C", 0}, {"S", 0}, {"F", 0}
            };

            while (true)
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
                        continue;
                    }
                    //else
                    //{
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

                    gradeCount[grade]++;
                    totalStudents++;

                    Console.Write("Do you want to enter another student? (yes/no): ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer != "yes")
                        break;
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Marks Summary
            Console.WriteLine("\n--- Summary Report ---");
            Console.WriteLine($"Total Students: {totalStudents}");
            foreach (var pair in gradeCount)
            {
                Console.WriteLine($"Grade {pair.Key}: {pair.Value}");
            }

            Console.ReadLine();
        }
    }
}
