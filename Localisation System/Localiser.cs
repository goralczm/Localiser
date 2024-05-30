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
            string tag = "";
            string key = "";

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
            UpdateUI();
        }

        private void InitalizeLocalisation()
        {
            localiser = new LocalisationSystem();
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

            if (localisationTagsComboBox.Items.Count > 0)
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
            UpdateUI();
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            localiser.AddTag(newTagTextBox.Text);
            newTagTextBox.Text = "";
            UpdateUI();
        }
    }
}
