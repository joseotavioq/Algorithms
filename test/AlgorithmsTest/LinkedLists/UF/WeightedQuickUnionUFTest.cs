using Xunit;
using Algorithms.LinkedLists.UF;

namespace AlgorithmsTest.LinkedLists.UF
{
    public class WeightedQuickUnionUFTest
    {
        [Fact]
        public void Connect_4_with_3()
        {
            int from = 4;
            int to = 3;

            var uf = new WeightedQuickUnionUF(10);

            uf.Union(from, to);

            for (int i = 0; i < uf.Length; i++)
            {
                if (i == to)
                    Assert.Equal(from, uf.Nodes[i]);
                else
                    Assert.Equal(i, uf.Nodes[i]);
            }
        }

        [Fact]
        public void Connect_6_with_5()
        {
            int from = 6;
            int to = 5;

            var uf = new WeightedQuickUnionUF(10);

            uf.Union(from, to);

            for (int i = 0; i < uf.Length; i++)
            {
                if (i == to)
                    Assert.Equal(from, uf.Nodes[i]);
                else
                    Assert.Equal(i, uf.Nodes[i]);
            }
        }

        [Fact]
        public void Connect_4_with_3_and_3_with_8()
        {
            var uf = new WeightedQuickUnionUF(10);

            uf.Union(4, 3);
            uf.Union(3, 8);

            for (int i = 0; i < uf.Length; i++)
            {
                if (i == 3)
                    Assert.Equal(4, uf.Nodes[i]);
                else if (i == 8)
                    Assert.Equal(4, uf.Nodes[i]);
                else
                    Assert.Equal(i, uf.Nodes[i]);
            }
        }

        [Fact]
        public void Connect_4_with_3_and_3_with_8_and_9_with_4()
        {
            var uf = new WeightedQuickUnionUF(10);

            uf.Union(4, 3);
            uf.Union(3, 8);
            uf.Union(9, 4);

            for (int i = 0; i < uf.Length; i++)
            {
                if (i == 3)
                    Assert.Equal(4, uf.Nodes[i]);
                else if (i == 8)
                    Assert.Equal(4, uf.Nodes[i]);
                else if (i == 9)
                    Assert.Equal(4, uf.Nodes[i]);
                else
                    Assert.Equal(i, uf.Nodes[i]);
            }
        }

        [Fact]
        public void A_big_test()
        {
            var uf = new WeightedQuickUnionUF(10);

            uf.Union(4, 3);
            uf.Union(3, 8);
            uf.Union(6, 5);
            uf.Union(9, 4);
            uf.Union(2, 1);
            Assert.True(uf.IsConnected(8, 9));
            Assert.False(uf.IsConnected(5, 4));
            uf.Union(5, 0);
            uf.Union(7, 2);
            uf.Union(6, 1);
            uf.Union(7, 3);

            Assert.Equal(6, uf.Nodes[0]);
            Assert.Equal(2, uf.Nodes[1]);
            Assert.Equal(6, uf.Nodes[2]);
            Assert.Equal(4, uf.Nodes[3]);
            Assert.Equal(6, uf.Nodes[4]);
            Assert.Equal(6, uf.Nodes[5]);
            Assert.Equal(6, uf.Nodes[6]);
            Assert.Equal(6, uf.Nodes[7]);
            Assert.Equal(4, uf.Nodes[8]);
            Assert.Equal(4, uf.Nodes[9]);
        }
    }
}