using Algorithms.Stacks;
using Xunit;

namespace AlgorithmsTest.Stacks
{
    public class EvaluateExpressionTest
    {
        [Fact]
        public void FirstTry_Easy_Expression_With_Sum()
        {
            var eval = new EvaluateExpression();

            int result = eval.FirstTry("(1+2)");

            Assert.Equal(3, result);
        }

        [Fact]
        public void FirstTry_Easy_Expression_With_Spaces()
        {
            var eval = new EvaluateExpression();

            int result = eval.FirstTry("(1 + 2)");

            Assert.Equal(3, result);
        }

        [Fact]
        public void FirstTry_Easy_Expression_With_Subtraction()
        {
            var eval = new EvaluateExpression();

            int result = eval.FirstTry("(2 - 4)");

            Assert.Equal(-2, result);
        }

        [Fact]
        public void FirstTry_Easy_Expression_With_Multiplication()
        {
            var eval = new EvaluateExpression();

            int result = eval.FirstTry("(2 * 4)");

            Assert.Equal(8, result);
        }

        [Fact]
        public void FirstTry_Easy_Expression_With_Division()
        {
            var eval = new EvaluateExpression();

            int result = eval.FirstTry("(4 / 2)");

            Assert.Equal(2, result);
        }

        [Fact]
        public void FirstTry_Complex_Expression()
        {
            var eval = new EvaluateExpression();

            int result = eval.FirstTry("(1 + ((2 + 3) * (4 * 5)))");

            Assert.Equal(101, result);
        }
    }
}