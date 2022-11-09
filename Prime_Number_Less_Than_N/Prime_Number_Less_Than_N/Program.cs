using System;
using System.Collections.Generic;

namespace Prime_Number_Less_Than_N
{

    class Program
    {
        
        
        static void IsPrime(int n,List<int> primes)
        {
            
                foreach (int j in primes)
                {
                    if (n < j * j) break;
                    if (n % j == 0) return; 
                }

            primes.Add(n);
        }
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            Console.WriteLine("Input N");
            int n = Convert.ToInt32(Console.ReadLine());
            //тут можно еще сделать проверку введено ли вообще число
            if (n <= 2) { Console.WriteLine("There is no prime numbers less than n"); return; }
            else
            {

                for (int i = 3; i < n; i += 2)
                {
                    if (i > 10 && i % 10 == 5) continue;
                    IsPrime(i, primes);
                }
            }
            foreach (var item in primes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
