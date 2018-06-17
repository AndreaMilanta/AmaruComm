using System;
using System.Collections.Generic;
using System.Linq;

using AmaruCommon.Exceptions;

namespace AmaruCommon.Constants
{
    [Serializable]
    public class LimitedList<T> : List<T> //where T: Object
    {
        public readonly int MaxSize;

        public LimitedList(int maxSize) : base()
        {
            MaxSize = maxSize;
        }

        public new void Add(T newItem)
        {
            if (this.Count < this.MaxSize)
                base.Add(newItem);
        }
    }
}
