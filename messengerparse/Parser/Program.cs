using System;
using System.IO;

using AngleSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create a (re-usable) parser front-end
            var parser = new AngleSharp.Parser.Html.HtmlParser();
            var stringcollector = new StringHandler();
            //Source to be parsed


            //Parse source to document

            //String _mysource = Class2.Run("C:\\code\\HAL_quickedits\\messengerparse\\abstract.html");
            Console.WriteLine("----------------- Welcome To MessengerParser! ------------------|\n|\n|\n|\n");
            Console.WriteLine("Paste the filepath of the messenger html file you would like to parse:\n");
            String uinput = Console.ReadLine();

            Console.WriteLine("Processing File...");
            System.Threading.Thread.Sleep(1000);

            String _mysource = Class2.Run(@uinput); //pull the contents of the file into a string variable 


            var document = parser.Parse(_mysource); //parse the string variable through AngleSharp


            //Do something with document like the following
            //TODO use anglesharp to select the message elements, extract the contents to a temporary variable, and then add them to their appropriate list.

            Console.WriteLine("Serializing the (original) document:");
            Console.WriteLine(document.DocumentElement.OuterHtml);


            List<String> memberList = new List<String>();
            foreach(String s in memberList)
            {
                //create a list for each person in the memberlist- named by the string inside the memberlist element it corresponds to.
            }
            //Currently only one list for all messsages in a chat- could seperate this out into lists per chat participant- extensible to group chats
            //TODO find a way to get a list of all the members of a group chat and create a list for each member of that chat.
            //list of lists??




            Console.ReadKey();
        }
    }
public class StringHandler
{
    public List<String> _items;

    public string ItemList
    {
        get
        {
            string output = "";
            foreach (String i in _items)
            {
                output += i +"\n";
            }
            return output;
        }
    }

    public StringHandler()
    {
        _items = new List<String>();
    }
        
    public void Put(String x)
    {
        _items.Add(x);
    }

}
}

