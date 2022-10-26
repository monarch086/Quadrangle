using Quadrangle.Core;

namespace Quadrangle.UI
{
    internal class DataReader
    {
        public Point[] Read(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                return lines.Select(line => parseLine(line)).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading input data: " + e.Message);

                throw;
            }
        }

        private Point parseLine(string line)
        {
            var values = line.Split(' ');

            var x = int.Parse(values[0]);
            var y = int.Parse(values[1]);

            return new Point(x, y);
        }
    }
}
