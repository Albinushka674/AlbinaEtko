using System;

namespace lab.one.calculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a = -1;
			double double1 = 0.0d;
			double double2 = 0.0d;
			var printer = new Printer();
			while (a != 0)
			{
				try
				{
					Console.WriteLine("Enter command:\n1 - addiction\n2 - subtraction\n3 - multiplication\n4 - division");
					String newLine = Console.ReadLine();
					a = Int32.Parse(newLine);

					Console.WriteLine("Enter first double:");
					newLine = Console.ReadLine();
					double1 = Double.Parse(newLine);

					Console.WriteLine("Enter second double:");
					newLine = Console.ReadLine();
					double2 = Double.Parse(newLine);

					IOperation operation = null;
					switch (a)
					{
						case 1:
							operation = new Addiction();
							break;

						case 2:
							operation = new Subtraction();
							break;

						case 3:
							operation = new Multiplication();
							break;

						case 4:
							operation = new Division();
							break;

						default:
							break;
					}

					if (operation != null)
					{
						printer.Print(operation, double1, double2);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
	}
}