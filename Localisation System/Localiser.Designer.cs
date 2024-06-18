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
            localisationTagsComboBox1 = new ComboBox();
            localisedTextRichTextBox1 = new RichTextBox();
            localisedKeysSearchTextBox = new TextBox();
            saveButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            addKeyButton = new Button();
            addTagButton = new Button();
            newTagTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            deleteKeyButton = new Button();
            renameKeyButton = new Button();
            renameKeyTextBox = new TextBox();
            label2 = new Label();
            localisedTextRichTextBox2 = new RichTextBox();
            localisationTagsComboBox2 = new ComboBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // localisationKeysListBox
            // 
            localisationKeysListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            localisationKeysListBox.FormattingEnabled = true;
            localisationKeysListBox.ItemHeight = 15;
            localisationKeysListBox.Location = new Point(0, 57);
            localisationKeysListBox.Name = "localisationKeysListBox";
            localisationKeysListBox.Size = new Size(243, 349);
            localisationKeysListBox.TabIndex = 1;
            // 
            // localisationTagsComboBox1
            // 
            localisationTagsComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            localisationTagsComboBox1.FormattingEnabled = true;
            localisationTagsComboBox1.Location = new Point(261, 26);
            localisationTagsComboBox1.Name = "localisationTagsComboBox1";
            localisationTagsComboBox1.Size = new Size(117, 23);
            localisationTagsComboBox1.TabIndex = 2;
            // 
            // localisedTextRichTextBox1
            // 
            localisedTextRichTextBox1.Location = new Point(261, 55);
            localisedTextRichTextBox1.Name = "localisedTextRichTextBox1";
            localisedTextRichTextBox1.Size = new Size(117, 378);
            localisedTextRichTextBox1.TabIndex = 3;
            localisedTextRichTextBox1.Text = "";
            // 
            // localisedKeysSearchTextBox
            // 
            localisedKeysSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            localisedKeysSearchTextBox.Location = new Point(0, 28);
            localisedKeysSearchTextBox.Name = "localisedKeysSearchTextBox";
            localisedKeysSearchTextBox.Size = new Size(162, 23);
            localisedKeysSearchTextBox.TabIndex = 4;
            localisedKeysSearchTextBox.TextChanged += localisedKeysSearchTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(527, 417);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(202, 22);
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(741, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // addKeyButton
            // 
            addKeyButton.Location = new Point(168, 28);
            addKeyButton.Name = "addKeyButton";
            addKeyButton.Size = new Size(75, 23);
            addKeyButton.TabIndex = 9;
            addKeyButton.Text = "Add Key";
            addKeyButton.UseVisualStyleBackColor = true;
            addKeyButton.Click += addKeyButton_Click;
            // 
            // addTagButton
            // 
            addTagButton.Location = new Point(125, 27);
            addTagButton.Name = "addTagButton";
            addTagButton.Size = new Size(75, 23);
            addTagButton.TabIndex = 10;
            addTagButton.Text = "Add Tag";
            addTagButton.UseVisualStyleBackColor = true;
            addTagButton.Click += addTagButton_Click;
            // 
            // newTagTextBox
            // 
            newTagTextBox.Location = new Point(3, 28);
            newTagTextBox.Name = "newTagTextBox";
            newTagTextBox.Size = new Size(116, 23);
            newTagTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 12;
            label1.Text = "Search Keys";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(localisedKeysSearchTextBox);
            panel1.Controls.Add(localisationKeysListBox);
            panel1.Controls.Add(addKeyButton);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 412);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(deleteKeyButton);
            panel2.Controls.Add(renameKeyButton);
            panel2.Controls.Add(renameKeyTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(addTagButton);
            panel2.Controls.Add(newTagTextBox);
            panel2.Location = new Point(524, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 382);
            panel2.TabIndex = 14;
            // 
            // deleteKeyButton
            // 
            deleteKeyButton.Location = new Point(3, 86);
            deleteKeyButton.Name = "deleteKeyButton";
            deleteKeyButton.Size = new Size(197, 23);
            deleteKeyButton.TabIndex = 15;
            deleteKeyButton.Text = "Delete Key";
            deleteKeyButton.UseVisualStyleBackColor = true;
            deleteKeyButton.Click += deleteKeyButton_Click;
            // 
            // renameKeyButton
            // 
            renameKeyButton.Location = new Point(125, 57);
            renameKeyButton.Name = "renameKeyButton";
            renameKeyButton.Size = new Size(75, 23);
            renameKeyButton.TabIndex = 14;
            renameKeyButton.Text = "Rename Key";
            renameKeyButton.UseVisualStyleBackColor = true;
            renameKeyButton.Click += renameKeyButton_Click;
            // 
            // renameKeyTextBox
            // 
            renameKeyTextBox.Location = new Point(3, 57);
            renameKeyTextBox.Name = "renameKeyTextBox";
            renameKeyTextBox.Size = new Size(116, 23);
            renameKeyTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 12;
            label2.Text = "Key and Tag Utilities";
            // 
            // localisedTextRichTextBox2
            // 
            localisedTextRichTextBox2.Location = new Point(384, 55);
            localisedTextRichTextBox2.Name = "localisedTextRichTextBox2";
            localisedTextRichTextBox2.Size = new Size(117, 378);
            localisedTextRichTextBox2.TabIndex = 3;
            localisedTextRichTextBox2.Text = "";
            // 
            // localisationTagsComboBox2
            // 
            localisationTagsComboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            localisationTagsComboBox2.FormattingEnabled = true;
            localisationTagsComboBox2.Location = new Point(384, 26);
            localisationTagsComboBox2.Name = "localisationTagsComboBox2";
            localisationTagsComboBox2.Size = new Size(117, 23);
            localisationTagsComboBox2.TabIndex = 2;
            // 
            // Localiser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(saveButton);
            Controls.Add(localisationTagsComboBox2);
            Controls.Add(localisationTagsComboBox1);
            Controls.Add(localisedTextRichTextBox2);
            Controls.Add(localisedTextRichTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Localiser";
            Text = "Localisation System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox localisationKeysListBox;
        private ComboBox localisationTagsComboBox1;
        private RichTextBox localisedTextRichTextBox1;
        private TextBox localisedKeysSearchTextBox;
        private Button saveButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Button addKeyButton;
        private Button addTagButton;
        private TextBox newTagTextBox;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button renameKeyButton;
        private TextBox renameKeyTextBox;
        private Button deleteKeyButton;
        private RichTextBox localisedTextRichTextBox2;
        private ComboBox localisationTagsComboBox2;
    }
}
