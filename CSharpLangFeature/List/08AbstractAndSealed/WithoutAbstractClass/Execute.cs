using System;

namespace CSharpLangFeature.List.AbstractAndSealed.WithoutAbstractClass
{
    public static class Execute
    {
        public static void WithoutAbstractClass()
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "James",
                LastName = "Cameron",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

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
