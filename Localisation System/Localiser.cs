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
            localisationTagsComboBox.SelectedIndexChanged += UpdateLocalisedText;
        }

        private void UpdateLocalisedText(object? sender, EventArgs e)
        {
            KeyValuePair<string, string> tagAndKey = GetCurrentTagAndKey();

            string value = localiser.GetLocalisedValue(tagAndKey.Key, tagAndKey.Value);

            localisedTextRichTextBox.Text = value;
        }

        private KeyValuePair<string, string> GetCurrentTagAndKey()
        {
            string? tag = "";
            string? key = "";

            if (localisationTagsComboBox.SelectedItem != null)
                tag = localisationTagsComboBox.SelectedItem.ToString();

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
            KeyValuePair<string, string> tagAndKey = GetCurrentTagAndKey();
            string newVal = localisedTextRichTextBox.Text;

            localiser.UpdateKeyInTag(tagAndKey.Key, tagAndKey.Value, newVal);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitalizeLocalisation();
        }

        private void InitalizeLocalisation()
        {
            localiser = new LocalisationSystem();
            localiser.OnKeysChanged += UpdateUI;
            localiser.OnTagsChanged += UpdateUI;

            localiser.Initialize();
        }

        private void UpdateUI()
        {
            UpdateListBoxWithKeys();
            UpdateComboBoxWithTags();
        }

        private void UpdateListBoxWithKeys()
        {
            localisationKeysListBox.Items.Clear();

            List<string> keys = localiser.GetAllKeys().ToList();
            keys.ForEach(key =>
            {
                if (key.StartsWith(localisedKeysSearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase))
                    localisationKeysListBox.Items.Add(key);
            });
        }

        private void UpdateComboBoxWithTags()
        {
            localisationTagsComboBox.Items.Clear();
            localiser.GetTags().ToList().ForEach(tag =>
            {
                localisationTagsComboBox.Items.Add(tag);
            });

            if (localisationTagsComboBox.SelectedIndex == -1 && localisationTagsComboBox.Items.Count > 0)
                localisationTagsComboBox.SelectedIndex = 0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
            localiser.SaveViaPath();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
            localiser.SaveViaDialog();
        }

        private void addKeyButton_Click(object sender, EventArgs e)
        {
            localiser.AddKey(newKeyTextBox.Text);
            newKeyTextBox.Text = "";
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
