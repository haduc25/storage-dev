using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Hashtable
            Hashtable hashtb = new Hashtable();
            hashtb.Add("H","Ha Duc");
            hashtb.Add("A", "Chose A");
            hashtb.Add("B", "Chose B");
            hashtb.Add("C", "Chose C");
            //In Hashtable
            Console.WriteLine("hashtb[\"H\"] = "+hashtb["A"]); //lấy đầy đủ cả key và DictionaryEntry
            Console.WriteLine(hashtb["A"]);
            Console.WriteLine(hashtb["B"]);
            Console.WriteLine(hashtb["C"]);
            //Sao chép giá trị của hashtb sang hashtb1 (Copy)
            Hashtable hashtb1 = new Hashtable(hashtb);
            Console.WriteLine(hashtb1["H"]);
            //Duyet pt trong Hashtable
            Console.Write("\nUse Foreach & Hashtable\n");
            foreach (DictionaryEntry item in hashtb)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            //Key sẽ trả về giá trị null nếu Key k được khai báo trong Hashtable
            Console.WriteLine("\nhashtb[\"D\"]= "+hashtb["D"]); //Giá trị không tồn tại
            if (hashtb["D"] == null) //Kiểm tra key 
            {
                Console.WriteLine("Key is not exsts !");
            }
            //Thêm phần tử
            Console.WriteLine("\nSo PT dau Count: "+hashtb.Count);
            foreach (DictionaryEntry item in hashtb)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            //Add phần tử không tồn tại
            hashtb["E"] = "Ey"; //Sort rand
            hashtb["F"] = "F"; //Sort rand
            Console.WriteLine("\nSo PT sau Count: " + hashtb.Count);
            foreach (DictionaryEntry item in hashtb)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.ReadKey();     
        }
     
    }
}
