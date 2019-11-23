namespace Algorithms.Stacks
{
    public class StackWithArray<T>
    {
        private T[] _items;

        public T Top { get { return Peek(); } }
        public T Bottom { get { return _items[0]; } }
        public int Length { get; private set; }

        public StackWithArray()
        {
            _items = new T[10];
        }

        public T Peek()
        {
            if (Length == 0)
                return default(T);

            return _items[Length - 1];
        }

        public void Push(T value)
        {
            if(Length + 1 > _items.Length)
            {
                var newArray = new T[_items.Length * 2];
                _items.CopyTo(newArray, 0);
                _items = newArray;
            }

            _items[Length] = value;
            Length++;
        }

        public T Pop()
        {
            if (Length == 0)
                return default(T);

            var item = _items[Length - 1];
            _items[Length - 1] = default(T);
            Length--;
            return item;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}