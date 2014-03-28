using System;

namespace Moduler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the 1st number : ");
			int num1 = int.Parse (Console.ReadLine ()); 
			Console.Write ("Enter the 2nd number : ");
			int num2 = int.Parse (Console.ReadLine ());
			Console.Write ("Enter the operation(/, % are allowed) : ");
			//Console.Write ("{0} / {1} = {2}, {0} % {1} = {3}", num1, num2, num1 / num2, num1 % num2);
			// 정수형 나눗셈은 반올림을 안함
			string operation = Console.ReadLine ();
			if (operation == "/") {
				Console.Write ("{0} / {1} = {2}", num1, num2, num1 / num2);
			}else if (operation == "%") {
					Console.Write ("{0} % {1} = {2}", num1, num2, num1 % num2);
			}else{
				Console.Write ("You entered invalid operation, \"{0}\". Only / and % are allowed.", operation);
			}
		}
	}
}
