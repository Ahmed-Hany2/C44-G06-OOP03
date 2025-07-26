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

            // Question (3)
            Employee[] EmpArr =
            {
                new Employee(
                id: 1,
                name: "Ahmed Ahmed",
                gender: 'M',
                salary: 12000,
                security: SecurityLevel.DBA,
                hireDate: new HiringDate(2, 2, 2022)
            ),
            new Employee(
            id: 2,
            name: "Ali Omar",
            gender: 'M',
            salary: 13000,
            security: SecurityLevel.DBA,
            hireDate: new HiringDate(10, 5, 2022)
            ),
            new Employee(
            id: 3,
            name: "Sara Ahmed",
            gender: 'F',
            salary: 8000,
            security: SecurityLevel.Guest,
            hireDate: new HiringDate(1, 1, 2023)
        )
        };

            Console.WriteLine("==================== Employees ================\n");
            foreach (var empolyee in EmpArr)
            {
                Console.WriteLine(empolyee);
                Console.WriteLine("----------------------------------------------");
            }



        }
    }
}
