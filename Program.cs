using System;

namespace c_grade_translator_assignment_T_Ralph
{
    class Program
    {
        static void Main()
        {
            /*
                Assignment: C# Grade Translator Practice
                Doc: https://docs.google.com/document/d/1xuHUSAyivOT3FOgOnW2WwN4vmTI-ktQDxAZr4FLFn4w/edit
                Author: Tosin Raphael Olaniyi (T-Ralph)
                Date: August 11, 2020
            */

            //Greet the user
            Console.WriteLine("  ------- -- -- ----- ---------- --------  \n| Welcome to C# Grade Translator Practice |\n  ------- -- -- ----- ---------- --------");
            Console.WriteLine("-> Enter the Numeric Grade and the Program will display the corresponding Letter Grade");
            Console.WriteLine("-> To exit the Program, enter Letter 'q' (case insensitive)\n");

            //Run the MainProcess method
            MainProcess();
        }

        static void MainProcess() {
            //Declare datatypes
            string gradeInput = "";
            double grade;

            //Listen for 'q' to exit program using Loop
            while (gradeInput.ToLower() != "q")
            {
                //Ask for input
                Console.Write("Enter the Grade: ");
                gradeInput = Console.ReadLine();

                if (gradeInput.ToLower() == "q")
                {
                    ExitProgram(); //Exit the Program
                }
                else {
                    //Catch exception for invalid input
                    if (double.TryParse(gradeInput, out grade))
                    {
                        GradeIdentification(grade); //Run GradeIdentification method
                    }
                    else
                    {
                        Console.WriteLine("Error: Numeric grade numbers only.\nInput grade between 0 and 100 (inclusive)\n"); //Error for invalid input
                        MainProcess(); //Run MainProcess method again
                    }
                }
            }

        }

        static void GradeIdentification(double grade)
        {
            //Declare datatypes
            string letterGrade;
            string gradeComment;

            //Conditions for Letter Grade and Comment Grade
            if (grade >= 0 && grade < 50) {
                letterGrade = "F"; //Letter Grade
                gradeComment = "Very Poor"; //Comment Grade
            }
            else if (grade >= 50 && grade < 55) {
                letterGrade = "D"; //Letter Grade
                gradeComment = "Poor"; //Comment Grade
            }
            else if (grade >= 55 && grade < 60) {
                letterGrade = "C-"; //Letter Grade
                gradeComment = "Good"; //Comment Grade
            }
            else if (grade >= 60 && grade < 65) {
                letterGrade = "C"; //Letter Grade
                gradeComment = "Good"; //Comment Grade
            }
            else if (grade >= 65 && grade < 70) {
                letterGrade = "C+"; //Letter Grade
                gradeComment = "Good"; //Comment Grade
            }
            else if (grade >= 70 && grade < 75) {
                letterGrade = "B-"; //Letter Grade
                gradeComment = "Very Good"; //Comment Grade
            }
            else if (grade >= 75 && grade < 80) {
                letterGrade = "B"; //Letter Grade
                gradeComment = "Very Good"; //Comment Grade
            }
            else if (grade >= 80 && grade < 85) {
                letterGrade = "B+"; //Letter Grade
                gradeComment = "Very Good"; //Comment Grade
            }
            else if (grade >= 85 && grade < 90) {
                letterGrade = "A-"; //Letter Grade
                gradeComment = "Excellent"; //Comment Grade
            }
            else if (grade >= 90 && grade < 97) {
                letterGrade = "A"; //Letter Grade
                gradeComment = "Excellent"; //Comment Grade
            }
            else if (grade >= 97 && grade <= 100) {
                letterGrade = "A+"; //Letter Grade
                gradeComment = "Perfect"; //Comment Grade
            }
            else {
                letterGrade = "N/A";
                gradeComment = "N/A";
                Console.WriteLine("Error: Invalid grade number.\nInput grade between 0 and 100 (inclusive)\n");
            }

            Console.WriteLine($"Letter Grade: {letterGrade}"); //Display Letter Grade
            Console.WriteLine($"Grade Comment: {gradeComment}\n"); //Display Comment Grade
        }

        static void ExitProgram()
        {
            //Exit the program
            Console.WriteLine("\n  -------------------  \n| Program will exit now |\n| Bye                   |\n -------------------  \n");
            Environment.Exit(0);
        }
    }
}
