namespace Localisation_System
{
    internal class LocalisationSystem
    {
        public static string LastPath;

        private Dictionary<string, Dictionary<string, string>> _localisedTextsByTag = new Dictionary<string, Dictionary<string, string>>();

        private CSVLoader _csvLoader = new CSVLoader();
        private CSVSaver _csvSaver = new CSVSaver();

        public void Initialize()
        {
            _csvLoader = new CSVLoader();
            _csvLoader.LoadCSVFromDialog();

            UpdateDictionaries();
        }

        public void UpdateDictionaries()
        {
            UpdateSingleLanguage("en");
            UpdateSingleLanguage("pl");
        }

        private void UpdateSingleLanguage(string tag)
        {
            if (!_localisedTextsByTag.ContainsKey(tag))
                _localisedTextsByTag.Add(tag, _csvLoader.GetDictionaryValues(tag));
            else
                _localisedTextsByTag[tag] = _csvLoader.GetDictionaryValues(tag);
        }

        public string GetLocalisedValue(string tag, string key)
        {
            string value = "";

            if (_localisedTextsByTag.ContainsKey(tag))
                _localisedTextsByTag[tag].TryGetValue(key, out value);

            return value;
        }

        public void UpdateKeyInTag(string tag, string key, string value)
        {
            if (!_localisedTextsByTag.ContainsKey(tag))
                return;

            _localisedTextsByTag[tag][key] = value;
        }

        public void SaveViaDialog()
        {
            _csvSaver.SaveFileViaDialog(_localisedTextsByTag);
        }

        public void SaveViaPath()
        {
            if (LastPath == "")
            {
                SaveViaDialog();
                return;
            }

            _csvSaver.SaveFileViaPath(LastPath, _localisedTextsByTag);
        }

        public IEnumerable<string> GetTags()
        {
            return _localisedTextsByTag.Keys;
        }

        public IEnumerable<string> GetAllKeys()
        {
            return _localisedTextsByTag.First().Value.Keys;
        }
    }
}
