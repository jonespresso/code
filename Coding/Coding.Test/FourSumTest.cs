namespace Coding.Test
{
    [TestClass]
    public sealed class FourSumTest
    {
        [TestMethod]
        public void ShouldGetEmptyListForArrayShorterThanFour()
        {
            var app = new FourSum();
            app.GetFourSum(new int[] { 1, 2 }, 3).Should().BeEquivalentTo(new List<IList<int>>());
        }

        [TestMethod]
        public void ShouldGetEmptyListForBadArray()
        {
            var app = new FourSum();
            app.GetFourSum(new int[] { 1, 2, 3, 4, 5 }, 100).Should().BeEquivalentTo(new List<IList<int>>());
        }

        [TestMethod]
        public void ShouldGetListForRightArrayOfFour()
        {
            var app = new FourSum();
            app.GetFourSum(new int[] { 1, 2, 3, 4 }, 10).Should().BeEquivalentTo(
                new List<IList<int>>()
                {
                    new List<int> { 1, 2, 3, 4 },
                });
        }

        [TestMethod]
        public void ShouldGetListForRightArrayOfMoreItems()
        {
            var app = new FourSum();
            app.GetFourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0).Should().BeEquivalentTo(
                new List<IList<int>>()
                {
                    new List<int> { -2, -1 , 1, 2 },
                    new List<int> { -2, 0, 0, 2 },
                    new List<int> { -1, 0, 0, 1 },
                });
        }

        [TestMethod]
        public void ShouldGetUniqueResults()
        {
            var app = new FourSum();
            app.GetFourSum(new int[] { 2, 2, 2, 2, 2 }, 8).Should().BeEquivalentTo(
                new List<IList<int>>()
                {
                    new List<int> { 2, 2, 2, 2 },
                });
        }
    }
}
