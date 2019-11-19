namespace Algorithms.HashTables
{
    public class MyHashTable<T>
    {
        private readonly Node<T>[] _data;

        public MyHashTable(int size)
        {
            _data = new Node<T>[size];
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
                _data[hash] = new Node<T>(key, value);
            else
            {
                var current = _data[hash];
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new Node<T>(key, value);
            }
        }
    }

    public class Node<T>
    {
        public Node(string key, T value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public T Value { get; private set; }
        public string Key { get; private set; }
        public Node<T> Next { get; set; }
    }
}
