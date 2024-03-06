//using System;
//namespace DotNerPractise
//{
//	public class LINQ_example2
//	{
//		public class Student
//		{
//			public int StudentID { get; set; }
//			public string StudentName{ get; set; }
//			public int Age { get; set; }
//		}
//		public static void Main(string[] args)
//		{
//			IList<Student> studentList = new List<Student>()
//			{
//				new Student() {StudentID =1, StudentName = "John", Age = 13 },
//                new Student() {StudentID =2, StudentName = "Bill", Age = 21 },
//                new Student() {StudentID =3, StudentName = "Moin", Age = 18 },
//                new Student() {StudentID =4, StudentName = "Ram", Age = 20},
//                new Student() {StudentID =5,StudentName = "Ron", Age = 15 }
//            };

//			var teenageStudent = from s in studentList
//								 where s.Age > 12 && s.Age < 20
//								 select s;
//			Console.WriteLine("Teen age Students:");

//			foreach(Student std in teenageStudent)
//			{
//				Console.WriteLine(std.StudentName);
//			}
//			Console.ReadKey();

//		}
//	}
//}

