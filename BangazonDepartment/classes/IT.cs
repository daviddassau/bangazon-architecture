using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartment.classes
{
    class IT : Department
    {

        public string Skillz { get; set; }

        public void Developers()
        {
            Console.WriteLine($"Out developers need to know the {Skillz} language in order to do their job well.");
        }

        public override void SetBudget(double budget)
        {
            Budget = budget + 50000;
            Console.WriteLine($"This is the budget for the IT department: ${Budget}");
        }

    }
}
