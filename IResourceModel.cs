using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchBowlSocialApplication
{
    public interface IResourceModel
    {
        // all members don't have implementation
        // all members are public and virtual by default
        //method body cannot be added nor can you use a different accessibility level
      bool Activity {get;set;}
      bool Guest { get; set; }
      bool Supplies { get; set; }
      string Inputmessage();


    }
}
