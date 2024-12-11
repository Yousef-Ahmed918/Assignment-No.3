namespace Assignment_No._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            /* int.TryParse(Console.ReadLine(), out int num);
             if (num % 3 == 0)
             {
                 Console.WriteLine("Yes");

             }
             else
             {
                 Console.WriteLine("No");
             } */
            #endregion

            #region Question 2 Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*int.TryParse(Console.ReadLine(), out int num);
            if (num > 0)
            {
                Console.WriteLine("Positive");

            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");

            }
            else
            {
                Console.WriteLine("Zero");

            }*/

            #endregion

            #region Question 3 Write a program that takes 3 integers from the user then prints the max element and the min element. 
            /*int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int.TryParse(Console.ReadLine(), out int num3);
            int max, min;

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else { max = num3; }

            if (num1 < num2 && num1 < num3)
            {
                min = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                min = num2;
            }
            else { min = num3; }

            Console.WriteLine($"The max Number: {max}");
            Console.WriteLine($"The min Number: {min}");*/
            #endregion

            #region Question 4 Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*int.TryParse(Console.ReadLine(), out int num);
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }*/
            #endregion

            #region Qusetion 5 Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /*char.TryParse(Console.ReadLine(), out char ch);

            switch (char.ToLower(ch))
            {
                case ('a'):
                case ('e'):
                case ('o'):
                case ('i'):
                case ('u'):
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;


            }*/


            #endregion

            #region Question 6 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            /*int.TryParse(Console.ReadLine(), out int num);
            for (int i = 1; i <= num; i++)
            {
                if (i == num)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i},");
                }
            }
            */
            #endregion

            #region Question 7 Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            /*int.TryParse(Console.ReadLine(), out int num);
            for (int i = 1; i <= 12; i++)
            {

                int sum = 0;
                sum = num * i;
                Console.Write($"{sum} ");

            }*/
            #endregion


            #region Question 8 Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*int.TryParse(Console.ReadLine(), out int num);
            for (int i = 1; i <= num; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }

            }*/
            #endregion


            #region Question 9 Write a program that takes two integers then prints the power.
            /*int.TryParse(Console.ReadLine(), out int num);
            int.TryParse(Console.ReadLine(), out int exp);
            int sum = 1;
            for (int i = 1; i <= exp; i++)
            {
                sum *= num;
            }
            Console.WriteLine(sum);*/
            #endregion


            #region Question 10 Write a program to enter marks of five subjects and calculate total, average and percentage.
            /*Console.Write("enter the mark of the first subject: ");
            int.TryParse(Console.ReadLine(), out int subj1);
            Console.Write("enter the mark of the secound subject: ");
            int.TryParse(Console.ReadLine(), out int subj2);
            Console.Write("enter the mark of the third subject: ");
            int.TryParse(Console.ReadLine(), out int subj3);
            Console.Write("enter the mark of the fourth subject: ");
            int.TryParse(Console.ReadLine(), out int subj4);
            Console.Write("enter the mark of the fifth subject: ");
            int.TryParse(Console.ReadLine(), out int subj5);
            int sum = subj1 + subj2 + subj3 + subj4 + subj5;
            double avg = sum / 5.0;
            double per = (sum / 500.0) * 100;



            Console.WriteLine($"Total Marks: {sum}");
            Console.WriteLine($"Average Marks: {avg}");
            Console.WriteLine($"Percentage: {per}");*/
            #endregion

            #region Question 11 Write a program to input the month number and print the number of days in that month.
            /*Console.Write("Month number: ");
            int.TryParse(Console.ReadLine(), out int num);
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 12:
                    Console.WriteLine("Days in month:31");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in month:30");
                    break;

                default:
                    Console.WriteLine("Days in month:28");
                    break;
            }*/
            #endregion.

            #region Question 12 Write a program to create a Simple Calculator.
            /*Console.WriteLine("Enter the first number: ");
            double.TryParse(Console.ReadLine(), out double num1);
            Console.WriteLine("Enter the operation: ");
            char.TryParse(Console.ReadLine(), out char op);
            if (op != '+' && op != '-' && op != '/' && op != '*' && op != 'x')
            {
                Console.WriteLine("Enter valid operation");
            return;
            }
            Console.WriteLine("Enter the Second number: ");
            double.TryParse(Console.ReadLine(), out double num2);

            

            if (op.Equals('+'))
            {
                Console.WriteLine(num1 + num2);
            }

            else if (op.Equals('-'))
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op.Equals('/'))
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine(num1 * num2);*/

                #endregion
            }
        }
    }
}
