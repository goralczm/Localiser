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
            SuspendLayout();
            // 
            // localisationKeysListBox
            // 
            localisationKeysListBox.FormattingEnabled = true;
            localisationKeysListBox.ItemHeight = 15;
            localisationKeysListBox.Location = new Point(12, 41);
            localisationKeysListBox.Name = "localisationKeysListBox";
            localisationKeysListBox.Size = new Size(222, 379);
            localisationKeysListBox.TabIndex = 1;
            // 
            // localisationTagsComboBox
            // 
            localisationTagsComboBox.FormattingEnabled = true;
            localisationTagsComboBox.Location = new Point(240, 12);
            localisationTagsComboBox.Name = "localisationTagsComboBox";
            localisationTagsComboBox.Size = new Size(121, 23);
            localisationTagsComboBox.TabIndex = 2;
            // 
            // localisedTextRichTextBox
            // 
            localisedTextRichTextBox.Location = new Point(489, 12);
            localisedTextRichTextBox.Name = "localisedTextRichTextBox";
            localisedTextRichTextBox.ReadOnly = true;
            localisedTextRichTextBox.Size = new Size(299, 426);
            localisedTextRichTextBox.TabIndex = 3;
            localisedTextRichTextBox.Text = "";
            // 
            // localisedKeysSearchTextBox
            // 
            localisedKeysSearchTextBox.Location = new Point(12, 12);
            localisedKeysSearchTextBox.Name = "localisedKeysSearchTextBox";
            localisedKeysSearchTextBox.Size = new Size(222, 23);
            localisedKeysSearchTextBox.TabIndex = 4;
            localisedKeysSearchTextBox.TextChanged += localisedKeysSearchTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(localisedKeysSearchTextBox);
            Controls.Add(localisedTextRichTextBox);
            Controls.Add(localisationTagsComboBox);
            Controls.Add(localisationKeysListBox);
            Name = "Form1";
            Text = "Localisation System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox localisationKeysListBox;
        private ComboBox localisationTagsComboBox;
        private RichTextBox localisedTextRichTextBox;
        private TextBox localisedKeysSearchTextBox;
    }
}
