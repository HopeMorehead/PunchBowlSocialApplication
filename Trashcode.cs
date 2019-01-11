//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PunchBowlSocialApplication
//{
//    class Trashcode
//    {


//           string message = "Hello";//string is a reference type variable and content live in different place. 
//                                     //Content live on the heap and has a 
//                                     //identifier to refrence the information on the heap

//            string[] messages = new string[3] { "hello", "world", "I" };//the variable message is on the stack 
//                                                                        // and the array as well as the elements are
//                                                                        //  on the heap. there are identifiers to each element on the heap

//            int[] numbers = new int[] { 1, 2, 3 };
//            // null references exist
//            string message1 = null;
//            int[] number2 = new[] { 1, 2, 2 };
//            number2 = null;//numbers variable isn't referencing the array anymore
//                           //   number2[3] = 6;
//                           //   Console.WriteLine(number2[1]); will crash FIX THIS  with a simple check
//            if (number2 != null)
//            {
//                number2[3] = 6;
//            }
//            else
//            {
//                Console.WriteLine("value equals null");
//            }


//            int a = 3;//value types the values is stored on the stack with the variable
          
//            int b = a;
//            b++;//b=b+1
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            // Console.WriteLine(number2[3])
//            ;
//            string hello = "hello";
//            string hi = hello;
//            hi = "hi";

//            Console.WriteLine(hello);


//            int[] c = new int[] { 1, 2, 3 };
//            int[] d = c;
//            d[0] = 17;
//            Console.WriteLine(c[0]);

//            string[] power = new string[] { "koo,kaa,kuu" };
//            string[] dower = power;
//            dower[0] = "poo";
//            Console.WriteLine(power[0]);








//    }
//}
