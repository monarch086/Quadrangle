namespace Quadrangle.Core
{
    public class QuadrangleProcessor
    {
        public bool isQuadrangle(Point[] points)
        {
            if (points == null || points.Length != 4)
            {
                return false;
            }

            var doVerticalEdgesIntersect = doIntersect(points[0], points[1], points[2], points[3]);
            var doHorizontalEdgesIntersect = doIntersect(points[1], points[2], points[3], points[0]);

            return !doVerticalEdgesIntersect && !doHorizontalEdgesIntersect;
        }

        private bool doIntersect(Point p1, Point q1, Point p2, Point q2)
        {
            int o1 = getOrientation(p1, q1, p2);
            int o2 = getOrientation(p1, q1, q2);
            int o3 = getOrientation(p2, q2, p1);
            int o4 = getOrientation(p2, q2, q1);

            // General case
            if (o1 != o2 && o3 != o4)
                return true;

            // Special Cases
            // p1, q1 and p2 are collinear and p2 lies on segment p1q1
            if (o1 == 0 && isOnSegment(p1, p2, q1)) return true;

            if (o2 == 0 && isOnSegment(p1, q2, q1)) return true;

            if (o3 == 0 && isOnSegment(p2, p1, q2)) return true;

            if (o4 == 0 && isOnSegment(p2, q1, q2)) return true;

            return false;
        }

        // To find orientation of ordered triplet (p, q, r).
        // 0 --> p, q and r are collinear
        // 1 --> Clockwise
        // 2 --> Counterclockwise
        private int getOrientation(Point p, Point q, Point r)
        {
            int val = (q.Y - p.Y) * (r.X - q.X) -
                    (q.X - p.X) * (r.Y - q.Y);

            if (val == 0) return 0; // collinear

            return (val > 0) ? 1 : 2; // clock or counterclock wise
        }

        // Given three collinear points p, q, r, the function checks if
        // point q lies on line segment 'pr'
        private bool isOnSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;

            return false;
        }
    }
}