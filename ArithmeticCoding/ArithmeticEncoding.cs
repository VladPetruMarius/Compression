using BitIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
    public class ArithmeticEncoding
    {
        private uint low;
        private uint high;

        private int bits_to_follow;

        private BitWriter writer;

        private uint mask;
        public ArithmeticEncoding(BitWriter writer)
        {
            this.writer = writer;
        }

        public void Initialize()
        {
            low = ModelParams.LOW_VALUE;
            high = ModelParams.HIGH_VALUE;
            bits_to_follow = 0;

            mask = ModelParams.HIGH_VALUE >> 2;
        }

        public void Encode(int symbol, int[] cum_freq)
        {
            ulong range = (ulong)(high - low) + 1;
            high = (uint)(low + (range * (ulong)cum_freq[symbol - 1]) / (ulong)cum_freq[0] - 1);
            low = (uint)(low + (range * (ulong)cum_freq[symbol]) / (ulong)cum_freq[0]);

            for (; ; )
            {
                if ((low & ModelParams.HALF) == (high & ModelParams.HALF))
                {
                    int bit = (int)((high & ModelParams.HALF) >> (ModelParams.BITS_USED - 1));

                    writer.WriteBit(bit);
                    while (bits_to_follow > 0)
                    {
                        bit = (int)((~high & ModelParams.HALF) >> (ModelParams.BITS_USED - 1));
                        writer.WriteBit(bit);
                        bits_to_follow--;
                    }
                }
                else if ((low & ModelParams.FIRST_QUARTER) != 0 && (high & ModelParams.FIRST_QUARTER) == 0)
                {
                    bits_to_follow++;
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
            }
        }

        public void Flush()
        {
            int bit = (int)((low & ModelParams.FIRST_QUARTER) >> (ModelParams.BITS_USED - 2));
            writer.WriteBit(bit);

            bits_to_follow++;

            while (bits_to_follow > 0)
            {
                bit = (int)((~low & ModelParams.FIRST_QUARTER) >> (ModelParams.BITS_USED - 2));
                writer.WriteBit(bit);
                bits_to_follow--;
            }
        }
    }
}
