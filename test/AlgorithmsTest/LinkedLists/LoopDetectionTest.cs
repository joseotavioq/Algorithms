using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class LoopDetectionTest
    {
        [Fact]
        public void FirstTry_Without_Loop()
        {
            Node<int> first = new Node<int>(1);
            Node<int> second = new Node<int>(2);
            first.Next = second;
            Node<int> third = new Node<int>(3);
            second.Next = third;

            var result = new LoopDetection().FirstTry(first);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_With_Loop()
        {
            Node<int> first = new Node<int>(1);
            Node<int> second = new Node<int>(2);
            first.Next = second;
            Node<int> third = new Node<int>(3);
            second.Next = third;
            third.Next = second;

            var result = new LoopDetection().FirstTry(first);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_With_Longer_Loop()
        {
            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            a.Next = b;
            Node<int> c = new Node<int>(3);
            b.Next = c;
            Node<int> d = new Node<int>(4);
            c.Next = d;
            Node<int> e = new Node<int>(5);
            d.Next = e;
            Node<int> f = new Node<int>(6);
            e.Next = f;
            Node<int> g = new Node<int>(7);
            f.Next = g;
            Node<int> h = new Node<int>(8);
            g.Next = h;
            Node<int> i = new Node<int>(9);
            h.Next = i;
            i.Next = b;

            var result = new LoopDetection().FirstTry(a);

            Assert.True(result);
        }

        [Fact]
        public void SecondTry_Without_Loop()
        {
            Node<int> first = new Node<int>(1);
            Node<int> second = new Node<int>(2);
            first.Next = second;
            Node<int> third = new Node<int>(3);
            second.Next = third;

            var result = new LoopDetection().SecondTry(first);

            Assert.False(result);
        }

        [Fact]
        public void SecondTry_With_Loop()
        {
            Node<int> first = new Node<int>(1);
            Node<int> second = new Node<int>(2);
            first.Next = second;
            Node<int> third = new Node<int>(3);
            second.Next = third;
            third.Next = second;

            var result = new LoopDetection().SecondTry(first);

            Assert.True(result);
        }

        [Fact]
        public void SecondTry_With_Longer_Loop()
        {
            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            a.Next = b;
            Node<int> c = new Node<int>(3);
            b.Next = c;
            Node<int> d = new Node<int>(4);
            c.Next = d;
            Node<int> e = new Node<int>(5);
            d.Next = e;
            Node<int> f = new Node<int>(6);
            e.Next = f;
            Node<int> g = new Node<int>(7);
            f.Next = g;
            Node<int> h = new Node<int>(8);
            g.Next = h;
            Node<int> i = new Node<int>(9);
            h.Next = i;
            i.Next = b;

            var result = new LoopDetection().SecondTry(a);

            Assert.True(result);
        }
    }
}