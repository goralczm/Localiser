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
            if (localisationTagsComboBox.SelectedItem == null ||
                localisationKeysListBox.SelectedItem == null)
            {
                localisedTextRichTextBox.Text = "";
                return;
            }

            string tag = localisationTagsComboBox.SelectedItem.ToString();
            string key = localisationKeysListBox.SelectedItem.ToString();

            string value = localiser.GetLocalisedValue(tag, key);

            localisedTextRichTextBox.Text = value;
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
    }
}
