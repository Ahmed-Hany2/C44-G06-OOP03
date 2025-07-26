using Assignment.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question (2)
            HiringDate hireDate = new HiringDate(10, 10, 2025);
            // Question (1)
            Employee emp = new Employee(
            id: 1,
            name: "Ahmed Ahmed",
            gender: 'M',
            security: SecurityLevel.Developer,
            salary: 15000,
            hireDate: hireDate
        );

            Console.WriteLine(emp);
        }
    }
}
