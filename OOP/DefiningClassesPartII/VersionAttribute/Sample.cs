using System;

namespace VersionAttribute
{
    [Version("v. 2.11")]

    class Sample
    {
        static void Main()
        {
            Type type = typeof(Sample);
            object[] attr = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
