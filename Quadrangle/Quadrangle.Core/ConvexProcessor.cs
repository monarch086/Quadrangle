namespace Quadrangle.Core
{
    public class ConvexProcessor
    {
        public bool isConvex(Point[] points)
        {
            int prevCross = 0, currCross = 0;

            for (int i = 0; i < points.Length; i++)
            {
                var edge1 = GetEdge(points, i);
                var edge2 = GetEdge(points, (i + 1) % points.Length);

                currCross = CrossProduct(edge1, edge2);

                if (currCross != 0)
                {
                    if (currCross * prevCross < 0)
                    {
                        return false;
                    }
                    else
                    {
                        prevCross = currCross;
                    }
                }
            }
            return true;
        }

        public static Point[] GetEdge(Point[] points, int offset)
        {
            var edge = new Point[2];

            for (var i = 0; i < edge.Length; i++)
                edge[i] = points[(offset + i) % points.Length];

            return edge;
        }

        // cross product of two vectors
        static int CrossProduct(Point[] vectorA, Point[] vectorB)
        {
            int X1 = (vectorA[1].X - vectorA[0].X);
            int Y1 = (vectorA[1].Y - vectorA[0].Y);

            int X2 = (vectorB[1].X - vectorB[0].X);
            int Y2 = (vectorB[1].Y - vectorB[0].Y);

            return (X1 * Y2 - Y1 * X2);
        }
    }
}
