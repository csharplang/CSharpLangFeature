using System;
using System.Collections.Generic;

namespace CSharpLangFeature.List.String
{
    public static class StringDetails
    {
        public static void CommonOperation()
        {
            string s1 = "Geek";
            string s2 = "s";
            string s3 = "For";
            string s4 = "Geek";

            // using concatenation operator 
            string str = s1 + s2 + s3 + s4 + "s";
            Console.WriteLine(str);


            // here include four null character 
            // between xyz and abc substring 
            string str3 = "xyz\0\0\0\0abc";
            Console.WriteLine(str3.Length);


            char[] chars = { 'G', 'E', 'E', 'K', 'S' };

            // Create a string from a character array. 
            string str1 = new string(chars);
            Console.WriteLine(str1);

            // Create a string that consists of  
            // a character repeated 20 times. 
            string str2 = new string('G', 10);
            Console.WriteLine(str2);


            string sentence = "Geeks For Geeks";

            // Extract the second word. 

            // taking the first space position value 
            int startpos = sentence.IndexOf(" ") + 1;

            // taking the second space position value 
            int endpos = sentence.IndexOf(" ", startpos) - startpos;

            // now extract second word from the sentence 
            string wrd = sentence.Substring(startpos, endpos);
        }

        public static void CreateaStringUsingFormat()
        {
            int no = 10;
            string cname = "BMW";
            string clr = "Red";

            // string creation using string.Format method 
            string str = string.Format("{0} {1} Cars color " + "are {2}", no.ToString(), cname, clr);
            Console.WriteLine(str);
        }

        public static void CharsProperty()
        {
            string str = "GeeksforGeeks";
            for (int i = 0; i <= str.Length - 1; i++)
                Console.Write("{0} ", str[i]);
        }


        public static void ValidateaString()
        {
            string str = "11Gee45for78geeks";

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    Console.WriteLine("{0} is a Number.", str[i]);
                else
                    Console.WriteLine("{0} is a character.", str[i]);
            }
        }

        public static string Reverse(string StringVar)
        {
            char[] charArray = StringVar.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string RemoveSpace(string StringVar)
        {
            return StringVar.Replace(" ", string.Empty);
        }


        public static void RemoveRange()
        {
            // Creating an List<T> of strings 
            List<string> firstlist = new List<string>
            {
                "Geeks",
                "For",
                "Geeks",
                "GFG",
                "C#",
                "Tutorials",
                "GeeksforGeeks"
            };

            // Displaying the elements of firstlist 
            Console.WriteLine("Elements in List:\n");

            foreach (string ele in firstlist)
            {
                Console.WriteLine(ele);
            }

            // removing 1 elements starting 
            // from index 3 
            firstlist.RemoveRange(3, 1);

            Console.WriteLine("");

            // Displaying the updated List 
            Console.WriteLine("After Removing of elements:\n");

            // Displaying the elements in List 
            foreach (string ele in firstlist)
            {
                Console.WriteLine(ele);
            }
        }

        public static void RandExample()
        {
            string firstname;
            string lastname;


            firstname = "Steven Clark";
            lastname = "Clark";


            Console.WriteLine(firstname.Clone());
            // Make String Clone
            Console.WriteLine(firstname.CompareTo(lastname));
            //Compare two string value and returns 0 for true and 1 for false

            Console.WriteLine(firstname.Contains("ven")); //Check whether specified value exists or not in string

            Console.WriteLine(firstname.EndsWith("n")); //Check whether specified value is the last character of string
            Console.WriteLine(firstname.Equals(lastname));
            //Compare two string and returns true and false


            Console.WriteLine(firstname.GetHashCode());
            //Returns HashCode of String

            Console.WriteLine(firstname.GetType());
            //Returns type of string

            Console.WriteLine(firstname.GetTypeCode());
            //Returns type of string

            Console.WriteLine(firstname.IndexOf("e")); //Returns the first index position of specified value the first index position of specified value


            Console.WriteLine(firstname.ToLower());
            //Covert string into lower case

            Console.WriteLine(firstname.ToUpper());
            //Convert string into Upper case

            Console.WriteLine(firstname.Insert(0, "Hello")); //Insert substring into string

            Console.WriteLine(firstname.IsNormalized());
            //Check Whether string is in Unicode normalization from C


            Console.WriteLine(firstname.LastIndexOf("e")); //Returns the last index position of specified value

            Console.WriteLine(firstname.Length);
            //Returns the Length of String

            Console.WriteLine(firstname.Remove(5));
            //Deletes all the characters from begining to specified index.

            Console.WriteLine(firstname.Replace('e', 'i')); // Replace the character

            string[] split = firstname.Split(new char[] { 'e' }); //Split the string based on specified value


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(firstname.StartsWith("S")); //Check wheter first character of string is same as specified value

            Console.WriteLine(firstname.Substring(2, 5));
            //Returns substring

            Console.WriteLine(firstname.ToCharArray());
            //Converts an string into char array.

            Console.WriteLine(firstname.Trim());
            //It removes starting and ending white spaces from string.
        }

    }
}


