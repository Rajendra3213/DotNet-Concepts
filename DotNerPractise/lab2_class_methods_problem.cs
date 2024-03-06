//using System;

//namespace Lab
//{
//    class Program
//    {

//        class Employee
//        {
//            private string firstName;
//            private string lastName;
//            private double salary;

//            public string FirstName
//            {
//                get { return firstName; }
//                set { firstName = value; }
//            }

//            public string LastName
//            {
//                get { return lastName; }
//                set { lastName = value; }
//            }

//            public double Salary
//            {
//                get { return salary; }
//                set { salary = value; }
//            }

//            public Employee(string firstName, string lastName, double s)
//            {
//               FirstName = firstName;
//               LastName = lastName;
//               Salary = s;
//            }

//            public void ShowFullName()
//            {
//                Console.WriteLine(FirstName + " " + LastName);
//            }

//            public void IncrementSalary()
//            {
//                Salary += 5000;
//                Console.WriteLine("Salary: " + Salary);
//            }
//        }

//        static void Main(string[] args)
//        {
//            Employee employee1 = new Employee("Ram", "Bahadur", 20000);
//            employee1.ShowFullName();
//            employee1.IncrementSalary();
//            employee1.FirstName = "Hari";
//            employee1.ShowFullName();
//            employee1.IncrementSalary(); 
//            Console.ReadKey();
//        }

//    }
//}