namespace GeometricShapesTest
{
   public class Perimeter
    {
        public double CirclePerimeter(double pi, double raduis)
        {

            var perimeter=2*pi*raduis;
            return perimeter;
        }

        public double RectanglePrimeter(double length, double width)
        {
         var perimeter=2*(length+width);
            return perimeter;
        }

        public double Squareperimeter(double side)
        {
            var peremeter = 4 * side;
            return peremeter;

        }

        public double TrianglePremeter(double height, double side, double baase)
        {
            var primeter=side+baase+height;
            return primeter;
        }
    }
}
