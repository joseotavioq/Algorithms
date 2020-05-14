namespace Algorithms.Recursion
{
    public class TripleStep
    {
        public int Recursive(int nSteps)
        {
            if (nSteps < 0)
                return 0;
            else if (nSteps == 0)
                return 1;

            return Recursive(nSteps - 1) + Recursive(nSteps - 2) + Recursive(nSteps - 3);
        }
    }
}