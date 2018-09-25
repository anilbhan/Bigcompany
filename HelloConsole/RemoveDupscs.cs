//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloConsole
//{
//    class RemoveDupscs
//    {
//        public static void Main()
//        {
//cool features.
//            //define the variables with repeated string;

//            string Value1 = RemoveDuplicate("Yahoo");
//            string Value2 = RemoveDuplicate("CNN");
//            string Value3 = RemoveDuplicate("Google");

//            Console.WriteLine(Value1);
//            Console.WriteLine(Value2);
//            Console.WriteLine(Value3);
//        }

//        public static string RemoveDuplicate(string val)
//        {
//            //temporary variable to hold repeated character;

//            string table = "";
//            //to hold result after removing repeated char;
//            string result = "";
//            foreach (char value in val)
//            {
//                if (table.IndexOf(value) == -1)
//                {
//                    table += value;
//                    result += value;

//                }
//            }
//            return result;
//        }
//    }
//}
