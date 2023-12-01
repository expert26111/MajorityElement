// See https://aka.ms/new-console-template for more information

// CHECK LINK TO IMPROVE PROGRAMME
// https://tutorialcup.com/leetcode-solutions/majority-element-leetcode-solution.htm

using MajorityElement;
using System;

Console.WriteLine("Hello, World!");
//int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
//int[] nums = { 3, 3, 4 };
//int[] nums = { 3, 3, 4 };
//int[] nums = { 3, 2, 3 };
int[] nums = { 1 };
Solution sol = new Solution();
int solution = sol.MajorityElement(nums);
Console.WriteLine("The majority element is: {0}", solution);