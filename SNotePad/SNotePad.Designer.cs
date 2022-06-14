namespace SNotePad
{
    partial class SNotePad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNotePad));
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeThroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutNotePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusContent = new System.Windows.Forms.StatusStrip();
            this.StautsLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.statusContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainRichTextBox.Location = new System.Drawing.Point(0, 24);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.MainRichTextBox.Size = new System.Drawing.Size(800, 426);
            this.MainRichTextBox.TabIndex = 2;
            this.MainRichTextBox.Text = "";
            this.MainRichTextBox.SelectionChanged += new System.EventHandler(this.MainRichTextBox_SelectionChanged);
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.MainRichTextBox_TextChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.PageSetupToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SaveAsToolStripMenuItem.Text = "&Save As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // PageSetupToolStripMenuItem
            // 
            this.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem";
            this.PageSetupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PageSetupToolStripMenuItem.Text = "&Page Setup";
            this.PageSetupToolStripMenuItem.Click += new System.EventHandler(this.PageSetupToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PrintToolStripMenuItem.Text = "P&rint";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.SelectAllToolStripMenuItem1,
            this.DeleteToolStripMenuItem,
            this.FindToolStripMenuItem,
            this.FindNextToolStripMenuItem,
            this.ReplaceToolStripMenuItem,
            this.GoToToolStripMenuItem,
            this.TimeDateToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.UndoToolStripMenuItem.Text = "&Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.CutToolStripMenuItem.Text = "&Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Enabled = false;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Enabled = false;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem1
            // 
            this.SelectAllToolStripMenuItem1.Enabled = false;
            this.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1";
            this.SelectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.SelectAllToolStripMenuItem1.Text = "SelectAll";
            this.SelectAllToolStripMenuItem1.Click += new System.EventHandler(this.SelectAllToolStripMenuItem1_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.DeleteToolStripMenuItem.Text = "&Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.Enabled = false;
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.FindToolStripMenuItem.Text = "&Find";
            this.FindToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // FindNextToolStripMenuItem
            // 
            this.FindNextToolStripMenuItem.Enabled = false;
            this.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem";
            this.FindNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FindNextToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.FindNextToolStripMenuItem.Text = "Find &Next";
            this.FindNextToolStripMenuItem.Click += new System.EventHandler(this.FindNextToolStripMenuItem_Click);
            // 
            // ReplaceToolStripMenuItem
            // 
            this.ReplaceToolStripMenuItem.Enabled = false;
            this.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem";
            this.ReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ReplaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ReplaceToolStripMenuItem.Text = "&Replace";
            this.ReplaceToolStripMenuItem.Click += new System.EventHandler(this.ReplaceToolStripMenuItem_Click);
            // 
            // GoToToolStripMenuItem
            // 
            this.GoToToolStripMenuItem.Enabled = false;
            this.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem";
            this.GoToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GoToToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.GoToToolStripMenuItem.Text = "&Go To";
            this.GoToToolStripMenuItem.Click += new System.EventHandler(this.GoToToolStripMenuItem_Click);
            // 
            // TimeDateToolStripMenuItem
            // 
            this.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem";
            this.TimeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.TimeDateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.TimeDateToolStripMenuItem.Text = "Time / &Date";
            this.TimeDateToolStripMenuItem.Click += new System.EventHandler(this.TimeDateToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underLineToolStripMenuItem,
            this.strikeThroughToolStripMenuItem,
            this.changeTextColorToolStripMenuItem});
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FormatToolStripMenuItem.Text = "&Format";
            // 
            // WordWrapToolStripMenuItem
            // 
            this.WordWrapToolStripMenuItem.CheckOnClick = true;
            this.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem";
            this.WordWrapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WordWrapToolStripMenuItem.Text = "Word Wrap";
            this.WordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.WordWrapToolStripMenuItem_CheckedChanged);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FontToolStripMenuItem.Text = "F&ont";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boldToolStripMenuItem.Text = "&Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.italicToolStripMenuItem.Text = "&Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // underLineToolStripMenuItem
            // 
            this.underLineToolStripMenuItem.Name = "underLineToolStripMenuItem";
            this.underLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.underLineToolStripMenuItem.Text = "&Under line";
            this.underLineToolStripMenuItem.Click += new System.EventHandler(this.UnderLineToolStripMenuItem_Click);
            // 
            // strikeThroughToolStripMenuItem
            // 
            this.strikeThroughToolStripMenuItem.Name = "strikeThroughToolStripMenuItem";
            this.strikeThroughToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.strikeThroughToolStripMenuItem.Text = "&Strike Through";
            this.strikeThroughToolStripMenuItem.Click += new System.EventHandler(this.StrikeoutToolStripMenuItem_Click);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeTextColorToolStripMenuItem.Text = "&Change Text Color";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeTextColorToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "&View";
            // 
            // StatusBarToolStripMenuItem
            // 
            this.StatusBarToolStripMenuItem.CheckOnClick = true;
            this.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
            this.StatusBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StatusBarToolStripMenuItem.Text = "Status Bar";
            this.StatusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.StatusBarToolStripMenuItem_CheckedChanged);           
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelpToolStripMenuItem,
            this.AboutNotePadToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // ViewHelpToolStripMenuItem
            // 
            this.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem";
            this.ViewHelpToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ViewHelpToolStripMenuItem.Text = "&View Help";
            this.ViewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // AboutNotePadToolStripMenuItem
            // 
            this.AboutNotePadToolStripMenuItem.Name = "AboutNotePadToolStripMenuItem";
            this.AboutNotePadToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AboutNotePadToolStripMenuItem.Text = "About Notepad";
            this.AboutNotePadToolStripMenuItem.Click += new System.EventHandler(this.AboutNotePadToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.FormatToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusContent
            // 
            this.statusContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StautsLevel});
            this.statusContent.Location = new System.Drawing.Point(0, 428);
            this.statusContent.Name = "statusContent";
            this.statusContent.Size = new System.Drawing.Size(800, 22);
            this.statusContent.TabIndex = 3;
            this.statusContent.Text = "statusStrip1";
            // 
            // StautsLevel
            // 
            this.StautsLevel.Name = "StautsLevel";
            this.StautsLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StautsLevel.Size = new System.Drawing.Size(65, 17);
            this.StautsLevel.Text = "Ln 1 , Col 1";
            // 
            // printDialog
            // 
            this.printDialog.AllowSelection = true;
            this.printDialog.AllowSomePages = true;
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // SNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusContent);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SNotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad-By_Sabbir _Mehedi_Mamun";
            this.Load += new System.EventHandler(this.SNotePad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusContent.ResumeLayout(false);
            this.statusContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutNotePadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeThroughToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTextColorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusContent;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripStatusLabel StautsLevel;
    }
}

