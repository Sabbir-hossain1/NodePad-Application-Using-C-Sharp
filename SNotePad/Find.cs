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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if(findTextBox.Text.Length>0)
            {
                findTextButton.Enabled = true;
            }
            else
            {
                findTextButton.Enabled = false;
            }
        }

        private void FindTextButton_Click(object sender, EventArgs e)
        {
            if(matchCaseCheckBox.Checked == true)
            {
                SNotePad.matchCase = true;
            }
            else
            {
                SNotePad.matchCase = false;
            }
            SNotePad.FindText = findTextBox.Text;
            this.Close();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SNotePad.FindText ="";
            this.Close();
        }
    }
}
