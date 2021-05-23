using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.Utils
{
    class IdentifierFactoryV2
    {
        public static string GenerateNumberID(int length = 6)
        {
            if (length < 1) return null;
            int result = (new Random()).Next((int)Math.Pow(10,length-1),(int)Math.Pow(10,length)-1);
            return result.ToString();
        }
    }
}
