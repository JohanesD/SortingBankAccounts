using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SortingBankAccounts
{
    class SortingBankAccount
    {
        static void Main(string[] args)
        {
            int countCases;
            Int32.TryParse(Console.ReadLine(), out countCases);

            for (int i = 0; i < countCases; i++)
            {
                int arraySize;
                Int32.TryParse(Console.ReadLine(), out arraySize);
                Hashtable table = new Hashtable();
                for (int j = 0; j < arraySize; j++)
                {
                    string key = Console.ReadLine();
                    if (!table.ContainsKey(key))
                    {
                        table.Add(key, 1);
                    }
                    else
                    {
                        int actualCount = (int)table[key];
                        actualCount++;
                        table[key] = actualCount;
                    }
                }
                SortedDictionary<string, int> sorterDictionary = new SortedDictionary<string, int>();
                ICollection keys = table.Keys;

                foreach (string key in keys)
                {
                    sorterDictionary.Add(key, (int)table[key]);
                }
                foreach (var item in sorterDictionary)
                {
                    Console.WriteLine("{0} {1}", item.Key, item.Value);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
