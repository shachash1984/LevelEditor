using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Elbit.Runtime;

namespace Elbit.Serialization
{
    public static class DataManager
    {
        public static void SaveScenario(Scenario scenario)
        {
            //Convert scenario to JSON
            string dataAsJSON = JsonUtility.ToJson(scenario);
            //Save JSON to text file
            FileManager.SaveScenarioToFile(dataAsJSON); 
        }

        public static Scenario LoadScenario(string path)
        {
            //Load text file
            string dataText = FileManager.LoadScenarioFromFile(path);
            //Convert JSON to scenario
            object scenario = JsonUtility.FromJson<Scenario>(dataText);
            return null;
        }
    }
}

