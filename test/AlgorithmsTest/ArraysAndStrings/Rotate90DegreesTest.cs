using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class Rotate90DegreesTest
    {
        [Fact]
        public void FirstTry_Rotate_2_2_Array()
        {
            string[,] contents = new string[,] { { "Aqua", "Black" } ,
                                                 { "Fuschia", "Gray" } };

            string[,] result = new Rotate90Degrees().FirstTry(contents);

            Assert.Equal(new string[,] { { "Fuschia", "Aqua" },
                                         { "Gray", "Black"} }, result);
        }

        [Fact]
        public void FirstTry_Rotate_3_3_Array()
        {
            string[,] contents = new string[,] { { "Aqua", "Black", "Blue" } ,
                                                 { "Fuschia", "Gray", "Green" } ,
                                                 { "Lime", "Maroon", "Navy" } };

            string[,] result = new Rotate90Degrees().FirstTry(contents);

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

            string[,] result = new Rotate90Degrees().FirstTry(contents);

            Assert.Equal(new string[,] { { "Gold", "Lime", "Fuschia", "Aqua" },
                                         { "Silver", "Maroon", "Gray", "Black"},
                                         { "Purple", "Navy", "Green", "Blue"},
                                         { "Pink", "Red", "White", "Yellow"}}, result);
        }

        [Fact]
        public void FirstTry_Validate_Null_Input()
        {
            string[,] result = new Rotate90Degrees().FirstTry(null);

            Assert.Null(result);
        }

        [Fact]
        public void FirstTry_Validate_Instance_Without_Elements_Input()
        {
            string[,] result = new Rotate90Degrees().FirstTry(new string[,] { });

            Assert.Null(result);
        }

        [Fact]
        public void FirstTry_Validate_Instance_With_One_Element()
        {
            string[,] result = new Rotate90Degrees().FirstTry(new string[,] { { "Aqua" } });

            Assert.Null(result);
        }
    }
}