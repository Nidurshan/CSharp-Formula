namespace Formula.Classes
{
    public class FindCircleArea
    {
        public FindCircleArea()
        {
            // Console.WriteLine();
        }

        public void CalculateCircleArea()
        {
            Console.WriteLine("This formula used for find circle's area: A = πr^2");
            Console.WriteLine("π value is 22 / 7");

            Console.Write("Enter circle's radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            string[] strings = {"cm", "m"};
            Console.Write("Select cm (0) or m (1): ");
            var selection = int.Parse(Console.ReadLine());

            Console.WriteLine("Selection: " + strings[selection]);

            double answer = Math.PI * (radius * radius);
            Console.WriteLine("Circle Area: " + answer + strings[selection] + "^2");
        }
    }
}