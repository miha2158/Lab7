using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1: Form
    {
        public static Random random = new Random( );
        public const int lowEnd = -100;
        public const int highEnd = 100;
        public const int maxLength = 20;

        public Form1 ( )
        {
            InitializeComponent( );
        }

        #region OneWay

        OneWayNode head;

        private void OWFill_Click (object sender, EventArgs e)
        {
            DeleteLastEven.Enabled = true;

            if (head == null)
                head = new OneWayNode(0);
            head.Refill();

            OWBox1.Text = head.ToString(true);
            OWBox2.Text = string.Empty;
        }

        private void DeleteLastEven_Click (object sender, EventArgs e)
        {
            if(head == null)
            {
                MessageBox.Show("Нельзя удалить ничего из пустого списка");
                DeleteLastEven.Enabled = false;
                head = new OneWayNode(0);
            }

            if (OWBox2.Text != string.Empty)
                OWBox1.Text = OWBox2.Text;

            if (!OneWayNode.DeleteLastEven(ref head))
                MessageBox.Show("В списке нет чётных элементов", "ОК?");
            try
            { OWBox2.Text = head.ToString(true);}
            catch (NullReferenceException)
            { OWBox2.Text = " ";}
        }

        #endregion

        #region TwoWay

        TwoWayNode point;

        private void TWAdd_Click (object sender, EventArgs e)
        {
            point = point.SetFirst();
            int MainNumber;
            int.TryParse(TWNumber.Text, out MainNumber);
            MainNumber--;
            if(MainNumber < 0)
            {
                MessageBox.Show("Нельзя добавить элемент на отрицательное положение в списке");
                return;
            }

            if (MainNumber == 0)
            {
                if (point == null)
                    point = new TwoWayNode(TwoWayNode.RandString( ));
                else
                    point.AddPrev(new TwoWayNode(TwoWayNode.RandString( )));

                if (TWBox2.Text != string.Empty)
                    TWBox1.Text = TWBox2.Text;
                TWBox2.Text = point.ToString(true);
                return;
            }

            TwoWayNode temp = point.MoveNext(--MainNumber);
            if(temp.Number != MainNumber)
            {
                MessageBox.Show("Нельзя добавить элемент после конца списка");
                return;
            }
            temp.AddNext(new TwoWayNode(TwoWayNode.RandString( )));


            if (TWBox2.Text != string.Empty)
                TWBox1.Text = TWBox2.Text;
            TWBox2.Text = point.ToString(true);
        }

        private void TWFill_Click (object sender, EventArgs e)
        {
            point = new TwoWayNode(string.Empty);
            point.Refill();
            point = point.SetFirst();
            
            TWBox1.Text = point.ToString(true);
            TWBox2.Text = string.Empty;
        }


        #endregion

        #region BinTree

        BinTree root = null;

        private void TreeFill_Click (object sender, EventArgs e)
        {
            root = BinTree.BalanceMake(random.Next((int)(maxLength*1.2)) + 1);
            TreeBox1.Text = root.ToString( );
            TreeHeight.Text = root.Height.ToString();
            SearchTree.Enabled = true;
        }

        private void SearchTree_Click (object sender, EventArgs e)
        {
            TreeBox1.Text = root.SearchTree( ).ToString( );
        }



        #endregion
    }
}