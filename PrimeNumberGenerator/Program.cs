using System;

namespace Extreme.Numerics.QuickStart.CSharp
{
    // We use many classes from the Extreme.Mathematics.SpecialFunctions 
    // namespace.
    using Extreme.Mathematics;
    using System.Collections.Generic;

    /// <summary>
    /// Illustrates working with prime numbers using the 
    /// IntegerMath class in the Extreme.Mathematics.SpecialFunctions 
    /// namespace of the Extreme Optimization Mathematics 
    /// Library for .NET.
    /// </summary>
    class PrimeNumbers
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //
            // Factoring numbers
            //

            // The Factorize method returns an array containing the prime factors:
            int index;

            //List<long> GetPrimesSequential(long first, long last);
           // List<long> GetPrimesParallel(long first, long last);

            int n = 1001110110;
            int[] factors = IntegerMath.Factorize(n);
            Console.Write("{0} = {1}", n, factors[0]);
            for (index = 1; index < factors.Length; index++)
                Console.Write(" * {0}", factors[index]);
            Console.WriteLine();

            // Factors that occur multiple times is repeated as many times as necessary:
            n = 256 * 6157413;
            factors = IntegerMath.Factorize(n);
            Console.Write("{0} = {1}", n, factors[0]);
            for (index = 1; index < factors.Length; index++)
                Console.Write(" * {0}", factors[index]);
            Console.WriteLine();

            // The 64bit version can safely factor numbers up to 48 bits long:
            long n2 = 1296523 * 1177157L;
            long[] factors2 = IntegerMath.Factorize(n2);
            Console.Write("{0} = {1}", n2, factors2[0]);
            for (index = 1; index < factors2.Length; index++)
                Console.Write(" * {0}", factors2[index]);
            Console.WriteLine();

            //
            // Prime numbers
            //

            // The IsPrime method verifies if a number is prime or not.
            n = 801853937;
            Console.WriteLine("{0} is prime? {1}!", n, IntegerMath.IsPrime(n));
            n = 801853939;
            Console.WriteLine("{0} is prime? {1}!", n, IntegerMath.IsPrime(n));

            // MextPrime gets the first prime after a specified number. 
            // You can call it repeatedly to get successive primes.
            // Let//s get the 10 smallest primes larger than one billion:
            n = 1000000000;
            Console.WriteLine("\nFirst 10 primes greater than 1 billion:");
            for (index = 0; index < 10; index++)
            {
                n = IntegerMath.NextPrime(n);
                Console.Write("{0,16}", n);
            }
            Console.WriteLine();

            // PreviousPrime gets the last prime before a specified number. 
            n = 1000000000;
            Console.WriteLine("Last 10 primes less than 1 billion:");
            for (index = 0; index < 10; index++)
            {
                n = IntegerMath.PreviousPrime(n);
                Console.Write("{0,16}", n);
            }
            Console.WriteLine();

            Console.Write("Press Enter key to exit...");
            Console.ReadLine();
        }
    }
}