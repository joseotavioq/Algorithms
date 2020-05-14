using Algorithms.Stacks;
using Xunit;

namespace AlgorithmsTest.Stacks
{
    public class ValidParenthesesTest
    {
        [Fact]
        public void Only_One_Char()
        {
            var input = "(";

            var result = new ValidParentheses().FirstTry(input);

            Assert.False(result);
        }

        [Fact]
        public void Only_With_Parentheses()
        {
            var input = "()";

            var result = new ValidParentheses().FirstTry(input);

            Assert.True(result);
        }

        [Fact]
        public void Using_The_Three_Different_Forms()
        {
            var input = "()[]{}";

            var result = new ValidParentheses().FirstTry(input);

            Assert.True(result);
        }

        [Fact]
        public void Simple_But_Incorrect()
        {
            var input = "(]";

            var result = new ValidParentheses().FirstTry(input);

            Assert.False(result);
        }

        [Fact]
        public void Complex_But_Incorrect()
        {
            var input = "([)]";

            var result = new ValidParentheses().FirstTry(input);

            Assert.False(result);
        }

        [Fact]
        public void Complex_And_Correct()
        {
            var input = "{[]}";

            var result = new ValidParentheses().FirstTry(input);

            Assert.True(result);
        }

        [Fact]
        public void Complete()
        {
            var input = "{[()]}";

            var result = new ValidParentheses().FirstTry(input);

            Assert.True(result);
        }
    }
}
