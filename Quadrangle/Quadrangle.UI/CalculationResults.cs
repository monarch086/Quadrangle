namespace Quadrangle.UI
{
    internal class CalculationResults
    {
        public bool isQuadrangle { get; set; }

        public bool isConvex { get; set; }

        public override string ToString()
        {
            return $"{(isQuadrangle ? "Yes" : "No")}, {(isConvex ? "Yes" : "No")}, {(isConvex ? "No" : "Yes")}";
        }
    }
}
