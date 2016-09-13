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
            char[] vowels = new char[5] { 'a', 'e', 'u', 'i', 'o' };
            if (vowels.Contains (firstletter))
            {
                v = v + "ay";
            }
            else
            {
                string bob = "";
                bob = bob.Substring(1);
                v = bob + firstletter + "ay";
            }
            return v;
        }
    }
}