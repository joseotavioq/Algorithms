using Algorithms.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class SumListsTest
    {
        [Fact]
        public void Sum_Two_Lists()
        {
            var first = new MyLinkedList<int>(7);
            first.Append(1);
            first.Append(6);

            var second = new MyLinkedList<int>(5);
            second.Append(9);
            second.Append(2);

            var result = new SumLists().FirstTry(first, second);

            Assert.Equal(2, result.Value);
            Assert.Equal(1, result.Next.Value);
            Assert.Equal(9, result.Next.Next.Value);
            Assert.Null(result.Next.Next.Next);
        }
    }
}
