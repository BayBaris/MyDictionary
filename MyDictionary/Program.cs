﻿using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sozluk = new Dictionary<int, string>();
            sozluk.Add(58, "Sivas");

            MyDict<int, string> plaka = new MyDict<int, string>();
            plaka.Add(77, "Yalova");
            
        }
    }
    class MyDict<Tkeys,Tvalues>
    {
        Tkeys[] tkeys;
        Tvalues[] tvalues;
        Tkeys[] tempKeys;
        Tvalues[] tempValues;

        public MyDict()
        {
            tkeys = new Tkeys[0];
            tvalues = new Tvalues[0];

        }

        public void Add(Tkeys keyitem,Tvalues keyvalue)
        {
            tempKeys = tkeys;
            tempValues = tvalues;

            tkeys = new Tkeys[tkeys.Length + 1];
            tvalues = new Tvalues[tvalues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                tkeys[i] = tempKeys[i];
                tvalues[i] = tempValues[i];
            }

            tkeys[tkeys.Length - 1] = keyitem;
            tvalues[tvalues.Length - 1] = keyvalue;

        }

    }
  
}
