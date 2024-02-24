using GeometricShapes;

namespace GeometricShapesTest
{
    public class Circle :Shape
    {
        public Circle()
        {
            Pi = 3.14;
        }

        public double Pi { get; set; }
        public double Radius { get; set; }


        public double Area()
        {
            var area = Pi * Radius * Radius;
            return area;
        }

        public double Primeter()
        {
            var area = 2 * Pi * Radius;
            return area;
        }
    }
}
