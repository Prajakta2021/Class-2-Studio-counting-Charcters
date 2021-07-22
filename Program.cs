using System;
using System.Collections.Generic;

namespace class_2_studio_counting_charcters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter a string you want to count the chaeters of : ");
            string stringToChange = Console.ReadLine().ToLower();
           
            //string stringToChange = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.!";
           
            char[] charArray = stringToChange.ToCharArray();
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            for (int i = 0; i < charArray.Length; i++) {
                if (char.IsLetter(charArray[i]))//checks if its alphabet 
                {
                    if (charDictionary.ContainsKey(charArray[i]))// checks if key already added 
                    {
                        charDictionary[charArray[i]] += 1; // if yes adds 1
                    }
                    else
                    {
                        charDictionary.Add(charArray[i], 1);// adds char to key 
                    }
                }

            }
            foreach (KeyValuePair<char, int> charcter in charDictionary)
            {
                Console.WriteLine(charcter.Key + ":" + charcter.Value);
            }
            Console.ReadLine();
        }
    }
}
