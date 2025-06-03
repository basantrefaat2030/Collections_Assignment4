using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Assignment4
{
    public class MyStringCollection
    {
        List<string> stringColl ;

        public MyStringCollection()
        {
            stringColl = new List<string>();
        
        }

        void Add(string item)
        {
            if (item != null)
            {
                if (stringColl.Contains(item))
                {
                    Remove(item);
                    stringColl.Add(item);
                }
                stringColl.Add(item.ToString());
            }
        }

        void Remove(string item)
        {
            if(item != null) 
            { 
                stringColl.Remove(item); 
            }
        }

        bool Contains(string item)
        {
            if(item != null)
            {
                if (stringColl.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }


        void PrintAll()
        {
            if(stringColl is not null)
            {
                foreach(string item in stringColl)
                {
                    Console.WriteLine($"\n {item}");
                }
            }

            Console.WriteLine("");
        }

    }
}
