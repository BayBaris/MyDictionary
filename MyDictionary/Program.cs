using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yapıyı anlamak için yazılan satır...
            Dictionary<int, string> sozluk = new Dictionary<int, string>();
            sozluk.Add(58, "Sivas");

            MyDict<int, string> plakalar = new MyDict<int, string>();
            plakalar.Add(77, "Yalova");
            plakalar.Add(35, "İzmir");
            plakalar.Add(45, "Manisa");
            plakalar.Add(06, "Ankara");
            plakalar.Add(09, "Aydın");
            plakalar.Add(58, "Sivas");
            foreach (var plakano in plakalar.Keys)
            {               
                Console.WriteLine(plakano);
            }
            foreach (var sehir in plakalar.Values)
            {
                Console.WriteLine(sehir);
            }


        }
    }
    
}
