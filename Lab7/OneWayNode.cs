using System;

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

        protected static Random Rand = new Random ( );
        protected static int RRand (int number) => Rand.Next(number);
        protected const int MaxSize = 15;
        protected const int MaxNumber = 99;

        public void Refill()
        {
            Info = RRand(MaxNumber) + 1;
            OneWayNode point = this;
            for (int i = RRand(MaxSize) + 2; i-- > 0;)
            {
                point.Next = new OneWayNode(RRand(MaxNumber));
                point = point.Next;
            }
            point.Next = null;

        }

        public static bool DeleteLastEven (ref OneWayNode headNode)
        {
            OneWayNode point = headNode;
            OneWayNode even = null;

            while (point != null)
            {
                if (point.Info % 2 == 0)
                    even = point;
                point = point.Next;
            }

            if (headNode != even)
            {
                point = headNode;
                while (point.Next != even)
                    point = point.Next;

                if (point.Next != null)
                {
                    point.Next = point.Next.Next;
                    return true;
                }
            }
            else
            {
                headNode = headNode.Next;
                return true;
            }

            return false;
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
                return Info.ToString();

            return Info + " -> " + Next.ToString(true);
        }

        public int Info;
        public OneWayNode Next;
    }
}