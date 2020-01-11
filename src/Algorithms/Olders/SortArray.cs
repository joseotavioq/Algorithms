namespace Algorithms.Olders
{
    public static class SortArray
    {
        //Time: O(n^2)
        public static int[] Insertion(int[] listOfNumbers)
        {
            for (var i = 1; i < listOfNumbers.Length; i++)
            {
                var atual = listOfNumbers[i];
                var j = i;
                while ((j > 0) && (listOfNumbers[j - 1] > atual))
                {
                    listOfNumbers[j] = listOfNumbers[j - 1];
                    j = j - 1;
                }
                listOfNumbers[j] = atual;
            }

            return listOfNumbers;
        }

        //Time: O(n log N)
        public static int[] Quick(int[] listOfNumbers, int left, int right)
        {
            if(left < right)
            {
                var pivot = listOfNumbers[left];
                var leftPointer = left + 1;
                var rightPointer = right;

                while(leftPointer <= rightPointer)
                {
                    if (listOfNumbers[leftPointer] <= pivot)
                        leftPointer++;
                    else if (pivot < listOfNumbers[rightPointer])
                        rightPointer--;
                    else
                    {
                        var tmp = listOfNumbers[leftPointer];
                        listOfNumbers[leftPointer] = listOfNumbers[rightPointer];
                        listOfNumbers[rightPointer] = tmp;
                        leftPointer++;
                        rightPointer--;
                    }
                }
                
                listOfNumbers[left] = listOfNumbers[rightPointer];
		        listOfNumbers[rightPointer] = pivot;

		        Quick(listOfNumbers, left, rightPointer - 1);
		        Quick(listOfNumbers, rightPointer + 1, right);
            }

            return listOfNumbers;
        }
    }
}