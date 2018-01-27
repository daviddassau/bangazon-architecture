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

            foreach (var department in Departments)
            {
                department.Department_Description();
                department.SetMeetingPlace();
                department.SetBudget(55000);

                switch (department)
                {
                    case Sales s:
                        s.SalesGoals();
                        break;
                    case Marketing m:
                        m.FacebookAdCampaigns();
                        break;
                    case IT m:
                        m.Developers();
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
