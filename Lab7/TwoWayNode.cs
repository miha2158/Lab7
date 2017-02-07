namespace Lab7
{
    public class TwoWayNode
    {
        public TwoWayNode (string info, TwoWayNode next = null, TwoWayNode prev = null)
        {
            Info = info;
            Next = next;
            if (Next != null)
                Next.Prev = this;
            Prev = prev;
            if (Prev != null)
                Prev.Next = this;
        }

        public TwoWayNode ( )
        {
        }

        public void SetFirst (ref TwoWayNode point)
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


        public TwoWayNode Next;
        public TwoWayNode Prev;
        public string Info;
    }
}