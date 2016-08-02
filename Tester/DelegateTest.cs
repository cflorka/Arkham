using System;
using System.Collections.Generic;
namespace SimpleEvent
{
	public delegate int Calculator(int x, int y);
	
	public class tester
	{
		public static List<Calculator> calcs = new List<Calculator>();
		
		public static void Main()
		{
			int a = 2;
			int b = 3;
			
			calcs.Add(OtherClass.AddInts);
			Calculator minus = (x,y) => y-x;
			calcs.Add(minus);
			calcs.Add((x,y) => x-y);
			calcs.Add((x,y) => x*y);
			calcs.Add((x,y) => x/y);
			calcs.Remove(minus);
			foreach(Calculator calc in calcs)
			{
				Console.WriteLine("Calc is: " + calc(a,b));
			}
		}
	}
}