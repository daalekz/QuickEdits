using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Parser
{
    public class Class2
    {
        public String Run()
        {
        try
        {   // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader(@"C:\\code\\HAL_quickedits\\messengerparse\\abstract.html"))
            {
            // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
                return line;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
                return null;
            }
        }
        public Class2()
        {
            Run();
        }
    }
}
