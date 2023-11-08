using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_4_Method
{
    internal class Deque<T>
    {
        private DoublyNode<T> Head;
        private DoublyNode<T> Tail;
        private int Count = 0;

        public void AddFirst(T data)
        {
            DoublyNode<T> Node = new DoublyNode<T>(data);
            DoublyNode<T> Temp = Head;
            Node.Next = Temp;
            Head = Node;
            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                Temp.Previous = Node;
            }
            Count++;
        }

        public void AddLast(T data)
        {
            DoublyNode<T> Node = new DoublyNode<T>(data);
            Tail.Next = Node;
            Node.Previous = Tail;
            Tail = Node;
            Count++;
        }

        public void Print()
        {
            DoublyNode<T> Print = Head;
            int Numb = 0;
            while (Numb < Count)
            {
                Console.WriteLine("{0}) {1}", Numb + 1, Print.Data);
                Numb++;
                Print = Print.Next;
            }
            Console.WriteLine();
        }

        public int Search(T data)
        {
            DoublyNode<T> search = Head;
            int Numb = 0;
            while (search != null) // или надо 
            {
                if (search.Data.Equals(data))
                {
                    return Numb + 1;
                }
                Numb++;
                search = search.Next;
            }
            return -1;
        }

        public void Delete_First()
        {
            if (Head != null) // проверить выдаст ли ошибку если это закоментить?
            {
                Head = Head.Next;
                if (Head != null)
                {
                    Head.Previous = null;

                }
                Count--;
            }
        }

        public void Delete_Last()
        {
            if (Tail != null)
            {
                Tail = Tail.Previous;
                if (Tail != null)
                {
                    Tail.Next = null;
                }
                Count--;
            }
        }

        public void Delete_Searching(T data)
        {
            DoublyNode<T> delete_searching = Head;
            while (delete_searching != null)
            {
                if (delete_searching.Data.Equals(data))
                {
                    break;
                }
                delete_searching = delete_searching.Next;
            }

            if (delete_searching.Next != null)
            {
                delete_searching.Next.Previous = delete_searching.Previous;
            }
            else
            {
                Tail = delete_searching.Previous;
            }

            if (delete_searching.Previous != null)
            {
                delete_searching.Previous.Next = delete_searching.Next;
            }
            else
            {
                Head = delete_searching.Next;
            }

            Count--;
        }

        public void Delete_All()
        {
            while (Count != 0)
            {
                Delete_First();
            }
        }
    }
}
