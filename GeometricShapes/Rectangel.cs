using GeometricShapes;

namespace GeometricShapesTest
{
    public class Rectangel :Shape
    {
      

        public double Length { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            var area = Length * Width;
            return area;
        }

        public double Primeter()
        {
            var primeter=2*(Length+Width);
            return primeter;
        }
    }
}
