﻿using System;

namespace EmployeeDirectoryNA20
{
    public static class Util
    {
        public static string AskForString(string prompt)
        {
            bool correct = true;
            string answer;
            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    correct = false;
                }

            } while (correct);

            return answer;
        }

        public static int AskForInt(string prompt)
        {
            bool success;
            int answer;

            do
            {
                string input = AskForString(prompt);
                // int result;
                success = int.TryParse(input, out answer);
                if (!success)
                {
                    Console.WriteLine("Wrong format try again");
                }

            } while (!success);

            return answer;
        }
    }
}