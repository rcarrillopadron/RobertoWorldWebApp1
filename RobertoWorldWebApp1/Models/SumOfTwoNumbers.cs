namespace RobertoWorldWebApp1.Models
{
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
