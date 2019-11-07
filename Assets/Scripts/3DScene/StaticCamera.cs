using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elbit.Runtime
{
    [System.Serializable]
    public class StaticCamera : SceneElement
    {
        private void Start()
        {
            Vector3 wantedPos = position;
            position = new Vector3(wantedPos.x, wantedPos.y + 25f, wantedPos.z);
            rotation = new Vector3(0, 0, 30);
        }

        public override void OnSelect()
        {
            base.OnSelect();

        }
    }
}

