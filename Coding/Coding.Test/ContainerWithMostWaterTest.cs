namespace Coding.Test
{
    [TestClass]
    public sealed class ContainerWithMostWaterTest
    {
        [TestMethod]
        public void ShouldGetMaxAreaForArrayOfTwoElements()
        {
            ShouldGetMaxArea(new ContainerWithMostWater(), expected: 1, 1, 2);
        }

        [TestMethod]
        public void ShouldGetMaxAreaForArrayOfManyElements()
        {
            ShouldGetMaxArea(new ContainerWithMostWater(), expected: 49, 1, 8, 6, 2, 5, 4, 8, 3, 7);
        }

        private static void ShouldGetMaxArea(ContainerWithMostWater app, int expected, params int[] height)
        {
            app.MaxArea(height).Should().Be(expected);
        }
    }
}