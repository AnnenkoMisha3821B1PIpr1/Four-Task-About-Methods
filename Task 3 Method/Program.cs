using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Method
{
    
    internal class Program
    {

        static bool CheckBrackets(string text, ref int extraLeftCount, ref int extraRightPosition)
        {
            int[] Stack = new int[0];
            for(int i = 0; i < text.Length; i++)
            {
                char check = text[i];
                if (check == '(')
                {
                    Array.Resize(ref Stack, Stack.Length+1);
                    Stack[Stack.Length-1] = i;
                }
                else if (check == ')')
                {
                    if (Stack.Length == 0)
                    {
                        extraRightPosition = i;
                        return false;
                    }

                    Array.Resize(ref Stack, Stack.Length-1);
                }
            }
            if (Stack.Length > 0)
            {
                extraLeftCount = Stack.Length;
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int extraLeftCount = 0;
            int extraRightPosition = -1;
            bool isBalanced = CheckBrackets(text, ref extraLeftCount, ref extraRightPosition);

            if (isBalanced == true)
            {
                Console.WriteLine("да");
            }
            else
            {
                if (extraLeftCount > 0)
                {
                    Console.WriteLine("Нет, количество лишних левых {0}", extraLeftCount);
                }
                else if(extraRightPosition > -1)
                {
                    Console.WriteLine("Нет, лишняя правая скобка на позиции {0}", extraRightPosition+1);
                }
            }
            Console.ReadKey();
        }
    }
}
