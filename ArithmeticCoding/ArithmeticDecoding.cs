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

        public ArithmeticDecoding(BitReader reader)
        {
            this.reader = reader;
        }

        public void Initialize()
        {
            value = 0;

            for (int i = 1; i <= Constants.BitsUsed; i++)
            {
                value = 2 * value + (uint)reader.ReadBit();
            }

            low = Constants.Low;
            high = Constants.High;
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
                if (high < Constants.Half)
                {
                    //do nothings
                }
                else if (low >= Constants.Half)
                {
                    value -= Constants.Half;
                    low -= Constants.Half;
                    high -= Constants.Half;
                }
                else if (low >= Constants.First_Quarter && high < Constants.Third_Quarter)
                {
                    value -= Constants.Third_Quarter;
                    low -= Constants.Third_Quarter;
                    high -= Constants.Third_Quarter;
                }
                else
                {
                    break;
                }

                low = 2 * low;
                high = 2 * high + 1;
                value = 2 * value + (uint)reader.ReadBit();
            }

            return symbol;
        }

    }
}
