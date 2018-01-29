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

            var Departments = new List<IShift>
            {
                sales,
                marketing,
                it
            };

            foreach (var department in Departments)
            {
                //if (department is Marketing depMarketing)
                //{
                //    depMarketing.Department_Description();
                //}
                //if (department is Sales depSales)
                //{
                //    depSales.Department_Description();
                //}
                //if (department is IT depIT)
                //{
                //    depIT.Department_Description();
                //}

                //if (department is Marketing marketingMeetingPlace)
                //{
                //    marketingMeetingPlace.SetMeetingPlace();
                //}
                //if (department is Sales salesMeetingPlace)
                //{
                //    salesMeetingPlace.SetMeetingPlace();
                //}
                //if (department is IT itMeetingPlace)
                //{
                //    itMeetingPlace.SetMeetingPlace();
                //}

                //if (department is Marketing marketingBudget)
                //{
                //    marketingBudget.SetBudget(55000);
                //}
                //if (department is Sales salesBudget)
                //{
                //    salesBudget.SetBudget(55000);
                //}
                //if (department is IT itBudget)
                //{
                //    itBudget.SetBudget(55000);
                //}


                //department.Salary("string");
                //department.Hourly("string");
                //department.Commission("string");


                switch (department)
                {
                    case Sales s:
                        s.SalesGoals();
                        s.Department_Description();
                        s.SetMeetingPlace();
                        s.SetBudget(55000);
                        s.Commission("string");
                        break;
                    case Marketing m:
                        m.FacebookAdCampaigns();
                        m.Department_Description();
                        m.SetMeetingPlace();
                        m.SetBudget(55000);
                        m.Hourly("string");
                        break;
                    case IT i:
                        i.Developers();
                        i.Department_Description();
                        i.SetMeetingPlace();
                        i.SetBudget(55000);
                        i.Salary("string");
                        break;
                    default:
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
