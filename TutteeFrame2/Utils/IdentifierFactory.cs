using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.Utils
{
    class IdentifierFactory
    {
        public static string GenerateID(int length = 10)
        {
            string[] characters = new string[] { "a", "b", "c", "d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                "0","1","2","3","4","5","6","7","8","9" };
            string result = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
                result += characters[random.Next(characters.Length)];
            return result;
        }
    }
}
