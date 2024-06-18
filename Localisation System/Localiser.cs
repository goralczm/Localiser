using System.Windows.Forms;

namespace Localisation_System
{
    public partial class Localiser : Form
    {
        private LocalisationSystem localiser = new LocalisationSystem();

        public Localiser()
        {
            InitializeComponent();

            localisationKeysListBox.SelectedIndexChanged += UpdateLocalisedText;
            localisationTagsComboBox1.SelectedIndexChanged += UpdateLocalisedText;
            localisationTagsComboBox2.SelectedIndexChanged += UpdateLocalisedText;
        }

        private void UpdateLocalisedText(object? sender, EventArgs e)
        {
            KeyValuePair<string, string> firstTagAndKey = GetCurrentTagAndKeyFromComboBox(localisationTagsComboBox1);
            string firstValue = localiser.GetLocalisedValue(firstTagAndKey.Key, firstTagAndKey.Value);
            localisedTextRichTextBox1.Text = firstValue;

            KeyValuePair<string, string> secondTagAndKey = GetCurrentTagAndKeyFromComboBox(localisationTagsComboBox2);
            string secondValue = localiser.GetLocalisedValue(secondTagAndKey.Key, secondTagAndKey.Value);
            localisedTextRichTextBox2.Text = secondValue;

            renameKeyTextBox.Text = firstTagAndKey.Value;
        }

        private KeyValuePair<string, string> GetCurrentTagAndKeyFromComboBox(ComboBox comboBox)
        {
            string? tag = "";
            string? key = "";

            if (comboBox.SelectedItem != null)
                tag = comboBox.SelectedItem.ToString();

            if (localisationKeysListBox.SelectedItem != null)
                key = localisationKeysListBox.SelectedItem.ToString();

            return new KeyValuePair<string, string>(tag, key);
        }

        private void localisedKeysSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBoxWithKeys();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            KeyValuePair<string, string> firstTagAndKey = GetCurrentTagAndKeyFromComboBox(localisationTagsComboBox1);
            KeyValuePair<string, string> secondTagAndKey = GetCurrentTagAndKeyFromComboBox(localisationTagsComboBox2);

            string firstVal = localisedTextRichTextBox1.Text;
            string secondVal = localisedTextRichTextBox2.Text;

            localiser.UpdateKeyInTag(firstTagAndKey.Key, firstTagAndKey.Value, firstVal);
            localiser.UpdateKeyInTag(secondTagAndKey.Key, secondTagAndKey.Value, secondVal);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitalizeLocalisation();
        }

        private void InitalizeLocalisation()
        {
            localiser = new LocalisationSystem();
            localiser.OnKeysChanged += UpdateListBoxWithKeys;
            localiser.OnTagsChanged += UpdateComboBoxWithTags;

            localiser.Initialize();
        }

        private void UpdateListBoxWithKeys()
        {
            localisationKeysListBox.Items.Clear();

            List<string> keys = localiser.GetAllKeys().ToList();
            keys.ForEach(key =>
            {
                if (key.Contains(localisedKeysSearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase))
                    localisationKeysListBox.Items.Add(key);
            });
        }

        private void UpdateComboBoxWithTags()
        {
            localisationTagsComboBox1.Items.Clear();
            localisationTagsComboBox2.Items.Clear();
            localiser.GetTags().ToList().ForEach(tag =>
            {
                localisationTagsComboBox1.Items.Add(tag);
                localisationTagsComboBox2.Items.Add(tag);
            });

            if (localisationTagsComboBox1.SelectedIndex == -1 && localisationTagsComboBox1.Items.Count > 0)
                localisationTagsComboBox1.SelectedIndex = 0;

            if (localisationTagsComboBox2.SelectedIndex == -1 && localisationTagsComboBox2.Items.Count > 0)
                localisationTagsComboBox2.SelectedIndex = 0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localiser.SaveViaPath();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localiser.SaveViaDialog();
        }

        private void addKeyButton_Click(object sender, EventArgs e)
        {
            localiser.AddKey(localisedKeysSearchTextBox.Text);
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            localiser.AddTag(newTagTextBox.Text);
            newTagTextBox.Text = "";
        }

        private void renameKeyButton_Click(object sender, EventArgs e)
        {
            string? key = "";
            if (localisationKeysListBox.SelectedItem != null)
                key = localisationKeysListBox.SelectedItem.ToString();

            string newName = renameKeyTextBox.Text;
            localiser.RenameKey(key, newName);
        }

        private void deleteKeyButton_Click(object sender, EventArgs e)
        {
            string? key = "";
            if (localisationKeysListBox.SelectedItem != null)
                key = localisationKeysListBox.SelectedItem.ToString();

            localiser.RemoveKey(key);
        }
    }
}
