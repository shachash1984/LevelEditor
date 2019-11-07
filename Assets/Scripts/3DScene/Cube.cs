using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elbit.Runtime
{
    [System.Serializable]
    public class Cube : SceneElement
    {
        private void Start()
        {
            Vector3 wantedPos = position;
            position = new Vector3(wantedPos.x, wantedPos.y + transform.localScale.y/2, wantedPos.z);
        }
    }
}
