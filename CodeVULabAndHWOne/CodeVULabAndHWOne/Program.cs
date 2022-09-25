using System;

namespace CodeVULabAndHWOne
{
    internal class Program
    {
        class Team
        //Lab 1 Data Types
        {
            string codeVU = "Cohort 5";
            int numberStudents = 10;
            float numberMentors = 3.0f;
            bool allPassed = true;
            char highGrade = 'A';
            double totalCost = 100.00D;
            decimal practice = 1.92m;
            byte sizeByte = 88;
            short sizeShort = 100;
            long sizeLong = 200;

            static void Main(string[] args)
            {
                Team myObj = new Team();
                Console.WriteLine(myObj.codeVU);
                Console.WriteLine(myObj.numberStudents);
                Console.WriteLine(myObj.numberMentors);
                Console.WriteLine(myObj.highGrade);
                Console.WriteLine(myObj.allPassed);
                Console.WriteLine(myObj.totalCost);
                Console.WriteLine(myObj.practice);
                Console.WriteLine(myObj.sizeByte);  
                Console.WriteLine(myObj.sizeShort);
                Console.WriteLine(myObj.sizeLong);



                //Lab 2 Input
                Console.WriteLine("What is your favorite season?");
                string faveSeason = Console.ReadLine();
                Console.WriteLine("What is your favorite car?");
                string faveCar = Console.ReadLine();
                Console.WriteLine("What is your favorite TV show?");
                string faveTVShow = Console.ReadLine();
                Console.WriteLine("How much do you spend on streaming services last year?");
                double streamingCost = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Your favorite season is {0}. Your favorite car is {1}. Your favorite TV show is {2}. You spend ${3} yearly on streaming services.", faveSeason, faveCar, faveTVShow,streamingCost);

                //Lab 3 MadLib

                Console.WriteLine("-----MADLIB------");

                Console.WriteLine("Enter a verb"); //0
                string verb1 = Console.ReadLine();
                Console.WriteLine("Enter an adjective"); //1
                string adjective1 = Console.ReadLine();
                Console.WriteLine("Enter a verb"); //2
                string verb2 = Console.ReadLine();
                Console.WriteLine("Enter an adjective"); //3
                string adjective2 = Console.ReadLine();
                Console.WriteLine("Enter an adjective."); //4
                string adjective3 = Console.ReadLine();
                Console.WriteLine("Enter a noun"); //5
                string noun1 = Console.ReadLine();
                Console.WriteLine("Enter a noun"); //6
                string noun2 = Console.ReadLine();
                Console.WriteLine("Enter a noun."); //6
                string noun3 = Console.ReadLine();
                Console.WriteLine("Enter an adjective"); //8
                string adjective4 = Console.ReadLine();

                string madLibStory;
                madLibStory = String.Format("Today we {0} in class. It was {1} to say the least. I requested a mentor to {2} the instructions. \n The students were {3} and {4}. So far, I love the class, despite Student A's lack of {5}s. \n Overall, this class will teach us about {6}s and {7}s. To say we're all {8} is an understatement!", verb1, adjective1, verb2, adjective2, adjective3, noun1, noun2, noun3, adjective4);

                Console.WriteLine(madLibStory);

                //Lab 4 Casting

                short pond = 29456;
                int lake = 100000;
                long ocean = 5;
                byte puddle = 100;

                //implicit casting
                //cast value of lake into ocean
                long lakeToOcean = lake;
                Console.WriteLine("Implicit Casting: " + lakeToOcean);

                //cast value of pond into ocean
                long pondToOcean = pond;
                Console.WriteLine("Implicit Casting: " + pondToOcean);

                //explicit casting
                //cast value of pond to into puddle
                byte pondToPuddle;
                pondToPuddle = (byte)puddle;
                Console.WriteLine("Explicit Casting: " + pondToPuddle);

                //cast value of ocean into lake
                int oceanToLake;
                oceanToLake = (int)ocean;
                Console.WriteLine("Explicit Casting: " + oceanToLake);

                //explicit casting with truncation
                int ocean2Lake = Convert.ToInt32(ocean);
                Console.WriteLine("Explicit Casting with Truncation: " + ocean2Lake);


            }
        }
    }
}



