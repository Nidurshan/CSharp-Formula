namespace Formula.Classes
{
    public class AddSubMultiplyDevide
    {
        public AddSubMultiplyDevide()
        {
            // Cosole.WriteLine();
        }

        public void CalculateAddSubMultiplyDevide()
        {
            Console.Write("Enter first num: ");
            var firstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter second num: ");
            var secondNum = int.Parse(Console.ReadLine());

            char[] operators = {'+', '-', '*', '/'};
            for(int i = 0; i < operators.Length; i++)
            {
                Console.WriteLine(firstNum + operators[i] + secondNum);
            }
        }
    }
}