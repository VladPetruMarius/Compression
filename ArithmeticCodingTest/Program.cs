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
            string filename = "flower.txt";
            string encode_file = "flower.bin";

            string decode_file = "flower_dec.jpg";

            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);

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

                symbol = model.CharToIndex[ch];
                encode.Encode(symbol, model.CumulativeFrequency);
                model.Update(symbol);
            }

            encode.Encode(ModelParams.No_Of_Symbols, model.CumulativeFrequency);
            encode.Flush();
            writer.Close();

            BitReader read = new BitReader(encode_file);

            stream = new FileStream(decode_file, FileMode.OpenOrCreate);

            ArithmeticDecoding decode = new ArithmeticDecoding(read);

            model.Initialize();
            decode.Initialize();

            for (; ; )
            {
                int ch, symbol;
                symbol = decode.Decode(model.CumulativeFrequency);

                if (symbol == ModelParams.EOF_Symbol)
                {
                    break;
                }

                ch = model.IndexToChar[symbol];

                stream.WriteByte((byte)ch);
                model.Update(symbol);
            }

            read.Close();
            stream.Close();

        }
    }
}
