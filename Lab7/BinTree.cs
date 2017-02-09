using System;
using System.Collections.Generic;
using System.Linq;

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

        #region Create

        public static BinTree BalanceMake (int size, bool fill = true)
        {
            if (size <= 0)
            {
                return null;
            }

            BinTree root = new BinTree('\\');
            if (fill)
                root.Info = RandChar;

            root.Right = BalanceMake(size / 2, fill);
            root.Left = BalanceMake(size - size / 2 - 1, fill);
            return root;
        }

        public void Refill ( )
        {
            Info = RandChar;
            Left?.Refill();
            Right?.Refill();
        }

        #endregion

        public int Height
        {
            get
            {
                if (Left == null)
                    if (Right == null)
                        return 1;
                    else
                        return Right.Height + 1;
                if (Right == null)
                    return Left.Height + 1;

                return Math.Max(Left.Height, Right.Height) + 1;
            }
        }

        public BinTree SearchTree ( )
        {
            char[] array = ToArray( ).ToArray( );

            Array.Sort(array);

            return FromArray(array);
        }

        #region Arrays

        public static BinTree FromArray(char[] array )
        {
            if (array == null || array.Length == 0)
                return null;

            int size = 1;
            while (size < array.Length)
                size *= 2;

            BinTree temp = BalanceMake(size,false);
            int i = 0;
            FromArray(temp, array, ref i);



            return temp;
        }

        protected static void FromArray(BinTree root,char[] array, ref int index)
        {
            if (root.Left != null)
                FromArray(root.Left, array, ref index);

            if (index < array.Length)
                root.Info = array[index++];

            if (root.Right != null)
                FromArray(root.Right, array, ref index);

            if (root.Left != null && root.Left.Info == '\\')
                root.Left = null;
            else
            if (root.Right != null && root.Right.Info == '\\')
                root.Right = null;

        }

        public IEnumerable<char> ToArray ( )
        {
            if (Left != null)
                foreach (char i in Left.ToArray( ))
                    yield return i;


            if (Right != null)
                foreach (char i in Right.ToArray( ))
                    yield return i;

            yield return Info;
        }

        #endregion

        #region ToString

        public override string ToString ( )
        {
            return Write();
        }

        protected static readonly int Margin = 4;

        protected string Write (int M = 2)
        {
            string result = Left?.Write(M + Margin);

            for (int i = M; i-- > 0;)
                result = result + " ";
            result = result + Info + "\r\n";

            result = result + Right?.Write(M + Margin);

            return result;
        }

        #endregion

        public char Info;
        public BinTree Left;
        public BinTree Right;
    }
}