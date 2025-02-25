using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class ListOperarations
    {
        public static void AddElement(List<int> list, int element)
        {
            list.Add(element);
        }

        public static void RemoveElement(List<int> list, int element)
        {
            list.Remove(element);
        }

        public static int GetSize(List<int> list)
        {
            return list.Count;
        }

    }
}
