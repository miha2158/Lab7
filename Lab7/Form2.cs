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
    public partial class Form2: Form
    {
        Form1 parent = null;

        public Form2 (Form1 formParent )
        {
            InitializeComponent( );
            parent = formParent;
            DesktopLocation = parent.DesktopLocation;
        }

        protected Form2 ( )
        {
            InitializeComponent( );
        }

        private void Search_Click (object sender, EventArgs e)
        {
            string dialogue = "Элемент {0} {1} найден";
            Hide();
            if (CharSearchBox.TextLength > 0)
                if (parent?.search.Search(CharSearchBox.Text[0]) ?? false)
                    MessageBox.Show(string.Format(dialogue, CharSearchBox.Text[0], "").Replace("  ", " "));
                else
                    MessageBox.Show(string.Format(dialogue, CharSearchBox.Text[0], "не").Replace("  ", " "));
            Close();
        }
    }
}
