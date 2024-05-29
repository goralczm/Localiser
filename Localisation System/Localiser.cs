namespace Localisation_System
{
    public partial class Localiser : Form
    {
        private LocalisationSystem localiser = new LocalisationSystem();

        public Localiser()
        {
            InitializeComponent();

            InitalizeLocalisation();
            UpdateListBoxWithKeys();
            UpdateComboBoxWithTags();

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

        private void InitalizeLocalisation()
        {
            localiser = new LocalisationSystem();
            localiser.Initialize();
        }

        private void UpdateListBoxWithKeys()
        {
            localisationKeysListBox.Items.Clear();
            localiser.GetAllKeys().ToList().ForEach(key =>
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

        private void localisedKeysSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBoxWithKeys();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> tagAndKey = GetCurrentTagAndKey();
            string newVal = localisedTextRichTextBox.Text;

            localiser.UpdateKeyInTag(tagAndKey.Key, tagAndKey.Value, newVal);
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            localiser.SaveToFile();
        }
    }
}
