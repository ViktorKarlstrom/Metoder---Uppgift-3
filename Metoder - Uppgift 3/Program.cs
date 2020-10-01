using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Metoder___Uppgift_3
{
    class Program
    {
        //3. Skapa ett program med en ny metod.Metoden skall ta emot två inparametrar av typen string
        //och slå ihop dom till en sträng och returnera det nya värdet.Anropa den nya metoden från
        //Main och skriv ut resultatet på skärmen.

        static void Main(string[] args)
        {
            Console.WriteLine(ReturnString("hej", "då"));
            string x = "abc";
            x = "def";
            int i = 12345;
            i = 6789;
        }

        static string ReturnString(string text, string text2)
        {
            string fullText = text + text2;

            return fullText;
            
        }
    }
}
