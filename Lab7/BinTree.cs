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
        protected const int MaxChar = 128;

        public void Fill ( )
        {
            Info = (char)random.Next(MaxChar);

            if (random.Next(2) % 2 == 0)
                return;
            try
            {

            }
            catch (Exception)
            {

            }



        }



        public char Info;
        public BinTree Left;
        public BinTree Right;
    }
}