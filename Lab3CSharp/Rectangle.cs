using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Rectangle
    {
        protected int a, b;
        protected int c;

        public int SideA
        {
            get
            {
                return a;
            }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
                else
                {
                    throw new InvalidOperationException("Attemt to accept negative value of rectangle side");
                }
            }
        }
        public Rectangle() : this(1, 1, 0) { }
        public Rectangle(int a, int b) : this(a, b, 0) { }
        public Rectangle(int a, int b, int c)
        {
            SideA = a;
            SideB = b;
            if (c >= 0 && c <= 15)
            {
                this.c = c;
            }
            else
            {
                throw new ArgumentException("Out of range possible colors");
            }
        }
        
        public int SideB
        {
            get
            {
                return b;
            }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException("Attemt to accept negative value of rectangle side");
                }
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return (ConsoleColor)c;
            }
        }
        public void PrintSides()
        {
            Console.WriteLine("a sides = {0}", a);
            Console.WriteLine("b sides = {0}", b);
        }
        public int CalculatePerimetr()
        {
            return 2 * (a + b);
        }
        public int CalculateArea()
        {
            return a * b;
        }

        public bool IsSquare()
        {
            return (a == b);
        }
    }
}
