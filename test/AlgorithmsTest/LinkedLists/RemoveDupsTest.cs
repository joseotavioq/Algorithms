using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class RemoveDupsTest
    {
        [Fact]
        public void FirstTry_Remove_Value_1_Duplicated()
        {
            Node<int> head = new Node<int>(1)
            {
                Next = new Node<int>(7)
                {
                    Next = new Node<int>(4)
                    {
                        Next = new Node<int>(1)
                        {
                            Next = new Node<int>(5)
                            {
                                Next = new Node<int>(6)
                            }
                        }
                    }
                }
            };

            var result = new RemoveDups().FirstTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(5, result.Next.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next.Next);
        }

        [Fact]
        public void FirstTry_Remove_Value_1_Duplicated_In_A_Sequence()
        {
            Node<int> head = new Node<int>(1)
            {
                Next = new Node<int>(7)
                {
                    Next = new Node<int>(4)
                    {
                        Next = new Node<int>(1)
                        {
                            Next = new Node<int>(1)
                            {
                                Next = new Node<int>(6)
                            }
                        }
                    }
                }
            };

            var result = new RemoveDups().FirstTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next);
        }

        [Fact]
        public void SecondTry_Remove_Value_1_Duplicated()
        {
            Node<int> head = new Node<int>(1)
            {
                Next = new Node<int>(7)
                {
                    Next = new Node<int>(4)
                    {
                        Next = new Node<int>(1)
                        {
                            Next = new Node<int>(5)
                            {
                                Next = new Node<int>(6)
                            }
                        }
                    }
                }
            };

            var result = new RemoveDups().SecondTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(5, result.Next.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next.Next);
        }

        [Fact]
        public void SecondTry_Remove_Value_1_Duplicated_In_A_Sequence()
        {
            Node<int> head = new Node<int>(1)
            {
                Next = new Node<int>(7)
                {
                    Next = new Node<int>(4)
                    {
                        Next = new Node<int>(1)
                        {
                            Next = new Node<int>(1)
                            {
                                Next = new Node<int>(6)
                            }
                        }
                    }
                }
            };

            var result = new RemoveDups().SecondTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next);
        }
    }
}