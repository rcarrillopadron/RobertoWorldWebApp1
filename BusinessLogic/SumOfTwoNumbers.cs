using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class SumOfTwoNumbers
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    public class SumOfTwoNumbersResult
    {
        public int Result { get; set; }
    }

    public class CalculateSumOfTwoNumbersService
    {
        public SumOfTwoNumbersResult Calculate(SumOfTwoNumbers input)
        {
            int result = input.Value1 + input.Value2;
            return new SumOfTwoNumbersResult
            {
                Result = result
            };
        }
    }
}
