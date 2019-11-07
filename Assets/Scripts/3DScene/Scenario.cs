using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elbit.Runtime
{
    [System.Serializable]
    public class Scenario 
    {
        [SerializeField]
        public List<SceneElement> sceneElements;

        public SceneElement this[int i] => sceneElements[i];

        public Scenario()
        {
            sceneElements = new List<SceneElement>();
        }
    }
}

