//using System;
//namespace DotNerPractise
//{
//	public class inheritance_example
//	{
//		//parent class
//	 class Vehicle
//		{
//			//data types
//			private string make;
//			private string model;
//			private int year;

//			//properties
//			public string Make
//			{
//				get { return make; }
//				set { make = value; }
//			}

//			public string Model
//			{
//				get { return model; }
//				set { model = value; }
//			}
//			public int Year
//			{
//				get { return year; }
//				set { year = value; }
//			}
//			// parent constructor
//			public Vehicle(string make, string model, int year)
//			{
//				Make = make;
//				Model = model;
//				Year = year;
//			}

//			public void showinfo()
//			{
//				Console.WriteLine("Brand: {0}, Model:{1}, Year: {2}", Make, Model, Year);
//			}


//		}

//		class Bike:Vehicle
//		{
//			private int no_of_wheel;
//			public int No_of_wheel
//			{
//				get
//				{
//					return no_of_wheel;
//				}
//				set
//				{
//					no_of_wheel = value;
//				}
//			}
//			public Bike(string make, string model, int year, int numwheels): base( make,model,year)
//			{
//				no_of_wheel = numwheels;

//			}

//			public void showinfo()
//			{
//				Console.WriteLine($"{Make},{Model},{Year},{No_of_wheel}");
//			}


//		}

//		public static void Main(string[] args)
//		{
//			Bike c1 = new Bike("Yamaha", "Fzs", 2022, 2);
//			c1.showinfo();
//			((Vehicle)c1).showinfo();
//			Console.ReadKey();

//		}
//	}
//}

