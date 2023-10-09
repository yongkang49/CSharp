using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //*********************************
            bool[] b = new bool[] { true, true, true, true, true, true, true, true, true };
            Console.WriteLine(Convert_Binario_To_Intero(b));
            //*********************************
            int[] dp = new int[] { 10, 10 };
            Console.WriteLine(Convert_Decimale_Puntato_To_Intero(dp));
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(bool[] b)
        {

            int decimale = 0;
            for (int i = 0; i < b.Length; i++)
            {
                decimale += Convert.ToUInt16(b[b.Length - i - 1]) * (int)Math.Pow(2, i);
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Intero(int[] dp)
        {
            int decimale = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale += dp[dp.Length - i - 1] * (int)Math.Pow(256, i);
            }
            return decimale;
        }
    }
}
