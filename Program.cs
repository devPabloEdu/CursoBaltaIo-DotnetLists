using System;
namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]; //pode usar o int[] no lugar do var caso queira
            //Console.WriteLine(meuArray[0]);
            meuArray[0] = 12;
            Console.WriteLine(meuArray[0]);
        }
    }
}