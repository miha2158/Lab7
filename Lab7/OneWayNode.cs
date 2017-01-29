namespace Lab7
{
    public class OneWayNode
    {
        public OneWayNode (int number)
        {
            Info = number;
            Next = null;
        }

        public OneWayNode (int number, ref OneWayNode headNode)
        {
            Info = number;
            Next = headNode;
            headNode = this;
        }

        public void DeleteLastEven (ref OneWayNode headNode)
        {
            OneWayNode point = headNode;
            OneWayNode even = null;

            while (point != null)
            {
                if (point.Next.Info % 2 == 0)
                    even = point;
                point = point.Next;
            }
            if (even == null)
            {
                if (headNode.Info % 2 == 0)
                    headNode = headNode.Next;
            }
            else
                even.Next = even.Next.Next;
        }

        public override string ToString ( )
        {
            return Info.ToString( );
        }

        public string ToString (bool doAll)
        {
            if (!doAll)
                return Info.ToString( );

            if (Next == null)
                return " -> " + Info;

            return " -> " + Info + Next.ToString(true);
        }

        public int Info;
        public OneWayNode Next;
    }
}