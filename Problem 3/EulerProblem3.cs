/*
 *  Sean Crane   
 *  June 16, 2013
 *  
 *  ProjectEuler.net 
 *  Problem #3 - Larget Prime Factor
 *  What is the largest prime factor of the number 600851475143?
 *  
 *  Using Sieve of Eratosthenes algorithm - http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
 */
using System;

namespace ProjectEuler_03
{
    // Global Variables
    public static class Globals
    {
        public static ulong PRIME_NUMBER_MAX = 600851475143; // If using a smaller prime number that is not limited by 2GB use this inplace of PRIME_NUMBER_FACTOR_SHORTENED. 
        public static ulong PRIME_NUMBER_FACTOR_SHORTENED = 1000000; // C Sharp array size limit is 2GB. 600 Billion exceeds that. Put it slighty above the squareroot.
        public static ulong PRIME_NUMBER_SQRT = (ulong)Math.Sqrt(PRIME_NUMBER_MAX);
        public static bool[] primeNumbers = new bool[PRIME_NUMBER_FACTOR_SHORTENED];
    }

    public class PrimeFactor
    {
        // Determines which numbers are prime numbers.
        public static void DeterminePrime()
        {
            // Initialize array to true. 
            for (ulong i = 0; i < Globals.PRIME_NUMBER_FACTOR_SHORTENED; ++i)
            {
                Globals.primeNumbers[i] = true;
            }

            // Sieve of Eratosthenes algorithm
            for (ulong i = 2; i < Globals.PRIME_NUMBER_SQRT; ++i)
            {
                if (Globals.primeNumbers[i])
                {
                    for (ulong j = i * i; j < Globals.PRIME_NUMBER_FACTOR_SHORTENED; j = j + i)
                    {
                        Globals.primeNumbers[j] = false; 
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            DeterminePrime();

            // Euler Problem 3 - Determine largest prime factor of the number 600851475143.
            ulong largestPrimeFactor = 0;
            for (ulong i = 2; i < Globals.PRIME_NUMBER_FACTOR_SHORTENED; ++i)
            {
                if (Globals.primeNumbers[i] == true && Globals.PRIME_NUMBER_MAX % i == 0) 
                largestPrimeFactor = i;
            }

            Console.WriteLine("The largest prime factor of the number 600851475143 is: " + largestPrimeFactor);
        }
    }
}
