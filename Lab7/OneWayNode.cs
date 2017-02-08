using System;

namespace Lab7
{
    public class OneWayNode
    {
        protected OneWayNode ( )
        {

        }

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

        #region Randomise

        protected static Random RandNum = new Random( );
        protected static int Rand (int number) => RandNum.Next(number);
        protected const int MaxSize = 15;
        protected const int MaxNumber = 99;

        public void Refill ( )
        {
            OneWayNode point = this;
            for (int i = Rand(MaxSize) + 2; i-- > 0;)
            {
                point.Info = Rand(MaxNumber);
                point.Next = new OneWayNode(0);
                point = point.Next;
            }
            point.Next = null;

        }

        #endregion

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

        #region ToString

        public override string ToString ( )
        {
            return Info.ToString( );
        }

        public string ToString (bool doAll)
        {
            if (!doAll)
                return Info.ToString( );

            if (Next == null)
                return Info.ToString( );

            return Info + " -> " + Next.ToString(true);
        }

        #endregion

        public int Info;
        public OneWayNode Next;

    }
}