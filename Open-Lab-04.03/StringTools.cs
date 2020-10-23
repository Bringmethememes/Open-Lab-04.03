using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length < 2)
            {
                return original;
            }
            else
            {
                char[] bruh = new char[original.Length - 1];
                for (int i = 0; i < original.Length- 1; i++)
                {
                    bruh[i] = original[i];
                }
                Array.Reverse(bruh);
                char[] bruh2 = new char[bruh.Length - 1];
                for (int i = 0; i < bruh.Length - 1; i++)
                {
                    bruh2[i] = bruh[i];
                }
                Array.Reverse(bruh2);
                string blyat = string.Join("", bruh2);
                return blyat;
            }












            



        }
    }
}
