using System;

class Program
{
    static void Main(string[] args)
    {   int j;
        string[] arr = { "Yusif", "Rasul", "Anvar" };
        int.TryParse(Console.ReadLine(), out int i);
        if (i >= arr.Length) {
            Console.WriteLine("duzgun daxil et");
        }
        else
        {
            
        string word = arr[i];
             for( j = word.Length-1; j >= 0; j--)
            {
                Console.Write(word[j]) ;
            }
        }
     }
}