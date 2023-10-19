using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Calculator
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
        public string Input()
        {
            return Console.ReadLine();
        }
        public ConsoleKeyInfo InputKey()
        {
            return Console.ReadKey();
        }
        public void Add(int op1,int op2)
        {
            Display("Add, Total is :" + (op1 + op2));
        }
        public void Sub(int op1, int op2)
        {
            Display("Sub, Total is :" + (op1 - op2));
        }
        public void Mul(int op1, int op2)
        {
            Display("Mul, Total is :" + (op1 * op2));
        }
        public void Div(int op1, int op2)
        {
            Display("Div, Total is :" + (op1 / op2));
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
