using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Four_Task_About_Methods
{
    internal class Program
    {
        static void Push_n(int n, ref int[] Stack)
        {
            if (Stack.Length <= 100)
            {
                Array.Resize(ref Stack, Stack.Length + 1);
                Stack[Stack.Length - 1] = n;
                Console.WriteLine("\nok\n");
            }
            else
            {
                Console.WriteLine("Количество элментов в стеке при добавлении превосходит 100 элементов");
            }
        }
        static void Pop(ref int[] Stack)
        {
            if (Stack.Length > 0)
            {
                Console.WriteLine("\n{0}\n", Stack[Stack.Length - 1]);
                Array.Resize(ref Stack, Stack.Length - 1);
            }
            else
            {
                Console.WriteLine("\nСтек пуст!\n");
            }
        }
        static void Back(int[] Stack)
        {
            if (Stack.Length > 0)
            {
                Console.WriteLine("\n{0}\n", Stack[Stack.Length - 1]);
            }
            else
            {
                Console.WriteLine("\nСтек пуст!\n");
            }
        }
        static void Size(int[] Stack)
        {
            Console.WriteLine("\n{0}\n", Stack.Length);
        }
        static void Clear(ref int[] Stack)
        {
            Array.Resize(ref Stack, 0);
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
            int[] Stack = new int[0];
            while (true)
            {
                Console.Write("Выберите команду:\n1) Push\n2) Pop\n3) Back\n4) Size\n5) Clear\n6) Exit\nВаш выбор: ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Write("\npush ");
                        Push_n(Convert.ToInt32(Console.ReadLine()), ref Stack);
                        break;
                    case 2:
                        Pop(ref Stack);
                        break;
                    case 3:
                        Back(Stack);
                        break;
                    case 4:
                        Size(Stack);
                        break;
                    case 5:
                        Clear(ref Stack);
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
