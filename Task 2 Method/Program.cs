using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2_Method
{
    internal class Program
    {
        static void Push_n(ref int[] Queue, int n)
        {
            Array.Resize(ref Queue, Queue.Length + 1);
            Queue[Queue.Length - 1] = n;
            Console.WriteLine("\nok\n");
        }
        static void Pop(ref int[] Queue)
        {
            if (Queue.Length > 0)
            {
                Console.WriteLine("\n{0}\n", Queue[0]);
                Array.Copy(Queue, 1, Queue, 0, Queue.Length - 1);
                Array.Resize(ref Queue, Queue.Length - 1);
            }
            else
            {
                Console.WriteLine("\nerror\n");
            }
        }
        static void Front(int[] Queue)
        {
            if (Queue.Length > 0)
            {
                Console.WriteLine("\n{0}\n", Queue[0]);
            }
            else
            {
                Console.WriteLine("\nerror\n");
            }
        }
        static void Size(int[] Queue)
        {
            Console.WriteLine("\n{0}\n", Queue.Length);
        }
        static void Clear(ref int[] Queue)
        {
            Array.Resize(ref Queue, 0);
            Console.WriteLine("\nok\n");
        }
        static void Exit()
        {
            Console.WriteLine("\nbye\n");
            Thread.Sleep(1500);
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            int[] Queue = new int[0];
            while (true)
            {
                Console.Write("Выберите команду:\n1) Push\n2) Pop\n3) Front\n4) Size\n5) Clear\n6) Exit\nВаш выбор: ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Write("\npush ");
                        Push_n(ref Queue, Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        Pop(ref Queue);
                        break;
                    case 3:
                        Front(Queue);
                        break;
                    case 4:
                        Size(Queue);
                        break;
                    case 5:
                        Clear(ref Queue);
                        break;
                    case 6:
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Нет такой команды!");
                        break;
                }
            }
        }
    }
}
