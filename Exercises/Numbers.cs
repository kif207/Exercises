using System;

namespace Exercises
{
    class Numbers
    {
        public static bool isPrime(int n)
        {
            for (int x = 2; x * x <= n; x++)
            {
                if (n % x == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isPrime2(int n)
        {
            for (int x = 2; x <= Math.Sqrt(n); x++)
            {
                if (n % x == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int factorial(int n)
        {
            if (n < 0) return -1;
            else if (n == 0) return 1;
            else return n * factorial(n - 1);
        }

        int powers0f2(int n)
        {
            if (n < 1)
            {
                return 0;
            }
            else if (n == 1)
            {
                Console.Write(1);
                return 1;
            }
            else
            {
                int prev = powers0f2(n / 2);
                int curr = prev * 2;
                Console.Write(curr);
                return curr;
            }
        }

        int product(int a, int b)
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
            }
            return sum;
        }

        int power(int a, int b)
        {
            if (b < 0)
            {
                return 0;
            }
            else if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * power(a, b - 1);
            }
        }

        int mod(int a, int b)
        {
            if (b <= 0)
            {
                return -1;
            }
            int div = a / b;
            return a - div * b;
        }

        int div(int a, int b)
        {
            int count = 0;
            int sum = b;
            while (sum <= a)
            {
                sum += b;
                count++;
            }
            return count;
        }

        int sumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}