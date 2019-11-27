namespace Algorithms.Stacks
{
    public class StackMin : StackWithLinkedList<int>
    {
        private StackWithArray<int> _minStack = new StackWithArray<int>();

        public int Min()
        {
            if (_minStack.IsEmpty())
                return int.MaxValue;
            else
                return _minStack.Peek();
        }

        public override void Push(int value)
        {
            if (value <= Min())
                _minStack.Push(value);

            base.Push(value);
        }

        public override int Pop()
        {
            if (Peek() == Min())
                _minStack.Pop();

            return base.Pop();
        }
    }
}
