using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class Rotate90DegreesTest
    {
        [Fact]
        public void FirstTry_Rotate_3_3_Array()
        {
            string[,] contents = new string[,] { { "Aqua", "Black", "Blue" } ,
                                                 { "Fuschia", "Gray", "Green" } ,
                                                 { "Lime", "Maroon", "Navy" } };

            string[,] result = new Rotate90Degrees().FirstTry(contents, 3);

            Assert.Equal(new string[,] { { "Lime", "Fuschia", "Aqua" },
                                         { "Maroon", "Gray", "Black"},
                                         { "Navy", "Green", "Blue"} }, result);
        }

        [Fact]
        public void FirstTry_Rotate_4_4_Array()
        {
            string[,] contents = new string[,] { { "Aqua", "Black", "Blue", "Yellow" } ,
                                                 { "Fuschia", "Gray", "Green", "White" } ,
                                                 { "Lime", "Maroon", "Navy", "Red" },
                                                 { "Gold", "Silver", "Purple", "Pink" } };

            string[,] result = new Rotate90Degrees().FirstTry(contents, 4);

            Assert.Equal(new string[,] { { "Gold", "Lime", "Fuschia", "Aqua" },
                                         { "Silver", "Maroon", "Gray", "Black"},
                                         { "Purple", "Navy", "Green", "Blue"},
                                         { "Pink", "Red", "White", "Yellow"}}, result);
        }
    }
}