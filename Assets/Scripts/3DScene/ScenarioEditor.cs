using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Elbit.Serialization;

namespace Elbit.Runtime
{
    public class ScenarioEditor : MonoBehaviour
    {
        public static Scenario currentScenario { get; private set; }


        private void Awake()
        {
            Init();
        }

        public static void Init()
        {
            currentScenario = new Scenario();
        }

        public static void AddSceneElement(SceneElement se)
        {
            if (!currentScenario.sceneElements.Contains(se))
                currentScenario.sceneElements.Add(se);
        }

        public static void RemoveSceneElement(SceneElement se)
        {
            if (currentScenario.sceneElements.Contains(se))
                currentScenario.sceneElements.Remove(se);
        }

        public void SaveScenario()
        {
            DataManager.SaveScenario(currentScenario);
        }
    }
}

