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

        public ArithmeticEncoding(BitWriter writer)
        {
            this.writer = writer;
        }

        public void Initialize()
        {
            low = ModelParams.LOW_VALUE;
            high = ModelParams.HIGH_VALUE;
            bits_to_follow = 0;
        }

        public void Encode(int symbol, int[] cum_freq)
        {
            ulong range = (ulong)(high - low) + 1;
            high = (uint)(low + (range * (ulong)cum_freq[symbol - 1]) / (ulong)cum_freq[0] - 1);
            low = (uint)(low + (range * (ulong)cum_freq[symbol]) / (ulong)cum_freq[0]);

            for (; ; )
            {
                if (high < ModelParams.HALF)
                {
                    bit_plus_follow(0);
                }
                else if (low >= ModelParams.HALF)
                {
                    bit_plus_follow(1);
                    low -= ModelParams.HALF;
                    high -= ModelParams.HALF;
                }
                else if (low >= ModelParams.FIST_QUARTER && high < ModelParams.THIRD_QUARTER)
                {
                    bits_to_follow++;
                    low -= ModelParams.FIST_QUARTER;
                    high -= ModelParams.FIST_QUARTER;
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
            bits_to_follow++;
            if (low < ModelParams.FIST_QUARTER)
            {
                bit_plus_follow(0);
            }
            else
            {
                bit_plus_follow(1);
            }
        }

        private void bit_plus_follow(int bit)
        {
            writer.WriteBit(bit);

            while (bits_to_follow > 0)
            {
                writer.WriteBit(~bit);
                bits_to_follow--;
            }
        }
    }
}
