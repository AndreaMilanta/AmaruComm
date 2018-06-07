using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Constants
{
    public static class Tools
    {
        /// <summary>
        /// Shuffle lists
        /// </summary>
        /// <param name="list"></param>
        public static List<T> Shuffle<T>(List<T> list)
        {
            Random rand = new Random();
            int len = list.Count * list.Count;
            list.OrderBy(e => rand.Next(len));
            return list;
        }
    }
}
