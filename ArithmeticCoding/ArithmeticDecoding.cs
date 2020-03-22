using BitIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
    public class ArithmeticDecoding
    {
        private uint low;
        private uint high;

        private uint value;

        private BitReader reader;

        private uint mask;

        public ArithmeticDecoding(BitReader reader)
        {
            this.reader = reader;
        }

        public void Initialize()
        {
            value = 0;

            for (int i = 1; i <= ModelParams.BITS_USED; i++)
            {
                value <<= 1;
                value |= (uint)reader.ReadBit();
            }

            low = ModelParams.LOW_VALUE;
            high = ModelParams.HIGH_VALUE;
            mask = ModelParams.HIGH_VALUE >> 2;
        }

        public int Decode(int[] cum_freq)
        {
            int symbol;

            ulong range = (ulong)(high - low) + 1;

            int cum = (int)((ulong)(((value - low) + 1) * cum_freq[0] - 1) / range);

            for (symbol = 1; cum_freq[symbol] > cum; symbol++) ;

            high = (uint)(low + (range * (ulong)cum_freq[symbol - 1]) / (ulong)cum_freq[0] - 1);

            low = (uint)(low + (range * (ulong)cum_freq[symbol]) / (ulong)cum_freq[0]);

            Console.WriteLine(symbol);
            for (; ; )
            {
                if ((low & ModelParams.HALF) == (high & ModelParams.HALF))
                {
                    //do nothings
                }
                else if ((low & ModelParams.FIRST_QUARTER) == ModelParams.FIRST_QUARTER && (high & ModelParams.FIRST_QUARTER) == 0)
                {
                    value ^= ModelParams.FIRST_QUARTER;
                    low &= mask;
                    high |= ModelParams.FIRST_QUARTER;
                }
                else
                {
                    break;
                }

                low <<= 1;
                high <<= 1;
                high |= 1;
                value <<= 1;
                value |= (uint)reader.ReadBit();
            }

            return symbol;
        }

    }
}
