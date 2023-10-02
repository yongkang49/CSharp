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
            int decimale = 0;
            string bit;
            bool[] binario = new bool[32];
            Console.WriteLine("inserisci i bit");
            bit = Console.ReadLine();
            for (int i = 0; i < bit.Length; i++)
            {

                if (bit[i] == '1')
                {
                    binario[i] = true;
                }
            }
            decimale = Convert_Binario_To_Intero(binario);
            if (decimale == -1)
            {
                Console.WriteLine("4294967295");
            }
            else
            {
                Console.WriteLine(decimale);
            }
            int[] dp = new int[4];
            for (int i = 0; i < dp.Length; i++)
            {
                Console.WriteLine($"inserisci la {i + 1} cifra in decimale puntato");
                dp[i] = Convert.ToInt16(Console.ReadLine());
            }
            decimale = Convert_Decimale_Puntato_To_Intero(dp);
            if (decimale == -1)
            {
                Console.WriteLine("4294967295");
            }
            else
            {
                Console.WriteLine(decimale);
            }
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(bool[] b)
        {

            int decimale = 0;
            for (int i = 0; i < b.Length; i++)
            {
                decimale += Convert.ToInt16(b[i]) * (int)Math.Pow(2, i);
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Intero(int[] dp)
        {
            int decimale = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale += dp[i] * (int)Math.Pow(256, i);
            }
            return decimale;
        }
    }
}
