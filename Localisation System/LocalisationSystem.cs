namespace Localisation_System
{
    internal class LocalisationSystem
    {
        private const string FILE_PATH = "C:\\Users\\Maciej\\Documents\\Unity Projects\\Defendron\\Assets\\Resources\\Localisation\\localisation.csv";

        private Dictionary<string, Dictionary<string, string>> _localisedTextsByTag = new Dictionary<string, Dictionary<string, string>>();
        private CSVLoader _csvLoader = new CSVLoader();
        private CSVSaver _csvSaver = new CSVSaver();

        public void Initialize()
        {
            _csvLoader = new CSVLoader();
            _csvLoader.LoadCSVFromDialog();
            //_csvLoader.LoadCSVFromPath(FILE_PATH);

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

        public void SaveToFile()
        {
            _csvSaver.SaveDictionaryToFile("lala", _localisedTextsByTag);
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
