﻿using System.Text.RegularExpressions;

namespace Localisation_System
{
    internal class CSVLoader
    {
        private string _csvFile = "";

        public void LoadCSVFromDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadCSVFromPath(filePath);
                }
            }
        }

        public void LoadCSVFromPath(string path)
        {
            LocalisationSystem.LastPath = path;
            using (StreamReader reader = new StreamReader(path))
            {
                _csvFile = reader.ReadToEnd();
            }
        }

        public List<string> GetTags()
        {
            string[] lines = _csvFile.Split(CSVFileStructure.LINE_SEPARATOR);
            string[] headers = lines[0].Split(CSVFileStructure.FIELD_SEPARATOR, System.StringSplitOptions.None);

            List<string> tags = new List<string>();
            for (int i = 1; i < headers.Length; i++)
            {
                headers[i] = headers[i].TrimStart(' ', CSVFileStructure.SURROUND);
                headers[i] = headers[i].TrimEnd('\r');
                headers[i] = headers[i].TrimEnd(CSVFileStructure.SURROUND);

                tags.Add(headers[i]);
            }

            return tags;
        }

        public Dictionary<string, string> GetDictionaryValues(string tag)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string[] lines = _csvFile.Split(CSVFileStructure.LINE_SEPARATOR);

            int attributeIndex = -1;

            string[] headers = lines[0].Split(CSVFileStructure.FIELD_SEPARATOR, System.StringSplitOptions.None);

            for (int i = 0; i < headers.Length; i++)
            {
                if (headers[i].Contains(tag))
                {
                    attributeIndex = i;
                    break;
                }
            }

            Regex CSVParses = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                if (line.Length > 0 && line[0] == '#')
                    continue;

                string[] fields = CSVParses.Split(line);

                for (int f = 0; f < fields.Length; f++)
                {
                    fields[f] = fields[f].TrimStart(' ', CSVFileStructure.SURROUND);
                    fields[f] = fields[f].TrimEnd('\r');
                    fields[f] = fields[f].TrimEnd(CSVFileStructure.SURROUND);
                }

                if (fields.Length > attributeIndex)
                {
                    var key = fields[0];

                    if (dictionary.ContainsKey(key))
                        continue;

                    var value = fields[attributeIndex];

                    dictionary.Add(key, value);
                }
            }

            return dictionary;
        }
    }
}
