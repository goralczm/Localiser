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
            List<string> tags = _csvLoader.GetTags();

            foreach (string tag in tags)
                UpdateSingleLanguage(tag);
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

        public void AddKey(string key)
        {
            if (key == "")
                return;

            var tags = GetTags();

            foreach (string tag in tags)
            {
                if (_localisedTextsByTag[tag].ContainsKey(key))
                    continue;

                _localisedTextsByTag[tag].Add(key, "");
            }
        }

        public void AddTag(string tag)
        {
            if (tag == "")
                return;

            if (_localisedTextsByTag.ContainsKey(tag))
                return;

            _localisedTextsByTag.Add(tag, new Dictionary<string, string>());
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
            if (_localisedTextsByTag.Count == 0)
                return Enumerable.Empty<string>();

            return _localisedTextsByTag.First().Value.Keys;
        }
    }
}
