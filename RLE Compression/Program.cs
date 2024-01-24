using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE_Compression
{
    class Program
    {
        static void Main(string[] args)
        {

            string s2 = "";
            int i;
            int counter = 1;

            Console.WriteLine("Enter the string you want to comrpess.");
            string userinput = Console.ReadLine();
            Console.WriteLine("You have entered: " + userinput);

            char[] userinputarr = userinput.ToCharArray();


            for (i = 0; i < userinput.Length - 1; i++)
            {

                if (userinputarr[i] == userinputarr[i + 1])
                {
                    
                    counter++;

                }
                else
                {
                    s2 += userinput[i];
                    s2 += counter + " ";
                    counter = 1;
                }
            }

            Console.WriteLine("Output " + "\n" + s2);
            Console.ReadLine();
        }
    }
}
