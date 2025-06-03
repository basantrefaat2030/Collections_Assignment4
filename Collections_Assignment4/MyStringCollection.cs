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

        public void Add(string item)
        {
            if (item != null)
            {
                stringColl.Add(item);
            }
        }

        public bool Remove(string item)
        {
            if (item != null)
            {
                return stringColl.Remove(item);
            }
            return false;
        }

        public bool Contains(string item)
        {
            if (stringColl.Count != 0)
            {
                if (stringColl.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }


        public void PrintAll()
        {
            if(stringColl.Count != 0)
            {
                foreach(string item in stringColl)
                {
                    Console.WriteLine($"\n {item}");
                }
            }

            Console.WriteLine("No Data in the list");
        }

    }
}
