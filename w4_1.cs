using System;

namespace w4_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the 1st no: ");
			int num1 = int.Parse (Console.ReadLine ());
			Console.Write ("Enter the 2nd no: ");
			int num2 = int.Parse (Console.ReadLine ());
			Console.Write ("Enter the Operation +, -, *, /, %: ");
			string operation = Console.ReadLine ();

			if(operation == "+"){
				Console.Write ("{0} + {1} = {2}", num1, num2, num1 + num2);
			}else if(operation == "-"){
				Console.Write ("{0} - {1} = {2}", num1, num2, num1 - num2);
			}else if(operation == "*"){
				Console.Write ("{0} * {1} = {2}", num1, num2, num1 * num2);
			}else if(operation == "/"){
				Console.Write ("{0} / {1} = {2}", num1, num2, num1 / num2);
			}else if(operation == "%"){
				Console.Write ("{0} % {1} = {2}", num1, num2, num1 % num2);
			}else{Console.Write ("You entered invalid operation \"{0}\".", operation);
			}
		}
	}
}
