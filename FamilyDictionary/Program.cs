using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>()
            {
                {"name", "Mark"},
                {"age", "26"}
            });

            myFamily.Add("mom", new Dictionary<string, string>()
            {
                {"name", "Tong" },
                {"age", "52" }
            });

            myFamily.Add("dad", new Dictionary<string, string>()
            {
                {"name", "Mark" },
                {"age", "50" }
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }

            Console.ReadLine();
        }
    }
}
