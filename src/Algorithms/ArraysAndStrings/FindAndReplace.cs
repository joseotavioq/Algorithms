namespace Algorithms.ArraysAndStrings
{
    public class FindAndReplace
    {
        public string FirstTry(string input, string find, string replace)
        {
            if (input == null)
                return null;

            if (find == null || find == "")
                return null;

            if (replace == null)
                return null;

            char[] temp = new char[input.Length];

            int j = 0;
            int tmpIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == find[j])
                {
                    if (j == find.Length - 1)
                    {
                        foreach (char r in replace)
                        {
                            if (tmpIndex >= temp.Length)
                                resizeArray(ref temp, temp.Length * 2);
                            temp[tmpIndex++] = r;
                        }
                        j = 0;
                    }
                    else
                        j++;
                }
                else if (j > 0)
                {
                    while (j >= 0)
                    {
                        if (tmpIndex >= temp.Length)
                            resizeArray(ref temp, temp.Length * 2);
                        temp[tmpIndex++] = input[i - j];
                        j--;
                    }
                    j = 0;
                }
                else
                {
                    if (tmpIndex >= temp.Length)
                        resizeArray(ref temp, temp.Length * 2);
                    temp[tmpIndex++] = c;
                }
            }

            return new string(temp, 0, tmpIndex);
        }

        private void resizeArray(ref char[] temp, int newSize)
        {
            char[] newArray = new char[newSize];

            for (int i = 0; i < temp.Length; i++)
                newArray[i] = temp[i];

            temp = newArray;
        }
    }
}