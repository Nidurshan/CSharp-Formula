namespace Formula.Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var findSqureArea = new FindSqureArea();
            findSqureArea.CalculateSqureArea();

            //======= Find rectrangle area ========

            var findRectrangleArea = new FindRectrangleArea();
            findRectrangleArea.CalculateRectrangleArea();
        }
    }
}
