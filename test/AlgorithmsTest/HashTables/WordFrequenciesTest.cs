using Algorithms.HashTables;
using Xunit;

namespace AlgorithmsTest.HashTables
{
    public class WordFrequenciesTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "sentence";

            int count = new WordFrequencies().FirstTry(sentence, word);

            Assert.Equal(2, count);
        }

        [Fact]
        public void FirstTry_No_Occurrences()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "word";

            int count = new WordFrequencies().FirstTry(sentence, word);

            Assert.Equal(0, count);
        }

        [Fact]
        public void FirstTry_Word_This_With_3_Occurrences()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "this";

            var myWordFrequencies = new WordFrequencies();

            int count = myWordFrequencies.FirstTry(sentence, word);

            Assert.Equal(3, count);
        }

        [Fact]
        public void SecondTry_Basic_Test()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "sentence";

            var myWordFrequencies = new WordFrequencies(sentence);

            int count = myWordFrequencies.SecondTry(word);

            Assert.Equal(2, count);
        }

        [Fact]
        public void SecondTry_No_Occurrences()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "word";

            var myWordFrequencies = new WordFrequencies(sentence);

            int count = myWordFrequencies.SecondTry(word);

            Assert.Equal(0, count);
        }

        [Fact]
        public void SecondTry_Word_This_With_3_Occurrences()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "this";

            var myWordFrequencies = new WordFrequencies(sentence);

            int count = myWordFrequencies.SecondTry(word);

            Assert.Equal(3, count);
        }

        [Fact]
        public void ThirdTry_Basic_Test()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "sentence";

            var myWordFrequencies = new WordFrequencies();

            int count = myWordFrequencies.ThirdTry(sentence, word);

            Assert.Equal(2, count);
        }

        [Fact]
        public void ThirdTry_No_Occurrences()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "word";

            var myWordFrequencies = new WordFrequencies();

            int count = myWordFrequencies.ThirdTry(sentence, word);

            Assert.Equal(0, count);
        }

        [Fact]
        public void ThirdTry_Word_This_With_3_Occurrences()
        {
            string sentence = "This is my sentence and I can write anything one this sentence because this is mine!";
            string word = "this";

            var myWordFrequencies = new WordFrequencies();

            int count = myWordFrequencies.ThirdTry(sentence, word);

            Assert.Equal(3, count);
        }
    }
}