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
            first_name = FName;
            last_name = LName;
            department = dept;
            job_title = job;
            basic_salary = 0;
        }

        public string FirstName
        {
            get { return first_name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be empty.");
                first_name = value;
            }
        }

        public string LastName
        {
            get { return last_name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                last_name = value;
            }
        }

        public string Department
        {
            get { return department; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Department cannot be empty.");
                department = value;
            }
        }

        public string JobTitle
        {
            get { return job_title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Job title cannot be empty.");
                job_title = value;
            }
        }

        public double BasicSalary
        {
            get { return basic_salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Basic salary cannot be negative.");
                basic_salary = value;
            }
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            if (hoursWorked < 0)
                throw new ArgumentException("Hours worked cannot be negative.");
            if (ratePerHour <= 0)
                throw new ArgumentException("Rate per hour must be greater than zero.");

            basic_salary = hoursWorked * ratePerHour;
        }

        public double GetSalary()
        {
            return basic_salary;
        }
    }
}
