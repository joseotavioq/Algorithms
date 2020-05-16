using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class FindAndReplaceTest
    {
        [Fact]
        public void Replacing_The_Last_Word()
        {
            string input = "I love my country";
            string find = "country";
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("I love my nation", result);
        }

        [Fact]
        public void Replacing_The_Last_Word_But_With_A_Char_In_The_End()
        {
            string input = "I love my country!";
            string find = "country";
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("I love my nation!", result);
        }

        [Fact]
        public void Replacing_One_Word()
        {
            string input = "1cou ntry I love my country!";
            string find = "country";
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("1cou ntry I love my nation!", result);
        }

        [Fact]
        public void Replacing_Two_Words()
        {
            string input = "1country I love my country!";
            string find = "country";
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("1nation I love my nation!", result);
        }

        [Fact]
        public void Replacing_The_Same_Word_Together()
        {
            string input = "countrycountry";
            string find = "country";
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("nationnation", result);
        }

        [Fact]
        public void Input_Is_Null()
        {
            string input = null;
            string find = "country";
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Null(result);
        }

        [Fact]
        public void Find_Is_Null()
        {
            string input = "I love my country!";
            string find = null;
            string replace = "nation";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Null(result);
        }

        [Fact]
        public void Replace_Is_Null()
        {
            string input = "I love my country!";
            string find = "country";
            string replace = null;

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Null(result);
        }

        [Fact]
        public void Replace_Is_StringEmpty()
        {
            string input = "I love my country!";
            string find = "country";
            string replace = string.Empty;

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("I love my !", result);
        }

        [Fact]
        public void Replace_To_A_Greater_String()
        {
            string input = "I love my country!";
            string find = "country";
            string replace = "beautiful home";

            var result = new FindAndReplace().FirstTry(input, find, replace);

            Assert.Equal("I love my beautiful home!", result);
        }
    }
}