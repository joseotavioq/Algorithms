using System.Text;

namespace Algorithms.ArraysAndStrings
{
    public class PrintWordWithSeparator
    {
        public string Print(string word, char separator, int cursorPosition)
        {
            if (word == null || cursorPosition > word.Length)
            {
                return null;
            }

            StringBuilder firstLine = new StringBuilder(word.Length * 2 - 1);
            StringBuilder secondLine = new StringBuilder(word.Length * 2 - 1);

            for (int i = 0; i < word.Length; i++)
            {
                firstLine.Append(word[i]);

                if (i < word.Length - 1)
                {
                    if (i + 1 == cursorPosition)
                    {
                        secondLine.Append('^');
                    }
                    else
                    {
                        secondLine.Append('-');
                    }

                    firstLine.Append(separator);
                }

                secondLine.Append('-');
            }

            return firstLine.ToString() + secondLine.ToString();
        }
    }
}