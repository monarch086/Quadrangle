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

            // return new Point[]
            // {
                //new Point(-1, 1),
                //new Point(1, 1),
                //new Point(1, -1),
                //new Point(-1, -1)

                //new Point(0, 0),
                //new Point(0, 10),
                //new Point(10, 10),
                //new Point(10, 0)

                //new Point(0, 0),
                //new Point(0, 10),
                //new Point(1, 1),
                //new Point(10, 1)

                //new Point(0, 0),
                //new Point(0, 10),
                //new Point(1, -1),
                //new Point(10, 1)
            // };
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
