//Problem 7. Encode/decode• Write a program that encodes and decodes a string using given encryption key (cipher).
//• The key consists of a sequence of characters. 
//• The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.
//input RT , 45 = FA
//input FA ,45 =RT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Enter string");
        string text = Console.ReadLine();
        Console.WriteLine("Enter cipher");
        string cipher = Console.ReadLine();

        string code = StringEncoder(text, cipher);
        Console.WriteLine(code);
    }

    private static string StringEncoder(string text, string cipher)
    {
        StringBuilder output = new StringBuilder(text.Length);
        
        for (int i = 0; i < text.Length; i++)
        {
            int j = i % cipher.Length;
            output.Append((char)(text[i] ^ cipher[j]));
        }
        return output.ToString();
    }
}
