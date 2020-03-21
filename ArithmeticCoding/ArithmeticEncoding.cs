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
            low = Constants.Low;
            high = Constants.High;
            bits_to_follow = 0;
        }


        public void Encode(int symbol, int[] cum_freq)
        {
            ulong range = (ulong)(high - low) + 1;
            high = (uint)(low + (range * (ulong)cum_freq[symbol - 1]) / (ulong)cum_freq[0] - 1);
            low = (uint)(low + (range * (ulong)cum_freq[symbol]) / (ulong)cum_freq[0]);

            for (; ; )
            {
                if (high < Constants.Half)
                {
                    bit_plus_follow(0);
                }
                else if (low >= Constants.Half)
                {
                    bit_plus_follow(1);
                    low -= Constants.Half;
                    high -= Constants.Half;
                }
                else if (low >= Constants.First_Quarter && high < Constants.Third_Quarter)
                {
                    bits_to_follow++;
                    low -= Constants.First_Quarter;
                    high -= Constants.First_Quarter;
                }
                else
                {
                    break;
                }

                low = 2 * low;
                high = 2 * high + 1;
            }
        }

        public void Flush()
        {
            bits_to_follow++;
            if (low < Constants.First_Quarter)
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
