using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitIO
{
    public class BitWriter
    {
        private FileStream stream;

        private byte buffer;

        private int bitCount;

        private const uint mask = 0x80000000;                 /* set a mask on 32-bits */

        public BitWriter(string filename)
        {
            stream = new FileStream(filename, FileMode.OpenOrCreate);

            bitCount = 0;

            buffer = 0x00;
        }

        public BitWriter(FileStream stream)
        {
            this.stream = stream;

            bitCount = 0;

            buffer = 0x00;
        }

        public void WriteBit(int bit)
        {
            buffer = (byte)(buffer << 1);            /* make room for next bit */

            buffer |= (byte)(0x01 & bit);            /* put LSB of bit in LSB of buffer */

            bitCount++;                              /* keep cont of the bits in buffer */

            if (bitCount % 8 == 0)                   /* check if buffer is full */
            {
                Console.WriteLine(buffer);
                stream.WriteByte((byte)buffer);      /* write buffer to file */
            }
        }

        public void WriteBits(int bits, int count)
        {
            bits = bits << (32 - count);                    /* bring the bits to the MSB */

            for (int i = 0; i < count; i++)
            {
                byte bit = (byte)((mask & bits) >> 31);     /* take the MSB */

                WriteBit(bit);

                bits = (int)(bits << 1);                    /* shift the rest to MSB */
            }
        }

        public void Close()
        {
            if (bitCount % 8 != 0)
            {
                WriteBits(0, 7);
            }

            bitCount = 0;
            buffer = 0x00;
            stream.Close();
        }

        public int BitCount
        {
            get
            {
                return bitCount;
            }
        }
    }
}
