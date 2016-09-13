using System;

namespace lab.one.calculator
{
	public class Printer : IPrinter
	{
		public void Print(IOperation operation, double double1, double double2)
		{
			Console.WriteLine("Result: " + operation.Calculate(double1, double2));
		}
	}
}