using System;

namespace Elemendid
{
    internal class Handler
    {
        private object mainLooper;

        public Handler(object mainLooper)
        {
            this.mainLooper = mainLooper;
        }

        internal void PostDelayed(Action p, long totalMilliseconds)
        {
            throw new NotImplementedException();
        }
    }
}