namespace Algoritmos
{
    public static class SearchArray
    {
        //Time: O(n)
        public static int MaximumElement(int[] listOfNumbers)
        {
            var max = listOfNumbers[0];

            for (var i = 0; i < listOfNumbers.Length; i++)
            {
                if (listOfNumbers[i] > max)
                    max = listOfNumbers[i];
            }

            return max;
        }

        //Time: O(n^2)
        public static bool HasDuplicateElement(int[] listOfNumbers)
        {
            var hasDuplicate = false;

            for (var i = 0; i < listOfNumbers.Length; i++)
            {
                for (var j = 0; j < listOfNumbers.Length; j++)
                {
                    if (i != j && listOfNumbers[i] == listOfNumbers[j])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (hasDuplicate)
                    break;
            }

            return hasDuplicate;
        }

        //Time: O(log N)
        public static bool BinarySearch_Linear(int[] listOfNumbers, int valueToSearchFor)
        {
            int highIndex = listOfNumbers.Length;
            int lowIndex = 0;

            while (lowIndex <= highIndex)
            {
                int midIndex = (lowIndex + highIndex) / 2;
                if (valueToSearchFor > listOfNumbers[midIndex])
                    lowIndex = midIndex + 1;
                else if (valueToSearchFor < listOfNumbers[midIndex])
                    highIndex = midIndex - 1;
                else
                    return true;
            }

            return false;
        }

        //Time: O(log N)
        public static bool BinarySearch_Recursive(int[] listOfNumbers, int valueToSearchFor, int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex)
                return false;

            int midIndex = (lowIndex + highIndex) / 2;

            if (valueToSearchFor > listOfNumbers[midIndex])
                return BinarySearch_Recursive(listOfNumbers, valueToSearchFor, midIndex + 1, highIndex);
            else if (valueToSearchFor < listOfNumbers[midIndex])
                return BinarySearch_Recursive(listOfNumbers, valueToSearchFor, lowIndex, midIndex - 1);
            else
                return true;
        }

        //Time: O(n)
        public static int MagicOf3(int number)
        {
            int i, m = 1;

            for (i = 1; i <= number; i++)
            {
                if (m == 0) return i;
                m = (10 * m + 1) % number;
            }

            return -1;
        }

        //Time: O(n)
        public static int MostFrequentNumber(int[] listOfNumbers)
        {
            var max = listOfNumbers[0];
            var mostFrequent = -1;
            var sizeOfArray = listOfNumbers.Length;

            for (var i = 0; i < sizeOfArray; i++)
            {
                listOfNumbers[(listOfNumbers[i] % sizeOfArray)] += sizeOfArray;
            }

            for (var j = 1; j < sizeOfArray; j++)
            {
                if (listOfNumbers[j] > max)
                {
                    max = listOfNumbers[j];
                    mostFrequent = j;
                }
            }

            return mostFrequent;
        }
    }
}