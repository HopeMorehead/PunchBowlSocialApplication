using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchBowlSocialApplication
{
    abstract class PunchBowlApplicationBaseCode
    {
        


       public string  InputText   { get; set; }
       public string  JobTitle    { get; set; }
       public string  Department  { get; set; }
       public bool    UserResponse { get; set; }

       public abstract string Inputmessage();

        
    }
}
