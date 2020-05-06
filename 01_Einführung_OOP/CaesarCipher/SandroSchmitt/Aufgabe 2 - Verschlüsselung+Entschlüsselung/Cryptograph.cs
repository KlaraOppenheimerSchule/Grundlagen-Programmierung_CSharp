using NetSpell.SpellChecker;
using NetSpell.SpellChecker.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Aufgabe_2___Verschlüsselung_Entschlüsselung
{
    class Cryptograph
    {
        public string Encrypt(string textToEncrypt, int key)
        {
            string encryptedString = "";

            foreach (char character in textToEncrypt)
            {
                int asciiChar = Convert.ToInt32(character) + key;
                asciiChar = asciiChar > 126 ? asciiChar - 95 : asciiChar;

                encryptedString += (char)asciiChar;
            }

            return encryptedString;
        }

        public string Decrypt(string textToDecrypt, int key)
        {
            string decryptedString = "";

            foreach (char character in textToDecrypt)
            {
                int asciiChar = Convert.ToInt32(character) - key;
                asciiChar = asciiChar < 32 ? asciiChar + 95 : asciiChar;

                decryptedString += (char)asciiChar;
            }

            return decryptedString;
        }

        public void FindWord(string text)
        {
            bool wordFound = false;
            string foundText = "";

            Spelling oSpell = new Spelling();

            for (int key = 1; key <= 95; key++)
            {
                string textToTest = Decrypt(text, key);
                string[] words = textToTest.Split(' ');

                foreach (string word in words)
                {
                    if (oSpell.TestWord(word))
                    {
                        wordFound = true;
                        foundText = textToTest;
                        break;
                    }
                }
            }

            Console.WriteLine(wordFound ? foundText : "Kein Wort gefunden!");
        }
    }
}
