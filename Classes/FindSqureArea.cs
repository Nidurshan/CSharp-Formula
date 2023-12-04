namespace Formula.Classes
{
    public class FindSqureArea
    {
        public FindSqureArea()
        {
            Console.WriteLine();
        }

        public void CalculateSqureArea()
        {
            Console.WriteLine("This formula used to find the squre area: Area = Length x Length");

            Console.Write("Enter the length of squre: ");
            var length = int.Parse(Console.ReadLine());

            string[] strings = { "cm", "m" };
            Console.Write("Select cm (0) or m (1): ");
            var selection = int.Parse(Console.ReadLine());
            Console.WriteLine("Selection: " + strings[selection]);

            var answer = length * length;
            Console.WriteLine("Answer: " + answer + strings[selection] + "^2");
        }
    }
}