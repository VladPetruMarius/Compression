using BitIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "flower.jpg";

            string filename_c = "flower_copy.jpg";

            Random rand = new Random();

            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);

            BitReader bitReader = new BitReader(stream);

            BitWriter bitWriter = new BitWriter(filename_c);

            long nbr = stream.Length * 8;

            long nb = 0;

            do
            {
                nb = rand.Next(32) + 1;

                if (nbr < nb)
                    nb = nbr;


                int bits = bitReader.ReadBites((int)nb);
                bitWriter.WriteBits(bits, (int)nb);

                nbr = nbr - nb;

            } while (nbr > 0);

            bitReader.Close();

            bitWriter.Close();
        }
    }
}
