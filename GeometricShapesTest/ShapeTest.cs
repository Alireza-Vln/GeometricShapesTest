using FluentAssertions;
using GeometricShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeometricShapesTest
{
    public class ShapeTest
    {
        [Fact]

        public void Get_the_square_area_with_side()
        {
            var num = 10;
            var expected = 100;
            var square = new Square()
            {
                Side = num
            };

            var actual = square.Area();

            actual.Should().Be(expected);
        }
        [Fact]
        public void Get_the_square_primeter_with_side()
        {
            var side = 10;
            var expected = 40;
            var square = new Square()
            {
                Side = side
            };
            var actual = square.Primeter();
            actual.Should().Be(expected);
        
        
        }
        [Fact]
        public void Get_the_circle_area_with_pi_and_radius()
        {
            var radius = 10;
            var expected = 314;
            var circle = new Circle()
            {
                Radius = radius
            };

            var actual = circle.Area();

            actual.Should().Be(expected);


        }
        [Fact]
        public void Get_the_circle_primeter_with_Pi_and_radius ()
        {
            var radius = 50;
            var expected = 314;
            var circle = new Circle()
            {
                Radius = radius
            };

            var actual = circle.Primeter();

            actual.Should().Be(expected);
        }
        [Fact]
        public void Get_the_rectangle_area_with_length_and_width()
        {
            var length = 10;
            var width = 10;
            var expected = 100;

            var rectangel = new Rectangel()
            {
                Length = length,
                Width = width,
            };
            var actual = rectangel.Area();

            actual.Should().Be(expected);
        }
        [Fact]
        public void Get_the_rectangle_primeter_with_lengh_and_width()
        {
            var length = 10;
            var width = 10;
            var expected = 40;

            var rectangel = new Rectangel()
            {
                Length = length,
                Width = width,
            };
            var actual = rectangel.Primeter();

            actual.Should().Be(expected);
        }
        [Fact]
        public void Get_the_triangle_area_with_base_and_height()
        {
            var height = 10;
            var basse = 10;
            var expected = 50;
            var triangel = new Triangle()
            {
                Height = height,
                Basse = basse,
            };

            var actual = triangel.Area();

            actual.Should().Be(expected);

            
        }
        [Fact]
        public void Get_the_triangle_primeter_with_side1_and_sid2_and_height()
        {
            var height = 10;
            var side1 = 10;
            var side2 = 10;
            var expected = 30;
            var triangel = new Triangle()
            {
                Height = height,
                Side1=side1,
                Side2=side2,
            };

            var actual = triangel.Primeter();

            actual.Should().Be(expected);


        }

    }
}
