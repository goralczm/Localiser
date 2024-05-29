namespace Localisation_System
{
    partial class Localiser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            localisationKeysListBox = new ListBox();
            localisationTagsComboBox = new ComboBox();
            localisedTextRichTextBox = new RichTextBox();
            localisedKeysSearchTextBox = new TextBox();
            saveButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // localisationKeysListBox
            // 
            localisationKeysListBox.FormattingEnabled = true;
            localisationKeysListBox.Location = new Point(14, 95);
            localisationKeysListBox.Margin = new Padding(3, 4, 3, 4);
            localisationKeysListBox.Name = "localisationKeysListBox";
            localisationKeysListBox.Size = new Size(253, 464);
            localisationKeysListBox.TabIndex = 1;
            // 
            // localisationTagsComboBox
            // 
            localisationTagsComboBox.FormattingEnabled = true;
            localisationTagsComboBox.Location = new Point(274, 43);
            localisationTagsComboBox.Margin = new Padding(3, 4, 3, 4);
            localisationTagsComboBox.Name = "localisationTagsComboBox";
            localisationTagsComboBox.Size = new Size(138, 28);
            localisationTagsComboBox.TabIndex = 2;
            // 
            // localisedTextRichTextBox
            // 
            localisedTextRichTextBox.Location = new Point(559, 16);
            localisedTextRichTextBox.Margin = new Padding(3, 4, 3, 4);
            localisedTextRichTextBox.Name = "localisedTextRichTextBox";
            localisedTextRichTextBox.Size = new Size(341, 460);
            localisedTextRichTextBox.TabIndex = 3;
            localisedTextRichTextBox.Text = "";
            // 
            // localisedKeysSearchTextBox
            // 
            localisedKeysSearchTextBox.Location = new Point(14, 43);
            localisedKeysSearchTextBox.Margin = new Padding(3, 4, 3, 4);
            localisedKeysSearchTextBox.Name = "localisedKeysSearchTextBox";
            localisedKeysSearchTextBox.Size = new Size(253, 27);
            localisedKeysSearchTextBox.TabIndex = 4;
            localisedKeysSearchTextBox.TextChanged += localisedKeysSearchTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(559, 483);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(343, 29);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(143, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(143, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(143, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // Localiser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(saveButton);
            Controls.Add(localisedKeysSearchTextBox);
            Controls.Add(localisedTextRichTextBox);
            Controls.Add(localisationTagsComboBox);
            Controls.Add(localisationKeysListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Localiser";
            Text = "Localisation System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox localisationKeysListBox;
        private ComboBox localisationTagsComboBox;
        private RichTextBox localisedTextRichTextBox;
        private TextBox localisedKeysSearchTextBox;
        private Button saveButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
    }
}
