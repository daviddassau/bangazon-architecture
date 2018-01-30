using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartment.classes
{
    class Department
    {

        List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees { get => _employees; }

        public string Name { get; set; }
        public string Supervisor { get; set; }
        public double Budget { get; set; }
        public int Employee_Count { get; set; }
        public string MeetingPlace { get; set; }

        public virtual void Department_Description()
        {
            Console.WriteLine($"{Supervisor} is the supervisor of the {Name} department, and has {Employee_Count} employees.");
        }

        public virtual void SetBudget(double budget)
        {
            Budget = budget;
            Console.WriteLine($"{Budget} is the budget for this department");
        }

        public virtual void SetMeetingPlace()
        {
            Console.WriteLine($"The {Name} department meets at {MeetingPlace}");
        }


        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

    }
}
