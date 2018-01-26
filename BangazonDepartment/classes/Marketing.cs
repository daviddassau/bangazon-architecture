using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartment.classes
{
    class Marketing : Department
    {

        public int FacebookAdCampaignsSold { get; set; }

        public void FacebookAdCampaigns()
        {
            Console.WriteLine($"The marketing department has sold {FacebookAdCampaignsSold} Facebook Ad Campaigns so far this year.");
        }

        public override void Department_Description()
        {
            FacebookAdCampaignsSold += 15;
            base.Department_Description();
        }

        public override void SetBudget(double budget)
        {
            Budget = budget + 2000;
            Console.WriteLine($"This is the budget for the marketing department: ${Budget}");
        }

    }
}
