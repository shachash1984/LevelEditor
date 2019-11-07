using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elbit.Runtime
{
    public interface ISceneElement
    {
        string Name { get; }
        Vector3 position { get; set; }
        Vector3 rotation { get; set; }
        int objectID { get; }
        void OnSelect();
        void OnDeselect();
        void OnCreate();
        void OnDelete();
    }

}
