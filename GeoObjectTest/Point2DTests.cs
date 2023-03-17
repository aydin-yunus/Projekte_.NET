using PunkteProjekt_TESTING_16._03.GeoObjects;

namespace GeoObjectTest
{
    public class Point2DTests
    {
        [Fact]
        public void TestConstructionPoint2DEmptySuccess()
        {
            //Arrange
            Point2D point = new Point2D();

            //Assert
            Assert.Equal(0, point.X);
            Assert.Equal(0, point.Y);
        }
        [Fact]
        public void TestLinearMovePoint2DEmptySuccess()
        {
            //Arrange
            Point2D point = new Point2D(3, 7);

            //Assert
            Assert.Equal(3, point.X);
            Assert.Equal(7, point.Y);
            //Assert.Equal("(3,7)", point.ToString()); //bunu ibo ya sor
        }
        [Fact]
        public void TestParameterConstructionPoint2DEmptySuccess()
        {
            //Arrange
            Point2D point = new Point2D(3, 7);

            //Act
            point.Move(4, 4);

            //Assert
            Assert.Equal(7, point.X);
            Assert.Equal(11, point.Y);

        }
        [Fact]
        public void TestDistanceMovePoint2DEmptySuccess()
        {
            //Arrange
            Point2D point = new Point2D(3, 4);

            //Act
            double d = point.GetDistance();

            //Assert
            Assert.Equal(5,d);

        }
    }
}