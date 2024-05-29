using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Localisation_System
{
    internal class CSVSaver
    {
        public void SaveDictionaryToFile(string path, Dictionary<string, Dictionary<string, string>> dict)
        {
            List<string> tags = dict.Keys.ToList();
            List<string> keys = dict[tags[0]].Keys.ToList();

            List<string> vals = ["key", .. tags];

            string firstLine = BuildLine(vals);
            List<string> lines = new List<string> { firstLine };

            keys.ForEach(k =>
            {
                List<string> vals = [ k ];
                tags.ForEach(t => vals.Add(dict[t][k]));
                lines.Add(BuildLine(vals));
            });

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "csv files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    var fileStream = saveFileDialog.OpenFile();

                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        foreach (string line in lines)
                        {
                            writer.Write(line);
                        }
                    }
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
    }
}
