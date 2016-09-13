using System;
using System.Linq;

namespace _04_Pig_Latin
{
    public class Translator
    {
        public Translator()
        {
        }
        public string Translate(string v)
        {
            char firstletter = v[0];
            char secondletter = v[1];
            char[] vowels = new char[5] { 'a', 'e', 'u', 'i', 'o' };
            string[] words;
            words = v.Split(' ');
            foreach (string word in words)
            {
                if (vowels.Contains(firstletter))
                {
                    v = v + "ay";
                }
                else
                {
                    if (vowels.Contains(secondletter))
                    {
                        string bob = "";
                        bob = v.Substring(1);
                        v = bob + firstletter + "ay";
                    }
                    else
                    {
                        string eli = "";
                        eli = v.Substring(2);
                        v = eli + firstletter + secondletter + "ay";
                    }
                }
            }
            

            return v;
        }
    }

}