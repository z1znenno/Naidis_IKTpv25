using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Naidis_IKTpv25
{
    public class TeineOsa_funktsioonid
    {
        public static string Juku(string nimi)
        {
            string vastus = "";
            string pilet = "";
            if (nimi.ToLower() == "juku")
            {
                try
                {
                    System.Console.Write("Kui vana Juku on: ");
                    byte vanus = byte.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus < 100)
                    {
                        switch (vanus)
                        {
                            case <= 6:
                                pilet = "tasutapilet";
                                break;
                            case <= 14:
                                pilet = "lastepilet";
                                break;
                            case <= 65:
                                pilet = "täispilet";
                                break;
                            case <= 100:
                                pilet = "sooduspilet";
                                break;
                        }
                    vastus = $"{nimi.ToUpper()}, me läheme kinno, sul on vaja {pilet}";
                    }
                    else
                    {
                        vastus = "Vale andmed";
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
            else
            {
                vastus = "Me läheme kinno ainult Jukuga";
            }
            return vastus;
        }
    }
}