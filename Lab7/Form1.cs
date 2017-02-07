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

        

        #endregion

    }
}