using System;
using System.Collections.Generic;

namespace CSharpLangFeature.ListCollection
{
    public static class Generic
    {
        public static void ListInt()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }
        }

        public static void ListStr()
        {
            List<string> animalsList = new List<string>(5);
            string[] animals = { "Cow", "Camel", "Elephant" };
            animalsList = new List<string>(animals);

            animalsList.Add("Mahesh Chand");
            animalsList.Add("Chris Love");
            animalsList.Add("Allen O'neill");
            animalsList.Add("Naveen Sharma");
            animalsList.Add("Monica Rathbun");
            animalsList.Add("David McCarter");

            foreach (var i in animalsList)
            {
                Console.WriteLine(i);
            }
        }

        public static void Dictonary()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
        public static void SortedList()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }

        public static void Stack()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
        }

        public static void Queue()
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
        }

        public static void HashSet()
        {
            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };
            HashSet<string> names1 = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };
            names.UnionWith(names1);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void LinkedList()
        {
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList 
            // Using AddLast() method 
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            Console.WriteLine("Best students of XYZ university:");
            // Accessing the elements of  
            // LinkedList Using foreach loop 
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
        }


        public static void LinkedList2()
        {
            // Creating a linkedlist 
            // Using LinkedList class 
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList 
            // Using AddLast() method 
            my_list.AddLast("01. Hasan");
            my_list.AddLast("02. Karim");
            my_list.AddLast("03. Afif");
            my_list.AddLast("04. Shakib");
            my_list.AddLast("05. Mushi");
            my_list.AddLast("06. Nabila");

            // Inital number of elements 
            Console.WriteLine("Best students of XYZ " +
                             "university initially:");

            // Accessing the elements of  
            // Linkedlist Using foreach loop 
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(LinkedListNode) 
            // method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2000:");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(T) method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2001:");

            my_list.Remove("Rohit");

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using RemoveFirst() method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2002:");

            my_list.RemoveFirst();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using RemoveLast() method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2003:");

            my_list.RemoveLast();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Clear() method 
            my_list.Clear();
            Console.WriteLine("Number of students: {0}", my_list.Count);
        }


        public static void CheckElementinLinkedList()
        {
            // Creating a linkedlist 
            // Using LinkedList class 
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the Linkedlist 
            // Using AddLast() method 
            my_list.AddLast("01. Hasan");
            my_list.AddLast("02. Karim");
            my_list.AddLast("03. Afif");
            my_list.AddLast("04. Shakib");
            my_list.AddLast("05. Mushi");
            my_list.AddLast("06. Nabila");

            // Check if the given element 
            // is available or not 
            if (my_list.Contains("06. Nabila") == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }
        }

    }
}