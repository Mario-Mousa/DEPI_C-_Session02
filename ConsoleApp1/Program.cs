using System;

namespace Assignment2
{
    class Program
    {
        #region Question 1
        static void Question1()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
        #endregion

        #region Question 2
        static void Question2()
        {
            string text = "12a3";

            try
            {
                int number = Convert.ToInt32(text);
                Console.WriteLine(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: not a valid number.");
            }
        }
        #endregion

        #region Question 3
        static void Question3()
        {
            float a = 0.1f;
            float b = 0.2f;
            float result = a + b;
            Console.WriteLine(result);
        }
        #endregion

        #region Question 4
        static void Question4()
        {
            string fullText = "Hello World from CSharp";
            string sub = fullText.Substring(6, 5);
            Console.WriteLine(sub);
        }
        #endregion

        #region Question 5
        static void Question5()
        {
            int x = 10;
            int y = x;

            y = 20;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
        #endregion

        #region Question 6
        class Person
        {
            public string Name;
        }

        static void Question6()
        {
            Person p1 = new Person { Name = "Ahmed" };
            Person p2 = p1;

            p2.Name = "Mostafa";

            Console.WriteLine("p1.Name = " + p1.Name);
            Console.WriteLine("p2.Name = " + p2.Name);
        }
        #endregion

        #region Question 7
        static void Question7()
        {
            string firstName = "Yousef";
            string lastName = "Khaled";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
        #endregion

        #region Question 8
        static void Question8()
        {
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d);
        }
        #endregion

        #region Question 9
        static void Question9()
        {
            Console.WriteLine(13 / 2 + " " + 13 % 2);
        }
        #endregion

        #region Question 10
        static void Question10()
        {
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
        }
        #endregion
    }
}