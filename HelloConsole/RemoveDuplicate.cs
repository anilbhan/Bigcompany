//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloConsole
//{
//    class RemoveDuplicate
//    {
//        public static void Main()
//        {

//            string value1 = RemoveDuplicateCharacters("Yahoo");
//            string value2 = RemoveDuplicateCharacters("CNN");
//            string value3 = RemoveDuplicateCharacters("Twitter");
//            string value4 = RemoveDuplicateCharacters("FACEBOOK");
//            string value5 = RemoveDuplicateCharacters("EYES");


//            Console.WriteLine(value1);
//            Console.WriteLine(value2);
//            Console.WriteLine(value3);
//            Console.WriteLine(value4);
//            Console.WriteLine(value5);


//        }




//        public static string RemoveDuplicateCharacters(string key)
//        {
//            //store the repeated char in this string;
//            string table = "";

//            //store the result in this string;
//            string result = "";

//            //loop over each character

//            foreach (char value in key)
//            {
//                //check if the char are in the table
//                if (table.IndexOf(value) == -1)
//                {
//                    //append to the table
//                    table += value;
//                    result += value;
//                }
//            }

//            return result;
//        }
//    }
//}
