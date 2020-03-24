using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
    public class ModelParams
    {
        public static readonly int BITS_USED = 32;

        public static readonly uint LOW_VALUE = 0u;

        public static readonly uint HIGH_VALUE = uint.MaxValue;

        public static readonly uint HALF = 1u << (BITS_USED - 1);

        public static readonly uint FIRST_QUARTER = (1u << (BITS_USED - 1)) >> 1;

        public static readonly uint THIRD_QUARTER = HALF | FIRST_QUARTER;

        public static readonly uint MAX_FREQUENCY = (1u << (BITS_USED - 2)) - 1;


        public static int No_Of_Chars = 256;

        public static int No_Of_Symbols = No_Of_Chars + 1;

        public static int EOF_Symbol = No_Of_Chars;
    }
}
