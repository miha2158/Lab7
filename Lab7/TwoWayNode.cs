using System;

namespace Lab7
{
    public class TwoWayNode: OneWayNode
    {
        protected TwoWayNode ( )
        {

        }

        public TwoWayNode (string info, TwoWayNode next = null, TwoWayNode prev = null)
        {
            Info = info;
            Next = next;
            if (next != null)
                Next.Prev = this;
            Prev = prev;
            if (Prev != null)
                Prev.Next = this;
        }

        protected new static bool DeleteLastEven (ref OneWayNode headNode )
        {
            return false;
        }

        #region Randomise

        protected static char RandChar => (char)RandNum.Next( );

        public static string RandString (int length)
        {
            string placeholder = string.Empty;
            while (placeholder.Length < length)
            {
                char c = '-';
                while (!char.IsLetterOrDigit(c))
                    c = RandChar;
                placeholder = placeholder + c;
            }
            return placeholder;
        }


        public new void Refill ( )
        {
            Prev = null;
            TwoWayNode point = this;
            for (int i = Rand(MaxSize); i-- > 0;)
            {
                Info = RandString(5);
                point.Next = new TwoWayNode( );
                point.Next.Prev = point;
                point = point.Next;
            }
        }

        #endregion

        #region Movement

        public static void SetFirst (ref TwoWayNode point)
        {
            while (point.Prev != null)
                point = point.Prev;
        }

        public TwoWayNode MoveNext (int number)
        {
            var temp = this;
            while (number-- != 0 && temp.Next != null)
                temp = temp.Next;
            return temp;
        }

        public TwoWayNode MovePrev (int number)
        {
            var temp = this;
            while (number-- != 0 && temp.Prev != null)
                temp = temp.Prev;
            return temp;
        }

        #endregion

        #region Addition

        public void AddNext (TwoWayNode element)
        {
            if (Next != null)
            {
                Next.Prev = element;
                element.Next = Next;
                element.Prev = this;
            }
            Next = element;
        }

        public void AddPrev (TwoWayNode element)
        {
            if (Prev != null)
            {
                Prev.Next = element;
                element.Prev = Prev;
                element.Next = this;
            }
            Prev = element;
        }

        #endregion

        #region ToString

        public override string ToString ( )
        {
            return Info;
        }

        public new string ToString(bool doAll)
        {

            if (!doAll)
                return Info;

            TwoWayNode point = this;
            SetFirst(ref point);
            point.WriteNext( );
            
        }

        public string WriteNext ( )
        {
            if (Next == null)
                return Info;

            return Info + " <-> " + Next.WriteNext();
        }

        #endregion

        protected int Number
        {
            get
            {
                if (Prev == null)
                    return 0;

                return Prev.Number + 1;
            }
        }

        public new TwoWayNode Next;
        public TwoWayNode Prev;
        public new string Info = string.Empty;
    }
}