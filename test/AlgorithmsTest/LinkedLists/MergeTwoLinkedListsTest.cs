using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class MergeTwoLinkedListsTest
    {
        [Fact]
        public void Merge_Simple_LinkedLists()
        {
            var first = new Node<int>(2)
            {
                Next = new Node<int>(4)
                {
                    Next = new Node<int>(5)
                    {
                        Next = new Node<int>(7)
                    }
                }
            };

            var second = new Node<int>(1)
            {
                Next = new Node<int>(3)
                {
                    Next = new Node<int>(5)
                    {
                        Next = new Node<int>(6)
                    }
                }
            };

            var merged = new MergeTwoLinkedLists().FirstTry(first, second);

            Assert.Equal(1, merged.Value);
            Assert.Equal(2, merged.Next.Value);
            Assert.Equal(3, merged.Next.Next.Value);
            Assert.Equal(4, merged.Next.Next.Next.Value);
            Assert.Equal(5, merged.Next.Next.Next.Next.Value);
            Assert.Equal(6, merged.Next.Next.Next.Next.Next.Value);
            Assert.Equal(7, merged.Next.Next.Next.Next.Next.Next.Value);
            Assert.Null(merged.Next.Next.Next.Next.Next.Next.Next);
        }

        [Fact]
        public void First_LinkedList_Is_Null()
        {
            var second = new Node<int>(1)
            {
                Next = new Node<int>(3)
                {
                    Next = new Node<int>(5)
                    {
                        Next = new Node<int>(6)
                    }
                }
            };

            var merged = new MergeTwoLinkedLists().FirstTry(null, second);

            Assert.Equal(1, merged.Value);
            Assert.Equal(3, merged.Next.Value);
            Assert.Equal(5, merged.Next.Next.Value);
            Assert.Equal(6, merged.Next.Next.Next.Value);
            Assert.Null(merged.Next.Next.Next.Next);
        }

        [Fact]
        public void Second_LinkedList_Is_Null()
        {
            var first = new Node<int>(2)
            {
                Next = new Node<int>(4)
                {
                    Next = new Node<int>(5)
                    {
                        Next = new Node<int>(7)
                    }
                }
            };

            var merged = new MergeTwoLinkedLists().FirstTry(first, null);

            Assert.Equal(2, merged.Value);
            Assert.Equal(4, merged.Next.Value);
            Assert.Equal(5, merged.Next.Next.Value);
            Assert.Equal(7, merged.Next.Next.Next.Value);
            Assert.Null(merged.Next.Next.Next.Next);
        }

        [Fact]
        public void Merge_LinkedLists_With_The_Same_Value()
        {
            var first = new Node<int>(1)
            {
                Next = new Node<int>(2)
                {
                    Next = new Node<int>(3)
                    {
                        Next = new Node<int>(4)
                    }
                }
            };

            var second = new Node<int>(1)
            {
                Next = new Node<int>(2)
                {
                    Next = new Node<int>(3)
                    {
                        Next = new Node<int>(4)
                    }
                }
            };

            var merged = new MergeTwoLinkedLists().FirstTry(first, second);

            Assert.Equal(1, merged.Value);
            Assert.Equal(2, merged.Next.Value);
            Assert.Equal(3, merged.Next.Next.Value);
            Assert.Equal(4, merged.Next.Next.Next.Value);
            Assert.Null(merged.Next.Next.Next.Next);
        }
    }
}
