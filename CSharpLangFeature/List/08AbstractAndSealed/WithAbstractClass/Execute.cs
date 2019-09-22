using System;

namespace CSharpLangFeature.List.AbstractAndSealed.WithAbstractClass
{
    public static class Execute
    {
        public static void AbstractClass()
        {
            FullTimeEmployee _FullTimeEmployee = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "David",
                LastName = "Pie",
                AnnualSalary = 60000
            };

            Console.WriteLine(_FullTimeEmployee.GetFullName());
            Console.WriteLine(_FullTimeEmployee.GetMonthlySalary());

            Console.WriteLine("-------------");

            ContractEmployee _ContractEmployee = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Pitter",
                LastName = "Ben",
                HourlyPay = 100,
                TotalHoursWorked = 40
            };

            Console.WriteLine(_ContractEmployee.GetFullName());
            Console.WriteLine(_ContractEmployee.GetMonthlySalary());
        }
    }
}
