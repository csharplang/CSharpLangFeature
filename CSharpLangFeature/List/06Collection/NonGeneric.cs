using System;
using System.Collections;
using System.Collections.Specialized;

namespace CSharpLangFeature.ListCollection
{
    public static class NonGeneric
    {
        public static void ArrayList()
        {
            ArrayList al = new ArrayList();
            string str = "R M Shahidul Islam Shahed";
            int x = 7;
            DateTime d = DateTime.Parse("1-Jun-1987");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
        }


        public static void HashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }

        public static void SortedList()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");
            Console.WriteLine("*******************");
            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }

        public static void StackExample()
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (object o in stk)
            {
                Console.WriteLine(o);
            }
        }

        public static void QueueExample()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.WriteLine(o);
            }
        }

        public static void Hashtable()
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "s");
            HT.Add(3, "n");
            HT.Add(4, "j");
            HT.Add(2, "a");
            HT.Add(5, "u");
            foreach (object i in HT.Keys)
                Console.WriteLine(i);
            foreach (object J in HT.Values)
                Console.WriteLine(J);
            foreach (DictionaryEntry di in HT)
                Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            Console.ReadKey();
        }

        public static void StringCollection()
        {  
            StringCollection authorNames = new StringCollection();
            // Add string using Add method    
            authorNames.Add("Mahesh Chand");
            authorNames.Add("Mike Gold");
            authorNames.Add("Praveen Kumar");
            authorNames.Add("Raj Beniwal");
            // Add an array of string using AddRange               
            string[] names = new string[] { "Chris Love", "Henry He", "Allen Neill", "David Maccarter" };
            authorNames.AddRange(names);
            // Insert an string at a specified index    
            authorNames.Insert(5, "New Author");
            // authorNames.Clear();    
            // authorNames.Remove("Mike Gold");    
            // authorNames.RemoveAt(5);    
            if (authorNames.Contains("Mike Gold"))
            {
                Console.WriteLine("Mike Gold is at position: " + authorNames.IndexOf("Mike Gold"));
            }
            int authorLocation = authorNames.IndexOf("Mike Gold");
            string authorName = authorNames[authorLocation];
            Console.WriteLine("Position of Mike Gold is " + authorLocation.ToString());
            Console.WriteLine("Total items in string collection: " + authorNames.Count.ToString());
            Console.WriteLine("-----------------------------");
            foreach (string name in authorNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------");
            // Copy Collection to new Array    
            string[] newAuthorList = new string[authorNames.Count];
            authorNames.CopyTo(newAuthorList, 0);
            foreach (string name in newAuthorList)
            {
                Console.WriteLine(name);
            }
        }

    }
}