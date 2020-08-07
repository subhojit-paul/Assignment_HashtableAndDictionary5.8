using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DiffHashtableAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Parts......");
            Dictionary<string, string> dt = new Dictionary<string, string>();

            // Using Add() method 
            dt.Add("1", "My");
            dt.Add("2", "Naame");
            dt.Add("3", "Is");
            dt.Add("4", "Subhojit");
            dt.Add("5", "Paul");

            foreach (KeyValuePair<string, string> item in dt)
            {
                Console.WriteLine("Key:- {0} and Value:- {1}", item.Key, item.Value);
            }

            Console.WriteLine("***********************");
            Console.WriteLine("Hashtable Parts....");


            Hashtable ht = new Hashtable();


            // Using Add() method 
            ht.Add("A1", "to");
            ht.Add(2, "score");
            ht.Add('C', "70%");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("Key:- {0} & Value:- {1} ", item.Key, item.Value);

            }


            StringCollection myCol = new StringCollection();

            String[] myArr1 = new String[] { "A", "B", "C", "D", "E" };
            myCol.AddRange(myArr1);

            String[] myArr2 = new String[myCol.Count];

            myCol.CopyTo(myArr2, 0);
            Console.WriteLine("*******StringCollection********");
            foreach (var item in myArr2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***********************");

            StringDictionary myDict = new StringDictionary();

            myDict.Add("A", "Apple");
            myDict.Add("B", "Banana");
            myDict.Add("C", "Cat");
            myDict.Add("D", "Dog");
            myDict.Add("E", "Elephant");
            Console.WriteLine("*************String Dictionary*******");
            foreach (DictionaryEntry dic in myDict)
            {
                Console.WriteLine(dic.Key + " " + dic.Value);
            }



            Console.WriteLine("***********************");

            ListDictionary myDict1 = new ListDictionary();


            myDict1.Add("Australia", "Canberra");
            myDict1.Add("Belgium", "Brussels");
            myDict1.Add("Netherlands", "Amsterdam");
            myDict1.Add("China", "Beijing");
            myDict1.Add("Russia", "Moscow");
            myDict1.Add("India", "New Delhi");

            // To get count of key/value pairs in myDict 
            Console.WriteLine("Total key/value pairs in myDict1 are : " + myDict1.Count);

            // Displaying the key/value pairs in myDict 
            Console.WriteLine("**********ListDictionary************");

            foreach (DictionaryEntry de in myDict1)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            Console.WriteLine("***********************");

            HybridDictionary myDict2 = new HybridDictionary();

            myDict2.Add("A", "Hi");
            myDict2.Add("B", "Good");
            myDict2.Add("C", "Morning");
            myDict2.Add("D", "Everyone");
            myDict2.Add("E", "How are");
            myDict2.Add("F", "you");

            DictionaryEntry[] arr = new DictionaryEntry[myDict2.Count];


            myDict2.CopyTo(arr, 0);
            Console.WriteLine("***********HybridDictionary*************");
            foreach (DictionaryEntry de in myDict2)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();
        }
    }
}