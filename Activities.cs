using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//had to manually put in an assembly reference
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PunchBowlSocialApplication

{
    //   public delegate void KeyEventHandler (object sender, KeyEventArgs e);

    class Activities:PunchBowlApplicationBaseCode,IResourceModelinterface
    {
        public Activities()
        { }

        public Activities(string jobTitle)
        {
            this.JobTitle = jobTitle;
        }




        public override string Inputmessage()
        {
            this.InputText = Console.ReadLine();
            if (InputText == null)
            {
                return null;
            }
            else if (InputText.Length < 139)
            {
                return InputText;
            }
            return InputText.Substring(0, 50);//returns the readline not the result of the readline
                                              // throw new NotImplementedException();
            //  public virtual void KeyboardEventMethod(object sender, KeyEventArgs x)


            //if (e.KeyCode == Keys.F1 && (e.Alt || e.Control || e.Shift))
            //{
            //    // Display a pop-up Help topic to assist the user.
            //    //  Help.ShowPopup( "Enter your name.", new Point(TextBox.Bottom, textBox1.Right));
            //}
            //else if (e.KeyCode == Keys.F2 && e.Modifiers == Keys.Alt)
            //{
            //    // Display a pop-up Help topic to provide additional assistance to the user.
            //    //    Help.ShowPopup(textBox1, "Enter your first name followed by your last name. Middle name is optional.",
            //    //      new Point(textBox1.Top, this.textBox1.Left));
            //}
            //KeyEventHandler testEvent = KeyboardEventMethod;

            //  }
            //public void myForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            // {
            //     if (e.KeyCode == Keys.L)
            //     {
            //         Console.WriteLine("You can choose from four different languages by clicking on the radio buttons");
            //     }
            //     else if (e.KeyCode == Keys.A && (e.Shift))
            //     {
            //         MessageBox.Show("This is version 1.0");
            //     }
            //   }
            //    bool Activity { get; set; }
            //    bool Guest { get; set; }
            //bool Supplies { get; set; }
            //public void Keycodemethod(KeyEventArgs c)
            //{
            //    if (c.KeyCode == Keys.F1)
            //    {
            //        //   //   Display a pop-up Help topic to assist the user.
            //        Console.WriteLine(("Enter your name."));
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //    }
            //}
        }
    }
}
