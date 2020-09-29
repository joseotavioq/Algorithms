namespace Algorithms.Logic
{
    public class RotateLeft
    {
        public int[] FirstTry(int[] array, int numberOfRotations)
        {
            while (numberOfRotations-- > 0)
            {
                int tmp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = tmp;
            }

            return array;
        }

        public int[] SecondTry(int[] array, int numberOfRotations)
        {
            while (numberOfRotations-- > 0)
            {
                int tmp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = tmp;
            }

            return array;
        }
    }
}