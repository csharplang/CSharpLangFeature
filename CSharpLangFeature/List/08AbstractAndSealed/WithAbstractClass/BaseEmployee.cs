using System;

namespace CSharpLangFeature.List.AbstractAndSealed.WithAbstractClass
{
    public abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public abstract int GetMonthlySalary();
    }
}
