using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class MappingCommandsTest
    {
        [Fact]
        public void Say_Hello()
        {
            string word = "hello";

            var commands = new MappingCommands().GetCommands(word);

            Assert.Equal(45, commands.Length);
            Assert.Equal(Commands.Click, commands[commands.Length - 1]);
        }
    }
}