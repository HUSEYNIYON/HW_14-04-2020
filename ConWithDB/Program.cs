
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Welcome to Human Resources Department. Choose a command:\n1-EmployeeInfo\n2-InfoByID\n3-Insert new Employee\n4-Delete an Employee\n5-Update an Information");
        l1:
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Information about Employees");
            switch (n)
            {
                case 1:
                    person.GetPerson();
                    break;
                case 2:
                    Console.Write("Input ID of Employee: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    person.GetPersonById(Id);
                    break;
                case 3:
                    Console.Write("LastName of Employee:");
                    string lname = Console.ReadLine();
                    Console.Write("FirstName of Employee:");
                    string fname = Console.ReadLine();
                    Console.Write("MiddleName of Employee:");
                    string Mname = Console.ReadLine();
                    Console.WriteLine("BirthDate of Employee:");
                    DateTime birthd = DateTime.Now;
                    person.PutInfoEmployees(lname,fname,Mname,birthd);
                    break;
                case 4:
                    Console.Write("ID of an Employee: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    person.DeletePersonInfo(id);
                    break;
                case 5:
                    Console.WriteLine("Enter an ID to update: ");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter LastName:");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter FirsName:");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter MiddleName:");
                    string MiddleName = Console.ReadLine();
                    Console.WriteLine("Enter a BirthDate:");
                    DateTime BirthDate = Convert.ToDateTime(Console.ReadLine());
                    person.UpdatePerson(ID, LastName, FirstName, MiddleName, BirthDate);
                    break;
                default:
                    Console.Write("Out of range! Choose in the interval 1-5");
                    break;
            }
            goto l1;
        }
    }
}
