﻿using System;
namespace DotNerPractise
{
	public class async_await
	{
		public static async Task Method1()
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 100; i++)
				{
					Console.WriteLine("Method 1");
				}
			}
			);
		}
		public static void Method2()
		{
			for (int i=0;i < 25; i++)
			{
				Console.WriteLine("Method2");
			}
		}
		public static void Main(string[] args)
		{
			Method1();
			Method2();
			Console.ReadKey();

		}
	}
}

