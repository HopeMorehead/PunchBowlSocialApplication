using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;//had to manually put in an assembly reference
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PunchBowlSocialApplication
{
    
    public delegate void KeyEventHandler(object sender, ConsoleKeyInfo e);// KeyEventArgs e);
    public delegate void KeyEventHandler1(object sender, KeyEventArgs f);



    class Program : EventArgs
    {


        public static void KeyboardEventMethod(object sender,ConsoleKeyInfo e)
        {

            if (sender != null)
            {
                Console.WriteLine("not null");
            }
             else 
            {
                Console.WriteLine("nothing pressed");
            }

        }


        public static void KeyboardEventMethod1(object sender,ConsoleKeyInfo e)
        {
            e = Console.ReadKey();
            if (e.Key == ConsoleKey.F1)
            {
                Console.WriteLine("Enter your name");
            }
            else
            {
                Console.WriteLine("nothing pressed");
            }

        }
        
        public static void KeyboardEventMethod2(object sender, KeyEventArgs f)
        {

            bool bExit = false;
            switch (f.KeyCode)
            {

                case Keys.Up:
                    Console.WriteLine("Right Arrow");
                    break;
                case Keys.Down:
                    Console.WriteLine("Left Arrow");
                    break;
                case Keys.Left:
                    //Console.WriteLine("Left Arrow");
                    bExit = true;
                    break;
                default:
                    break;
            }
        }










        public static void LogToConsole(LogEvent logEvent)
        {
            Console.WriteLine((logEvent.Text));
        }



        public static void LogToFile(LogEvent logEvent)
        {
            File.AppendAllText("log.txt", logEvent.Text + "\n");
        }


        public static void LogEventMethod(LogEvent logEvent)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                Console.WriteLine(keyInfo.Key + "was pressed");
            }
            while (keyInfo.Key != ConsoleKey.X);
        }
        



            public event KeyEventHandler ButtonPressed;
            public void OnButtonPressed(ConsoleKeyInfo e)
            {
                KeyEventHandler handler = ButtonPressed;
                if (handler != null)
                    ButtonPressed(this, e);
            }




            [STAThread]
            static void Main(string[] args)
            {

                KeyEventHandler keyhandlers = KeyboardEventMethod;
                keyhandlers += KeyboardEventMethod1;
                keyhandlers(new Program(), new ConsoleKeyInfo());


                KeyEventHandler1 keyhandlers1 = KeyboardEventMethod2;
                keyhandlers1 += KeyboardEventMethod2;
                keyhandlers1(new Program(), new KeyEventArgs(Keys.Left));


                LogEventHandler logHandlers = LogToConsole;
                logHandlers += LogToFile;

                logHandlers(new LogEvent("Message"));


                LogEventHandler logHander = LogEventMethod;
                logHander(new LogEvent("What is your request"));



                Activities activities = new Activities();
                activities.Inputmessage();
                Console.WriteLine(activities.Inputmessage());


























                //Console.WriteLine("Enter any Key: ");
                //ConsoleKeyInfo name = Console.ReadKey();
                //Console.WriteLine("You pressed {0}", name.KeyChar);

                //bool bExit = false;
                //while (!bExit)
                //{
                //    ConsoleKeyInfo _Key = Console.ReadKey();

                //    switch (_Key.Key)
                //    {
                //        case ConsoleKey.RightArrow:
                //            Console.WriteLine("Right Arrow");
                //            break;
                //        case ConsoleKey.LeftArrow:
                //            Console.WriteLine("Left Arrow");
                //            break;
                //        case ConsoleKey.Q:
                //            //Console.WriteLine("Left Arrow");
                //            bExit = true;
                //            break;
                //        default:
                //            break;
                //    }
                //KeyEventArgs v = new KeyEventArgs(Keys.D9);
                //if (v != null)
                //{

                //    Console.WriteLine("not null");
                //    Console.WriteLine(v.KeyData);

                //}
                //else
                //{
                //    Console.WriteLine("null");
                //}
                //KeyEventHandler a = new KeyEventHandler(a, KeyEventhandlerMethod);

                //if (a != null)
                //{

                //}
                //else
                //{
                //    Console.WriteLine("null");
                //}
                //Console.WriteLine("Press ESC to stop");
                //do
                //{
                //    while (!Console.KeyAvailable)
                //    {
                //        Console.WriteLine("this doesn't work");
                //    }
                //} while (Console.ReadKey(true).Key != ConsoleKey.Escape);            //  activities.myForm_PreviewKeyDown();
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);

                //Form myMainWindow = new Form();
                //myMainWindow.PreviewKeyDown += myForm_PreviewKeyDown;

                //Application.Run(myMainWindow);
            }

            //static void myForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            //{
            //    if (e.KeyCode == Keys.L)
            //    {
            //        Console.WriteLine("You can choose from four different languages by clicking on the radio buttons");
            //    }
            //    else if (e.KeyCode == Keys.A && (e.Shift))
            //    {
            //        MessageBox.Show("This is version 1.0");
            //    }

            //}
       // }

    }
}