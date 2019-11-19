namespace Algorithms.HashTables
{
    public class MyHashTable<T>
    {
        private readonly HashTableNode<T>[] _data;

        public MyHashTable(int size)
        {
            _data = new HashTableNode<T>[size];
        }

        private int generateHash(string key)
        {
            int hash = 0;

            for (int i = 0; i < key.Length; i++)
                hash = (hash + key[i] * i) % _data.Length;

            return hash;
        }

        public T Get(string key)
        {
            int hash = generateHash(key);
            return getOnBucket(hash, key);
        }

        private T getOnBucket(int hash, string key)
        {
            var current = _data[hash];
            while (current != null)
            {
                if (current.Key == key)
                    return current.Value;

                current = current.Next;
            }

            return default(T);
        }

        public void Set(string key, T value)
        {
            int hash = generateHash(key);
            setOnBucket(hash, key, value);
        }

        private void setOnBucket(int hash, string key, T value)
        {
            if (_data[hash] == null)
                _data[hash] = new HashTableNode<T>(key, value);
            else
            {
                var current = _data[hash];
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new HashTableNode<T>(key, value);
            }
        }
    }

    public class HashTableNode<T>
    {
        public HashTableNode(string key, T value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public T Value { get; private set; }
        public string Key { get; private set; }
        public HashTableNode<T> Next { get; set; }
    }
}
