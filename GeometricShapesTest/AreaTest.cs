using FluentAssertions;
using GeometricShapes;

namespace GeometricShapesTest
{
    public class AreaTest
    {
        [Fact]
        public void Add_area_circle_with_pi_and_radius()
        {
            var pi = 3.14;
            var radius = 10;
            var result = 314;
            var area = new Area();



            var actual = area.CircleArea(radius, pi);


            actual.Should().Be(result);
        }
        [Fact]
        public void Add_area_Rectangle_with_length_and_width()
        {
            var Length = 10;
            var width = 10;
            var result = 100;
            var area = new Area();


            var actual = area.RectangleArea(Length, width);



            actual.Should().Be(result);
        }

        [Fact]
        public void Add_area_square_with_side()
        {
            var side = 10;
            var result = 100;
            var area = new Area();


            var actual=area.SquareArea(side);


            actual.Should().Be(result);
        }



        [Fact]

        public void add_area_triangel_with_base_and_height()
        {
            var Base = 10;
            var height = 10;
            var area = new Area();
            var result=50;

            var actual=area.TriangleArea(Base, height);


            actual.Should().Be(result);


        }


    }
}