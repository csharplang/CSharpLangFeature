namespace CSharpLangFeature.ExpressionBodiedMembers
{
    public class Main
    {
        //Normal Method
        public double Summation(double x, double y)
        {
             return x + y;
        }

        //Method with Expression Bodied Members
        public double SummationExpressionBodied(double x, double y) => x + y;
    }
}