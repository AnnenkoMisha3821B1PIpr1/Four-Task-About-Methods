using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_4_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deque<string> Dack = new Deque<string>();
            Dack.AddFirst("Masha");
            Dack.Print();
            Dack.Delete_Last();
            Dack.Print();
            Dack.AddFirst("Masha");
            Dack.AddFirst("Sasha");
            Dack.AddLast("Petya");
            Dack.AddLast("Dasha");
            Dack.AddFirst("Vanya");
            Dack.Print();
            Dack.Delete_First();
            Dack.Print();
            Dack.Delete_Last();
            Dack.Print();
            Console.WriteLine("Данный элемент находится под номером: {0}\n", Dack.Search("Masha"));
            Dack.Print();
            Dack.AddLast("Anya");
            Dack.Print();
            Dack.Delete_Searching("Petya");
            Dack.Print();
            Dack.Delete_All();
            Dack.Print();

            Console.ReadKey();
        }
    }
}
