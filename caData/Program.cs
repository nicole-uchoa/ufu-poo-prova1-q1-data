using System;

namespace caData
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(2, 9, 2021);
            Data data2 = new Data(30, 9, 2000);
            data2 = data.Clone();
            Console.WriteLine(data.Compara(data2));
        }
    }
}
