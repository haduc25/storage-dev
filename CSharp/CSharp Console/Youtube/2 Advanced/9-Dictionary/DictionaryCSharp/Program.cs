using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            //Create Dictionary
            Dictionary<string, string> dtnr = new Dictionary<string, string>();//Dictionary Empty
            Dictionary<string, string> dtnr1 = new Dictionary<string, string>(10);//Dictionary 10 Value
            Dictionary<string, string> dtnr2 = new Dictionary<string, string>(dtnr1);//Dictionary dtnr2 as dtnr1
            #endregion
            #region Ex 1:
            //Create Dictonary
            Dictionary<string, string> dtnr3 = new Dictionary<string, string>();
            //Add
            Console.WriteLine("Key and Value\n");
            dtnr3.Add("A","Ahihi"); //Add(Keys,Value)
            dtnr3.Add("B", "Boom");
            dtnr3.Add("C", "Create");
            foreach (KeyValuePair<string, string> item in dtnr3)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
