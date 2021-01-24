using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> il_TelefonKodu = new Dictionary<string, int>();
            il_TelefonKodu.Add("Ankara", 312);
            il_TelefonKodu.Add("istanbul", 212);
            il_TelefonKodu.Add("Ordu", 552);
            il_TelefonKodu.Add("Aydın", 256);
            il_TelefonKodu.Add("Manisa", 236);
            il_TelefonKodu.Add("Samsun", 362);
            il_TelefonKodu.Add("Hatay", 326);


            Console.WriteLine("Listede toplam" + " " + il_TelefonKodu.Items1.Length + " " + "şehir vardır!");
            Console.WriteLine("Bu şehir ve telefon kodları aşağıdaki gibidir;");

            for (int i = 0; i < il_TelefonKodu.Items1.Length; i++)
            {
                Console.WriteLine(il_TelefonKodu.Items1[i] + " : "+ il_TelefonKodu.Items2[i]);
            }


        }
    }
}
