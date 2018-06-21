using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Exceptions
{
    public class TargetPlaceFullException : Exception
    {
        private Place Place { get; set; }
        
        public TargetPlaceFullException(Place place)
        {
            this.Place = place;
        }

        public override string ToString()
        {
            return Place.ToString() + ": " + base.ToString();
        }
    }
}
