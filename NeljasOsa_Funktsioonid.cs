using System;

namespace Naidis_IKTpv25
{
    class NeljasOsa_Finktsioonid
    {
        public static void Faili_kirjutamine()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt"); //@"..\..\..\Kuud.txt"
            try
            {
          
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
            //StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("Midagi");
            //sw.Close(); // Vajalik!
            
            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine("Midagi");
            //} // Fail suletakse automaatselt siin
        }
        public static void Faili_lugemine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused); 
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static void Ridade_lugemine()
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }
    }
}