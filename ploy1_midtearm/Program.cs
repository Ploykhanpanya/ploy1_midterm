using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityStudent = 1;
            int[] scoreMid, scoreFinal, scoreSum;
            string[] nameStudent;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            nameStudent = new string[quantityStudent];
            scoreMid = new int[quantityStudent];
            scoreFinal = new int[quantityStudent];
            scoreSum = new int[quantityStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iTerator = 0; iTerator < quantityStudent; iTerator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({iTerator + 1} of {quantityStudent}) name : ");
                nameStudent[iTerator] = Console.ReadLine();

                Console.Write($"Please key {nameStudent[iTerator]}'s middle score : ");
                scoreMid[iTerator] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {nameStudent[iTerator]}'s final score : ");
                scoreFinal[iTerator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                scoreSum[iTerator] = scoreMid[iTerator] + scoreFinal[iTerator];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int iterator_ = 0;

            while (iterator_ < quantityStudent)
            {
                float gradesScore = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (scoreSum[iterator_] <= 49) gradesScore = 0f;
                else if (scoreSum[iterator_] <= 54) gradesScore = 1f;
                else if (scoreSum[iterator_] <= 59) gradesScore = 1.5f;
                else if (scoreSum[iterator_] <= 64) gradesScore = 2f;
                else if (scoreSum[iterator_] <= 69) gradesScore = 2.5f;
                else if (scoreSum[iterator_] <= 74) gradesScore = 3f;
                else if (scoreSum[iterator_] <= 79) gradesScore = 3.5f;
                else if (scoreSum[iterator_] >= 80) gradesScore = 4f;

                #endregion

                Console.WriteLine($"{iterator_ + 1}. {nameStudent[iterator_]} have a" +
                                $" total {scoreSum[iterator_]} score or {gradesScore} grades.");
                iterator_++;
            } 

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}