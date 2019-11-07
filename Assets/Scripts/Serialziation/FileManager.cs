using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Crosstales.FB;


namespace Elbit.Serialization
{
    public static class FileManager
    {
        public static void SaveScenarioToFile(string data)
        {
            string path = FileBrowser.SaveFile("MyScenario", "json");
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(data);
            }
        }

        public static string LoadScenarioFromFile(string path)
        {
            string data = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    data = sr.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                Debug.LogError("The file could not be read " + ex.Message);
            }
            return data;
        }
    }

}

