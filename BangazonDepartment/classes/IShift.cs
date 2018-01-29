using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartment.classes
{
    interface IShift
    {
        string SalaryHourlyCommission { get; }

        void Salary(string salary);
        void Hourly(string hourly);
        void Commission(string commission);
    }
}
