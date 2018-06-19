using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Constants
{
    public static class Tools
    {
        private static Random rng = new Random();
        /// <summary>
        /// Shuffle lists
        /// </summary>
        /// <param name="list"></param>
        public static List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                T value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }
            return list;
        }
    }
}
