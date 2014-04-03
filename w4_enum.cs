using System;

namespace Enum
{
	class MainClass
	{
		enum DayOfWeek {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY}

		public static void Main (string[] args)
		{

			Console.Write("Enter your number: ");
			int number = int.Parse(Console.ReadLine());

			switch (number) {
			case (int)DayOfWeek.SUNDAY:
				Console.WriteLine ("Sun");
				break;
			case (int)DayOfWeek.MONDAY:
				Console.WriteLine ("Moon");
				break;
			case (int)DayOfWeek.TUESDAY:
				Console.WriteLine ("Mars");
				break;
			case (int)DayOfWeek.WEDNESDAY:
				Console.WriteLine ("Mercury");
				break;
			case (int)DayOfWeek.THURSDAY:
				Console.WriteLine ("Jupitor");
				break;
			case (int)DayOfWeek.FRIDAY:
				Console.WriteLine ("Venus");
				break;
			case (int)DayOfWeek.SATURDAY:
				Console.WriteLine ("Saturn");
				break;
			}
		}
	}
}
