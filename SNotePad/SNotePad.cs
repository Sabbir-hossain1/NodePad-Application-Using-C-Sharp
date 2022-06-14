using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNotePad
{
    public partial class SNotePad : Form
    {
        // Variables
        #region variables
        private bool isFileAlreadySaved = false;
        private bool addNewText;
        private string currOpenFileName;      
        public static string FindText;
        public static string ReplaceText;
        public static bool matchCase;
        int d;

        #endregion

        public SNotePad()
        {
            InitializeComponent();            
        }

        //File  Menu 
        #region NewMenu 
        //New Menu Method
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addNewText)
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes ?", "Save file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFileMenu();
                        ClearScreen();
                        break;
                    case DialogResult.No:
                        ClearScreen();
                        break;
                }
            }
            else
                ClearScreen();

            PasteToolStripMenuItem.Enabled = false;
            CutToolStripMenuItem.Enabled = false;
            CopyToolStripMenuItem.Enabled = false;
            SelectAllToolStripMenuItem.Enabled = false;               
            DeleteToolStripMenuItem.Enabled = false;
            FindNextToolStripMenuItem.Enabled = false;
            FindToolStripMenuItem.Enabled = false;
            ReplaceToolStripMenuItem.Enabled = false;
            GoToToolStripMenuItem.Enabled = false;
            SelectAllToolStripMenuItem1.Enabled = false;
        }
        #endregion        
        #region OpenMenu

        //Open Menu Method
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
            this.Text = Path.GetFileName(openFileDialog.FileName) + "- SNotepad";
            isFileAlreadySaved = true;
            addNewText = false;
            currOpenFileName = openFileDialog.FileName;

            UndoToolStripMenuItem.Enabled = false;
            PasteToolStripMenuItem.Enabled = false;

        }
        #endregion        
        #region SaveMenu

        //Save Menu Method 
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save Menu Method        
            SaveFileMenu();

        }

        //Save Menu Method
        private void SaveFileMenu()
        {
            if (isFileAlreadySaved)
            {
                if (Path.GetExtension(currOpenFileName) == ".txt")
                    MainRichTextBox.SaveFile(currOpenFileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(currOpenFileName) == ".rtf")
                    MainRichTextBox.SaveFile(currOpenFileName, RichTextBoxStreamType.RichText);
                addNewText = false;
            }
            else
            {
                if (addNewText | !isFileAlreadySaved)
                {
                    SaveAsFileMenu();
                }
                else
                {
                    ClearScreen();

                }

            }
        }
        #endregion        
        #region SaveAsMenu

        //SaveAs Method
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveAs Method call
            SaveAsFileMenu();
        }
        
        private void SaveAsFileMenu()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                {
                    MainRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                {
                    MainRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(saveFileDialog.FileName) + "-SNotepad";
                isFileAlreadySaved = true;
                addNewText = false;
                currOpenFileName = saveFileDialog.FileName;
            }
        }
        #endregion
        #region PageSetup
        private void PageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }
        #endregion
        #region Print
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {

            printDialog.Document = printDocument;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            //Call ShowDialog  
            if (printDialog.ShowDialog() == DialogResult.OK) printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(MainRichTextBox.Text, new Font("Arial", 14), Brushes.Black, 12, 20);
        }

        #endregion
        #region Exit
        //Exit Method
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(addNewText)
            {
               DialogResult result = MessageBox.Show("Do you want to save changes ?", "Warning !", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    SaveFileMenu();           
                Application.Exit();
                } 
                if(result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            Application.Exit();
        }
        #endregion

     

        //Edit Menu
        #region Undo        
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
        }
        #endregion        
        #region Cut
        //Cut Method
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
            PasteToolStripMenuItem.Enabled = true;
        }
        #endregion        
        #region Copy
        //Copy Method
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
            PasteToolStripMenuItem.Enabled = true;
        }
        #endregion        
        #region Pasete
        //Paste Method
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }
        #endregion        
        #region SelectAll
        private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }
        #endregion    
        #region Delete
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Text = MainRichTextBox.Text.Remove(MainRichTextBox.SelectionStart,MainRichTextBox.SelectionLength);
        }
        #endregion
        #region Find
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find find = new Find();
            find.ShowDialog();
            if(FindText !="")
            {
                d = MainRichTextBox.Find(FindText);
                FindNextToolStripMenuItem.Enabled = true;

            }
        }
        #endregion
        #region FindNext
        private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (FindText != "")
            {
                if (matchCase == true)
                {
                   // MainRichTextBox.Find(FindText);
                    d = MainRichTextBox.Find(FindText,(d+1),MainRichTextBox.Text.Length,RichTextBoxFinds.MatchCase);

                }
                else
                {
                   // MainRichTextBox.Find(FindText);
                    d = MainRichTextBox.Find(FindText, (d + 1), MainRichTextBox.Text.Length, RichTextBoxFinds.None);

                }

            }            
        }        

        #endregion
        #region Replace
        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace replace = new Replace();
            replace.ShowDialog();
            MainRichTextBox.Find(FindText);
            MainRichTextBox.SelectedText = ReplaceText;
        }
        #endregion        
        #region Goto
        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Line Number", "Go To", "1");
            try
            {
                int line = Convert.ToInt32(input);
                if(line>MainRichTextBox.Lines.Length)
                {
                    MessageBox.Show("Total lines in the files is " + MainRichTextBox.Lines.Length , "Can't Reach",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    string[] lines = MainRichTextBox.Lines;
                    int len = 0;
                    for(int i=0;i<line-1;i++)
                    {
                        len = len + lines[i].Length+1;
                    }
                    MainRichTextBox.Focus();
                    MainRichTextBox.Select(len, 0);
                }

            }catch(Exception )
            {
                MessageBox.Show("Please Enter a valid integer", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion        
        #region DateTime
        private void TimeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText += DateTime.Now.ToString();
        }
        #endregion

        //Formate Menu
        #region WordWrap & Status
        private void MainRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int pos = MainRichTextBox.SelectionStart;
            int line = MainRichTextBox.GetLineFromCharIndex(pos) + 1;
            int col = pos - MainRichTextBox.GetFirstCharIndexOfCurrentLine() + 1;
            StautsLevel.Text = "Ln " + line + " , Col " + col;
        }

        private void WordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            MainRichTextBox.WordWrap = WordWrapToolStripMenuItem.Checked;
            StatusBarToolStripMenuItem.Enabled = !WordWrapToolStripMenuItem.Checked;
            StatusBarToolStripMenuItem.Checked = true;
            statusContent.Visible = StatusBarToolStripMenuItem.Enabled;
        }

        private void StatusBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            statusContent.Visible = StatusBarToolStripMenuItem.Checked;
        }
        #endregion
        #region Font
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            DialogResult result =  fontDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if(MainRichTextBox.SelectionLength>0)
                {
                    MainRichTextBox.SelectionFont = fontDialog.Font;
                    MainRichTextBox.SelectionColor = fontDialog.Color;
                }
            }
        }

        private void FormateText(FontStyle fontStyle)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font,fontStyle);
        }
        #endregion       
        #region Normal
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormateText(FontStyle.Regular);
        }
        #endregion     
        #region Bold
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormateText(FontStyle.Bold);
        }
        #endregion
        #region Italic
        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormateText(FontStyle.Italic);
        }
        #endregion       
        #region Underline
        private void UnderLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormateText(FontStyle.Underline);
        }
        #endregion       
        #region Strikeout
        private void StrikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormateText(FontStyle.Strikeout);
        }
        #endregion
        #region Change Text Color
        private void ChangeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(MainRichTextBox.SelectionLength>0)
            {
                if(result == DialogResult.OK)
                {
                    MainRichTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }
        #endregion


        //View Menu
        #region StatusBar
        private void StatusBar()
        {
            MainRichTextBox.WordWrap = WordWrapToolStripMenuItem.Enabled;
            StatusBarToolStripMenuItem.Enabled = !WordWrapToolStripMenuItem.Checked;
            if (StatusBarToolStripMenuItem.Enabled)
                StatusBarToolStripMenuItem.Checked = true;
            statusContent.Visible = StatusBarToolStripMenuItem.Checked;
        }
        #endregion


        //Help Menu
        #region Help
        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/?LinkId=834783");
        }
        #endregion
        #region About
        private void AboutNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        #endregion                  

        //Load Method
        #region Load_Method
        private void SNotePad_Load(object sender, EventArgs e)
        {
            isFileAlreadySaved = false;
            addNewText = false;
            currOpenFileName = "";
            statusContent.BackColor = Color.AntiqueWhite;

            //This part is for WordWrap and Status Bar
            StatusBar();
        }        
        #endregion

        //Pressed any key
        #region Text changes
        //Text Changed Method
        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            addNewText = true;
            UndoToolStripMenuItem.Enabled = true;
            CutToolStripMenuItem.Enabled = true;
            CopyToolStripMenuItem.Enabled = true;
            DeleteToolStripMenuItem.Enabled = true;            
            FindToolStripMenuItem.Enabled = true;
            ReplaceToolStripMenuItem.Enabled = true;
            GoToToolStripMenuItem.Enabled = true;
            SelectAllToolStripMenuItem1.Enabled = true;

        }
        #endregion

        //Clear Screen
        #region ClearScreen
        //Clear Screen Method
        private void ClearScreen()
        {
            MainRichTextBox.Clear();
            addNewText = false;
            this.Text = "Untitled Notepad";
        }




        #endregion        
               
    }
}
