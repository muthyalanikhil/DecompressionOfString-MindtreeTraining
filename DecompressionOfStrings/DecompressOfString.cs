using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecompressionOfStrings
{
    class DecompressOfString
    {
        public void DecompressionAlgorithm()
        {
            try
            {
                string input;
                int count = 0, index = 0;
                Console.WriteLine("\nEnter the string to be decompressed:");
                input = Console.ReadLine();

                for (count = index; count < input.Length; count++)
                {
                    if (char.IsDigit(input[count]))
                    {




                        int number = input[count] - 48;
                        for (int k = 0; k < number; k++)
                        {
                            Console.Write(input[count - 1]);
                        }
                    }
                    else
                    {
                        Console.Write(input[count]);
                        index = count;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n{0}.\nInvalid Input", exception.Message);
            }
            try
            {
                Console.WriteLine("\nPress y to compress another string and n to exit ? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    CompressionOfString compressor = new CompressionOfString();
                    compressor.CompressionAlgorithm();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

