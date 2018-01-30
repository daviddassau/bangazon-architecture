using System;
using System.Collections.Generic;
using BangazonDepartment.classes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartment
{
    class Program
    {
        public static void Main()
        {

            var sales = new Sales
            {
                Name = "Sales",
                Supervisor = "Mark",
                Employee_Count = 24,
                SalesCompleted = 0,
                MeetingPlace = "Starbucks"
            };

            var marketing = new Marketing
            {
                Name = "Marketing",
                Supervisor = "Jennifer",
                Employee_Count = 10,
                FacebookAdCampaignsSold = 12,
                MeetingPlace = "Panera Bread"
            };

            var it = new IT
            {
                Name = "IT/Development",
                Supervisor = "Ringo",
                Employee_Count = 16,
                Skillz = "C#",
                MeetingPlace = "Think Tank #1"
            };

            var Departments = new List<Department>
            {
                sales,
                marketing,
                it
            };

            sales.AddEmployee(new Employee { FirstName = "John", LastName = "Bonham" });
            sales.AddEmployee(new Employee { FirstName = "Robert", LastName = "Plant" });
            sales.AddEmployee(new Employee { FirstName = "Jimmy", LastName = "Page" });
            marketing.AddEmployee(new Employee { FirstName = "Jordan", LastName = "Pudnick" });
            marketing.AddEmployee(new Employee { FirstName = "Chad", LastName = "Gilbert" });
            marketing.AddEmployee(new Employee { FirstName = "Ian", LastName = "Grushka" });
            it.AddEmployee(new Employee { FirstName = "Paul", LastName = "McCartney" });
            it.AddEmployee(new Employee { FirstName = "John", LastName = "Lenon" });
            it.AddEmployee(new Employee { FirstName = "George", LastName = "Harrison" });

            


            foreach (var department in Departments)
            {

                switch (department)
                {
                    case Sales s:
                        s.Department_Description();
                        s.SalesGoals();
                        s.SetMeetingPlace();
                        s.SetBudget(55000);
                        s.Commission("commission");
                        break;
                    case Marketing m:
                        m.Department_Description();
                        m.FacebookAdCampaigns();
                        m.SetMeetingPlace();
                        m.SetBudget(55000);
                        m.Hourly("hourly");
                        break;
                    case IT i:
                        i.Department_Description();
                        i.Developers();
                        i.SetMeetingPlace();
                        i.SetBudget(55000);
                        i.Salary("salary");
                        break;
                    default:
                        break;
                }
            }


            foreach (var department in Departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}");
                }
            }





            Console.ReadLine();

        }
    }
}
