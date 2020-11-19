using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Tool.Library.ConsoleIo
{
    public class RandomAdv : Random
    {
        public RandomAdv()
        {
        }

        public RandomAdv(int Seed) : base(Seed)
        {
        }

        public string NextString(int length)
        {
            string randomString = string.Empty;
            int randomChar = 0;

            for (int i = 0; i < length; i++)
            {
                int isUpperCase = this.Next(0, 2); //0 = false, 1 = true
                if (isUpperCase == 0)
                {
                    randomChar = this.Next('a', 'z' + 1);
                }
                else
                {
                    randomChar = this.Next('A', 'Z' + 1);
                }
                randomString += (char)randomChar;
            }

            return randomString;

        }
    }
}

//char[] myCharacterList = new char[65];

//int zufallsIndex = this.Next(0, 66);           
// zufallsstring += myCharacterList[zufallsIndex].ToString();

//int upperCaseChar = this.Next(65, 91);
//int lowerCaseChar = this.Next(97, 123);
