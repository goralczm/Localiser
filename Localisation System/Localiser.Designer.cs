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
            saveToFileButton = new Button();
            SuspendLayout();
            // 
            // localisationKeysListBox
            // 
            localisationKeysListBox.FormattingEnabled = true;
            localisationKeysListBox.Location = new Point(14, 55);
            localisationKeysListBox.Margin = new Padding(3, 4, 3, 4);
            localisationKeysListBox.Name = "localisationKeysListBox";
            localisationKeysListBox.Size = new Size(253, 504);
            localisationKeysListBox.TabIndex = 1;
            // 
            // localisationTagsComboBox
            // 
            localisationTagsComboBox.FormattingEnabled = true;
            localisationTagsComboBox.Location = new Point(274, 16);
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
            localisedKeysSearchTextBox.Location = new Point(14, 16);
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
            // saveToFileButton
            // 
            saveToFileButton.Location = new Point(559, 518);
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.Size = new Size(343, 29);
            saveToFileButton.TabIndex = 6;
            saveToFileButton.Text = "Save To File";
            saveToFileButton.UseVisualStyleBackColor = true;
            saveToFileButton.Click += saveToFileButton_Click;
            // 
            // Localiser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(saveToFileButton);
            Controls.Add(saveButton);
            Controls.Add(localisedKeysSearchTextBox);
            Controls.Add(localisedTextRichTextBox);
            Controls.Add(localisationTagsComboBox);
            Controls.Add(localisationKeysListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Localiser";
            Text = "Localisation System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox localisationKeysListBox;
        private ComboBox localisationTagsComboBox;
        private RichTextBox localisedTextRichTextBox;
        private TextBox localisedKeysSearchTextBox;
        private Button saveButton;
        private Button saveToFileButton;
    }
}
