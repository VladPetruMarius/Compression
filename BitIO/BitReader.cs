using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitIO
{
    public class BitReader
    {
        private FileStream stream;

        private int buffer;

        private int bitCount;

        private BinaryReader binaryReader;

        public BitReader(string filename)
        {
            stream = new FileStream(filename, FileMode.OpenOrCreate);
            binaryReader = new BinaryReader(stream);

            bitCount = 0;
        }

        public BitReader(FileStream stream)
        {
            this.stream = stream;
            binaryReader = new BinaryReader(this.stream);

            bitCount = 0;
        }

        public int ReadBit()
        {
            byte bit = 0;

            if (bitCount % 8 == 0)                    /* check if buffer is empty */
            {
                buffer = stream.ReadByte();     /* read byte form file */
            }

            bit = (byte)((0x80 & buffer) >> 7);       /* take MSB form buffer */

            buffer = (byte)(buffer << 1);             /* shift left to eliminate MSB */

            bitCount++;                               /* increase to know how many bits remains */

            return bit;
        }

        public int ReadBites(int count)
        {
            int bites = 0;

            for (int i = 0; i < count; i++)       /* read bit by bit */
            {
                bites = (int)(bites << 1);        /* shift right to make room in LSB */

                bites |= ReadBit();               /* add read bit in LSB */
            }

            return bites;
        }

        public void Close()
        {
           // binaryReader.Close();

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
