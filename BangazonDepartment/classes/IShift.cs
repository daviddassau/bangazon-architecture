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
