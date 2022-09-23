using System;

namespace CodeVULabAndHWOne
{
    internal class Program
    {
        class Team

        {
            string codeVU = "Cohort 5";
            int numberStudents = 10;
            float numberMentors = 3.0f;
            bool allPassed = true;
            char highGrade = 'A';

            static void Main(string[] args)
            {
                Team myObj = new Team();
                Console.WriteLine(myObj.codeVU);
                Console.WriteLine(myObj.numberStudents);
                Console.WriteLine(myObj.numberMentors);
                Console.WriteLine(myObj.highGrade);
                Console.WriteLine(myObj.allPassed);

                Console.WriteLine("What is your favorite season?");
                string faveSeason = Console.ReadLine();
                Console.WriteLine("What is your favorite car?");
                string faveCar = Console.ReadLine();
                Console.WriteLine("What is your favorite TV show?");
                string faveTVShow = Console.ReadLine();
                Console.WriteLine("How much do you spend on streaming services last year?");
                double streamingCost = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Your favorite season is {0}.Your favorite car is {1}.Your favorite TV show is {2}. You spend ${3} yearly on streaming services.", faveSeason, faveCar, faveTVShow,streamingCost);


            }
        }
    }
}



