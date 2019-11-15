using Algorithms.HashTables;
using Xunit;

namespace AlgorithmsTest.HashTables
{
    public class MyHashTableTest
    {
        [Fact]
        public void Insert_An_Item_And_Get_It_Back()
        {
            var myHashTable = new MyHashTable<int>(10);
            string key = "myTest";
            int value = 1000;

            myHashTable.Set(key, value);
            int result = myHashTable.Get(key);

            Assert.Equal(value, result);
        }

        [Fact]
        public void Insert_Items_Testing_Colission()
        {
            var myHashTable = new MyHashTable<int>(10);
            string key = "myTest";
            string key2 = "myTest2";
            string key3 = "myTest7";
            int value = 5;

            myHashTable.Set(key, 10);
            myHashTable.Set(key2, 2);
            myHashTable.Set(key3, value);

            int result = myHashTable.Get(key3);

            Assert.Equal(value, result);
        }
    }
}