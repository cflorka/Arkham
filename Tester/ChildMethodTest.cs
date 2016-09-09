using System;

namespace ChildMethodTest
{
	public class Parent
	{
		public virtual void Talk(){Console.WriteLine("I is parent.");}
	}

	public class Child : Parent
	{
		public override void Talk(){Console.WriteLine("I is child.");}
	}

	public class Driver
	{
		public static void Main()
		{
			Parent parent = new Parent();
			Parent childAsParent = new Child();
			Child childAsChild = new Child();
			
			parent.Talk();
			childAsParent.Talk();
			childAsChild.Talk();
		}
	}
}