using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Bits
{
    internal class Bits
    {
        public Bits(long b)
        {
            this.Value = b;
        }
        public Bits(int c)
        {
            this.Value2 = c;

        }
        public Bits(byte d)
        {
            this.Value3 = d;
        }

        public long Value { get; private set; } = 0;
        public int Value2 { get; private set; } = 0;
        public int Value3 { get; private set; } = 0;


        public static implicit operator Bits(long b) => new Bits(b);
        public static implicit operator Bits(int c) => new Bits(c);
        public static implicit operator Bits(byte d) => new Bits(d);
    }
}
