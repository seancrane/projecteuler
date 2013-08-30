/*
 * Sean Crane 
 * August 30, 2013
 * 
 * ProjectEuler.net
 * Problem #6 - Sum Square Difference
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

package eulerSumSquare;

import java.lang.Math; 

public class EulerProject6 {
	
	// CONSTANTS
	interface Constants
	{
		//Find the max number to find the square of sums and sum of squares from 1 to NATURAL_NUMBER_RANGE.
		public static final int NATURAL_NUMBER_RANGE = 100;
	}
	
	// Find the sum of the squares
	// 		EX: First 5 numbers sumOfSquares = (1^2 + 2^2 + 3^2 + 4^2 + 5^2)
	public static int sumOfSquares(int maxNumber)
	{
		int sum = 0; 
		for(int i = 1; i <= maxNumber; ++i)
		{
			sum += Math.pow(i, 2);
		}
		return sum; 
	}
	
	// Find the square of the sum
	// 		EX: First 5 numbers suqareOfSums = (1 + 2 + 3 + 4 + 5)^2
	public static int squareOfSums(int maxNumber)
	{
		int sum = 0; 
		for(int i = 1; i <= maxNumber; ++i)
		{
			sum += i; 
		}
		return (int) Math.pow(sum, 2);
		
	}
	
	// Main Function
	public static void main(String [] args)
	{
		int sumSquares = 0; // Sum of Squares variable.
		int squareSums = 0; // Square of Sums variable. 
		
		sumSquares = EulerProject6.sumOfSquares(Constants.NATURAL_NUMBER_RANGE);
		squareSums = EulerProject6.squareOfSums(Constants.NATURAL_NUMBER_RANGE);
		
		// Euler Problem 6 - The difference between the Square of Sums and Sum of Squares. 
		int differenceOfSums = squareSums - sumSquares; 
		
		// Print out the values. 
		System.out.println("Sum of Squares for 1 to " + Constants.NATURAL_NUMBER_RANGE + " is: " + sumSquares);
		System.out.println("Square of sums for 1 to " + Constants.NATURAL_NUMBER_RANGE + " is: " + squareSums);
		System.out.println("Difference of Squares is: " + squareSums + " - " + sumSquares + " = " + differenceOfSums );		
	}
}

