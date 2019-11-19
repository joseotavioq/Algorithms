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

            int count = 0;
            while (result != null)
            {
                if (count > 0)
                    Assert.NotEqual(1, result.Value);
                result = result.Next;
                count++;
            }

            Assert.Equal(5, count);
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

            int count = 0;
            while (result != null)
            {
                if (count > 0)
                    Assert.NotEqual(1, result.Value);
                result = result.Next;
                count++;
            }

            Assert.Equal(4, count);
        }
    }
}