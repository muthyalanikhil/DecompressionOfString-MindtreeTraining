using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecompressionOfStrings
{
    class Decompression
    {
        public void DecompressionAlgorithm()
        {
            try
            {
                string input;
                int count = 0, index = 0, iteration = 0;
                Console.WriteLine("\nEnter the string to be decompressed:");
                input = Console.ReadLine();

                string value, alphabet = null;

                for (index = count; index < input.Length; index++)
                {
                    if (char.IsLetter(input[count]))
                    {
                        alphabet = Convert.ToString(input[count]);
                        Console.Write(alphabet);
                        count++;
                    }
                    for (int limit = 0; limit < input.Length; limit++)
                    {
                        value = null;
                        if (char.IsDigit(input[count]))
                        {
                            while (iteration < input.Length)
                            {
                                value = value + input[count];
                                count++;
                                if (count >= input.Length)
                                {
                                    break;
                                }
                                if (char.IsLetter(input[count]))
                                {
                                    break;
                                }
                            }
                        }
                        for (int limis = 0; limis < Convert.ToInt32(value); limis++)
                        {
                            Console.Write(alphabet);
                        }
                        break;
                    }
                    if (count >= input.Length)
                    {
                        break;
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

