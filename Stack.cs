using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TestStack
    {
        public static void Main()
        {
            IntStack s = new IntStack();
            s.Push(10);
            s.Push(20);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            StringStack ss = new StringStack();
            ss.Push("First");
            ss.Push("Second");
            Console.WriteLine(ss.Pop());
        }
    }

    // Generic Stack 
    class Stack<T>
    {
        private T[] data = new T[10];
        private int top = 0;

        public void Push(T value)
        {
            data[top] = value;
            top++;
        }
        public T Pop()
        {
            top--;
            return data[top];
        }
    }


    class IntStack
    {
        private int[] data = new int[10];
        private int top = 0;

        public void Push(int n)
        {
            data[top] = n;
            top++;
        }

        public int Pop()
        {
            top--;
            return data[top];
        }

    }

    class StringStack
    {
        private string [] data = new string[10];
        private int top = 0;

        public void Push(string value)
        {
            data[top] = value;
            top++;
        }

        public string Pop()
        {
            top--;
            return data[top];
        }

    }
}
