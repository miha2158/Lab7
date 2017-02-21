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
    public partial class Form3: Form
    {
        Form1 parentForm = null;
        int operatingMode = 0;

        public Form3 (Form1 parent, int mode)
        {
            InitializeComponent( );
            parentForm = parent;
            DesktopLocation = parent.DesktopLocation;
            Owner = parentForm;
            operatingMode = mode;
            if (operatingMode == 2)
                label1.Text = "Пробелы и новые строки будут проигнорированы";
        }

        private void OWBox1_TextChanged (object sender, EventArgs e)
        {
            Accept.Enabled = OWBox1.Text.Trim( ).Length != 0;

            if(operatingMode != 1)
                return;

            string input = OWBox1.Text;
            string Numbers = string.Empty;
            int select = OWBox1.SelectionStart + OWBox1.SelectionLength;
            foreach (char c in input)
                if (char.IsDigit(c) || char.IsWhiteSpace(c) || c == '-')
                    Numbers = Numbers + c;
                else
                    select--;
            if (Numbers != Numbers.Replace("--", "-"))
            {
                select--;
                Numbers = Numbers.Replace("--", "-");
            }

            if (Numbers != Numbers.Replace("- ", " "))
            {
                select--;
                Numbers = Numbers.Replace("- ", " ");
            }
            OWBox1.Text = Numbers;
            OWBox1.SelectionStart = select > 0 ? select : 0;
            OWBox1.SelectionLength = 0;
        }

        private void Accept_Click (object sender, EventArgs e)
        {
            Hide();
            if (operatingMode == 1)
            {
                string[] InputArray = OWBox1.Text.Trim( ).Replace("  ", " ").Split(' ');

                int[] OutputArray = new int[0];
                foreach (string s in InputArray)
                {
                    int temp;
                    if (int.TryParse(s, out temp))
                    {
                        Array.Resize(ref OutputArray, OutputArray.Length + 1);
                        OutputArray[OutputArray.Length - 1] = temp;
                    }
                }

                OneWayNode head = null;

                for (int i = OutputArray.Length; i-- > 0;)
                    head = new OneWayNode(OutputArray[i], ref head);

                parentForm.head = head;
            }

            if(operatingMode == 2)
            {
                char[] OutputArray = new char[0];

                foreach (char c in OWBox1.Text)
                    if (!char.IsWhiteSpace(c))
                    {
                        Array.Resize(ref OutputArray, OutputArray.Length + 1);
                        OutputArray[OutputArray.Length - 1] = c;
                    }

                parentForm.root = BinTree.FromArray(OutputArray);
                parentForm.search = parentForm.root.SearchTree( );
            }

            Close();
        }
    }
}
