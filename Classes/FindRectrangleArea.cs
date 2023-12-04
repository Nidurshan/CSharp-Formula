namespace Formula.Classes
{
    public class FindRectrangleArea
    {
        public FindRectrangleArea()
        {
            // Console.WriteLine();
        }

        public void CalculateRectrangleArea()
        {
            Console.WriteLine("This formula is used for find rectrangle's area: Area = Length x Width");

            Console.Write("Enter the lenght of rectrangle: ");
            var lengthOfRectrangle = int.Parse(Console.ReadLine());

            Console.Write("Enter the width of rectrangle: ");
            var widthOfRectrangle = int.Parse(Console.ReadLine());

            string[] strings = { "cm", "m" };
            Console.Write("Select cm (0) or m (1): ");
            var selection = int.Parse(Console.ReadLine());
            Console.WriteLine("Selection: " + strings[selection]);

            var areaOfRectrangle = lengthOfRectrangle * widthOfRectrangle;
            Console.WriteLine("Answer: " + areaOfRectrangle + strings[selection] + "^2");
        }
    }
}