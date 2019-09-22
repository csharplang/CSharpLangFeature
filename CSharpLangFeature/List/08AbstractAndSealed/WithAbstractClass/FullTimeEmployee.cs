namespace CSharpLangFeature.List.AbstractAndSealed.WithAbstractClass
{
    public class FullTimeEmployee : BaseEmployee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
