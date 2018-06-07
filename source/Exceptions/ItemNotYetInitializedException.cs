using System;

namespace AmaruCommon.Exceptions
{
    public class ItemNotYetInitializedException : Exception
    {
        private string _item = null;
        public ItemNotYetInitializedException(string item)
        {
            _item = item;
        }

        public override string ToString()
        {
            return _item + " has not yet been initialized";
        }
    }
}
