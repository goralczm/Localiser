namespace Localisation_System
{
    internal class LocalisationSystem
    {
        private const string FILE_PATH = "C:\\Users\\Maciej\\Documents\\Unity Projects\\Defendron\\Assets\\Resources\\Localisation\\localisation.csv";

        private static Dictionary<string, Dictionary<string, string>> _localisedTextsByTag = new Dictionary<string, Dictionary<string, string>>();
        private static CSVLoader _csvLoader = new CSVLoader();

        public void Initialize()
        {
            _csvLoader = new CSVLoader();
            //_csvLoader.LoadCSVFromDialog();
            _csvLoader.LoadCSVFromPath(FILE_PATH);

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
            _localisedTextsByTag[tag].TryGetValue(key, out value);

            return value;
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
