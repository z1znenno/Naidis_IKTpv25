using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            // Console.ForegroundColor = ConsoleColor.Blue;
            string tekst = "Tere tulemast C#'i maailma";
            // System.Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            // System.Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);
            Console.Write("Mis on sinu nimi: ");
            string nimi = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Kui vana sa oled: ");
                    byte vanus = Convert.ToByte(Console.ReadLine());
                    System.Console.WriteLine($"Tere, {nimi}. Sa oled {vanus} aastat vana!");
                    break;  
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
            while (true)
            {
                try
                {
                    System.Console.Write("Sisestage arv 1: ");
                    float a = float.Parse(Console.ReadLine());
                    System.Console.Write("Sisestage arv 2:");
                    float b = float.Parse(Console.ReadLine());
                    float res = Naidis_funktsioonid.Summa(a, b);
                    System.Console.WriteLine(res);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }    
            }         
            
        }
    }
}