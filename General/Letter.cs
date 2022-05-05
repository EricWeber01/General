using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class Letter
    {
        char L = 'A';
        int End { get; set; }
        public Letter(int _end) => End = _end;
        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < End; i++)
            {
                yield return L++;
            }
        }
    }
}