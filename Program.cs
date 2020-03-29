using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                string pad = "".PadLeft(Task2.Padding / 2, task.DecorativeSign);
                string spaces = "".PadLeft(Task2.Padding / 2);
                string balance = task.Balance.ToString("C2", new System.Globalization.CultureInfo("en-US"));

                return $"{pad}{spaces}{balance}{spaces}{pad}";
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
