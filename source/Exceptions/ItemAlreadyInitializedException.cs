using System;

namespace AmaruCommon.Exceptions
{
    public class ItemAlreadyInitializedException : Exception
    { 
        private string _item = null;
        public ItemAlreadyInitializedException(string item)
        {
            _item = item;
        }

        public override string ToString()
        {
            return _item + " has already been initialized";
        }
    }
}
