using GeometricShapes;

namespace GeometricShapesTest
{
    public class Triangle:Shape
    {
      

        public double Height { get; set; }
        public double Basse { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double Area()
        {
            var area = (Height * Basse) / 2;
            return area;
        }

        public double Primeter()
        {
            var primeter = Side1 + Side2 + Height;
            return primeter;
        }
    }
}
