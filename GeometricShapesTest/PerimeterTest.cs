using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesTest
{
    public class PerimeterTest
    {
        [Fact]

        public void Add_perimeter_circle_with_pi_and_raduis()
        {
            var pi = 3.14;
            var raduis = 100;
            var expected = 628;
            var perimeter = new Perimeter();


            var actual = perimeter.CirclePerimeter(pi, raduis);

            actual.Should().Be(expected);


        }
        [Fact]

        public void Add_perimeter_Rectangle_with_length_and_width()
        {
            var length = 10;
            var width= 10;
            var expected=40;
            var perimeter = new Perimeter();


            var actual=perimeter.RectanglePrimeter(length, width);


            actual.Should().Be(expected);
        }
        [Fact]
        public void Add_perimeter_square_with_side()
        {
            var side = 10;
            var expected = 40;
            var perimeter= new Perimeter();

            var actual = perimeter.Squareperimeter(side);

            actual.Should().Be(expected);



        }
        [Fact]
        public void Add_perimeter_triangle_with_base_and_height_and_side()
        {
            var height = 10;
            var side = 10;
            var Base = 10;
            var expected = 30;
            var perimeter = new Perimeter();


            var actual=perimeter.TrianglePremeter(height, side, Base);


            actual.Should().Be(expected);   
            

            

        }

    }
}
