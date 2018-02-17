using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecompressionOfStrings
{
    class CompressionOfString
    {
        public void CompressionAlgorithm()
        {
            try
            {
                string input, output = null, result = null;
                int count = 0, i;
                Console.WriteLine("Enter the string to be compressed:");
                input = Console.ReadLine();
                input = input.ToLower();
                char compare = input[0];

                for (i = 0; i < input.Length; i++)
                {
                    if (compare == input[i])
                    {
                        count++;
                    }
                    else
                    {
                        if ((count - 1) == 0)
                        {
                            output = Convert.ToString(input[i - 1]);
                            result = result + output;
                            compare = input[i];
                            count = 0;
                            i = i - 1;
                        }
                        else
                        {
                            output = input[i - 1] + (count - 1).ToString();
                            result = result + output;
                            compare = input[i];
                            count = 0;
                            i = i - 1;
                        }

                    }
                }
                if ((count - 1) == 0)
                {
                    output = Convert.ToString(input[i - 1]);
                    result = result + output;
                }
                else
                {
                    output = input[i - 1] + (count - 1).ToString();
                    result = result + output;
                }
                if (input.Length > result.Length)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n{0}.\nInvalid Input", exception.Message);
            }
            try
            {
                Console.WriteLine("Want to decompress the string ? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    DecompressOfString decompressor = new DecompressOfString();
                    decompressor.DecompressionAlgorithm();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}