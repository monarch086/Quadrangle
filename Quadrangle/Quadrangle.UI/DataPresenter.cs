namespace Quadrangle.UI
{
    internal class DataPresenter
    {
        public void Display(CalculationResults results)
        {
            Console.WriteLine("1. Is the polygon a quadrangle?");
            Console.WriteLine("2. Is a quadrangle convex?");
            Console.WriteLine("3. Is a quadrangle non-convex?");

            Console.WriteLine("Results of calculations: ");
            Console.WriteLine(results.ToString());
            Console.ReadLine();
        }
    }
}
