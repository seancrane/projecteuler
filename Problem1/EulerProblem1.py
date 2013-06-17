# Sean Crane 
# June 16, 2013
# 
# ProjectEuler.net
# Problem #1 - Multiples of 3 and 5
# Find the sum of all the multiples of 3 or 5 below 1000.

#!/usr/bin/python

import sys
import argparse

# Find the sum of all multiples of 3 or 5. 
def FindSum(x):
    sum = 0
    for i in range(0,x):
        if i%3 == 0 or i%5 == 0:
            sum = sum + i
    print "The sum of " + str(x) + " is " + str(sum)

parser = argparse.ArgumentParser("Please enter an integer: Ex: python EulerProblem1.py 1000.")
parser.add_argument('Integer', type=int, help="Enter an integer to set the limit to find the multiples of 3 and 5.")

args = parser.parse_args()
FindSum(args.Integer)
