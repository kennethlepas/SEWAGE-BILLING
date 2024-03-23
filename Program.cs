using System;

namespace SewerageBillCalculator
{
  class Program
  {
    static void Main(string[] args)
    { 
      Console.Write("Enter water usage in cubic meters: ");
      double usage;
      if(!double.TryParse(Console.ReadLine(), out usage)) {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
      }

      Console.Write("Select usage type (1 for Residential, 2 for Commercial, 3 for Industrial): ");
      int type;
      if(!int.TryParse(Console.ReadLine(), out type)) {
        Console.WriteLine("Invalid input. Please select 1, 2 or 3.");
        return;
      }

      double rate;
      if(type == 1) {
        rate = 10.0;  
      }
      else if(type == 2) {
        rate = 12.5;
      }
      else if(type == 3) {
        rate = 15.0;
      }
      else {
        Console.WriteLine("Invalid usage type. Please select 1, 2 or 3.");
        return;
      }

      double bill = usage * rate;

      Console.WriteLine($"Monthly sewerage bill for {usage} cubic meters at {rate}/cubic meter: Ksh {bill}");
    }
  }
}