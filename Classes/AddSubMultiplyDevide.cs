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

            // Displaying addition of the two numbers
            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);

            // Displaying subtraction of the two numbers
            Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);

            // Displaying multiplication of the two numbers
            Console.WriteLine("{0} x {1} = {2}", firstNum, secondNum, firstNum * secondNum);

            // Displaying division of the two numbers
            Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);

            // Displaying modulus (remainder) of the two numbers
            Console.WriteLine("{0} mod {1} = {2}", firstNum, secondNum, firstNum % secondNum);
        }
    }
}