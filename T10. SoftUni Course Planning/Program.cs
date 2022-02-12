using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading the input
            List<string> allLessons = Console.ReadLine().Split(", ").ToList();

            // Creating a list where we will store all the lessons that are Exercises
            List<string> exerciseTitles = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArgs = command.Split(':');

                // Getting action and the title of the lesson:
                string action = cmdArgs[0];
                string lessonTitle = cmdArgs[1];

                // Making the logic with all of the actions:
                if (action == "Add")
                {
                    allLessons.Add(lessonTitle);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);

                    if (allLessons.Contains(lessonTitle))
                    {
                        continue;
                    }

                    allLessons.Insert(index, lessonTitle);
                }
                else if (action == "Remove")
                {
                    allLessons.Remove(lessonTitle);
                }
                else if (action == "Swap")
                {
                    string swapTitle = cmdArgs[2];

                    //// Here we swap two lessons, one of which for sure is an Exercise:
                    //if (exerciseTitles.Contains(lessonTitle) || exerciseTitles.Contains(swapTitle))
                    //{
                    //    if (!allLessons.Contains(lessonTitle) && !allLessons.Contains(swapTitle))
                    //    {
                    //        continue;
                    //    }

                    //    string temp;

                    //    if (exerciseTitles.Contains(lessonTitle))
                    //    {
                    //        temp = $"{lessonTitle}-Exercise";
                    //        lessonTitle += "-Exercise";
                    //    }
                    //    else
                    //    {
                    //        temp = $"{swapTitle}-Exercise";
                    //        swapTitle += "-Exercise";
                    //    }

                    //    int firstSwapIndex = allLessons.IndexOf(lessonTitle);
                    //    int secondSwapIndex = allLessons.IndexOf(swapTitle);

                    //    allLessons[firstSwapIndex] = swapTitle;
                    //    allLessons[secondSwapIndex] = temp;
                    //}


                    // Here we swap two lesson, normally:
                    if (!allLessons.Contains(lessonTitle) && !allLessons.Contains(swapTitle))
                    {
                        continue;
                    }

                    string temp = lessonTitle;
                    bool isFollowingForFirstTitle = false;
                    bool isFollowingForSecondTitle = false;

                    int firstSwapIndex = allLessons.IndexOf(lessonTitle);
                    int secondSwapIndex = allLessons.IndexOf(swapTitle);

                    if (exerciseTitles.Contains(lessonTitle))
                    {
                        isFollowingForFirstTitle = true;
                    }

                    if (exerciseTitles.Contains(swapTitle))
                    {
                        isFollowingForSecondTitle = true;
                    }

                    allLessons[firstSwapIndex] = swapTitle;
                    allLessons[secondSwapIndex] = temp;

                    //TODO: Fix the logic below for -Exercise

                    if (isFollowingForFirstTitle)
                    {
                        allLessons.Insert(firstSwapIndex + 1, lessonTitle + "-Exercise");
                    }

                    if (isFollowingForSecondTitle)
                    {
                        allLessons.Insert(secondSwapIndex + 1, swapTitle + "-Exercise");
                    }
                }
                else if (action == "Exercise")
                {
                    OrderExerciseAction(allLessons, lessonTitle, exerciseTitles);
                }
            }

            // Printing the ordered result:
            for (int i = 0; i < allLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{allLessons[i]}");
            }
        }

        static void OrderExerciseAction(List<string> lessons, string lessonTitle, List<string> exercisesStrings)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
                lessons.Add(lessonTitle + "-Exercise");
            }
            else
            {
                int index = lessons.IndexOf(lessonTitle);
                lessons.Insert(index + 1, $"{lessonTitle}-Exercise");
            }

            exercisesStrings.Add(lessonTitle);
        }
    }
}
