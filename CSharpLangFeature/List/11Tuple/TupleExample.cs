using System;

namespace CSharpLangFeature.List.TupleCheck
{
    public class TupleExample
    {
        public void Execute()
        {
            var person = Tuple.Create(1, "Steve", "Jobs");

            var Item2 = person.Item1; // returns 1
            var Item3 = person.Item2; // returns "Steve"
            var Item4 = person.Item3; // returns "Jobs"

            //Nested Tuple
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            var Item1 = numbers.Item1; // returns 1
            var Item7 = numbers.Item7; // returns 7
            var Rest = numbers.Rest.Item1; //returns (8, 9, 10, 11, 12, 13)
            var Item11 = numbers.Rest.Item1.Item1; //returns 8
            var Item12 = numbers.Rest.Item1.Item2; //returns 9
        }
    }
}