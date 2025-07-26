using Assignment.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question (1)
            Employee emp = new Employee(
            id: 1,
            name: "Ahmed Ahmed",
            gender: 'M',
            security: SecurityLevel.Developer,
            salary: 15000,
            hireDate: new DateTime(2025, 10, 10)
        );

            Console.WriteLine(emp);
        }
    }
}
