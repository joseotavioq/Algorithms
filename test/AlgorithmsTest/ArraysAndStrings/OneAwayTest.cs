using Algorithms.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class OneAwayTest
    {
        #region Method FirstTry
        [Fact]
        public void FirstTry_Parameters_PALE_and_PLE_Returns_True()
        {
            string first = "pale";
            string second = "ple";

            bool result = new OneAway().FirstTry(first, second);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Parameters_PLE_and_PALE_Returns_True()
        {
            string first = "ple";
            string second = "pale";

            bool result = new OneAway().FirstTry(first, second);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Parameters_PALES_and_PALE_Returns_True()
        {
            string first = "pales";
            string second = "pale";

            bool result = new OneAway().FirstTry(first, second);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Parameters_PALE_and_PALES_Returns_True()
        {
            string first = "pale";
            string second = "pales";

            bool result = new OneAway().FirstTry(first, second);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Parameters_PALE_and_BALE_Returns_True()
        {
            string first = "pale";
            string second = "bale";

            bool result = new OneAway().FirstTry(first, second);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Parameters_PALE_and_BAKE_Returns_False()
        {
            string first = "pale";
            string second = "bake";

            bool result = new OneAway().FirstTry(first, second);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Parameters_PALE_and_BAE_Returns_False()
        {
            string first = "pale";
            string second = "bae";

            bool result = new OneAway().FirstTry(first, second);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Equal_Parameters_Returns_True()
        {
            string first = "pale";
            string second = "pale";

            bool result = new OneAway().FirstTry(first, second);

            Assert.True(result);
        }
        #endregion

        #region Method Fast
        [Fact]
        public void Fast_Parameters_PALE_and_PLE_Returns_True()
        {
            string first = "pale";
            string second = "ple";

            bool result = new OneAway().Fast(first, second);

            Assert.True(result);
        }

        [Fact]
        public void Fast_Parameters_PLE_and_PALE_Returns_True()
        {
            string first = "ple";
            string second = "pale";

            bool result = new OneAway().Fast(first, second);

            Assert.True(result);
        }

        [Fact]
        public void Fast_Parameters_PALES_and_PALE_Returns_True()
        {
            string first = "pales";
            string second = "pale";

            bool result = new OneAway().Fast(first, second);

            Assert.True(result);
        }

        [Fact]
        public void Fast_Parameters_PALE_and_PALES_Returns_True()
        {
            string first = "pale";
            string second = "pales";

            bool result = new OneAway().Fast(first, second);

            Assert.True(result);
        }

        [Fact]
        public void Fast_Parameters_PALE_and_BALE_Returns_True()
        {
            string first = "pale";
            string second = "bale";

            bool result = new OneAway().Fast(first, second);

            Assert.True(result);
        }

        [Fact]
        public void Fast_Parameters_PALE_and_BAKE_Returns_False()
        {
            string first = "pale";
            string second = "bake";

            bool result = new OneAway().Fast(first, second);

            Assert.False(result);
        }

        [Fact]
        public void Fast_Parameters_PALE_and_BAE_Returns_False()
        {
            string first = "pale";
            string second = "bae";

            bool result = new OneAway().Fast(first, second);

            Assert.False(result);
        }

        [Fact]
        public void Fast_Equal_Parameters_Returns_True()
        {
            string first = "pale";
            string second = "pale";

            bool result = new OneAway().Fast(first, second);

            Assert.True(result);
        }
        #endregion
    }
}
