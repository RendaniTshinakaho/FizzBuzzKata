namespace Domain
{
    public interface IFizzBuzz
    {
        string Evaluate(int number);
    }

    public class FizzBuzz : IFizzBuzz
    {
        public string Evaluate(int number)
        {
            if (MultipleOfThree(number) && MultipleOfFive(number))
            {
                return "FizzBuzz";
            }
            if (MultipleOfThree(number))
            {
                return "Fizz";
            }else if (MultipleOfFive(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        private bool MultipleOfFive(int number)
        {
            return number % 5 == 0;
        }

        private bool MultipleOfThree(int number)
        {
            return number % 3 == 0;
        }
    }
}