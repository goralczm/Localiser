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
            newKeyTextBox = new TextBox();
            addKeyButton = new Button();
            addTagButton = new Button();
            newTagTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
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
            // localisationTagsComboBox
            // 
            localisationTagsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            localisationTagsComboBox.FormattingEnabled = true;
            localisationTagsComboBox.Location = new Point(118, 3);
            localisationTagsComboBox.Name = "localisationTagsComboBox";
            localisationTagsComboBox.Size = new Size(121, 23);
            localisationTagsComboBox.TabIndex = 2;
            // 
            // localisedTextRichTextBox
            // 
            localisedTextRichTextBox.Location = new Point(261, 27);
            localisedTextRichTextBox.Name = "localisedTextRichTextBox";
            localisedTextRichTextBox.Size = new Size(251, 406);
            localisedTextRichTextBox.TabIndex = 3;
            localisedTextRichTextBox.Text = "";
            // 
            // localisedKeysSearchTextBox
            // 
            localisedKeysSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            localisedKeysSearchTextBox.Location = new Point(0, 28);
            localisedKeysSearchTextBox.Name = "localisedKeysSearchTextBox";
            localisedKeysSearchTextBox.Size = new Size(240, 23);
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
            // newKeyTextBox
            // 
            newKeyTextBox.Location = new Point(3, 28);
            newKeyTextBox.Name = "newKeyTextBox";
            newKeyTextBox.Size = new Size(116, 23);
            newKeyTextBox.TabIndex = 8;
            // 
            // addKeyButton
            // 
            addKeyButton.Location = new Point(125, 27);
            addKeyButton.Name = "addKeyButton";
            addKeyButton.Size = new Size(75, 23);
            addKeyButton.TabIndex = 9;
            addKeyButton.Text = "Add Key";
            addKeyButton.UseVisualStyleBackColor = true;
            addKeyButton.Click += addKeyButton_Click;
            // 
            // addTagButton
            // 
            addTagButton.Location = new Point(125, 56);
            addTagButton.Name = "addTagButton";
            addTagButton.Size = new Size(75, 23);
            addTagButton.TabIndex = 10;
            addTagButton.Text = "Add Tag";
            addTagButton.UseVisualStyleBackColor = true;
            addTagButton.Click += addTagButton_Click;
            // 
            // newTagTextBox
            // 
            newTagTextBox.Location = new Point(3, 57);
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
            panel1.Controls.Add(localisationTagsComboBox);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 412);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(addTagButton);
            panel2.Controls.Add(newTagTextBox);
            panel2.Controls.Add(newKeyTextBox);
            panel2.Controls.Add(addKeyButton);
            panel2.Location = new Point(524, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 88);
            panel2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 12;
            label2.Text = "Add Key and Tag";
            // 
            // Localiser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(saveButton);
            Controls.Add(localisedTextRichTextBox);
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
        private ComboBox localisationTagsComboBox;
        private RichTextBox localisedTextRichTextBox;
        private TextBox localisedKeysSearchTextBox;
        private Button saveButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private TextBox newKeyTextBox;
        private Button addKeyButton;
        private Button addTagButton;
        private TextBox newTagTextBox;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}
