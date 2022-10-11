using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Given a positive number n > 1 find the prime factor decomposition of n. 
//    The result will be a string with the following form :

// "(p1**n1)(p2**n2)...(pk**nk)"
//with the p(i) in increasing order and n(i) empty if n(i) is 1.

//Example: n = 86240 should return "(2**5)(5)(7**2)(11)"


namespace Prime_in_numbers
{
    public class PrimeDecomp
    {
        //public static String factors(int lst)
        //{
        //    string[] ch = (PrimeDivisibleBy(lst).Split(' '));
        //    int[] ar = new int[ch.Length - 1];
        //    string answer = string.Empty;

        //    //  Copy character by character into array

        //    for (int i = 0; i < ch.Length - 1; i++)
        //    {
        //        ar[i] = int.Parse(ch[i]);
        //    }

        //    // Printing content of array 

        //    foreach (var c in ar)
        //    {
        //       answer = answer + bracket(lst, c);
        //    }

        //    return answer;
        //}
        //public static bool CheckNumberPrimeNumber(int num)
        //{
        //    bool CheckPrimeNumber = true;
        //    int factor = num / 2;
        //    int i = 0;
        //    for (i = 2; i <= factor; i++)
        //    {
        //        if ((num % i) == 0) CheckPrimeNumber = false;
        //    }
        //    return CheckPrimeNumber;
        //}
        //public static string PrimeDivisibleBy(int num)
        //{
        //    string str = string.Empty;
        //    for (int i = 2; i <= 10000; i++)
        //    {
        //        if (CheckNumberPrimeNumber(i) == true && (num % i) == 0)
        //            str = str + i.ToString() + " ";
        //    }
        //    return str;
        //}
        //public static string bracket(int lst, int primeDivisor)
        //{
        //    int count = 0;
        //    while (lst % primeDivisor == 0)
        //    {
        //        lst /= primeDivisor;
        //        count++;
        //    }

        //    if (count == 1)
        //        return "(" + primeDivisor + ")";
        //    else
        //        return "(" + primeDivisor + "**" + count +")";
        //}




        public static String factors(int lst)
        {
            string[] ch = (PrimeDivisibleBy(lst).Split(' '));
            int[] ar = new int[ch.Length - 1];
            string answer = string.Empty;

            //  Copy character by character into array

            for (int i = 0; i < ch.Length - 1; i++)
            {
                ar[i] = int.Parse(ch[i]);
            }

            // Printing content of array 

            foreach (var c in ar)
            {
                answer = answer + bracket(lst, c);
            }

            return answer;
        }
        public static bool CheckNumberPrimeNumber(int num)
        {
            bool CheckPrimeNumber = true;
            int factor = num / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((num % i) == 0) CheckPrimeNumber = false;
            }
            return CheckPrimeNumber;
        }
        public static string PrimeDivisibleBy(int num)
        {
            string str = string.Empty;
            for (int i = 2; i <= 10000; i++)
            {
                if (CheckNumberPrimeNumber(i) == true && (num % i) == 0)
                    str = str + i.ToString() + " ";
            }
            return str;
        }
        public static string bracket(int lst, int primeDivisor)
        {
            int count = 0;
            while (lst % primeDivisor == 0)
            {
                lst /= primeDivisor;
                count++;
            }

            if (count == 1)
                return "(" + primeDivisor + ")";
            else
                return "(" + primeDivisor + "**" + count + ")";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeDecomp.factors(86240)); // "(2**5)(5)(7**2)(11)"
            Console.WriteLine(PrimeDecomp.factors(7775460)); // "(2**2)(3**3)(5)(7)(11**2)(17)"
            Console.WriteLine(PrimeDecomp.factors(2310));  
        }
    }
}
