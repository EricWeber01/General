using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class Poind2D<T>
    {
        T X { get; set; }
        T Y { get; set; }
        public Poind2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public void ShowPoint()
        {
            Console.WriteLine($"X - {X} | Y - {Y} ");
        }
    }
}
