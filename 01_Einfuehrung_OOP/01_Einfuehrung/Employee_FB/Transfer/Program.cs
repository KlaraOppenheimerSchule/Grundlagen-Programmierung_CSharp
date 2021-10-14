using System;
using System.Collections.Generic;

namespace EmployeeClass

{
	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employeeList = new List<Employee>(); //create a list of employees
			Console.WriteLine("input name: ");
			var lastName = Console.ReadLine(); //read input
			Employee employeeObj = new Employee(lastName); //create employee
			employeeList.Add(employeeObj); //add employee to list
			Console.WriteLine(employeeObj.LastName); //writes lastname
			Console.ReadKey();
		}
	}
	public class Employee
	{
		private string _LastName;
		public string LastName { //when we need public get/setters for properties, this is how you would conventionally handle it.
			get { return _LastName; }
			set { _LastName = LastName; }
			}

		public Employee(string lastName)
		{
			this._LastName = lastName;
		}
	}

}
