using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    // Question (1)
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Gender must be 'M' or 'F'");
            }
        }
        public SecurityLevel Security { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public Employee(int id, string name, char gender, SecurityLevel security, double salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {(Gender == 'M' ? "Male" : "Female")}\n" +
                   $"Security Level: {Security}\n" +
                   $"Salary: {Salary}\n" +
                   $"Hire Date: {HireDate}";
        }

    }
}
