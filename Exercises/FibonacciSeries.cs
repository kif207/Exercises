using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class FibonacciSeries
    {
        public static int Find(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        public static void allFib(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + ": " + fib(i));
            }
        }

        public static int fib(int n)
        {
            if (n <= 0) return 0;
            else if (n == 1) return 1;
            return fib(n - 1) + fib(n - 2);
        }


        void allFibMemo(int n)
        {
            int[] memo = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + ": " + fib(i, memo));
            }
        }

        int fib(int n, int[] memo)
        {
            if (n <= 0) return 0;
            else if (n == 1) return 1;
            else if (memo[n] > 0) return memo[n];

            memo[n] = fib(n - 1, memo) + fib(n - 2, memo);

            return memo[n];
        }

        public static void RunFibonacciSeries()
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Find(i));
            }
            Console.ReadKey();
        }

        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
    }
}
