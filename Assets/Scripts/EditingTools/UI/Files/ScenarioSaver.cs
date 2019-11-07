using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Elbit.Serialization;
using Elbit.Runtime;

namespace Elbit.Editor
{
    public class ScenarioSaver : MonoBehaviour
    {
        public void SaveScenario()
        {
            DataManager.SaveScenario(ScenarioEditor.currentScenario);
        }
    }
}

