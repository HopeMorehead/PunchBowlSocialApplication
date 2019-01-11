using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchBowlSocialApplication
{
    public delegate void LogEventHandler(LogEvent logEvent);
    public class LogEvent
    {
        public string Text { get; }//prperty
        public LogEvent(string text)//constructor
        {
            Text = text;
        }
        
    }




}
