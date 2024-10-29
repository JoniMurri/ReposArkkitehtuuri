
using Humanizer;


namespace AppLogger;

public class Logger
{

        public static void Log(string text)
        {
            Console.WriteLine(text);
           
            
        }
        public static void LogHumanized(string message){
            string humanized = message.Humanize();
            Console.WriteLine(humanized);
        }
}
