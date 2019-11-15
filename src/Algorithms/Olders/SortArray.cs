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

        //Time: O(n^2)
        public static int[] Selection(int[] listOfNumbers)
        {
            for (var i = 0; i < listOfNumbers.Length - 1; i++)
            {
                var min = i;

                for (var j = i + 1; j < listOfNumbers.Length; j++)
                    if (listOfNumbers[j] < listOfNumbers[min])
                        min = j;

                if (min != i)
                {
                    var tmp = listOfNumbers[min];
                    listOfNumbers[min] = listOfNumbers[i];
                    listOfNumbers[i] = tmp;
                }
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

        //Time: O(n^2)
        public static int[] Bubble(int[] listOfNumbers)
        {
            for(var i = listOfNumbers.Length - 1; i > 1; i--)
            {
                for(var j = 0; j < i; j++)
                {
                    if(listOfNumbers[j] > listOfNumbers[j + 1])
                    {
                        var tmp = listOfNumbers[j];
                        listOfNumbers[j] = listOfNumbers[j + 1];
                        listOfNumbers[j + 1] = tmp;
                    }
                }
            }

            return listOfNumbers;
        }
    }
}