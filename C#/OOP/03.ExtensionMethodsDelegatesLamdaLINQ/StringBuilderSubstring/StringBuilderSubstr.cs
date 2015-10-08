using System;
using System.Text;

namespace StringBuilderSubstring
{
    public static class StringBuilderSubstr
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int count)
    {
        string initialstr = strBuilder.ToString();
        StringBuilder result = new StringBuilder(count);

        if (index < 0 || index > initialstr.Length -1)
        {
            throw new ArgumentOutOfRangeException("Starting index must be in range 0, string.Lenght.");
        }

        if (count < 0 || count + index > initialstr.Length -1)
        {
            throw new ArgumentException("Count must be >0 and count + index must be < string.Lenght.");
        }

        for (int i = index; i < index+count; i++)
        {
            result.Append(initialstr[i]);
        }
        return result;
    }

        public static StringBuilder Substring(this StringBuilder strBuilder, int index)
        {
            string initialstr = strBuilder.ToString();
            StringBuilder result = new StringBuilder(initialstr.Length - index);
            if (index < 0 || index > initialstr.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Starting index must be in range 0, string.Lenght.");
            }

            for (int i = index; i < initialstr.Length; i++)
            {
                result.Append(initialstr[i]);
            }
            return result;
        }
    }
}
