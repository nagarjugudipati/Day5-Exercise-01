﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int noc, nos;
            //Console.WriteLine("Enter a Number of Classes");
            //noc = int.Parse(Console.ReadLine());
            //string[][] students = new string[noc][];
            //for (int i = 0; i < noc; i++)
            //{
            //    Console.WriteLine("Enter Number of student in Class" + (i + 1));
            //    nos = int.Parse(Console.ReadLine());
            //    students[i] = new string[nos];
            //    for (int j = 0; j < nos; j++)
            //    {
            //        Console.WriteLine($"Enter Student {j + 1}\'s name");
            //        students[i][j] = Console.ReadLine();
            //    }
            //}
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Students List of Class {i + 1}");
            //    Console.WriteLine("*********************************");
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        Console.WriteLine(students[i][j]);
            //    }
            //    Console.WriteLine("*******************************");
            //}
            //Console.ReadKey();


            //Day-5 Exercise - 1

            Console.Write("Enter number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days for each employee: ");
            int numWorkingDays = int.Parse(Console.ReadLine());

            int[][] salaries = new int[numEmployees][];

            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numWorkingDays];

                Console.WriteLine($"Enter salaries for employee {i + 1}:");
                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.Write($"Day{j + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nWeekly salary calculation:");
            for (int i = 0; i < numEmployees; i++)
            {
                int totalSalary = 0;

                Console.WriteLine($"Employee {i + 1}:");
                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.WriteLine($"Day{j + 1}: {salaries[i][j]}");
                    totalSalary += salaries[i][j];
                }

                Console.WriteLine($"Total Salary: {totalSalary}\n");
            }

            Console.ReadKey();
        }

    }
}

