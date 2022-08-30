﻿using System;
using System.IO;

class FileDetails
{
    static void Main(string[] args)
    {
        string fileName = args[0];
        FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        int size = (int)stream.Length;
        char[] contents = new char[size];

        for (int i = 0; i < size; i++)
        {
            contents[i] = (char)reader.Read();
        }

        foreach (char c in contents)
        {
            Console.WriteLine(c);
        }
        reader.Close();

        Summarize(contents);
    }
    static void Summarize(char[] contents)
    {
        int vowels = 0, consonants = 0, lines = 0;
        foreach (char current in contents)
        {
            if (Char.IsLetter(current))
            {
                if ("AEIOUaeiou".IndexOf(current) != -1)
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            else if (current == '\n')
            {
                lines++;
            }
        }
        Console.WriteLine("Total no characters: {0}", contents.Length);
        Console.WriteLine("Total no vowels: {0}", vowels);
        Console.WriteLine("Total no consonants: {0}", consonants);
        Console.WriteLine("Total no lines: {0}", lines);
    }


}
