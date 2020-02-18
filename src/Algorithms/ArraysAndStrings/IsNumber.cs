namespace Algorithms.ArraysAndStrings
{
    public class IsNumber
    {
        public bool FirstTry(string s)
        {
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    start = i;
                    break;
                }
            }

            int end = s.Length;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    end = i + 1;
                    break;
                }
            }

            int length = end - start;

            if (length <= 0)
                return false;

            bool signAppeared = false;
            bool decimalPointAppeared = false;
            for (int i = start; i < end; i++)
            {
                bool isNumber = (s[i] >= '0' && s[i] <= '9');
                bool isExpoent = (s[i] == 'e' && length > 2 && (i - 1 >= 0 && s[i - 1] >= '0' && s[i - 1] <= '9') && (i == end - 3 || i == end - 2));
                bool isNegativeOrPositiveSign = ((s[i] == '-' || s[i] == '+') && !signAppeared);
                bool isDecimalPoint = (s[i] == '.' && length > 1 && !decimalPointAppeared);

                if (isNegativeOrPositiveSign)
                    signAppeared = true;

                if (isDecimalPoint)
                    decimalPointAppeared = true;

                if (!isNumber && !isExpoent && !isNegativeOrPositiveSign && !isDecimalPoint)
                    return false;
            }

            return true;
        }
    }
}
