using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public abstract class Payroll
    {
        private string _employeeId;
        private string _firstName;
        private string _lastName;
        private string _position;

        public string EmployeeId
        {
            get { return _employeeId; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Employee ID cannot be empty.");
                _employeeId = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be empty.");
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                _lastName = value;
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Position cannot be empty.");
                _position = value;
            }
        }

        public string FullName => $"{_firstName} {_lastName}";

        public Payroll(string employeeId, string firstName, string lastName, string position)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public abstract double ComputeGrossPay();

        public virtual double ComputeTax()
        {
            double gross = ComputeGrossPay();
            if (gross <= 10000) return gross * 0.10;
            else if (gross <= 30000) return gross * 0.15;
            else return gross * 0.20;
        }

        public virtual double ComputeSSS() => 500.00;
        public virtual double ComputePhilHealth() => 300.00;
        public virtual double ComputePagIbig() => 200.00;

        public double ComputeTotalDeductions()
        {
            return ComputeTax() + ComputeSSS() + ComputePhilHealth() + ComputePagIbig();
        }

        public double ComputeNetPay()
        {
            return ComputeGrossPay() - ComputeTotalDeductions();
        }

        public override string ToString()
        {
            return $"[{EmployeeId}] {FullName} — {Position}";
        }
    }

    public class FullTime : Payroll
    {
        private double _monthlyRate;
        private int _overtimeHours;
        private double _overtimeRatePerHour;

        public double MonthlyRate
        {
            get { return _monthlyRate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Monthly rate must be greater than zero.");
                _monthlyRate = value;
            }
        }

        public int OvertimeHours
        {
            get { return _overtimeHours; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Overtime hours cannot be negative.");
                _overtimeHours = value;
            }
        }

        public double OvertimeRatePerHour
        {
            get { return _overtimeRatePerHour; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Overtime rate cannot be negative.");
                _overtimeRatePerHour = value;
            }
        }

        public FullTime(string employeeId, string firstName, string lastName,
                        string position, double monthlyRate,
                        int overtimeHours = 0, double overtimeRatePerHour = 0)
            : base(employeeId, firstName, lastName, position)
        {
            MonthlyRate = monthlyRate;
            OvertimeHours = overtimeHours;
            OvertimeRatePerHour = overtimeRatePerHour;
        }

        public override double ComputeGrossPay()
        {
            double overtimePay = _overtimeHours * _overtimeRatePerHour;
            return _monthlyRate + overtimePay;
        }

        public double OvertimePay => _overtimeHours * _overtimeRatePerHour;

        public string EmployeeType => "Full-Time";
    }

    public class PartTime : Payroll
    {
        private double _hourlyRate;
        private int _hoursWorked;

        public double HourlyRate
        {
            get { return _hourlyRate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Hourly rate must be greater than zero.");
                _hourlyRate = value;
            }
        }

        public int HoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Hours worked cannot be negative.");
                if (value > 744)
                    throw new ArgumentException("Hours worked cannot exceed 744 hours/month.");
                _hoursWorked = value;
            }
        }

        public PartTime(string employeeId, string firstName, string lastName,
                        string position, double hourlyRate, int hoursWorked)
            : base(employeeId, firstName, lastName, position)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double ComputeGrossPay()
        {
            return _hourlyRate * _hoursWorked;
        }

        public override double ComputeSSS() => 250.00;
        public override double ComputePhilHealth() => 150.00;
        public override double ComputePagIbig() => 100.00;

        public string EmployeeType => "Part-Time";
    }
}
