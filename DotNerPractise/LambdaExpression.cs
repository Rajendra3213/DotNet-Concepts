using System;
namespace DotNerPractise
{
	public class LambdaExpression
	{
		public static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
			//lambda expression
			var square = numbers.Select(x => x * x);
			Console.Write("Squares: ");
			foreach (var value in square)
			{
				Console.Write("{0} ", value);
			}
			Console.ReadKey();
		}
	}
}

