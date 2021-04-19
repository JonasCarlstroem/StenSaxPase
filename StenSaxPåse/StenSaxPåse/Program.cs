using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StenSaxPåse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sten = 1;
            //Sax = 2;
            //Påse = 3;
            int vinst = 0;
            int förlust = 0;
            int aiVinst = 0;
            int aiFörlust = 0;
            string val;
            Random rnd = new Random();
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("Resultat: Dator(V/F): " + aiVinst + "/" + aiFörlust);
                Console.WriteLine("Spelare(V/F): " + vinst + "/" + förlust);
                Console.Write("Sten(1), sax(2) eller påse(3): ");
                val = Console.ReadLine();
                //int val = rnd.Next(1, 3);
                Thread.Sleep(2000);
                int oVal = int.Parse(val);
                int AiVal = rnd.Next(1, 3);
                
                switch (oVal)
                {
                    case 1:
                        switch (AiVal)
                        {
                            case 1:
                                Console.WriteLine("Du valde: Sten\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Sten\n\r");
                                Console.WriteLine("Oavgjort.");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                            case 2:
                                Console.WriteLine("Du valde: Sten\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Sax\n\r");
                                Console.WriteLine("Du vann!");
                                Thread.Sleep(1000);
                                vinst++;
                                aiFörlust++;
                                Console.WriteLine("Du har: " + vinst + " vinster!");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                            case 3:
                                Console.WriteLine("Du valde: Sten\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Påse\n\r");
                                Console.WriteLine("Du förlorade.\n\r");
                                Thread.Sleep(1000);
                                förlust++;
                                aiVinst++;
                                Console.WriteLine("Du har: " + förlust + " förluster!");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                        }
                        break;
                    case 2:
                        switch (AiVal)
                        {
                            case 1:
                                Console.WriteLine("Du valde: Sax\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Sten\n\r");
                                Console.WriteLine("Du förlorade!");
                                Thread.Sleep(1000);
                                förlust++;
                                aiVinst++;
                                Console.WriteLine("Du har: " + förlust + " förluster!");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                            case 2:
                                Console.WriteLine("Du valde: Sax\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Sax\n\r");
                                Console.WriteLine("Oavgjort.");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                            case 3:
                                Console.WriteLine("Du valde: Sax\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Påse\n\r");
                                Console.WriteLine("Du vann!");
                                Thread.Sleep(1000);
                                vinst++;
                                aiFörlust++;
                                Console.WriteLine("Du har: " + vinst + " vinster!");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;

                        }
                        break;
                    case 3:
                        switch (AiVal)
                        {
                            case 1:
                                Console.WriteLine("Du valde: Påse\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Sten\n\r");
                                Console.WriteLine("Du vann!");
                                Thread.Sleep(1000);
                                vinst++;
                                aiFörlust++;
                                Console.WriteLine("Du har: " + vinst + " vinster");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                            case 2:
                                Console.WriteLine("Du valde: Påse\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Sax\n\r");
                                Console.WriteLine("Du förlorade!");
                                Thread.Sleep(1000);
                                förlust++;
                                aiVinst++;
                                Console.WriteLine("Du har: " + vinst + " vinster!");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                            case 3:
                                Console.WriteLine("Du valde: Påse\n\r");
                                Thread.Sleep(1000);
                                Console.WriteLine("Datorn valde: Påse\n\r");
                                Console.WriteLine("Oavgjort.");
                                Thread.Sleep(1000);
                                //_ = Console.Read();
                                break;
                        }
                        break;
                }
                //val = "";
                Console.WriteLine();
                Thread.Sleep(1000);
            }

        }
    }
}
