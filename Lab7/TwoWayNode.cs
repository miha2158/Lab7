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

        protected static char RandChar => (char)RandNum.Next(128);

        public static string RandString (int length = 5)
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
                point.Info = RandString();
                point.Next = new TwoWayNode(string.Empty, prev:point);
                point = point.Next;
            }
            point.Info = RandString( );
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
            var place = this;
            while (number-- > 0 && place.Next != null)
                place = place.Next;
            return place;
        }

        public TwoWayNode MovePrev (int number)
        {
            var place = this;
            while (number-- > 0 && place.Prev != null)
                place = place.Prev;
            return place;
        }

        #endregion

        #region Addition

        public void AddNext (TwoWayNode element)
        {
            if (Next != null)
            {
                element.Next = Next;
                Next.Prev = element;
            }
            Next = element;
            element.Prev = this;
        }

        public void AddPrev (TwoWayNode element)
        {
            if (Prev != null)
            {
                Prev.Next = element;
                element.Prev = Prev;
            }
            Prev = element;
            element.Next = this;
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
            return point.WriteAllNexts( );
        }

        public string WriteAllNexts ( )
        {
            if (Next == null)
                return Info;

            return Info + " <-> " + Next.WriteAllNexts();
        }

        #endregion

        public int Number
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