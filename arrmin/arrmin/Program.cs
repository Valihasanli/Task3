using System;
namespace az
{
    internal class A
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 4, 2, 5 };
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);
        }

    }

}