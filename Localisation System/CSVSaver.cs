using System.Text;

namespace Localisation_System
{
    internal class CSVSaver
    {
        public void SaveFileViaDialog(Dictionary<string, Dictionary<string, string>> dict)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "csv files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SaveFileViaPath(filePath, dict);
                }
            }
        }

        public void SaveFileViaPath(string path, Dictionary<string, Dictionary<string, string>> dict)
        {
            LocalisationSystem.LastPath = path;
            List<string> lines = DictionaryToCSVLines(dict);

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    writer.Write(line);
                }
            }
        }

        private string BuildLine(List<string> values)
        {
            StringBuilder line = new StringBuilder();
            line.Append(CSVFileStructure.SURROUND);
            for (int i = 0; i < values.Count; i++)
            {
                line.Append(values[i]);
                if (i < values.Count - 1)
                    line.Append(CSVFileStructure.FIELD_SEPARATOR);
            }
            line.Append(CSVFileStructure.SURROUND);
            line.Append(CSVFileStructure.LINE_SEPARATOR);

            return line.ToString();
        }

        private List<string> DictionaryToCSVLines(Dictionary<string, Dictionary<string, string>> dict)
        {
            List<string> tags = dict.Keys.ToList();
            List<string> keys = dict[tags[0]].Keys.ToList();

            List<string> vals = ["key", .. tags];

            string firstLine = BuildLine(vals);
            List<string> lines = new List<string> { firstLine };

            keys.ForEach(k =>
            {
                List<string> vals = [k];
                tags.ForEach(t => vals.Add(dict[t][k]));
                lines.Add(BuildLine(vals));
            });

            return lines;
        }
    }
}
