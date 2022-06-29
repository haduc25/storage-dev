using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleCSharp
{
    class Program
    {
        #region Ex 2: Get Date,Month,Year(Now)
        static Tuple<int, int, int> GetTimeNow() 
        {
            //Get Time System
            DateTime now = DateTime.Now;
            //Use Contructer of Tuple is return
            return new Tuple<int, int, int>(now.Day,now.Month,now.Year);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Ex 1.Tuple
            ////Create Tuple
            //var tp = Tuple.Create<int,string>(10,"Hello");
            //var tp1 = new Tuple<int, string, bool>(50,"Hey",true);
            //Console.WriteLine("Value: {0}, Content: {1}",tp.Item1,tp.Item2);
            //Console.WriteLine("Value: {0}, Content: {1}", tp.Item1, tp1.Item2);

            #endregion
            #region Ex 2: Get Date,Month,Year(Now)
            var now = GetTimeNow();
            Console.WriteLine("Day/Month/Year of System");
            Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",now.Item1,now.Item2,now.Item3);
            Console.WriteLine(now.ToString());
            #endregion
            Console.ReadKey();
        }
    }
}
