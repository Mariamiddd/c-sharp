using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Tasks.Sources;

namespace davaleba6_massives
{
    internal class Program
    {
        private static object lowAndHigh;

        static void Main(string[] args)
        {

            #region  davaleba 1
            //    int[][] score = [[10,49,5,8],[60,9,6,7],[24,32,5,9],[10, 9, 5, 8], [10, 29, 5, 8]];
            //    int[] sumArrResult = new int[score.Length];
            //    for(int i=0; i < score.Length; i++)
            //    {
            //        int sum = 0;
            //        foreach(int item in score[i])
            //        {
            //            sum += item;
            //        }
            //        int average = sum / score[i].Length;

            //        Console.WriteLine($"Student {i + 1} average score: {average}");
            //}
            #endregion

            #region  davaleba 2

            //string[] passArr = ["2754", "2353", "6783", "2843", "6351", "5392", "1832", "9201", "4191", "3821"];
            //Console.WriteLine("enter correct passoword");
            //string userInput = Console.ReadLine();

            //bool isCorrect = false;
            //for (int i = 0; i < passArr.Length; i++)
            //{
            //    if (passArr[i] == userInput)
            //    {
            //        isCorrect = true;
            //        break;
            //    }
            //}

            //if (isCorrect) {
            //    Console.WriteLine("correct password");
            //       }
            //else
            //{
            //    Console.WriteLine("incorrect password");
            //}

            #endregion

            #region  davaleba 3

            //int[] numArr = [3, -5, 7, -2, 8, 1];
            ////highest and lowest number in the array
            //int highest = numArr[0];
            //int lowest = numArr[0];

            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    if (numArr[i] > highest)
            //    {
            //        highest = numArr[i];
            //    }
            //}

            //for(int i = 0; i < numArr.Length; i++)
            //{
            //    if (numArr[i] < lowest)
            //    {
            //        lowest = numArr[i];
            //    }
            //}
            //Console.WriteLine($"highest number is: {highest}");
            //Console.WriteLine($"lowest number is: {lowest}");

            #endregion

            #region  davaleba 4
            //string[] newString = { "fdsa", "asdf", "sdfg", "dfgh", "fghj" };
            //foreach (string str in newString)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion

            #region  davaleba 5
            //string[] emailCheck = { "example@gmail.com", "example2@gmail.com" , "example3@gmail.com", "exampleAgmail.com" };

            //for (int i = 0; i < emailCheck.Length; i++)
            //{
            //    string currentEmail = emailCheck[i];

            //    bool isSymbol = false;

            //    foreach (char c in currentEmail)
            //    {
            //        if (c == '@')  
            //        {
            //            isSymbol = true;
            //            break;
            //        }
            //    }
            //    if (isSymbol)
            //    {
            //        Console.WriteLine($"{currentEmail} contains @");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{currentEmail} doesnt contain @");
            //    }

            //}
            #endregion
        }
    }
}
