using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartment.classes
{
    class Sales : Department
    {

        public int SalesCompleted { get; set; }

        public void SalesGoals()
        {
            Console.WriteLine($"The sales department has made {SalesCompleted} sales so far this year.");
        }

        public override void Department_Description()
        {
            SalesCompleted += 30;
            base.Department_Description();
        }

        public override void SetBudget(double budget)
        {
            Budget = budget + 30000;
            Console.WriteLine($"This is the budget for the sales department: ${Budget}");
        }

    }
}
