using System;
using System.Collections.Generic;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public T Start
        {
            get
            {
                return this.start;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
        } 

        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        public override string Message
        {
            get
            {
                return String.Format("{0} is out of range [{1} - {2}].",typeof (T).Name, this.Start, this.End);
            }
        }
    }
}
