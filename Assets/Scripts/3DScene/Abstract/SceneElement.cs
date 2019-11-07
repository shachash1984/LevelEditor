using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elbit.Runtime
{
    public abstract class SceneElement : MonoBehaviour, ISceneElement
    {
        public virtual string Name => "SceneElementBase";


        public virtual Vector3 position { get => transform.position; set => transform.position = value; }
        public virtual Vector3 rotation { get => transform.rotation.eulerAngles; set => transform.rotation = Quaternion.Euler(value); }
        [SerializeField] protected int _objectID;
        public virtual int objectID { get => _objectID; }

        public virtual void OnDeselect()
        {
            //hide transform gizmo
        }

        public virtual void OnSelect()
        {
            //show transform gizmo
        }

        public virtual void OnCreate()
        {
            _objectID = gameObject.GetInstanceID();
            ScenarioEditor.AddSceneElement(this);
        }

        public virtual void OnDelete()
        {
            ScenarioEditor.RemoveSceneElement(this);
        }

    }

}

