using System;
using System.IO;

namespace shirleys_creations
{
   public class Log
   {  
      public void LogFileAppender() 
      {
         using (StreamWriter w = File.AppendText("log.txt"))
         {
             LogTxt("Test1", w);
             LogTxt("Test2", w);
         }
         using (StreamReader r = File.OpenText("log.txt"))
         {
             DumpLog(r);
         }
      } 
      public void LogTxt(string logMessage, TextWriter w)
      {
         w.Write("\r\nLog Entry : ");
         w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
         w.WriteLine("  :");
         w.WriteLine($"  :{logMessage}");
         w.WriteLine("-------------------------------");
      }
      public void DumpLog(StreamReader r)
      {
         string line;
         while ((line = r.ReadLine()) != null)
         {
             Console.WriteLine(line);
         }
      }
   } 
}