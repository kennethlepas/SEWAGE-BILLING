Sewerage Bill Calculator
This console application estimates monthly sewerage bills based on water usage for residential, commercial, and industrial customers.

Usage
To use the application:

Run the executable file.
Enter total water usage in cubic meters for the month.
Select usage type by entering: 1 for Residential 2 for Commercial
3 for Industrial
The application will calculate and display the estimated sewerage bill.
Sample usage:

Enter water usage in cubic meters: 45
Select usage type (1 for Residential, 2 for Commercial, 3 for Industrial): 2

Monthly sewerage bill for 45 cubic meters at 12.5/cubic meter: Ksh 562.5

Enter water usage in cubic meters: 45
Select usage type (1 for Residential, 2 for Commercial, 3 for Industrial): 2

Monthly sewerage bill for 45 cubic meters at 12.5/cubic meter: Ksh 562.5
Sewerage Rates
The sewerage rates per cubic meter are:

Residential: Ksh 10
Commercial: Ksh 12.50
Industrial: Ksh 15
Error Handling
The application validates inputs and displays error messages for invalid data:

Non-numeric usage values
Out of range usage type selections
Files
SewerageBillCalculator.cs - Main C# source code
This application calculates sewerage bills based on water usage and fixed rates per cubic meter for different usage types. Feel free to enhance and modify as needed.