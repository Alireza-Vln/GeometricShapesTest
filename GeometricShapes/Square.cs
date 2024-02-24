namespace GeometricShapes
{
    public class Square : Shape
    {
        public double Area()
        {
             var area = Side * Side;
            return area;
        }

        public double Primeter()
        {
            var primeter = 4 * Side;
            return primeter;
        }

        public double Side { get; set; }
    }
}
