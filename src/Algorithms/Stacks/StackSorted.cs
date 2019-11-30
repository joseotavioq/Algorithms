namespace Algorithms.Stacks
{
    public class StackSorted : StackWithLinkedList<int>
    {
        public override void Push(int value)
        {
            base.Push(value);

            var sorted = new StackWithLinkedList<int>();

            while (!base.IsEmpty())
            {
                int element = base.Pop();
                while(!sorted.IsEmpty() && sorted.Peek() > element)
                {
                    base.Push(sorted.Pop());
                }

                sorted.Push(element);
            }

            while(!sorted.IsEmpty())
            {
                base.Push(sorted.Pop());
            }
        }
    }
}