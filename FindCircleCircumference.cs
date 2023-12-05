namespace Formula.Classes
{
    public class FindCircleCircumference
    {
        public FindCircleCircumference()
        {
            // Console.WriteLine();
        }

        public void calculateCircleCircumference()
        {
            Console.WriteLine("This formula used for find circle's circumference: C = 2πr");
            Console.WriteLine("r = radius of the circle");
            Console.WriteLine("π value is 22 / 7");

            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            string[] strings = {"cm", "m"};
            Console.Write("Select cm (0) or m (1): ");
            var selection = int.Parse(Console.ReadLine());
            Console.WriteLine("Selection: " + strings[selection]);

            double answer  = 2 * Math.PI * radius;
            Console.WriteLine("Circumference of circle: " + answer + strings[selection]);
        }
    }
}