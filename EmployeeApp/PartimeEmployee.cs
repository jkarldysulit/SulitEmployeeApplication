using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;
namespace EmployeeApplication
{

    public class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept;
            this.job_title = job;
        }

        public void computeSalary()
        {
            Console.WriteLine("Enter the number of hours worked: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate per hour: ");
            double rateHour = Convert.ToDouble(Console.ReadLine());

            basic_salary = hoursWorked * rateHour;
        }

        public double GetSalary()
        {
            return basic_salary;
        }

        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public string Department { get => department; set => department = value; }
        public string JobTitle { get => job_title; set => job_title = value; }
        public double BasicSalary { get => basic_salary; set => basic_salary = value; }

        public void ComputeSalary(IEmployee employee, int hoursWorked, double rateHour)
        {
            employee.BasicSalary = hoursWorked * rateHour;
        }
    }

    public static class EmployeeExtensions
    {
        public static void ComputeSalary(this IEmployee employee, int hoursWorked, double rateHour)
        {
            employee.BasicSalary = hoursWorked * rateHour;
        }
    }
}
