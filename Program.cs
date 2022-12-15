using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab
{
    class Program
    {
        public static void RemoveAnnagrams(List<string> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (IsAnnagrams(array[i].ToCharArray(), array[j].ToCharArray()))
                    {
                        array[j] = " ";
                    }
                    
                }
                if (array[i] == " ")
                {
                    array.Remove(array[i]);
                }
            }

        }

        public static bool IsAnnagrams(char[] a, char[] b)
        {
            Array.Sort(a);
            Array.Sort(b);
            if (a.SequenceEqual(b))
                return true;
            else return false;
        }

        public static void Main()
        {
            List<string> array = new List<string> {"moon", "code", "doce", "ecod", "sun", "framer", "frmaer", "frame", "snu"};
            
            Console.WriteLine("Initial array:");
            foreach (string item in array)
                Console.Write(item + " ");
            Console.WriteLine();
            RemoveAnnagrams(array);
            Console.WriteLine("Array without annagrams:");
            foreach (string item in array)
                Console.Write(item + " ");
        }
    }
}