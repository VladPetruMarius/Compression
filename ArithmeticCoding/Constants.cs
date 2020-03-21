using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
    public class Constants
    {
        public static readonly int BitsUsed = 32;

        public static readonly uint Low = 0u;

        public static readonly uint High = uint.MaxValue;

        public static readonly uint Half = 1u << (BitsUsed - 1);

        public static readonly uint First_Quarter = (1u << (BitsUsed - 1)) >> 1;

        public static readonly uint Third_Quarter = Half | First_Quarter;

        public static readonly uint MAX_FREQ = (1u << (BitsUsed - 2)) - 1;


        public static readonly int No_Of_Chars = 256;

        public static readonly int No_Of_Symbols = No_Of_Chars + 1;

        public static readonly int EOF_Symbol = No_Of_Chars + 1;
    }
}
