using System;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Nate"; // key is name and value is Nate
            Console.WriteLine(cookie["name"]); //Nate
        }
    }
}


//HttpCookie.cs
/*using System;
using System.Collections.Generic;
namespace IndexerDemo
{
    public class HttpCookie
    {
        //using a field to store key value pairs in the cookie . A dat type/structure used for that is a Dictionary
        //generic class and generic parameters that specify the type of a dictionary key is a string and value is a string 

        private readonly Dictionary<string, string> _dictionary; //built like a property // rely on the dictionary to store the key value pairs and 

        public DateTime Expiring { get; set; }

        //constructor
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //an indexer doesn't have a name . we use the this keyword
        public string this[string key]
        {
            get { return _dictionary[key];}
            set { _dictionary[key] = value; }
        }
    }
}
*/
