using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecompressionOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to compress the string and 2 to Decompress");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                CompressionOfString compressor = new CompressionOfString();
                compressor.CompressionAlgorithm();
            }
            else
            {
                if (input == "2")
                {
                    Decompression decompressor = new Decompression();
                    decompressor.DecompressionAlgorithm();
                }
            }
        }
    }
}
