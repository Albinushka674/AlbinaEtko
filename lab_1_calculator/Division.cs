using System;
namespace lab.one.calculator
{
	public class Division : IOperation
	{
		public double Calculate(double double1, double double2)
		{
			if (double2 == 0.0d)
			{
                throw new ArithmeticException("Can't device by 0.");
			}

			return double1 / double2;
		}
	}
}

