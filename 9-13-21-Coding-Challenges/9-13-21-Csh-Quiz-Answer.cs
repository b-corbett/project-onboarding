using System;
using System.Collections.Generic;

// with help from:
// https://stackoverflow.com/questions/239865/best-way-to-find-all-factors-of-a-given-number

namespace _9_13_21_Csh_Quiz_Answer
{
  class Program
  {
    static string ExpressFactors(int num_to_factor)
    {
      string factor_expression = "";  // adding trivial factor, optional
      int num_to_factor_cp = num_to_factor;
      int i = 2;
      while (num_to_factor_cp > 1)
      {
        if (num_to_factor_cp % i == 0)
        {
          factor_expression += i.ToString() + " * ";
          num_to_factor_cp /= i;
        }
        else i++;
      }
      // factor_expression.Add(num_to_factor);   // adding trivial factor, optional
      return factor_expression.Substring(0, factor_expression.Length - 3);
    }

    static void Main(string[] args)
    {
      Console.Write("Enter a number greater than 1: ");
      string console_input = Console.ReadLine();
      int int_input;

      bool successful = Int32.TryParse(console_input, out int_input);
      if (successful && int_input > 1)
      {
        Console.Write("The factorization for " + console_input + " is: ");
        Console.WriteLine(ExpressFactors(int_input));
      }
      Console.ReadLine();
    }
  }
}
