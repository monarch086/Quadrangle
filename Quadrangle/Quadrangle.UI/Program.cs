using Quadrangle.Core;
using System.Reflection;

namespace Quadrangle.UI
{
    internal class Program
    {
        private static string? currentLocation => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string path => @$"{currentLocation}\InputData.txt";
        static void Main(string[] args)
        {
            var reader = new DataReader();
            var points = reader.Read(path);

            var quadrangleProcessor = new QuadrangleProcessor();
            var convexProcessor = new ConvexProcessor();

            var results = new CalculationResults()
            {
                isQuadrangle = quadrangleProcessor.isQuadrangle(points),
                isConvex = convexProcessor.isConvex(points)
            };

            var presenter = new DataPresenter();
            presenter.Display(results);
        }
    }
}