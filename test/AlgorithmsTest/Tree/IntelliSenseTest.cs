using Algorithms.Tree;
using Xunit;

namespace AlgorithmsTest.Tree
{
    public class IntelliSenseTest
    {
        [Fact]
        public void Add_Element()
        {
            var intellisense = new IntelliSense();
            intellisense.AddWord("System");

            Assert.Equal(6, intellisense.Height);
        }

        [Fact]
        public void Add_Elements()
        {
            var intellisense = new IntelliSense();
            intellisense.AddWord("System");
            intellisense.AddWord("System.IO");
            intellisense.AddWord("System.Threading");
            intellisense.AddWord("System.Text");

            Assert.Equal(16, intellisense.Height);
        }
    }
}