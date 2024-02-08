using ClassShapes.Helper;

namespace TestClassShapes
{
    public class UnitTest1
    {
        [Fact]
        public void GetResult_ReturnsAreaOfCircle()
        {
            
            string isNumber = "5";
            string type = "c";

            
            double? result = Util.GetResult(isNumber, type);

            
            Assert.Equal(78.539816339744831, result);
        }

        [Fact]
        public void GetResult_ReturnsAreaOfTriangle()
        {
            
            string isNumber = "3 4 5";
            string type = "t";

            
            double? result = Util.GetResult(isNumber, type);

            
            Assert.Equal(6.0, result);
        }

        [Fact]
        public void GetResult_ReturnsAreaOfPolygon()
        {
            
            string isNumber = "3 4 5 6";
            string type = "p";

            
            double? result = Util.GetResult(isNumber, type);

            
            Assert.Equal(56.92099788303083, result);
        }

        [Fact]
        public void GetResult_ReturnsThrowsIfZeroInArgument()
        {

            string isNumber = "3 4 5 0";
            string type = "p";

            Assert.Throws<ArgumentException>(() => Util.GetResult(isNumber, type));

        }

        [Fact]
        public void GetResultCheckTriangle_ReturnsTrueForRightTriangle()
        {
            
            string isNumber = "3 4 5";

            
            bool result = Util.GetResultCheckTriangle(isNumber);

            Assert.True(result);
        }
        
    }
}