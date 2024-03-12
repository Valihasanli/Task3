//Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana çap edin.
//Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array = { 1, -2, 3,123,-111, -4, 5 };
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] <0) { array[i] *= -1; }
            Console.Write(array[i]+" ");
           
        }

    }
}