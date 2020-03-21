using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
    public class Model
    {
        private int[] char_to_index;

        private int[] index_to_char;

        private int[] cum_freq;

        private int[] freq;

        public Model()
        {
            char_to_index = new int[ModelParams.No_Of_Chars];

            index_to_char = new int[ModelParams.No_Of_Symbols + 1];

            cum_freq = new int[ModelParams.No_Of_Symbols + 1];

            freq = new int[ModelParams.No_Of_Symbols + 1];
        }

        public void Initialize()
        {
            for (int i = 0; i < ModelParams.No_Of_Chars; i++)
            {
                char_to_index[i] = i + 1;
                index_to_char[i + 1] = i;
            }

            for (int i = 0; i <= ModelParams.No_Of_Symbols; i++)
            {
                freq[i] = 1;
                cum_freq[i] = ModelParams.No_Of_Symbols - i;
            }

            freq[0] = 0;
        }

        public void Update(int symbol)
        {
            int i;
            if (cum_freq[0] == ModelParams.MAX_FREQUENCY)
            {
                int cum;
                cum = 0;
                for (i = ModelParams.No_Of_Symbols; i >= 0; i--)
                {
                    freq[i] = (freq[i] + 1) / 2;
                    cum_freq[i] = cum;
                    cum += freq[i];

                }
            }

            for (i = symbol; freq[i] == freq[i - 1]; i--) ; /* Find symbol's new index. */
            if (i < symbol)
            {
                int ch_i, ch_symbol;
                ch_i = index_to_char[i];        /* Update the translation   */
                ch_symbol = index_to_char[symbol];  /* tables if the symbol has */
                index_to_char[i] = ch_symbol;           /* moved.                   */
                index_to_char[symbol] = ch_i;
                char_to_index[ch_i] = symbol;
                char_to_index[ch_symbol] = i;

            }

            freq[i] += 1;               /* Increment the frequency  */
            while (i > 0)
            {               /* count for the symbol and */
                i -= 1;                 /* update the cumulative    */
                cum_freq[i] += 1;           /* frequencies.             */

            }
        }

        public int[] CharToIndex
        {
            get
            {
                return char_to_index;
            }
            set
            {
                char_to_index = value;
            }
        }

        public int[] IndexToChar
        {
            get
            {
                return index_to_char;
            }
            set
            {
                index_to_char = value;
            }
        }

        public int[] CumulativeFrequency
        {
            get
            {
                return cum_freq;
            }
            set
            {
                cum_freq = value;
            }
        }
    }
}
