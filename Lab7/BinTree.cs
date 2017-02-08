using System;

namespace Lab7
{
    public class BinTree
    {
        public BinTree (char info, BinTree left = null, BinTree right = null)
        {
            Info = info;
            Left = left;
            Right = right;
        }

        protected static Random random = new Random( );
        public static char RandChar
        {
            get
            {
                char c = '-';
                while (!char.IsLetterOrDigit(c))
                    c = (char)random.Next(128);
                return c;
            }
        }

        public static void BalanceMake (out BinTree root, int size)
        {
            if (size <= 0)
            {
                root = null;
                return;
            }

            root = new BinTree(RandChar);
            BalanceMake(out root.Left, size / 2);
            BalanceMake(out root.Right, size - size / 2 - 1);
        }


        public override string ToString ( )
        {
            return Write();
        }

        protected static readonly int Margin = 4;

        protected string Write (int M = 2)
        {
            string result = "\r\n";

            result = result + Left?.Write(M + Margin);

            for (int i = M; i-- > 0;)
                result = result + " ";
            result = result + Info + "\r\n";

            result = result + Right?.Write(M + Margin);

            return result;
        }


        public char Info;
        public BinTree Left;
        public BinTree Right;
    }
}