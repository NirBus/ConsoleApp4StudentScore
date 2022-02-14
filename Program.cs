using System;

namespace ConsoleApp4
{
    internal class Program
    {
        //Give me 100/100 score :)
        #region Average of scores of Student
        static void Main(string[] args)
        {
            int num1 = 0;
            int pointsum = 0;
            StNum(ref num1);
            StPoint(ref pointsum);
            double result = (num1 + pointsum) / 2;
            Console.WriteLine("Sinif ortalamasi " + result);
        }
        #endregion

        #region Student of number MeThod
        public static int StNum(ref int num1) //Telebe sayisi
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            {
                foreach (int num in arr)
                {
                    num1 += num;
                }
                return num1;
            }
        }
        #endregion

        #region Stutend Score MeThod
        public static int StPoint(ref int pointsum) //Telebe bali
        {
            int[] arr = { 70, 65, 100, 90, 30, 95, 40 };
            {
                foreach (int num in arr)
                {
                    pointsum += num;
                }
                return pointsum;
            }
        }
        #endregion
    }
}

