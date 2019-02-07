using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractices
{
    public class FrequencyOfCharactersInAString
    {
        static void Main(string[] args)
        {
            var sentence = "Tekrar eden harfleri bulmaca";

            var result = JoinDictionaryElements(FindFrequencyOfCharactersInAString(sentence));

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static Dictionary<char, int> FindFrequencyOfCharactersInAString(string sentence)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                var character = char.ToLower(sentence[i]);
                if (!char.IsWhiteSpace(character))
                {
                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character] += 1;
                    }
                    else
                    {
                        dictionary.Add(character, 1);
                    }
                }
            }

            return dictionary;
        }

        public static string JoinDictionaryElements(Dictionary<char, int> dictionary)
        {
            var lines = dictionary.Select(x => x.Key + ": " + x.Value);
            return string.Join(", ", lines);
        }
    }
}
