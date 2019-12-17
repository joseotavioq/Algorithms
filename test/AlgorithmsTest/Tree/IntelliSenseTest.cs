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

            Assert.Equal(6, intellisense.Depth);
        }

        [Fact]
        public void Add_Elements()
        {
            var intellisense = new IntelliSense();
            intellisense.AddWord("System");
            intellisense.AddWord("System.IO");
            intellisense.AddWord("System.Threading");
            intellisense.AddWord("System.Text");

            Assert.Equal(16, intellisense.Depth);
        }

        [Fact]
        public void Find_Elements_With_Prefix_System()
        {
            var intellisense = new IntelliSense();
            intellisense.AddWord("System");
            intellisense.AddWord("Microsoft");
            intellisense.AddWord("System.IO");
            intellisense.AddWord("Microsoft.AspNetCore.Mvc");
            intellisense.AddWord("System.Threading");
            intellisense.AddWord("System.Text");

            var listOfItems = intellisense.Find("System.");

            Assert.Equal("System.IO", listOfItems[0]);
            Assert.Equal("System.Text", listOfItems[1]);
            Assert.Equal("System.Threading", listOfItems[2]);
        }

        [Fact]
        public void Find_Elements_With_Prefix_M()
        {
            var intellisense = new IntelliSense();
            intellisense.AddWord("System");
            intellisense.AddWord("Microsoft");
            intellisense.AddWord("System.IO");
            intellisense.AddWord("Microsoft.AspNetCore.Mvc");
            intellisense.AddWord("System.Threading");
            intellisense.AddWord("MS");
            intellisense.AddWord("System.Text");

            var listOfItems = intellisense.Find("M");

            Assert.Equal("MS", listOfItems[0]);
            Assert.Equal("Microsoft.AspNetCore.Mvc", listOfItems[1]);
            Assert.Equal("Microsoft", listOfItems[2]);
        }
    }
}