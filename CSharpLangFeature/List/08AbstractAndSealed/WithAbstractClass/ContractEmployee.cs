namespace CSharpLangFeature.List.AbstractAndSealed.WithAbstractClass
{
    public class ContractEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return HourlyPay * this.TotalHoursWorked;
        }
    }
}
