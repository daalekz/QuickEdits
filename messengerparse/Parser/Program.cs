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
        public void Main(string[] args)
        {
            //Create a (re-usable) parser front-end
            var parser = new AngleSharp.Parser.Html.HtmlParser();
            var stringcollector = new StringHandler();
            //Source to be parsed


            //Parse source to document
            
            String _mysource = Class2.Run();
            var document = parser.Parse(_mysource);
            //Do something with document like the following

            Console.WriteLine("Serializing the (original) document:");
            Console.WriteLine(document.DocumentElement.OuterHtml);

            //var p = document.CreateElement("p");
            //p.TextContent = "This is another paragraph.";

            //Console.WriteLine("Inserting another element in the body ...");
            //document.Body.AppendChild(p);

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

