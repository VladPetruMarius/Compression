using BitIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "test.txt";
            string encode_file = "test.bin";

            string decode_file = "test_dec.txt";

            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);

          //  StreamReader reader = new StreamReader(filename);

            BitWriter writer = new BitWriter(encode_file);

            Model model = new Model();

            ArithmeticEncoding encode = new ArithmeticEncoding(writer);

            model.Initialize();
            encode.Initialize();

            for (; ; )
            {
                int ch, symbol;

                ch = stream.ReadByte();

                if (ch == -1)
                {
                    break;
                }

                symbol = model.char_to_index[ch];
                encode.Encode(symbol, model.cum_freq);
                model.Update(symbol);
            }

            encode.Encode(Constants.No_Of_Symbols, model.cum_freq);
            encode.Flush();
            writer.Close();

            BitReader read = new BitReader(encode_file);

            stream = new FileStream(decode_file, FileMode.OpenOrCreate);

          //  StreamWriter write = new StreamWriter(decode_file);

            ArithmeticDecoding decode = new ArithmeticDecoding(read);

            model.Initialize();
            decode.Initialize();

            for (; ; )
            {
                int ch, symbol;
                symbol = decode.Decode(model.cum_freq);

                if (symbol == Constants.EOF_Symbol)
                {
                    break;
                }

                ch = model.index_to_char[symbol];

                stream.WriteByte((byte)ch);
                model.Update(symbol);
            }

            read.Close();
            stream.Close();

        }
    }
}
