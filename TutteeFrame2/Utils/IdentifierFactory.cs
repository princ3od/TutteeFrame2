using System;

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
        public static string GenerateNumberID(int length = 6)
        {
            if (length < 1) return null;
            int result = (new Random()).Next((int)Math.Pow(10, length - 1), (int)Math.Pow(10, length) - 1);
            return result.ToString();
        }
    }
}
