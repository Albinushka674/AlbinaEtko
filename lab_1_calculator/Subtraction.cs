﻿using System;

namespace lab.one.calculator
{
	public class Subtraction : IOperation
	{
		public double Calculate(double double1, double double2)
		{
			return double1 - double2;
		}
	}
}