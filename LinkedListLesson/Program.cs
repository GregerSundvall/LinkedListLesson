using System;

namespace ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> words = new LinkedList<string>();
            
            words.Add("asdf");
            words.Add("trew");
            words.Add("gfsd");
            words.Add("bvcx");
            words.Add("ghjk");
            words.Add("yuio");

            Console.WriteLine(words.IndexOf("bvcx"));
            Console.WriteLine(words.GetFromIndex(2));

            /*
            DList<String> words = new DList<String>(4);
            words.Add("Hello");
            words.Add("World");
            words.Add("this");
            words.Add("fine");
            words.Add("day");
            words.Insert(3, "very");
            words.RemoveAt(4);
            words.Remove("World");
            words[0] = "Bye bye";

            String[] otherWords = new string[5];
            words.CopyTo(otherWords, 2);

            for (int i=0; i<words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine("\nCount: " + words.Count);
            Console.WriteLine("Capacity: " + words.Capacity);

            foreach (var word in otherWords)
            {
                Console.WriteLine(word);
            }
            */
        }
    }
}
