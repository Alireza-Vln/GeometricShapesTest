namespace GeometricShapes
{
    public class Area
    {
        public double CircleArea(double radius,double pi)
        {
            var area = pi * radius * radius;
            return area;
        }

        public double RectangleArea(double Length,double width)
        {
            var area = Length * width;
            return area;
        }
         
        public double SquareArea(double side)
        {
            var area = side * side;
            return area;
        }
        public double TriangleArea(double Base,double height )
        {
        
        var area=(Base * height)/2;
            return area;
        }

    }
}