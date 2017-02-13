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

        public static BinTree BalanceMake (int size, bool randomFill = true)
        {
            if (size <= 0)
            {
                return null;
            }

            BinTree root = new BinTree(defaultSymbol);
            if (randomFill)
                root.Info = RandChar;

            root.Right = BalanceMake(size / 2, randomFill);
            root.Left = BalanceMake(size - size / 2 - 1, randomFill);
            return root;
        }

        public void Refill ( )
        {
            Info = RandChar;
            Left?.Refill( );
            Right?.Refill( );
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

            for (int i = 1; i < array.Length; i++)
                if (array[i - 1] == array[i])
                {
                    for (int j = i; j < array.Length; j++)
                        array[j - 1] = array[j];

                    Array.Resize(ref array, array.Length - 1);
                }
            

            return FromArray(array);
        }

        #region Arrays

        public static BinTree FromArray (char[] array)
        {
            if (array == null || array.Length == 0)
                return null;

            int size = 2;
            while (size < array.Length)
                size *= 2;

            BinTree temp = BalanceMake(size, false);
            int i = 0;
            FromArray(temp, array, ref i);

            temp.Clear( );

            return temp;
        }

        protected static char defaultSymbol = '\\';

        protected static void FromArray (BinTree root, char[] array, ref int index)
        {
            //root.Info = array[array.Length / 2];

            if (root.Left != null)
                FromArray(root.Left, array, ref index);
            try
            {
                root.Info = array[index];
                index++;
            }
            catch (Exception)
            { }

            if (root.Right != null)
                FromArray(root.Right, array, ref index);
        }

        protected void Clear ( )
        {
            if (Left != null && Left.Info == defaultSymbol)
                Left = Left?.Left;
            else if (Right != null && Right.Info == defaultSymbol)
                Right = Right?.Left;

            Left?.Clear( );
            Right?.Clear( );
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
            return Write( );
        }

        protected static readonly int Margin = 4;

        protected string Write (int M = 2)
        {
            string result = Left?.Write(M + Margin);

            for (int i = M; i-- > 0;)
                result = result + " ";

            result = result + (int)Info + "\r\n";

            result = result + Right?.Write(M + Margin);

            return result;
        }

        #endregion

        public char Info;
        public BinTree Left;
        public BinTree Right;
    }
}