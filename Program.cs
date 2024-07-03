using System;
namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var meuArray = new int[5]; //pode usar o int[] no lugar do var caso queira
            //Console.WriteLine(meuArray[0]);
            var meuArray = new int[5] {1, 2, 3, 4, 5};
            //meuArray[0] = 12;
            //Console.WriteLine(meuArray[0]);
            // for (var i = 0; i < meuArray.Length; i++ ){
            //     Console.WriteLine($"index {i} = {meuArray[i]}");
            // }
            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}