using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNotePad
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void FindTextButton_Click(object sender, EventArgs e)
        {
            SNotePad.FindText = findTextBox.Text;
            SNotePad.ReplaceText = replaceTextBox.Text;
            this.Close();
        }
    }
}
